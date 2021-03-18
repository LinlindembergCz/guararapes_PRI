﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LukeSkywalker.Domain.Entities
{
    [Table("planets_films_films")]
    [Index(nameof(FilmsId), Name = "IDX_0d7eb62f80e794b5701ad7a8ff")]
    [Index(nameof(PlanetsId), Name = "IDX_fb27cd4913415c3a51818eda84")]
    public partial class PlanetsFilmsFilms
    {
        [Key]
        [Column("planetsId")]
        public int PlanetsId { get; set; }
        [Key]
        [Column("filmsId")]
        public int FilmsId { get; set; }

        [ForeignKey(nameof(FilmsId))]
        [InverseProperty("PlanetsFilmsFilms")]
        public virtual Films Films { get; set; }
        [ForeignKey(nameof(PlanetsId))]
        [InverseProperty("PlanetsFilmsFilms")]
        public virtual Planets Planets { get; set; }
    }
}