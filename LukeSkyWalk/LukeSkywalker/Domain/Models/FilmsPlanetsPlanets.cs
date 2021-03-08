﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LukeSkywalker.Models
{
    [Table("films_planets_planets")]
    [Index(nameof(FilmsId), Name = "IDX_59f34f486757575a016c375061")]
    [Index(nameof(PlanetsId), Name = "IDX_956e9e10fd96ed618538bb2b96")]
    public partial class FilmsPlanetsPlanets
    {
        [Key]
        [Column("filmsId")]
        public int FilmsId { get; set; }
        [Key]
        [Column("planetsId")]
        public int PlanetsId { get; set; }

        [ForeignKey(nameof(FilmsId))]
        [InverseProperty("FilmsPlanetsPlanets")]
        public virtual Films Films { get; set; }
        [ForeignKey(nameof(PlanetsId))]
        [InverseProperty("FilmsPlanetsPlanets")]
        public virtual Planets Planets { get; set; }
    }
}