using Microsoft.EntityFrameworkCore;
using SERVER.Models;
using System;
using System.Collections.Generic;



namespace DAL.Models;

public partial class ProjectContext : DbContext
{
    public ProjectContext()
    {
    }

    public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)  
    {
    }

    public virtual DbSet<Baby> Babies { get; set; }

    public virtual DbSet<Mother> Mothers { get; set; }

    public virtual DbSet<Registration> Registrations { get; set; }

    public virtual DbSet<RoomPrice> RoomPrices { get; set; }

    public virtual DbSet<RoomType> RoomTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\COM\\Desktop\\finalProject\\Project\\Project.mdf\";Integrated Security=True;Connect Timeout=30;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Baby>(entity =>
        {
            entity.HasKey(e => e.BabyId).HasName("PK__Babies__7915D7EFA7B0E436");

            entity.Property(e => e.BabyId)
                .ValueGeneratedNever()
                .HasColumnName("BabyID");
            entity.Property(e => e.DateOfBirth).HasColumnType("date");
            entity.Property(e => e.MotherId).HasColumnName("MotherID");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            entity.HasOne(d => d.Mother).WithMany(p => p.Babies)
                .HasForeignKey(d => d.MotherId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Babies__MotherID__7F2BE32F");
        });

        modelBuilder.Entity<Mother>(entity =>
        {
            entity.HasKey(e => e.IdMother).HasName("PK__tmp_ms_x__AFFC3DD5D06A7DEF");

            entity.ToTable("mother");

            entity.Property(e => e.IdMother)
                .ValueGeneratedNever()
                .HasColumnName("Id_mother");
          
            entity.Property(e => e.MotherName)
                .HasMaxLength(20)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("mother_name");
            entity.Property(e => e.Phone)
                .HasMaxLength(9)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("phone");

           
        });

        modelBuilder.Entity<Registration>(entity =>
        {
            entity.HasKey(e => e.IdRegistration).HasName("PK__registra__38DBEA6F50A0C60E");

            entity.ToTable("registration");

            entity.Property(e => e.IdRegistration)
                .ValueGeneratedNever()
                .HasColumnName("Id_registration");
            entity.Property(e => e.ArrivalDate)
                .HasColumnType("date")
                .HasColumnName("Arrival_date");
            entity.Property(e => e.DepartureDate)
                .HasColumnType("date")
                .HasColumnName("departure_date");
            entity.Property(e => e.IdMother).HasColumnName("Id_mother");
            entity.Property(e => e.IdRoom).HasColumnName("Id_room");

            entity.HasOne(d => d.IdMotherNavigation).WithMany(p => p.Registrations)
                .HasForeignKey(d => d.IdMother)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__registrat__Id_mo__7C4F7684");

            entity.HasOne(d => d.IdRoomNavigation).WithMany(p => p.Registrations)
                .HasForeignKey(d => d.IdRoom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__registrat__Id_ro__7D439ABD");
        });

        modelBuilder.Entity<RoomPrice>(entity =>
        {
            entity.HasKey(e => e.IdRoom).HasName("PK__RoomPric__74C1FDF6617444B9");

            entity.Property(e => e.IdRoom)
                .ValueGeneratedNever()
                .HasColumnName("Id_room");
            entity.Property(e => e.IdType)
                .HasMaxLength(20)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("id_type");
            entity.Property(e => e.Price).HasColumnName("price");

            entity.HasOne(d => d.IdRoomNavigation).WithOne(p => p.RoomPrice)
                .HasForeignKey<RoomPrice>(d => d.IdRoom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RoomPrice__Id_ty__797309D9");
        });

        modelBuilder.Entity<RoomType>(entity =>
        {
            entity.HasKey(e => e.IdType).HasName("PK__RoomType__74C1FDF69A9A8AFD");

            entity.Property(e => e.IdType)
                .ValueGeneratedNever()
                .HasColumnName("Id_type");
            entity.Property(e => e.TypeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
