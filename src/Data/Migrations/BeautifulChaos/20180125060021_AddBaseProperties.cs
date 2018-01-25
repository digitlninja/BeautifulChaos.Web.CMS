using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Data.Migrations.BeautifulChaos
{
    public partial class AddBaseProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedAt",
                table: "Work",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DeletedAt",
                table: "Work",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UUId",
                table: "Work",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "UpdatedAt",
                table: "Work",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedAt",
                table: "Testimonials",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DeletedAt",
                table: "Testimonials",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UUId",
                table: "Testimonials",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "UpdatedAt",
                table: "Testimonials",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedAt",
                table: "Page",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DeletedAt",
                table: "Page",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UUId",
                table: "Page",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "UpdatedAt",
                table: "Page",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedAt",
                table: "Images",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DeletedAt",
                table: "Images",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UUId",
                table: "Images",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "UpdatedAt",
                table: "Images",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedAt",
                table: "About",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DeletedAt",
                table: "About",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UUId",
                table: "About",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "UpdatedAt",
                table: "About",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Work");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Work");

            migrationBuilder.DropColumn(
                name: "UUId",
                table: "Work");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Work");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Testimonials");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Testimonials");

            migrationBuilder.DropColumn(
                name: "UUId",
                table: "Testimonials");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Testimonials");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Page");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Page");

            migrationBuilder.DropColumn(
                name: "UUId",
                table: "Page");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Page");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "UUId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "About");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "About");

            migrationBuilder.DropColumn(
                name: "UUId",
                table: "About");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "About");
        }
    }
}
