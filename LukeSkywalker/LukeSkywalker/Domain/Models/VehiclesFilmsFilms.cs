﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LukeSkywalker.Models
{
    [Table("vehicles_films_films")]
    [Index(nameof(FilmsId), Name = "IDX_5e2fb2eb3483ccdba246e1fcb3")]
    [Index(nameof(VehiclesId), Name = "IDX_7b4cb950bab7edfc0a92351cdd")]
    public partial class VehiclesFilmsFilms
    {
        [Key]
        [Column("vehiclesId")]
        public int VehiclesId { get; set; }
        [Key]
        [Column("filmsId")]
        public int FilmsId { get; set; }

        [ForeignKey(nameof(FilmsId))]
        [InverseProperty("VehiclesFilmsFilms")]
        public virtual Films Films { get; set; }
        [ForeignKey(nameof(VehiclesId))]
        [InverseProperty("VehiclesFilmsFilms")]
        public virtual Vehicles Vehicles { get; set; }
    }
}