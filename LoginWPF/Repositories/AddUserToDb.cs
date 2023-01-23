using LoginWPF.Database.Context;
using LoginWPF.Model.Entities;
using LoginWPF.Validator;
using LoginWPF.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginWPF.Repositories
{
    internal class AddUserToDb
    {
        UserDbContext userDbContext = new UserDbContext();

        public void AddUserToDatabase(string usernameVM, string passwordVM)
        {
            User newUser = new User()
            {
                login = usernameVM,
                password = passwordVM
            };

            userDbContext.Add(newUser);
            userDbContext.SaveChanges();
        }

    }
}
