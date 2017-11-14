using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SeattlePetNanny.Migrations
{
    public partial class FixedWorker : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Walker",
                table: "Walker");

            migrationBuilder.DropColumn(
                name: "WalkerID",
                table: "ReportCard");

            migrationBuilder.DropColumn(
                name: "WalkerID",
                table: "Walker");

            migrationBuilder.AddColumn<int>(
                name: "WorkerID",
                table: "ReportCard",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WorkerID",
                table: "Walker",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Walker",
                table: "Walker",
                column: "WorkerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Walker",
                table: "Walker");

            migrationBuilder.DropColumn(
                name: "WorkerID",
                table: "ReportCard");

            migrationBuilder.DropColumn(
                name: "WorkerID",
                table: "Walker");

            migrationBuilder.AddColumn<int>(
                name: "WalkerID",
                table: "ReportCard",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WalkerID",
                table: "Walker",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Walker",
                table: "Walker",
                column: "WalkerID");
        }
    }
}
