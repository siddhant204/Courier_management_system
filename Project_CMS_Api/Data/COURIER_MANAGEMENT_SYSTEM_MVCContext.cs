using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Project_CMS_Api.Models;

#nullable disable

namespace Project_CMS_Api.Data
{
    public partial class COURIER_MANAGEMENT_SYSTEM_MVCContext : DbContext
    {
        public COURIER_MANAGEMENT_SYSTEM_MVCContext()
        {
        }

        public COURIER_MANAGEMENT_SYSTEM_MVCContext(DbContextOptions<COURIER_MANAGEMENT_SYSTEM_MVCContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdminTable> AdminTables { get; set; }
        public virtual DbSet<Agent> Agents { get; set; }
        public virtual DbSet<Consignment> Consignments { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-OT25R96E;Initial Catalog=COURIER_MANAGEMENT_SYSTEM_MVC;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AdminTable>(entity =>
            {
                entity.HasKey(e => e.AdminId)
                    .HasName("PK__admin_TA__43AA4141020BC574");

                entity.Property(e => e.AdminName).IsUnicode(false);

                entity.Property(e => e.AdminPass).IsUnicode(false);
            });

            modelBuilder.Entity<Agent>(entity =>
            {
                entity.Property(e => e.AgentContact).IsUnicode(false);

                entity.Property(e => e.AgentName).IsUnicode(false);

                entity.Property(e => e.AgentPass).IsUnicode(false);
            });

            modelBuilder.Entity<Consignment>(entity =>
            {
                entity.Property(e => e.Consignee).IsUnicode(false);

                entity.Property(e => e.ConsigneeAdd).IsUnicode(false);

                entity.Property(e => e.ConsignmentStatus).IsUnicode(false);

                entity.HasOne(d => d.AssignedAgent)
                    .WithMany(p => p.Consignments)
                    .HasForeignKey(d => d.AssignedAgentId)
                    .HasConstraintName("fkey2");

                entity.HasOne(d => d.ConsignerCustomer)
                    .WithMany(p => p.Consignments)
                    .HasForeignKey(d => d.ConsignerCustomerId)
                    .HasConstraintName("fkey1");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.CustomerContact).IsUnicode(false);

                entity.Property(e => e.CustomerName).IsUnicode(false);

                entity.Property(e => e.CustomerPassword).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public DbSet<Project_CMS_Api.Models.Login> Login { get; set; }
    }
}
