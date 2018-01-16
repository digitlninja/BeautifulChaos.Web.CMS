using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Data.Migrations.BeautifulChaos
{
    public partial class UpdateServicesPageKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Service_ServicesPage_ServiceId",
                table: "Service");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Service",
                table: "Service");

            migrationBuilder.RenameTable(
                name: "Service",
                newName: "Services");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Services",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            //            migrationBuilder.AlterColumn<int>(
            //                name: "ServiceId",
            //                table: "Services",
            //                nullable: false,
            //                oldClrType: typeof(int))
            //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                    name: "ServiceId2",
                    table: "Services",
                    nullable: true);

            migrationBuilder.Sql("update services set ServiceId2 = ServiceId");

           
            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "Services");


            migrationBuilder.RenameColumn(
                name: "ServiceId2",
                table: "Services",
                newName: "ServiceId");


            migrationBuilder.AlterColumn<int>(
                name: "ServiceId",
                table: "Services",
                nullable: false,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServiceId",
                table: "Services",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_ServicePageId",
                table: "Services",
                column: "ServicePageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Services_ServicesPage_ServicePageId",
                table: "Services",
                column: "ServicePageId",
                principalTable: "ServicesPage",
                principalColumn: "ServicesPageId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_ServicesPage_ServicePageId",
                table: "Services");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Services",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Services_ServicePageId",
                table: "Services");

            migrationBuilder.RenameTable(
                name: "Services",
                newName: "Service");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Service",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "ServiceId",
                table: "Service",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Service",
                table: "Service",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Service_ServicesPage_ServiceId",
                table: "Service",
                column: "ServiceId",
                principalTable: "ServicesPage",
                principalColumn: "ServicesPageId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
