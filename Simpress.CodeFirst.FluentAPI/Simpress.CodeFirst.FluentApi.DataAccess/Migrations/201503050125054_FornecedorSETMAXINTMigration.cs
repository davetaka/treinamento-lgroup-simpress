namespace Simpress.CodeFirst.FluentApi.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FornecedorSETMAXINTMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TB_PRODUTO", "NM_FORNECEDOR", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TB_PRODUTO", "NM_FORNECEDOR", c => c.String(nullable: false, maxLength: 8000, unicode: false));
        }
    }
}
