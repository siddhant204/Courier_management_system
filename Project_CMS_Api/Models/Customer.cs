using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Project_CMS_Api.Models
{
    [Table("customer")]
    [Index(nameof(CustomerPassword), Name = "UQ__customer__75B0A3FD10C0924E", IsUnique = true)]
    [Index(nameof(CustomerEmail), Name = "UQ__customer__CE486A0A80B26B3F", IsUnique = true)]
    public partial class Customer
    {
        public Customer()
        {
            Consignments = new HashSet<Consignment>();
        }

        [Key]
        [Column("customer_id")]
        public int CustomerId { get; set; }
        [Column("customer_name")]
        [StringLength(40)]
        public string CustomerName { get; set; }
        [Column("customer_contact")]
        [StringLength(10)]
        public string CustomerContact { get; set; }
        [Column("customer_email")]
        [StringLength(255)]
        public string CustomerEmail { get; set; }
        [Column("customer_password")]
        [StringLength(20)]
        public string CustomerPassword { get; set; }

        [InverseProperty(nameof(Consignment.ConsignerCustomer))]
        public virtual ICollection<Consignment> Consignments { get; set; }
    }
}
