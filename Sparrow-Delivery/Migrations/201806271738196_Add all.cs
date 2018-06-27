namespace Sparrow_Delivery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addall : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DetallePedido",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        pedido_ID = c.Int(),
                        producto_Id = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Pedido", t => t.pedido_ID)
                .ForeignKey("dbo.Producto", t => t.producto_Id)
                .Index(t => t.pedido_ID)
                .Index(t => t.producto_Id);
            
            CreateTable(
                "dbo.Pedido",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        shippedAddress = c.String(nullable: false),
                        telefono = c.String(nullable: false),
                        descripcíon = c.String(nullable: false),
                        totalPrice = c.Double(nullable: false),
                        tipoEstado_ID = c.Int(nullable: false),
                        tipoPago_ID = c.Int(nullable: false),
                        usuario_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.TipoEstado", t => t.tipoEstado_ID, cascadeDelete: true)
                .ForeignKey("dbo.TipoPago", t => t.tipoPago_ID, cascadeDelete: true)
                .ForeignKey("dbo.Usuario", t => t.usuario_Id, cascadeDelete: true)
                .Index(t => t.tipoEstado_ID)
                .Index(t => t.tipoPago_ID)
                .Index(t => t.usuario_Id);
            
            CreateTable(
                "dbo.TipoEstado",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        nombre = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TipoPago",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        nombre = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DetallePedido", "producto_Id", "dbo.Producto");
            DropForeignKey("dbo.DetallePedido", "pedido_ID", "dbo.Pedido");
            DropForeignKey("dbo.Pedido", "usuario_Id", "dbo.Usuario");
            DropForeignKey("dbo.Pedido", "tipoPago_ID", "dbo.TipoPago");
            DropForeignKey("dbo.Pedido", "tipoEstado_ID", "dbo.TipoEstado");
            DropIndex("dbo.Pedido", new[] { "usuario_Id" });
            DropIndex("dbo.Pedido", new[] { "tipoPago_ID" });
            DropIndex("dbo.Pedido", new[] { "tipoEstado_ID" });
            DropIndex("dbo.DetallePedido", new[] { "producto_Id" });
            DropIndex("dbo.DetallePedido", new[] { "pedido_ID" });
            DropTable("dbo.TipoPago");
            DropTable("dbo.TipoEstado");
            DropTable("dbo.Pedido");
            DropTable("dbo.DetallePedido");
        }
    }
}
