namespace Simpress.CodeFirst.FluentApi.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEnderecoCPF : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TB_CLIENTE", "DS_ENDERECO", c => c.String(maxLength: 50, unicode: false));
            AddColumn("dbo.TB_CLIENTE", "NR_CPF", c => c.String(maxLength: 14, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TB_CLIENTE", "NR_CPF");
            DropColumn("dbo.TB_CLIENTE", "DS_ENDERECO");
        }
    }
}
