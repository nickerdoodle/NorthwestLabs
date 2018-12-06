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

        public System.Data.Entity.DbSet<NorthwestLabs.Models.Assay> Assays { get; set; }
    }
}