namespace Sparrow_Delivery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addusuario : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        email = c.String(nullable: false),
                        password = c.String(nullable: false, maxLength: 16),
                        nombre = c.String(nullable: false),
                        apellido = c.String(nullable: false),
                        DNI = c.String(nullable: false, maxLength: 8),
                        userAddress = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuario");
        }
    }
}
