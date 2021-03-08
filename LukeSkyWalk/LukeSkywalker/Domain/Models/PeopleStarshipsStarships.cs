﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LukeSkywalker.Models
{
    [Table("people_starships_starships")]
    [Index(nameof(StarshipsId), Name = "IDX_0a5517fc734c462fc3a0d32eb9")]
    [Index(nameof(PeopleId), Name = "IDX_78e90ed25ace2390fa2c7a4d50")]
    public partial class PeopleStarshipsStarships
    {
        [Key]
        [Column("peopleId")]
        public int PeopleId { get; set; }
        [Key]
        [Column("starshipsId")]
        public int StarshipsId { get; set; }

        [ForeignKey(nameof(PeopleId))]
        [InverseProperty("PeopleStarshipsStarships")]
        public virtual People People { get; set; }
        [ForeignKey(nameof(StarshipsId))]
        [InverseProperty("PeopleStarshipsStarships")]
        public virtual Starships Starships { get; set; }
    }
}