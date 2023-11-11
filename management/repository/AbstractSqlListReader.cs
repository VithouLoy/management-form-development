using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using management.mapper;

namespace management.repository
{
    internal abstract class AbstractSqlListReader<T> : AbstractReaderRepository<T>
    {
        private SqlCommand cmd = new SqlCommand();
        private IEntityMapper<T> entityMapper;

        public AbstractSqlListReader(IEntityMapper<T> mapper)
        {
            this.entityMapper = mapper;
        }

        protected override List<T> shouldRead<D>(QueryReader qr, params D[] data)
        {
            List<T> list = new List<T>();
            using (SqlConnection sqlConnection = new SqlConnection(getConnectionString()))
            {
                cmd.Connection = sqlConnection;
                cmd.CommandText = getQuery(qr, data);
                sqlConnection.Open();
                using (cmd)
                {
                    using (DbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                T entity = entityMapper.map(reader);
                                list.Add(entity);
                            }
                        }
                    }
                }
            }

            return list;
        }
        

        protected virtual string getConnectionString()
        {
            return DataSource.CONNECTION_STRING;
        }

        protected virtual string getReadAllQuery()
        {
            throw new NotImplementedException();
        }

        protected virtual string getReadByQuery<D>(params D[] data)
        {
            throw new NotImplementedException();
        }

        protected virtual string getReadAllByQuery<D>(params D[] data)
        {
            throw new NotImplementedException();
        }


        protected void addParameter<D>(string field, D data)
        {
            if ((data != null))
            {
                cmd.Parameters.AddWithValue(field, data);
            }
        }


        protected void clear()
        {
            cmd.Parameters.Clear();
        }

        private string getQuery<D>(QueryReader qr, params D[] data)
        {
            switch(qr)
            {
                case QueryReader.READ_ALL:
                    return getReadAllQuery();
                case QueryReader.READ_BY: 
                    return getReadByQuery(data);
                case QueryReader.READ_ALL_BY:
                    return getReadAllByQuery(data);
                default: throw new NotImplementedException();
            }
        }
    }
}
