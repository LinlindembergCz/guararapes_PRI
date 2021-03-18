﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LukeSkywalker.Domain.Entities
{
    [Table("films_starships_starships")]
    [Index(nameof(FilmsId), Name = "IDX_3965a3d69c030eca6799a06d9d")]
    [Index(nameof(StarshipsId), Name = "IDX_e79353f238988153784b207757")]
    public partial class FilmsStarshipsStarships
    {
        [Key]
        [Column("filmsId")]
        public int FilmsId { get; set; }
        [Key]
        [Column("starshipsId")]
        public int StarshipsId { get; set; }

        [ForeignKey(nameof(FilmsId))]
        [InverseProperty("FilmsStarshipsStarships")]
        public virtual Films Films { get; set; }
        [ForeignKey(nameof(StarshipsId))]
        [InverseProperty("FilmsStarshipsStarships")]
        public virtual Starships Starships { get; set; }
    }
}