using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace accountingSystem.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountsReceivable",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Addition = table.Column<int>(nullable: false),
                    CPF = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Discount = table.Column<float>(nullable: false),
                    Due = table.Column<DateTime>(nullable: false),
                    Emission = table.Column<DateTime>(nullable: false),
                    Payed = table.Column<float>(nullable: false),
                    Price = table.Column<float>(nullable: false),
                    UserEmail = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    UserPhone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountsReceivable", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountsReceivable");
        }
    }
}
