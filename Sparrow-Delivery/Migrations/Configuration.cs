namespace Sparrow_Delivery.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Sparrow_Delivery.Models.SparrowModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Sparrow_Delivery.Models.SparrowModel context)
        {
            context.TipoPago.AddOrUpdate(
                x => x.nombre,
                new TipoPago { nombre = "Efectivo" },
                new TipoPago { nombre="Tarjeta débito/crédito"}
                );

            context.TipoEstado.AddOrUpdate(
                x => x.nombre,
                new TipoEstado { nombre = "Entregado" },
                new TipoEstado { nombre = "Por entregar" }
                );
            var c1 = new Categoria { nombre = "Plato a la carta" };
            var c2 = new Categoria { nombre = "Ensaladas" };
            var c3 = new Categoria { nombre = "Bebidas" };
            var c4 = new Categoria { nombre = "Acompañamientos" };
            context.Categoria.AddOrUpdate(
                x => x.nombre,
                c1,
                c2,
                c3,
                c4
                );

            context.Producto.AddOrUpdate(
                x => x.nombre,
                new Producto
                {
                    nombre = "Milanesa de Pollo",
                    descripcion = "lorem ipsum dolor",
                    precio = 25.00,
                    stock = 100,
                    urlImage = "https://i.imgur.com/0tkt3IJ.png",
                    estado = 1,
                    categoria = c1
                },
                new Producto
                {
                    nombre = "Papa a la huancaina",
                    descripcion = "lorem ipsum dolor",
                    precio = 10.00,
                    stock = 50,
                    urlImage = "https://i.imgur.com/liF0RI0.png",
                    estado = 1,
                    categoria = c2
                },
                new Producto
                {
                    nombre = "Chicha morada 1L",
                    descripcion = "lorem ipsum dolor",
                    precio = 15.00,
                    stock = 100,
                    urlImage = "https://i.imgur.com/1jxeYn2.png",
                    estado = 1,
                    categoria = c3
                },
                new Producto
                {
                    nombre = "Suspiro a la limeña",
                    descripcion = "lorem ipsum dolor",
                    precio = 10.00,
                    stock = 100,
                    urlImage = "https://i.imgur.com/eEVPN6h.png",
                    estado = 1,
                    categoria = c4
                }
                );
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
