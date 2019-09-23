using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ZORI_KIDS_KG.Models;

namespace ZORI_KIDS_KG.Model
{ 
    public partial class zori_kids_dbContext : DbContext
    {
        public zori_kids_dbContext()
        {
        }

        public zori_kids_dbContext(DbContextOptions<zori_kids_dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admins> Admins { get; set; }
        public virtual DbSet<AsocCopil> AsocCopil { get; set; }
        public virtual DbSet<AsocParinte> AsocParinte { get; set; }
        public virtual DbSet<Asociatie> Asociatie { get; set; }
        public virtual DbSet<Copil> Copil { get; set; }
        public virtual DbSet<LinkRolesMenus> LinkRolesMenus { get; set; }        
        public virtual DbSet<Menus> Menus { get; set; }
        public virtual DbSet<Parinte> Parinte { get; set; }
        public virtual DbSet<ParinteCopil> ParinteCopil { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        IConfigurationRoot configuration = new ConfigurationBuilder()
        //           .SetBasePath(Directory.GetCurrentDirectory())
        //           .AddJsonFile("appsettings.json")
        //           .Build();
        //        var connectionString = configuration.GetConnectionString("ZoriDatabase");
        //        optionsBuilder.UseMySQL(connectionString);
        //    }
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Admins>(entity =>
            {
                entity.ToTable("admins", "zori_kids_db");

                entity.HasIndex(e => e.RolesId)
                    .HasName("admins_ibfk_1");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.FullName)
                    .HasColumnName("full_name")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.RolesId)
                    .HasColumnName("roles_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.HasOne(d => d.Roles)
                    .WithMany(p => p.Admins)
                    .HasForeignKey(d => d.RolesId)
                    .HasConstraintName("admins_ibfk_1");
            });
            

            modelBuilder.Entity<AsocCopil>(entity =>
            {
                entity.ToTable("asoc_copil", "zori_kids_db");

                entity.HasIndex(e => e.AsocId)
                    .HasName("asoc_id_for1");

                entity.HasIndex(e => e.CopilId)
                    .HasName("copil_id_for1");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.AsocId)
                    .HasColumnName("asoc_id")
                    .HasColumnType("int(11)");                    

                entity.Property(e => e.CopilId)
                    .HasColumnName("copil_id")
                    .HasColumnType("int(11)");                    

                entity.HasOne(d => d.Asoc)
                    .WithMany(p => p.AsocCopil)
                    .HasForeignKey(d => d.AsocId)
                    .HasConstraintName("rel_asoc_id_for1");

                entity.HasOne(d => d.Copil)
                    .WithMany(p => p.AsocCopil)
                    .HasForeignKey(d => d.CopilId)
                    .HasConstraintName("rel_copil_id_for1");
            });

            modelBuilder.Entity<AsocParinte>(entity =>
            {
                entity.ToTable("asoc_parinte", "zori_kids_db");

                entity.HasIndex(e => e.AsociatieId)
                    .HasName("asociatie_id");

                entity.HasIndex(e => e.ParinteId)
                    .HasName("parinte_id");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.AsociatieId)
                    .HasColumnName("asociatie_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ParinteId)
                    .HasColumnName("parinte_id")
                    .HasColumnType("int(11)");                    

                entity.HasOne(d => d.Asociatie)
                    .WithMany(p => p.AsocParinte)
                    .HasForeignKey(d => d.AsociatieId)
                    .HasConstraintName("idint_asoc");

                entity.HasOne(d => d.Parinte)
                    .WithMany(p => p.AsocParinte)
                    .HasForeignKey(d => d.ParinteId)
                    .HasConstraintName("identificare_parinte");
            });

            modelBuilder.Entity<Asociatie>(entity =>
            {
                entity.ToTable("asociatie", "zori_kids_db");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.HasIndex(e => e.CopilId)
                    .HasName("copil_id");

                entity.HasIndex(e => e.ParinteId)
                    .HasName("parinte_id");

                entity.Property(e => e.Adresa)
                    .IsRequired()
                    .HasColumnName("adresa")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CodFiscal)
                    .IsRequired()
                    .HasColumnName("cod_fiscal")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DataInfintare)
                    .HasColumnName("data_infintare")
                    .HasColumnType("date");

