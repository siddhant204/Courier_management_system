using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Project_CMS_Api.Models
{
    [Table("agent")]
    [Index(nameof(AgentEmail), Name = "UQ__agent__15F0EE89B2565405", IsUnique = true)]
    [Index(nameof(AgentPass), Name = "UQ__agent__246A5A77F8504B3B", IsUnique = true)]
    public partial class Agent
    {
        public Agent()
        {
            Consignments = new HashSet<Consignment>();
        }

        [Key]
        [Column("agent_id")]
        public int AgentId { get; set; }
        [Column("agent_name")]
        [StringLength(40)]
        public string AgentName { get; set; }
        [Column("agent_contact")]
        [StringLength(10)]
        public string AgentContact { get; set; }
        [Column("agent_email")]
        [StringLength(255)]
        public string AgentEmail { get; set; }
        [Column("agent_pass")]
        [StringLength(20)]
        public string AgentPass { get; set; }
        [Column("area_start_code")]
        public int AreaStartCode { get; set; }
        [Column("area_end_code")]
        public int AreaEndCode { get; set; }

        [InverseProperty(nameof(Consignment.AssignedAgent))]
        public virtual ICollection<Consignment> Consignments { get; set; }
    }
}
