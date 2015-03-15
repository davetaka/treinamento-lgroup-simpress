using Simpress.CodeFirst.DataAnnotations.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpress.CodeFirst.DataAnnotations.DataAccess
{
    public class Connection : DbContext
    {
        public Connection()
            : base("Data Source=(local); Initial Catalog=ANNOTATION; Integrated Security=True;")
        {

        }

        public void CreateDatabase()
        {
            Database.Create();
        }

        public void DropDatabase()
        {
            Database.Delete();
        }



        public DbSet<FriendModel> Friends { get; set; }
        public DbSet<GenderModel> Genders { get; set; }
        public DbSet<FilingStatusModel> FilingStatus { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
