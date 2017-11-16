using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SeattlePetNanny.Migrations.SeattlePetNanny
{
    public partial class AddedConnections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Worker");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Worker");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Admin");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Worker",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Worker",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Admin",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Admin",
                nullable: true);
        }
    }
}
