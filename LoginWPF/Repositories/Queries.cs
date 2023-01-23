using LoginWPF.Database.Context;
using LoginWPF.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginWPF.Repositories
{
    internal class Queries
    {
        UserDbContext userDbContext = new UserDbContext();
        User users = new User();

        public bool UsernameQuery(string username)
        {
            var usernameQuery = userDbContext.Users.Any(u => u.login.Equals(username));
            return usernameQuery;
        }

        public string PasswordQuery(string username)
        {
            var passwordQuery = userDbContext.Users.FirstOrDefault(u => u.login == username)?.password;
            return passwordQuery;
        }

    }
}
