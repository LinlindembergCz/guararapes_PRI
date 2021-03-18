﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

#nullable disable

namespace LukeSkywalker.Domain.Entities
{
    [Table("species")]
    [Index(nameof(Name), Name = "IDX_1adf701cac3b2c0f8bacb54774", IsUnique = true)]
    public partial class Species
    {
        public Species()
        {
            FilmsSpeciesSpecies = new HashSet<FilmsSpeciesSpecies>();
            PeopleSpeciesSpecies = new HashSet<PeopleSpeciesSpecies>();
            SpeciesFilmsFilms = new HashSet<SpeciesFilmsFilms>();
            SpeciesPeoplePeople = new HashSet<SpeciesPeoplePeople>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("name", TypeName = "varchar(200)")]
        public string Name { get; set; }
        [Column("classification", TypeName = "varchar(200)")]
        public string Classification { get; set; }
        [Column("designation", TypeName = "varchar(200)")]
        public string Designation { get; set; }
        [Column("average_height", TypeName = "varchar(200)")]
        public string AverageHeight { get; set; }
        [Column("average_lifespan", TypeName = "varchar(200)")]
        public string AverageLifespan { get; set; }
        [Column("eye_colors", TypeName = "varchar(200)")]
        public string EyeColors { get; set; }
        [Column("hair_colors", TypeName = "varchar(200)")]
        public string HairColors { get; set; }
        [Column("skin_colors", TypeName = "varchar(200)")]
        public string SkinColors { get; set; }
        [Column("language", TypeName = "varchar(200)")]
        public string Language { get; set; }
        [Column("homeworld", TypeName = "varchar(200)")]
        public string Homeworld { get; set; }
        [Column("url", TypeName = "varchar(200)")]
        public string Url { get; set; }
        [Column("created", TypeName = "varchar(30)")]
        public string Created { get; set; }
        [Column("edited", TypeName = "varchar(30)")]
        public string Edited { get; set; }

        [InverseProperty("Species")]
        [JsonIgnore]
        public virtual ICollection<FilmsSpeciesSpecies> FilmsSpeciesSpecies { get; set; }
        [InverseProperty("Species")]
        [JsonIgnore]
        public virtual ICollection<PeopleSpeciesSpecies> PeopleSpeciesSpecies { get; set; }
        [InverseProperty("Species")]
        [JsonIgnore]
        public virtual ICollection<SpeciesFilmsFilms> SpeciesFilmsFilms { get; set; }
        [InverseProperty("Species")]
        [JsonIgnore]
        public virtual ICollection<SpeciesPeoplePeople> SpeciesPeoplePeople { get; set; }
    }
}