﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using _2015104916.Entities.Entities;

namespace _2015104916.Persistence.EntitiesConfiguration
{
    public class PropietarioConfiguration : EntityTypeConfiguration<Propietario>
    {
        public PropietarioConfiguration()
       {
           //Table Configuration
           ToTable("Propietarios");
           HasKey(c => c.PropietarioId);

       }
    }
}
