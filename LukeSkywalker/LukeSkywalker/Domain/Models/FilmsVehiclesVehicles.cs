﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LukeSkywalker.Models
{
    [Table("films_vehicles_vehicles")]
    [Index(nameof(FilmsId), Name = "IDX_21c53d0d80b975c872a4ca4ada")]
    [Index(nameof(VehiclesId), Name = "IDX_a623eaa88213329f69118cdea5")]
    public partial class FilmsVehiclesVehicles
    {
        [Key]
        [Column("filmsId")]
        public int FilmsId { get; set; }
        [Key]
        [Column("vehiclesId")]
        public int VehiclesId { get; set; }

        [ForeignKey(nameof(FilmsId))]
        [InverseProperty("FilmsVehiclesVehicles")]
        public virtual Films Films { get; set; }
        [ForeignKey(nameof(VehiclesId))]
        [InverseProperty("FilmsVehiclesVehicles")]
        public virtual Vehicles Vehicles { get; set; }
    }
}