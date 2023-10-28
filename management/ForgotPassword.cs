using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace management
{
    internal class ForgotPassword
    {
        private string username;
        private string password;
        private string oldPassword;
        private string confirmPassoword;

        public string Password { get { return password; } set { password = value; } }
        public string ConfirmPassoword { get {  return confirmPassoword; } set {  confirmPassoword = value; } }
        public string Username {  get { return username; } set { username = value; } }

        public string OldPassword {  get { return oldPassword; } set {  oldPassword = value; } }
    }
}
