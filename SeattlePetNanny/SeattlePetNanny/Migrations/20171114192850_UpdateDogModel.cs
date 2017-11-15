using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SeattlePetNanny.Migrations
{
    public partial class UpdateDogModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Owner_Dog_DogID1",
                table: "Owner");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Walker",
                table: "Walker");

            migrationBuilder.DropIndex(
                name: "IX_Owner_DogID1",
                table: "Owner");

            migrationBuilder.DropColumn(
                name: "DogID",
                table: "Owner");

            migrationBuilder.DropColumn(
                name: "DogID1",
                table: "Owner");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Owner");

            migrationBuilder.RenameTable(
                name: "Walker",
                newName: "Worker");

            migrationBuilder.AddColumn<string>(
                name: "OwnerNotes",
                table: "ReportCard",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkerNotes",
                table: "ReportCard",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Owner",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Owner",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Owner",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Owner",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "Owner",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Owner",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Owner",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Owner",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Owner",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Owner",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Owner",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Owner",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Owner",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Owner",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Owner",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Owner",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Worker",
                table: "Worker",
                column: "WorkerID");

            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    AdminID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.AdminID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dog_OwnerId",
                table: "Dog",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dog_Owner_OwnerId",
                table: "Dog",
                column: "OwnerId",
                principalTable: "Owner",
                principalColumn: "OwnerID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dog_Owner_OwnerId",
                table: "Dog");

            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Worker",
                table: "Worker");

            migrationBuilder.DropIndex(
                name: "IX_Dog_OwnerId",
                table: "Dog");

            migrationBuilder.DropColumn(
                name: "OwnerNotes",
                table: "ReportCard");

            migrationBuilder.DropColumn(
                name: "WorkerNotes",
                table: "ReportCard");

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Owner");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Owner");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Owner");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Owner");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Owner");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Owner");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Owner");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Owner");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Owner");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Owner");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Owner");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Owner");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Owner");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Owner");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Owner");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Owner");

            migrationBuilder.RenameTable(
                name: "Worker",
                newName: "Walker");

            migrationBuilder.AddColumn<int>(
                name: "DogID",
                table: "Owner",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DogID1",
                table: "Owner",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Owner",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Walker",
                table: "Walker",
                column: "WorkerID");

            migrationBuilder.CreateIndex(
                name: "IX_Owner_DogID1",
                table: "Owner",
                column: "DogID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Owner_Dog_DogID1",
                table: "Owner",
                column: "DogID1",
                principalTable: "Dog",
                principalColumn: "DogID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
