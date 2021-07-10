using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Project_CMS_Api.Models
{
    [Table("consignment")]
    public partial class Consignment
    {
        [Key]
        [Column("consignment_id")]
        public int ConsignmentId { get; set; }
        [Column("consignment_booking_date", TypeName = "date")]
        public DateTime? ConsignmentBookingDate { get; set; }
        [Column("consignment_expected_date", TypeName = "date")]
        public DateTime? ConsignmentExpectedDate { get; set; }
        [Column("consignment_status")]
        [StringLength(255)]
        public string ConsignmentStatus { get; set; }
        [Column("consigner_customer_id")]
        public int ConsignerCustomerId { get; set; }
        [Column("consignee")]
        [StringLength(20)]
        public string Consignee { get; set; }
        [Column("consignee_add")]
        [StringLength(700)]
        public string ConsigneeAdd { get; set; }
        [Column("consignee_code")]
        public int ConsigneeCode { get; set; }
        [Column("assigned_agent_id")]
        public int AssignedAgentId { get; set; }

        [ForeignKey(nameof(AssignedAgentId))]
        [InverseProperty(nameof(Agent.Consignments))]
        public virtual Agent AssignedAgent { get; set; }
        [ForeignKey(nameof(ConsignerCustomerId))]
        [InverseProperty(nameof(Customer.Consignments))]
        public virtual Customer ConsignerCustomer { get; set; }
    }
}
