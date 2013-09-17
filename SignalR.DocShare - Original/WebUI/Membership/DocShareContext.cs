using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebUI.Entities;
using WebUI.Models;

namespace WebUI.Membership
{
    public class DocShareContext : DbContext
    {
        public DocShareContext()
            : base("name=DocShareDBConnString")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Document> Documents { get; set; }
    }
}