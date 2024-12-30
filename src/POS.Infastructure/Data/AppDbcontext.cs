using Microsoft.EntityFrameworkCore;
using POS.Domain.Entities;

namespace POS.Infastructure.Data;

public partial class AppDbcontext : DbContext
{
    public AppDbcontext()
    {
    }

    public AppDbcontext(DbContextOptions<AppDbcontext> options)
        : base(options)
    {
    }

    public virtual DbSet<Invoice> Invoices { get; set; }

    public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; }

    public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Return> Returns { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Stock> Stocks { get; set; }

    public virtual DbSet<StockDamaged> StockDamageds { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Invoice>(entity =>
        {
            entity.ToTable("Invoice");

            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.Date).HasColumnType("smalldatetime");
            entity.Property(e => e.Discount).HasColumnType("smallmoney");
            entity.Property(e => e.Total).HasColumnType("smallmoney");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.Invoices)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Invoice_Users");

            entity.HasOne(d => d.PaymenyMethodNavigation).WithMany(p => p.Invoices)
                .HasForeignKey(d => d.PaymenyMethod)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Invoice_PaymentMethods");
        });

        modelBuilder.Entity<InvoiceDetail>(entity =>
        {
            entity.Property(e => e.Date).HasColumnType("smalldatetime");
            entity.Property(e => e.ProductCode).HasMaxLength(20);

            entity.HasOne(d => d.Invoice).WithMany(p => p.InvoiceDetails)
                .HasForeignKey(d => d.InvoiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InvoiceDetails_Invoice");

            entity.HasOne(d => d.ProductCodeNavigation).WithMany(p => p.InvoiceDetails)
                .HasForeignKey(d => d.ProductCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InvoiceDetails_Products");
        });

        modelBuilder.Entity<PaymentMethod>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductCode);

            entity.Property(e => e.ProductCode).HasMaxLength(20);
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.UnitPrice).HasColumnType("smallmoney");
        });

        modelBuilder.Entity<Return>(entity =>
        {
            entity.Property(e => e.Date).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasIndex(e => e.Rolel, "UK_Roles").IsUnique();

            entity.Property(e => e.Rolel)
                .HasMaxLength(20)
                .HasColumnName("Role");
        });

        modelBuilder.Entity<Stock>(entity =>
        {
            entity.HasKey(e => e.StokcId);

            entity.ToTable("Stock");

            entity.Property(e => e.BuyUnitPrice).HasColumnType("smallmoney");
            entity.Property(e => e.ProductCode).HasMaxLength(20);
            entity.Property(e => e.Total).HasColumnType("smallmoney");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.Stocks)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Stock_Users");

            entity.HasOne(d => d.ProductCodeNavigation).WithMany(p => p.Stocks)
                .HasForeignKey(d => d.ProductCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Stock_Products");
        });

        modelBuilder.Entity<StockDamaged>(entity =>
        {
            entity.ToTable("StockDamaged");

            entity.Property(e => e.Note).HasMaxLength(256);
            entity.Property(e => e.Total).HasColumnType("smallmoney");

            entity.HasOne(d => d.Stokc).WithMany(p => p.StockDamageds)
                .HasForeignKey(d => d.StokcId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockDamaged_Stock");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasIndex(e => e.Username, "UN_usernam").IsUnique();

            entity.Property(e => e.UserId).ValueGeneratedOnAdd();
            entity.Property(e => e.Password)
                .HasMaxLength(256)
                .HasColumnName("password");
            entity.Property(e => e.Username)
                .HasMaxLength(15)
                .HasColumnName("username");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Users_Roles");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
