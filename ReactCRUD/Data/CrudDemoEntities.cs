using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using ReactCRUD.Models;

public partial class CrudDemoEntities : DbContext
{
    public CrudDemoEntities() : base("name=CrudDemoEntities")
    {
    }
    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }
    public virtual DbSet<studentmaster> studentmasters { get; set; }
}
