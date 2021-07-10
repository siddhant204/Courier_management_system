using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Project_CMS_Api.Models
{
    [Table("admin_TABLE")]
    [Index(nameof(AdminPass), Name = "UQ__admin_TA__83F45280C19C202A", IsUnique = true)]
    public partial class AdminTable
    {
        [Key]
        [Column("admin_id")]
        public int AdminId { get; set; }
        [Column("admin_name")]
        [StringLength(50)]
        public string AdminName { get; set; }
        [Column("admin_pass")]
        [StringLength(20)]
        public string AdminPass { get; set; }
    }
}
