using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop.Repository;

namespace Webshop.Model
{
    internal class LoginViewModel
    {
        private readonly IRepository<User> repository;
        private List<User> customers;
        public LoginViewModel()
        {
            customers = new List<User>(repository.GetAll().ToList());
        }
        Customer user = null;
        public string UserName { get; set; }
        public string Password { get; set; }
        public void UserAuthentification(string password)
        {
        }
        private Customer User(string username)
        {
            Customer user = null;
            
            return user;
        }

    }
}
