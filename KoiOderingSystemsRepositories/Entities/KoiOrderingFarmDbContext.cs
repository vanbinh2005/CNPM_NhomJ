using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace KoiOderingSystemsRepositories.Entities;

public  class KoiOrderingFarmDbContext : DbContext
{
    public KoiOrderingFarmDbContext()
    {
    }

    public KoiOrderingFarmDbContext(DbContextOptions<KoiOrderingFarmDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<OrderItem> OrderItems { get; set; }

    public virtual DbSet<Consultingstaff> Consultingstaffs { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Deliveringstaff> Deliveringstaffs { get; set; }

    public virtual DbSet<Manager> Managers { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Sale> Sales { get; set; }

    public virtual DbSet<SalesStaff> SalesStaffs { get; set; }

    public virtual DbSet<Tour> Tours { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source= LAPTOP-070S0K4J\\SQLEXPRESS,1433;Initial Catalog= KoiOrderingFarmDB;Integrated Security=True;User iD=sa;Password=123456;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.AccId).HasName("PK__Account__91CBC398DDDBD1C1");

            entity.ToTable("Account");

            entity.HasIndex(e => e.EmailAddress, "UQ__Account__49A14740DD466595").IsUnique();

            entity.Property(e => e.AccId)
                .ValueGeneratedNever()
                .HasColumnName("AccID");
            entity.Property(e => e.Description).HasMaxLength(140);
            entity.Property(e => e.EmailAddress).HasMaxLength(90);
            entity.Property(e => e.Password).HasMaxLength(90);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.KoiId).HasName("PK__Category__E03435B83D77C3B2");

            entity.ToTable("CategoryKoi");

            entity.Property(e => e.KoiId)
                .ValueGeneratedNever()
                .HasColumnName("KoiID");
            entity.Property(e => e.ImageUrl).HasMaxLength(255);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<Consultingstaff>(entity =>
        {
            entity.HasKey(e => e.Staffid).HasName("PK__Consulti__645AE4A65D436E6F");

            entity.ToTable("Consultingstaff");

            entity.Property(e => e.Staffid)
                .ValueGeneratedNever()
                .HasColumnName("staffid");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.PhoneNumber).HasColumnName("phoneNumber");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__Customer__B611CB7DAF6F43EC");

            entity.ToTable("Customer");

            entity.HasIndex(e => e.Email, "UQ__Customer__AB6E61644BC16BAF").IsUnique();

            entity.Property(e => e.CustomerId).HasColumnName("customerId");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasColumnName("address");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(15)
                .HasColumnName("phoneNumber");
        });

        modelBuilder.Entity<Deliveringstaff>(entity =>
        {
            entity.HasKey(e => e.Staffid).HasName("PK__Deliveri__645AE4A669EBC193");

            entity.ToTable("Deliveringstaff");

            entity.Property(e => e.Staffid)
                .ValueGeneratedNever()
                .HasColumnName("staffid");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.PhoneNumber).HasColumnName("phoneNumber");
        });

        modelBuilder.Entity<Manager>(entity =>
        {
            entity.HasKey(e => e.Staffid).HasName("PK__Manager__645AE4A66489A2E0");

            entity.ToTable("Manager");

            entity.Property(e => e.Staffid)
                .ValueGeneratedNever()
                .HasColumnName("staffid");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.PhoneNumber).HasColumnName("phoneNumber");
        });


        modelBuilder.Entity<Sale>(entity =>
        {
            entity.HasKey(e => e.StaffId).HasName("PK__Sales__6465E07E62248212");

            entity.Property(e => e.StaffId)
                .ValueGeneratedNever()
                .HasColumnName("staffId");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.PhoneNumber).HasColumnName("phoneNumber");
        });

        modelBuilder.Entity<SalesStaff>(entity =>
        {
            entity.HasKey(e => e.StaffId).HasName("PK__SalesSta__6465E07E2D4BCBD3");

            entity.ToTable("SalesStaff");

            entity.HasIndex(e => e.Email, "UQ__SalesSta__AB6E616454D95694").IsUnique();

            entity.Property(e => e.StaffId).HasColumnName("staffId");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(15)
                .HasColumnName("phoneNumber");
        });

        modelBuilder.Entity<Tour>(entity =>
        {
            entity.HasKey(e => e.TourId).HasName("PK__Tour__519D1D63C93E8834");

            entity.ToTable("Tour");

            entity.Property(e => e.TourId).HasColumnName("TourId");
            entity.Property(e => e.TourId).HasColumnName("TourId");
            entity.Property(e => e.DepartureCity)
                .HasMaxLength(100)
                .HasColumnName("departureCity");
            entity.Property(e => e.DestinationCity)
                .HasMaxLength(100)
                .HasColumnName("destinationCity");
            entity.Property(e => e.DepartureDate)
                .HasColumnType("datetime")
                .HasColumnName("departureDate");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("price");
        });

    }

}
