using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcUserManagementView.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public int Age { get; set; }

        public string Phone { get; set; }
    }

    public class UserDbcontext : DbContext
    {
        public DbSet<User> Users { get; set; }


    }
}


