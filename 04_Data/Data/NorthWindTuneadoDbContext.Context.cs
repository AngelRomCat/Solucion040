

//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------


namespace _04_Data.Data
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class NorthWindTuneadoDbContext : DbContext
{
    public NorthWindTuneadoDbContext()
        : base("name=NorthWindTuneadoDbContext")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<Categoria> Categoria { get; set; }

    public virtual DbSet<Cliente> Cliente { get; set; }

    public virtual DbSet<DetallePedido> DetallePedido { get; set; }

    public virtual DbSet<Empleado> Empleado { get; set; }

    public virtual DbSet<Naviera> Naviera { get; set; }

    public virtual DbSet<Pedido> Pedido { get; set; }

    public virtual DbSet<Producto> Producto { get; set; }

    public virtual DbSet<Proveedor> Proveedor { get; set; }

}

}

