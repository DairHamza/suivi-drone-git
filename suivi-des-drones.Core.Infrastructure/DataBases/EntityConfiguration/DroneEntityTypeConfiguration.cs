﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using suivi_des_drones.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace suivi_des_drones.Core.Infrastructure.DataBases.EntityConfiguration
{
    internal class DroneEntityTypeConfiguration : IEntityTypeConfiguration<Drone>
    {
        #region Public methods
        public void Configure(EntityTypeBuilder<Drone> builder)
        {
            builder.ToTable("Drone");
            builder.HasKey(item => item.Matricule);
        }
        #endregion
    }
}
