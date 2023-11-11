using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace management.repository
{
    internal abstract class AbstractSqlWriter<T> : AbstractWriterRepository<T>, IDataSource
    {
        private SqlCommand cmd = new SqlCommand();
        protected override void shouldWrite(T data, QueryWriter w)
        {
            using (SqlConnection sqlConnection = new SqlConnection(getConnectionString()))
            {
                cmd.Connection = sqlConnection;
                cmd.CommandText = getQuery(data, w);
                sqlConnection.Open();
                using (cmd) {
                    cmd.ExecuteNonQuery();
                }
            }
            cmd.Parameters.Clear();
        }

        protected void add(string field, object value)
        {
            this.cmd.Parameters.AddWithValue(field, value ?? string.Empty);
        }

        protected virtual string getWriteQuery(T data)
        {
            throw new NotImplementedException();
        }

        protected virtual string getUpdateQuery(T data)
        {
            throw new NotImplementedException();
        }

        protected virtual string getDeleteQuery(T data)
        {
            throw new NotImplementedException();
        }

        protected void clear()
        {
            this.cmd.Parameters.Clear();
        }


        private string getQuery(T data, QueryWriter writer)
        {
            switch(writer)
            {
                case QueryWriter.UPDATE:
                    return this.getUpdateQuery(data);
                case QueryWriter.DELETE:
                    return this.getDeleteQuery(data);
                case QueryWriter.INSERT:
                    return this.getWriteQuery(data);
                default:
                    throw new ArgumentException("There is no such writer");
            }
        }

        public abstract string getConnectionString();
    }
}
