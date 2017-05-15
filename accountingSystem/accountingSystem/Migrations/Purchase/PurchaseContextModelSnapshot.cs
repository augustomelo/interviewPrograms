using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using accountingSystem.DAL;

namespace accountingSystem.Migrations.Purchase
{
    [DbContext(typeof(PurchaseContext))]
    partial class PurchaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("accountingSystem.Models.Purchase", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Cancelled");

                    b.Property<string>("ItemName");

                    b.Property<string>("Name");

                    b.Property<float>("Price");

                    b.Property<int>("Quantity");

                    b.HasKey("ID");

                    b.ToTable("Purchase");
                });
        }
    }
}