                entity.Property(e => e.Denumire)
                    .IsRequired()
                    .HasColumnName("denumire")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Iban)
                    .IsRequired()
                    .HasColumnName("iban")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Judet)
                    .IsRequired()
                    .HasColumnName("judet")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Localitate)
                    .IsRequired()
                    .HasColumnName("localitate")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ParinteId)
                    .HasColumnName("parinte_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CopilId)
                    .HasColumnName("copil_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NrRegCom)
                    .IsRequired()
                    .HasColumnName("nr_reg_com")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.Copil)
                    .WithMany(p => p.Asociatie)
                    .HasForeignKey(d => d.CopilId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("copil_asoc");

                entity.HasOne(d => d.Parinte)
                    .WithMany(p => p.Asociatie)
                    .HasForeignKey(d => d.ParinteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("parinte_asoc");
            });

            modelBuilder.Entity<Copil>(entity =>
            {
                entity.ToTable("copil", "zori_kids_db");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.HasIndex(e => e.ParinteId)
                    .HasName("parinte_id");                

                entity.Property(e => e.Cnp)
                    .IsRequired()
                    .HasColumnName("cnp")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Nume)
                    .IsRequired()
                    .HasColumnName("nume")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Prenume)
                    .IsRequired()
                    .HasColumnName("prenume")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .IsRequired()
                    .HasColumnName("sex")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Varsta)
                    .HasColumnName("varsta")
                    .HasColumnType("date");

                entity.Property(e => e.Vorbeste)
                    .IsRequired()
                    .HasColumnName("vorbeste")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ParinteId)
                   .HasColumnName("parinte_id")
                   .HasColumnType("int(11)");

                entity.HasOne(d => d.Parinte)
                    .WithMany(p => p.Copil)
                    .HasForeignKey(d => d.ParinteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("parinte_copil");
            });

            modelBuilder.Entity<LinkRolesMenus>(entity =>
            {
                entity.ToTable("link_roles_menus", "zori_kids_db");

                entity.HasIndex(e => e.MenusId)
                    .HasName("menus_id");

                entity.HasIndex(e => e.RolesId)
                    .HasName("roles_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MenusId)
                    .HasColumnName("menus_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RolesId)
                    .HasColumnName("roles_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Menus)
                    .WithMany(p => p.LinkRolesMenus)
                    .HasForeignKey(d => d.MenusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("link_roles_menus_ibfk_1");

                entity.HasOne(d => d.Roles)
                    .WithMany(p => p.LinkRolesMenus)
                    .HasForeignKey(d => d.RolesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("link_roles_menus_ibfk_2");
            });

            modelBuilder.Entity<Menus>(entity =>
            {
                entity.ToTable("menus", "zori_kids_db");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Icon)
                    .IsRequired()
                    .HasColumnName("icon")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<Parinte>(entity =>
            {
                entity.ToTable("parinte", "zori_kids_db");                

                entity.HasIndex(e => e.RolesId)
                    .HasName("admins_ibfk_2");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");                

                entity.Property(e => e.Adresa)
                    .IsRequired()
                    .HasColumnName("adresa")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Cnp)
                    .IsRequired()
                    .HasColumnName("cnp")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Judet)
                    .IsRequired()
                    .HasColumnName("judet")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Localitate)
                    .IsRequired()
                    .HasColumnName("localitate")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Nume)
                    .IsRequired()
                    .HasColumnName("nume")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Prenume)
                    .IsRequired()
                    .HasColumnName("prenume")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RolesId)
                    .HasColumnName("roles_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Sex)
                    .IsRequired()
                    .HasColumnName("sex")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Telefon)
                    .IsRequired()
                    .HasColumnName("telefon")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Varsta)
                    .HasColumnName("varsta")
                    .HasColumnType("date");
                             

                entity.HasOne(d => d.Roles)
                    .WithMany(p => p.Parinte)
                    .HasForeignKey(d => d.RolesId)
                    .HasConstraintName("admins_ibfk_3");
            });

            modelBuilder.Entity<ParinteCopil>(entity =>
            {
                entity.ToTable("parinte_copil", "zori_kids_db");

                entity.HasIndex(e => e.CopilId)
                    .HasName("copil_id");

                entity.HasIndex(e => e.ParinteId)
                    .HasName("parinte_id");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CopilId)
                    .HasColumnName("copil_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ParinteId)
                    .HasColumnName("parinte_id")
                    .HasColumnType("int(11)");                    

                entity.HasOne(d => d.Copil)
                    .WithMany(p => p.ParinteCopil)
                    .HasForeignKey(d => d.CopilId)
                    .HasConstraintName("id_copil");

                entity.HasOne(d => d.Parinte)
                    .WithMany(p => p.ParinteCopil)
                    .HasForeignKey(d => d.ParinteId)
                    .HasConstraintName("id_parinte");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.ToTable("roles", "zori_kids_db");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });
        }
    }
}
