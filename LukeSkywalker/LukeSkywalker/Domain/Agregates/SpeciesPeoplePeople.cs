﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LukeSkywalker.Domain.Models
{
    [Table("species_people_people")]
    [Index(nameof(PeopleId), Name = "IDX_4c896768b50c46acd8b611917e")]
    [Index(nameof(SpeciesId), Name = "IDX_62c0a74121aa06cdea24bc1e58")]
    public partial class SpeciesPeoplePeople
    {
        [Key]
        [Column("speciesId")]
        public int SpeciesId { get; set; }
        [Key]
        [Column("peopleId")]
        public int PeopleId { get; set; }

        [ForeignKey(nameof(PeopleId))]
        [InverseProperty("SpeciesPeoplePeople")]
        public virtual People People { get; set; }
        [ForeignKey(nameof(SpeciesId))]
        [InverseProperty("SpeciesPeoplePeople")]
        public virtual Species Species { get; set; }
    }
}