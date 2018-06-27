namespace Sparrow_Delivery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addproductandcategorytables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categoria",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        nombre = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Producto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        nombre = c.String(nullable: false),
                        precio = c.Double(nullable: false),
                        stock = c.Double(nullable: false),
                        urlImage = c.String(nullable: false),
                        descripcion = c.String(nullable: false),
                        estado = c.Int(nullable: false),
                        categoria_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categoria", t => t.categoria_ID, cascadeDelete: true)
                .Index(t => t.categoria_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Producto", "categoria_ID", "dbo.Categoria");
            DropIndex("dbo.Producto", new[] { "categoria_ID" });
            DropTable("dbo.Producto");
            DropTable("dbo.Categoria");
        }
    }
}
