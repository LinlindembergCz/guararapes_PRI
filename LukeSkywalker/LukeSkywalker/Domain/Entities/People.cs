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
    [Table("people")]
    [Index(nameof(Name), Name = "IDX_e7ec00b080e693706a6eaa6d31", IsUnique = true)]
    public partial class People
    {
        public People()
        {
            FilmsPeoplePeople = new HashSet<FilmsPeoplePeople>();
            PeopleFilmsFilms = new HashSet<PeopleFilmsFilms>();
            PeopleSpeciesSpecies = new HashSet<PeopleSpeciesSpecies>();
            PeopleStarshipsStarships = new HashSet<PeopleStarshipsStarships>();
            PeopleVehiclesVehicles = new HashSet<PeopleVehiclesVehicles>();
            PlanetsPeoplePeople = new HashSet<PlanetsPeoplePeople>();
            SpeciesPeoplePeople = new HashSet<SpeciesPeoplePeople>();
            StarshipsPeoplePeople = new HashSet<StarshipsPeoplePeople>();
            VehiclesPeoplePeople = new HashSet<VehiclesPeoplePeople>();
        }

        public People( string name,
                       string birthYea,
                       string eyeColor ,
                       string gender,
                       string hairColor,
                       string height,
                       string mass,
                       string skinColor
                       )
        {
            Name = name;
            BirthYear = birthYea;
            EyeColor = eyeColor;
            Gender = gender;
            HairColor = hairColor;
            Height = height;
            Mass = mass;
            SkinColor = skinColor;     
         }


        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("name", TypeName = "varchar(200)")]
        public string Name { get; set; }
        [Column("birth_year", TypeName = "varchar(20)")]
        public string BirthYear { get; set; }
        [Column("eye_color", TypeName = "varchar(200)")]
        public string EyeColor { get; set; }
        [Column("gender", TypeName = "varchar(200)")]
        public string Gender { get; set; }
        [Column("hair_color", TypeName = "varchar(200)")]
        public string HairColor { get; set; }
        [Column("height", TypeName = "varchar(200)")]
        public string Height { get; set; }
        [Column("mass", TypeName = "varchar(200)")]
        public string Mass { get; set; }
        [Column("skin_color", TypeName = "varchar(200)")]
        public string SkinColor { get; set; }
        [Column("homeworld", TypeName = "varchar(200)")]
        public string Homeworld { get; set; }
        [Column("url", TypeName = "varchar(200)")]
        public string Url { get; set; }
        [Column("created", TypeName = "varchar(30)")]
        public string Created { get; set; }
        [Column("edited", TypeName = "varchar(30)")]
        public string Edited { get; set; }

        [InverseProperty("People")]
       // [JsonIgnore]
        public virtual ICollection<FilmsPeoplePeople> FilmsPeoplePeople { get; set; }
        [InverseProperty("People")]
       // [JsonIgnore]
        public virtual ICollection<PeopleFilmsFilms> PeopleFilmsFilms { get; set; }
        [InverseProperty("People")]
        [JsonIgnore]
        public virtual ICollection<PeopleSpeciesSpecies> PeopleSpeciesSpecies { get; set; }
        [InverseProperty("People")]
        [JsonIgnore]
        public virtual ICollection<PeopleStarshipsStarships> PeopleStarshipsStarships { get; set; }
        [InverseProperty("People")]
        [JsonIgnore]
        public virtual ICollection<PeopleVehiclesVehicles> PeopleVehiclesVehicles { get; set; }
        [InverseProperty("People")]
        [JsonIgnore]
        public virtual ICollection<PlanetsPeoplePeople> PlanetsPeoplePeople { get; set; }
        [InverseProperty("People")]
        [JsonIgnore]
        public virtual ICollection<SpeciesPeoplePeople> SpeciesPeoplePeople { get; set; }
        [InverseProperty("People")]
        [JsonIgnore]
        public virtual ICollection<StarshipsPeoplePeople> StarshipsPeoplePeople { get; set; }
        [InverseProperty("People")]
        [JsonIgnore]
        public virtual ICollection<VehiclesPeoplePeople> VehiclesPeoplePeople { get; set; }
    }
}