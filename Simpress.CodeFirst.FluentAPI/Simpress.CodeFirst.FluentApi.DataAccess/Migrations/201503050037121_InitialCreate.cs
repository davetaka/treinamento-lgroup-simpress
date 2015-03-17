namespace Simpress.CodeFirst.FluentApi.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TB_CLIENTE",
                c => new
                    {
                        Codigo = c.Int(nullable: false, identity: true),
                        NM_NOME = c.String(nullable: false, maxLength: 30, unicode: false),
                        DS_EMAIL = c.String(nullable: false, maxLength: 50, unicode: false),
                        NR_TELEFONE = c.String(nullable: false, maxLength: 15, unicode: false),
                        DT_NASCIMENTO = c.DateTime(nullable: false),
                        DT_CADASTRO = c.DateTime(nullable: false, defaultValueSql: "GETDATE()"),
                    })
                .PrimaryKey(t => t.Codigo);
            
            CreateTable(
                "dbo.TB_ITEM_PEDIDO",
                c => new
                    {
                        ID_ITEM_PEDIDO = c.Int(nullable: false, identity: true),
                        ID_PEDIDO = c.Int(nullable: false),
                        ID_PRODUTO = c.Int(nullable: false),
                        NR_PRODUTOS = c.Int(nullable: false),
                        VL_PRODUTO = c.Decimal(nullable: false, precision: 8, scale: 2),
                        DT_CADASTRO = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID_ITEM_PEDIDO)
                .ForeignKey("dbo.TB_PEDIDO", t => t.ID_PEDIDO)
                .ForeignKey("dbo.TB_PRODUTO", t => t.ID_PRODUTO)
                .Index(t => t.ID_PEDIDO)
                .Index(t => t.ID_PRODUTO);
            
            CreateTable(
                "dbo.TB_PEDIDO",
                c => new
                    {
                        ID_PEDIDO = c.Int(nullable: false, identity: true),
                        ID_CLIENTE = c.Int(nullable: false),
                        DS_OBSERVACAO = c.String(nullable: false, maxLength: 250, unicode: false),
                        DT_CADASTRO = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID_PEDIDO)
                .ForeignKey("dbo.TB_CLIENTE", t => t.ID_CLIENTE)
                .Index(t => t.ID_CLIENTE);
            
            CreateTable(
                "dbo.TB_PRODUTO",
                c => new
                    {
                        ID_PRODUTO = c.Int(nullable: false, identity: true),
                        NM_PRODUTO = c.String(nullable: false, maxLength: 50, unicode: false),
                        DS_PRODUTO = c.String(nullable: false, maxLength: 250, unicode: false),
                        VL_PRODUTO = c.Decimal(nullable: false, precision: 8, scale: 2),
                        FLG_STATUS = c.Boolean(nullable: false),
                        DT_CADASTRO = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID_PRODUTO);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TB_ITEM_PEDIDO", "ID_PRODUTO", "dbo.TB_PRODUTO");
            DropForeignKey("dbo.TB_ITEM_PEDIDO", "ID_PEDIDO", "dbo.TB_PEDIDO");
            DropForeignKey("dbo.TB_PEDIDO", "ID_CLIENTE", "dbo.TB_CLIENTE");
            DropIndex("dbo.TB_PEDIDO", new[] { "ID_CLIENTE" });
            DropIndex("dbo.TB_ITEM_PEDIDO", new[] { "ID_PRODUTO" });
            DropIndex("dbo.TB_ITEM_PEDIDO", new[] { "ID_PEDIDO" });
            DropTable("dbo.TB_PRODUTO");
            DropTable("dbo.TB_PEDIDO");
            DropTable("dbo.TB_ITEM_PEDIDO");
            DropTable("dbo.TB_CLIENTE");
        }
    }
}
