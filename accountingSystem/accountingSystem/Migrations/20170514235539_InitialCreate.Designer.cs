using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using accountingSystem.DAL;

namespace accountingSystem.Migrations
{
    [DbContext(typeof(AccountsReceivableContext))]
    [Migration("20170514235539_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("accountingSystem.Models.AccountsReceivable", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Addition");

                    b.Property<string>("CPF");

                    b.Property<string>("Description");

                    b.Property<float>("Discount");

                    b.Property<DateTime>("Due");

                    b.Property<DateTime>("Emission");

                    b.Property<float>("Payed");

                    b.Property<float>("Price");

                    b.Property<string>("UserEmail");

                    b.Property<string>("UserName");

                    b.Property<string>("UserPhone");

                    b.HasKey("ID");

                    b.ToTable("AccountsReceivable");
                });
        }
    }
}
