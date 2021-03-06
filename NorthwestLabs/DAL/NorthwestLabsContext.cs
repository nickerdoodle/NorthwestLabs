﻿using System;
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
        public DbSet<VolumeUnit>VolumeUnits { get; set; }
        public DbSet<WeightUnit>WeightUnits { get; set; }
        public DbSet<WorkOrder>WorkOrders { get; set; }
        public DbSet<Customer>Customers { get; set; }
        public DbSet<Material>Materials { get; set; }
        public DbSet<CustomerLogin>CustomerLogins { get; set; }
        public DbSet<State>States { get; set; }
        public DbSet<Country>Countries { get; set; }
        //public DbSet<MaterialsUsed>MaterialsUseds { get; set; }
        
        public DbSet<NorthwestLabs.Models.Assay> Assays { get; set; }
    }
}