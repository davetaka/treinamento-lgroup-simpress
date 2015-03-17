using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Simpress.CodeFirst.FluentApi.DataAccess.Models.Mapping;

namespace Simpress.CodeFirst.FluentApi.DataAccess.Models
{
    public partial class SIMPRESSContext : DbContext
    {
        static SIMPRESSContext()
        {
            Database.SetInitializer<SIMPRESSContext>(null);
        }

        public SIMPRESSContext()
            : base("Name=SIMPRESSContext")
        {
        }

        public DbSet<TB_AMIGO> TB_AMIGO { get; set; }
        public DbSet<TB_ESCOLARIDADE> TB_ESCOLARIDADE { get; set; }
        public DbSet<TB_SEXO> TB_SEXO { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new TB_AMIGOMap());
            modelBuilder.Configurations.Add(new TB_ESCOLARIDADEMap());
            modelBuilder.Configurations.Add(new TB_SEXOMap());
        }
    }
}
