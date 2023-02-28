using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MegaCasting2022.DBLib.Class
{
    public partial class MegaCastingCsharpContext : DbContext
    {
        public MegaCastingCsharpContext()
        {
        }

        public MegaCastingCsharpContext(DbContextOptions<MegaCastingCsharpContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Activity> Activities { get; set; } = null!;
        public virtual DbSet<ActivityArtist> ActivityArtists { get; set; } = null!;
        public virtual DbSet<ActivityDomain> ActivityDomains { get; set; } = null!;
        public virtual DbSet<Advice> Advices { get; set; } = null!;
        public virtual DbSet<Artist> Artists { get; set; } = null!;
        public virtual DbSet<Civility> Civilities { get; set; } = null!;
        public virtual DbSet<Client> Clients { get; set; } = null!;
        public virtual DbSet<ContractType> ContractTypes { get; set; } = null!;
        public virtual DbSet<DiffusionPartner> DiffusionPartners { get; set; } = null!;
        public virtual DbSet<Interview> Interviews { get; set; } = null!;
        public virtual DbSet<Offer> Offers { get; set; } = null!;
        public virtual DbSet<Pack> Packs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=MegaCastingCsharp;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Activity>(entity =>
            {
                entity.HasKey(e => e.Identifier);

                entity.ToTable("Activity");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<ActivityArtist>(entity =>
            {
                entity.HasKey(e => e.Identifier);

                entity.ToTable("ActivityArtist");

                entity.Property(e => e.Identifier).ValueGeneratedNever();

                entity.HasOne(d => d.IdentifierActivityNavigation)
                    .WithMany(p => p.ActivityArtists)
                    .HasForeignKey(d => d.IdentifierActivity)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ActivityArtist_Activity");

                entity.HasOne(d => d.IdentifierArtistNavigation)
                    .WithMany(p => p.ActivityArtists)
                    .HasForeignKey(d => d.IdentifierArtist)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ActivityArtist_Artist");
            });

            modelBuilder.Entity<ActivityDomain>(entity =>
            {
                entity.HasKey(e => e.Identifier);

                entity.ToTable("ActivityDomain");

                entity.Property(e => e.Identifier).ValueGeneratedNever();

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Label).HasMaxLength(250);
            });

            modelBuilder.Entity<Advice>(entity =>
            {
                entity.HasKey(e => e.Identifier);

                entity.ToTable("Advice");

                entity.Property(e => e.Identifier).ValueGeneratedNever();

                entity.Property(e => e.Content).HasMaxLength(500);

                entity.Property(e => e.Label).HasMaxLength(250);
            });

            modelBuilder.Entity<Artist>(entity =>
            {
                entity.HasKey(e => e.Identifier);

                entity.ToTable("Artist");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Civility>(entity =>
            {
                entity.HasKey(e => e.Identifier);

                entity.ToTable("Civility");

                entity.Property(e => e.Identifier).ValueGeneratedNever();

                entity.Property(e => e.LabelLong).HasMaxLength(250);

                entity.Property(e => e.LabelShort).HasMaxLength(250);
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.Identifier);

                entity.ToTable("Client");

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.AddressZipCode).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(3000);

                entity.Property(e => e.Email).HasMaxLength(250);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);
            });

            modelBuilder.Entity<ContractType>(entity =>
            {
                entity.HasKey(e => e.Identifier);

                entity.ToTable("ContractType");

                entity.Property(e => e.Name).HasMaxLength(40);

                entity.Property(e => e.ShortName).HasMaxLength(5);
            });

            modelBuilder.Entity<DiffusionPartner>(entity =>
            {
                entity.HasKey(e => e.Identifier)
                    .HasName("PK_DiffusionPartner_1");

                entity.ToTable("DiffusionPartner");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Login).HasMaxLength(250);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(250);

                entity.Property(e => e.Phone).HasMaxLength(50);
            });

            modelBuilder.Entity<Interview>(entity =>
            {
                entity.HasKey(e => e.Identifier);

                entity.ToTable("Interview");

                entity.Property(e => e.Identifier).ValueGeneratedNever();

                entity.Property(e => e.Label).HasMaxLength(250);

                entity.Property(e => e.Url)
                    .HasMaxLength(250)
                    .HasColumnName("url");
            });

            modelBuilder.Entity<Offer>(entity =>
            {
                entity.HasKey(e => e.Identifier);

                entity.ToTable("Offer");

                entity.Property(e => e.Description).HasMaxLength(3000);

                entity.Property(e => e.Label).HasMaxLength(50);

                entity.Property(e => e.Localisation).HasMaxLength(250);

                entity.Property(e => e.Reference).HasMaxLength(250);

                entity.HasOne(d => d.IdentifierActivityDomainNavigation)
                    .WithMany(p => p.Offers)
                    .HasForeignKey(d => d.IdentifierActivityDomain)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Offer_ActivityDomain");

                entity.HasOne(d => d.IdentifierClientNavigation)
                    .WithMany(p => p.Offers)
                    .HasForeignKey(d => d.IdentifierClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Offer_Client");

                entity.HasOne(d => d.IndentifierContractTypeNavigation)
                    .WithMany(p => p.Offers)
                    .HasForeignKey(d => d.IndentifierContractType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Offer_ContractType");
            });

            modelBuilder.Entity<Pack>(entity =>
            {
                entity.HasKey(e => e.Identifier);

                entity.ToTable("Pack");

                entity.Property(e => e.Identifier).ValueGeneratedNever();

                entity.Property(e => e.Label).HasMaxLength(250);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
