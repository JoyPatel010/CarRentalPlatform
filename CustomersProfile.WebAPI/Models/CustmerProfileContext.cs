using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CustomersProfile.WebAPI.Models;

public partial class CustmerProfileContext : DbContext
{
    public CustmerProfileContext()
    {
    }

    public CustmerProfileContext(DbContextOptions<CustmerProfileContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=CustomersProfile;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Customer__3214EC07F7A7C0B6");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
