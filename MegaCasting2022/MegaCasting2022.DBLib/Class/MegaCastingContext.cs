using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MegaCasting2022.DBLib.Class
{
    public partial class MegaCastingContext : DbContext
    {
        public MegaCastingContext()
        {
        }

        public MegaCastingContext(DbContextOptions<MegaCastingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Activity> Activities { get; set; } = null!;
        public virtual DbSet<ActivityDomain> ActivityDomains { get; set; } = null!;
        public virtual DbSet<Advice> Advices { get; set; } = null!;
        public virtual DbSet<Civility> Civilities { get; set; } = null!;
        public virtual DbSet<Client> Clients { get; set; } = null!;
        public virtual DbSet<ContractType> ContractTypes { get; set; } = null!;
        public virtual DbSet<DiffusionPartner> DiffusionPartners { get; set; } = null!;
        public virtual DbSet<DoctrineMigrationVersion> DoctrineMigrationVersions { get; set; } = null!;
        public virtual DbSet<Interview> Interviews { get; set; } = null!;
        public virtual DbSet<Offer> Offers { get; set; } = null!;
        public virtual DbSet<Pack> Packs { get; set; } = null!;
        public virtual DbSet<ResetPasswordRequest> ResetPasswordRequests { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=MegaCasting;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Activity>(entity =>
            {
                entity.HasKey(e => e.Identifier)
                    .HasName("PK__Activity__821FB0180A9B0462");

                entity.ToTable("Activity");

                entity.HasIndex(e => e.IdentifierActivityDomain, "IDX_55026B0C62DE144D");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.HasOne(d => d.IdentifierActivityDomainNavigation)
                    .WithMany(p => p.Activities)
                    .HasForeignKey(d => d.IdentifierActivityDomain)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_55026B0C62DE144D");

                entity.HasMany(d => d.IdentifierActivities)
                    .WithMany(p => p.IdentifierOffers)
                    .UsingEntity<Dictionary<string, object>>(
                        "ActivityOffer",
                        l => l.HasOne<Offer>().WithMany().HasForeignKey("IdentifierActivity").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_588484686C5C7B9"),
                        r => r.HasOne<Activity>().WithMany().HasForeignKey("IdentifierOffer").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_58848461E116446"),
                        j =>
                        {
                            j.HasKey("IdentifierOffer", "IdentifierActivity").HasName("PK__Activity__7D7D4CE67A4092BE");

                            j.ToTable("ActivityOffer");

                            j.HasIndex(new[] { "IdentifierOffer" }, "IDX_58848461E116446");

                            j.HasIndex(new[] { "IdentifierActivity" }, "IDX_588484686C5C7B9");
                        });
            });

            modelBuilder.Entity<ActivityDomain>(entity =>
            {
                entity.HasKey(e => e.Identifier)
                    .HasName("PK__Activity__821FB0189ACA0F42");

                entity.ToTable("ActivityDomain");

                entity.Property(e => e.Description).HasMaxLength(3000);

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<Advice>(entity =>
            {
                entity.HasKey(e => e.Identifier)
                    .HasName("PK__Advice__821FB018C0076409");

                entity.ToTable("Advice");

                entity.Property(e => e.Content).IsUnicode(false);

                entity.Property(e => e.Label).HasMaxLength(255);
            });

            modelBuilder.Entity<Civility>(entity =>
            {
                entity.HasKey(e => e.Identifier)
                    .HasName("PK__Civility__821FB018BC12DA29");

                entity.ToTable("Civility");

                entity.Property(e => e.Longlabel).HasMaxLength(255);

                entity.Property(e => e.ShortLabel).HasMaxLength(255);

                entity.HasMany(d => d.IdentifierCivilities)
                    .WithMany(p => p.IdentifierOffersNavigation)
                    .UsingEntity<Dictionary<string, object>>(
                        "CivilityOffer",
                        l => l.HasOne<Offer>().WithMany().HasForeignKey("IdentifierCivility").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_EE61644212FC897A"),
                        r => r.HasOne<Civility>().WithMany().HasForeignKey("IdentifierOffer").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_EE6164421E116446"),
                        j =>
                        {
                            j.HasKey("IdentifierOffer", "IdentifierCivility").HasName("PK__Civility__2366827304303E3C");

                            j.ToTable("CivilityOffer");

                            j.HasIndex(new[] { "IdentifierCivility" }, "IDX_EE61644212FC897A");

                            j.HasIndex(new[] { "IdentifierOffer" }, "IDX_EE6164421E116446");
                        });
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.Identifier)
                    .HasName("PK__Client__821FB018461FBA40");

                entity.ToTable("Client");

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.AddressZipCode).HasMaxLength(255);

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.FirstName).HasMaxLength(255);

                entity.Property(e => e.LastName).HasMaxLength(255);

                entity.Property(e => e.Phone).HasMaxLength(255);
            });

            modelBuilder.Entity<ContractType>(entity =>
            {
                entity.HasKey(e => e.Identifier)
                    .HasName("PK__Contract__821FB0181AC0FF3D");

                entity.ToTable("ContractType");

                entity.Property(e => e.Label).HasMaxLength(255);

                entity.Property(e => e.ShortLabel).HasMaxLength(255);
            });

            modelBuilder.Entity<DiffusionPartner>(entity =>
            {
                entity.HasKey(e => e.Identifier)
                    .HasName("PK__Diffusio__821FB018E9ACDD76");

                entity.ToTable("DiffusionPartner");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Phone)
                    .HasMaxLength(255)
                    .HasColumnName("phone");
            });

            modelBuilder.Entity<DoctrineMigrationVersion>(entity =>
            {
                entity.HasKey(e => e.Version)
                    .HasName("PK__doctrine__79B5C94C3D6BB6D4");

                entity.ToTable("doctrine_migration_versions");

                entity.Property(e => e.Version)
                    .HasMaxLength(191)
                    .HasColumnName("version");

                entity.Property(e => e.ExecutedAt)
                    .HasPrecision(6)
                    .HasColumnName("executed_at");

                entity.Property(e => e.ExecutionTime).HasColumnName("execution_time");
            });

            modelBuilder.Entity<Interview>(entity =>
            {
                entity.HasKey(e => e.Identifier)
                    .HasName("PK__Intervie__821FB0189F8FCB5B");

                entity.ToTable("Interview");

                entity.Property(e => e.Label).HasMaxLength(255);

                entity.Property(e => e.Url).HasMaxLength(500);
            });

            modelBuilder.Entity<Offer>(entity =>
            {
                entity.HasKey(e => e.Identifier)
                    .HasName("PK__Offers__821FB018170F03D4");

                entity.HasIndex(e => e.IdentifierClient, "IDX_DDEA011199AD3AB8");

                entity.HasIndex(e => e.IdentifierContractType, "IDX_DDEA0111B0E4728C");

                entity.Property(e => e.Description).HasMaxLength(3000);

                entity.Property(e => e.Label).HasMaxLength(255);

                entity.Property(e => e.Localisation).HasMaxLength(255);

                entity.Property(e => e.OfferEndDate).HasPrecision(6);

                entity.Property(e => e.OfferStartDate).HasPrecision(6);

                entity.Property(e => e.ParutionDateTime).HasPrecision(6);

                entity.Property(e => e.ProfesionalLevel).HasColumnName("profesional_level");

                entity.Property(e => e.Reference).HasMaxLength(255);

                entity.Property(e => e.Sponsor).HasColumnName("sponsor");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.IdentifierClientNavigation)
                    .WithMany(p => p.Offers)
                    .HasForeignKey(d => d.IdentifierClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DDEA011199AD3AB8");

                entity.HasOne(d => d.IdentifierContractTypeNavigation)
                    .WithMany(p => p.Offers)
                    .HasForeignKey(d => d.IdentifierContractType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DDEA0111B0E4728C");
            });

            modelBuilder.Entity<Pack>(entity =>
            {
                entity.HasKey(e => e.Identifier)
                    .HasName("PK__Pack__821FB0183527C604");

                entity.ToTable("Pack");

                entity.Property(e => e.Label).HasMaxLength(255);

                entity.HasMany(d => d.IdentifierPacks)
                    .WithMany(p => p.IdentifierClients)
                    .UsingEntity<Dictionary<string, object>>(
                        "PackClient",
                        l => l.HasOne<Client>().WithMany().HasForeignKey("IdentifierPack").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_B779645E8806D6C8"),
                        r => r.HasOne<Pack>().WithMany().HasForeignKey("IdentifierClient").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_B779645E99AD3AB8"),
                        j =>
                        {
                            j.HasKey("IdentifierClient", "IdentifierPack").HasName("PK__PackClie__B3FE70D398983C60");

                            j.ToTable("PackClient");

                            j.HasIndex(new[] { "IdentifierPack" }, "IDX_B779645E8806D6C8");

                            j.HasIndex(new[] { "IdentifierClient" }, "IDX_B779645E99AD3AB8");
                        });
            });

            modelBuilder.Entity<ResetPasswordRequest>(entity =>
            {
                entity.ToTable("reset_password_request");

                entity.HasIndex(e => e.UserId, "IDX_7CE748AA76ED395");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ExpiresAt)
                    .HasPrecision(6)
                    .HasColumnName("expires_at")
                    .HasComment("(DC2Type:datetime_immutable)");

                entity.Property(e => e.HashedToken)
                    .HasMaxLength(100)
                    .HasColumnName("hashed_token");

                entity.Property(e => e.RequestedAt)
                    .HasPrecision(6)
                    .HasColumnName("requested_at")
                    .HasComment("(DC2Type:datetime_immutable)");

                entity.Property(e => e.Selector)
                    .HasMaxLength(20)
                    .HasColumnName("selector");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ResetPasswordRequests)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_7CE748AA76ED395");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.HasIndex(e => e.Email, "UNIQ_2DA1797726535370")
                    .IsUnique()
                    .HasFilter("([email] IS NOT NULL)");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.AddressZipCode).HasMaxLength(255);

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.Country).HasMaxLength(255);

                entity.Property(e => e.Email)
                    .HasMaxLength(180)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName).HasMaxLength(255);

                entity.Property(e => e.ImageName)
                    .HasMaxLength(255)
                    .HasColumnName("image_name");

                entity.Property(e => e.IsVerified).HasColumnName("is_verified");

                entity.Property(e => e.LastName).HasMaxLength(255);

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .HasColumnName("password");

                entity.Property(e => e.Phone).HasMaxLength(255);

                entity.Property(e => e.ProfesionalLevel).HasColumnName("profesional_level");

                entity.Property(e => e.Roles)
                    .IsUnicode(false)
                    .HasColumnName("roles")
                    .HasComment("(DC2Type:json)");

                entity.Property(e => e.UpdatedAt)
                    .HasPrecision(6)
                    .HasColumnName("updated_at")
                    .HasComment("(DC2Type:datetime_immutable)");

                entity.HasMany(d => d.IdentifierUsers)
                    .WithMany(p => p.IdentifierOffers1)
                    .UsingEntity<Dictionary<string, object>>(
                        "UserOffer",
                        l => l.HasOne<Offer>().WithMany().HasForeignKey("IdentifierUser").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_4D42164B924B5EA2"),
                        r => r.HasOne<User>().WithMany().HasForeignKey("IdentifierOffer").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_4D42164B1E116446"),
                        j =>
                        {
                            j.HasKey("IdentifierOffer", "IdentifierUser").HasName("PK__UserOffe__2CE47EFDFBB8AB49");

                            j.ToTable("UserOffer");

                            j.HasIndex(new[] { "IdentifierOffer" }, "IDX_4D42164B1E116446");

                            j.HasIndex(new[] { "IdentifierUser" }, "IDX_4D42164B924B5EA2");
                        });
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
