using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using NorthwestLabs.Models;

namespace NorthwestLabs.DAL
{
    public class NorthwestLabsContext : DbContext
    {
        public NorthwestLabsContext() : base("NorthwestLabsContext")
        {

        }

        public DbSet<Compound> Compounds { get; set; }
        public DbSet<TestInstance>TestInstances { get; set; }
        public DbSet<TestType>TestTypes { get; set; }
        public DbSet<UnitOfMeasure>UnitOfMeasures { get; set; }
        public DbSet<WorkOrder>WorkOrders { get; set; }
        public DbSet<Customer>Customers { get; set; }
        public DbSet<Material>Materials { get; set; }

       

        
    }
}