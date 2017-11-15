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
                name: "FK_Dog_Owner_OwnerNumber",
                table: "Dog");

            migrationBuilder.DropIndex(
                name: "IX_Dog_OwnerNumber",
                table: "Dog");

            migrationBuilder.DropColumn(
                name: "WorkerID",
                table: "ReportCard");

            migrationBuilder.AlterColumn<int>(
                name: "DogID",
                table: "ReportCard",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "DogNumber",
                table: "ReportCard",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OwnerID",
                table: "Dog",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ReportCard_DogID",
                table: "ReportCard",
                column: "DogID");

            migrationBuilder.CreateIndex(
                name: "IX_Dog_OwnerID",
                table: "Dog",
                column: "OwnerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Dog_Owner_OwnerID",
                table: "Dog",
                column: "OwnerID",
                principalTable: "Owner",
                principalColumn: "OwnerID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReportCard_Dog_DogID",
                table: "ReportCard",
                column: "DogID",
                principalTable: "Dog",
                principalColumn: "DogID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dog_Owner_OwnerID",
                table: "Dog");

            migrationBuilder.DropForeignKey(
                name: "FK_ReportCard_Dog_DogID",
                table: "ReportCard");

            migrationBuilder.DropIndex(
                name: "IX_ReportCard_DogID",
                table: "ReportCard");

            migrationBuilder.DropIndex(
                name: "IX_Dog_OwnerID",
                table: "Dog");

            migrationBuilder.DropColumn(
                name: "DogNumber",
                table: "ReportCard");

            migrationBuilder.DropColumn(
                name: "OwnerID",
                table: "Dog");

            migrationBuilder.AlterColumn<int>(
                name: "DogID",
                table: "ReportCard",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WorkerID",
                table: "ReportCard",
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
    }
}
