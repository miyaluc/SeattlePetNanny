using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SeattlePetNanny.Migrations
{
    public partial class AddedApplicationUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dog_Owner_OwnerId",
                table: "Dog");

            migrationBuilder.DropIndex(
                name: "IX_Dog_OwnerId",
                table: "Dog");

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

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Dog");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Owner",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OwnerNumber",
                table: "Dog",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Dog_OwnerNumber",
                table: "Dog",
                column: "OwnerNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Dog_Owner_OwnerNumber",
                table: "Dog",
                column: "OwnerNumber",
                principalTable: "Owner",
                principalColumn: "OwnerID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dog_Owner_OwnerNumber",
                table: "Dog");

            migrationBuilder.DropIndex(
                name: "IX_Dog_OwnerNumber",
                table: "Dog");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Owner");

            migrationBuilder.DropColumn(
                name: "OwnerNumber",
                table: "Dog");

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Owner",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Owner",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Owner",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Owner",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "Owner",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Owner",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Owner",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Owner",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Owner",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Owner",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Owner",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Owner",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Owner",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Owner",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Owner",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Owner",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OwnerId",
                table: "Dog",
                nullable: false,
                defaultValue: 0);

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
    }
}
