using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ISap.Models
{
    public partial class DB_ISAPContext : DbContext
    {
        public DB_ISAPContext()
        {
        }

        public DB_ISAPContext(DbContextOptions<DB_ISAPContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DbServer> DbServers { get; set; }
        public virtual DbSet<Inv1> Inv1s { get; set; }
        public virtual DbSet<Oinv> Oinvs { get; set; }
        public virtual DbSet<Orct> Orcts { get; set; }
        public virtual DbSet<Ousr> Ousrs { get; set; }
        public virtual DbSet<SapServer> SapServers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-R24LB32;Database=DB_ISAP;User Id=sa;Password=1234;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<DbServer>(entity =>
            {
                entity.HasKey(e => e.IdDbServer);

                entity.ToTable("DB_SERVER");

                entity.HasIndex(e => e.ServerName, "UQ__DB_SERVE__97BAE5EBC3C000A8")
                    .IsUnique();

                entity.Property(e => e.IdDbServer).HasColumnName("ID_DB_SERVER");

                entity.Property(e => e.ServerName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ServerPass)
                    .IsRequired()
                    .HasMaxLength(254);

                entity.Property(e => e.ServerType)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.ServerUser)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Inv1>(entity =>
            {
                entity.HasKey(e => e.IdInv1);

                entity.ToTable("INV1");

                entity.Property(e => e.IdInv1).HasColumnName("ID_INV1");

                entity.Property(e => e.Currency)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DiscPrcnt).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.Dscription)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IdOinv).HasColumnName("ID_OINV");

                entity.Property(e => e.ItemCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LineTotal).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.Price).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.Rate).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.TaxCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TotalFrgn).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.VatSum).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.VatSumFrgn).HasColumnType("decimal(19, 6)");

                entity.HasOne(d => d.IdOinvNavigation)
                    .WithMany(p => p.Inv1s)
                    .HasForeignKey(d => d.IdOinv)
                    .HasConstraintName("fk_INV1_OINV1");
            });

            modelBuilder.Entity<Oinv>(entity =>
            {
                entity.HasKey(e => e.IdOinv);

                entity.ToTable("OINV");

                entity.Property(e => e.IdOinv).HasColumnName("ID_OINV");

                entity.Property(e => e.CardCode)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CardName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DocDate).HasColumnType("date");

                entity.Property(e => e.DocDueDate).HasColumnType("date");

                entity.Property(e => e.DocTotal).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.SyncronizedDate).HasColumnType("date");

                entity.Property(e => e.TaxDate).HasColumnType("date");

                entity.HasOne(d => d.SyncronizedByNavigation)
                    .WithMany(p => p.Oinvs)
                    .HasForeignKey(d => d.SyncronizedBy)
                    .HasConstraintName("fk_OINV_OUSR");
            });

            modelBuilder.Entity<Orct>(entity =>
            {
                entity.HasKey(e => e.IdOrct);

                entity.ToTable("ORCT");

                entity.Property(e => e.IdOrct).HasColumnName("ID_ORCT");

                entity.Property(e => e.CashSum).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.CheckSum).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.CreditSum).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.DocDate).HasColumnType("date");

                entity.Property(e => e.DocTotal).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.IdOinv).HasColumnName("ID_OINV");

                entity.Property(e => e.SyncronizedDate).HasColumnType("date");

                entity.Property(e => e.TrsfrSum).HasColumnType("decimal(19, 6)");

                entity.HasOne(d => d.IdOinvNavigation)
                    .WithMany(p => p.Orcts)
                    .HasForeignKey(d => d.IdOinv)
                    .HasConstraintName("fk_ORCT_OINV1");
            });

            modelBuilder.Entity<Ousr>(entity =>
            {
                entity.HasKey(e => e.IdOusr);

                entity.ToTable("OUSR");

                entity.Property(e => e.IdOusr).HasColumnName("ID_OUSR");

                entity.Property(e => e.Usercode)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("USERCODE");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<SapServer>(entity =>
            {
                entity.HasKey(e => e.IdSapServer);

                entity.ToTable("SAP_SERVER");

                entity.Property(e => e.IdSapServer).HasColumnName("ID_SAP_SERVER");

                entity.Property(e => e.CmpName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DbName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Loc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("LOC");

                entity.Property(e => e.VersStr)
                    .IsRequired()
                    .HasMaxLength(13);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
