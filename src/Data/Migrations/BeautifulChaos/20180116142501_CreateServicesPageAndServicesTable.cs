using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Data.Migrations.BeautifulChaos
{
    public partial class CreateServicesPageAndServicesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ServicesPage",
                columns: table => new
                {
                    ServicesPageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Content1Header = table.Column<string>(nullable: false),
                    Content1Paragraph = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    DeletedAt = table.Column<DateTimeOffset>(nullable: false),
                    FeatureLeftIcon = table.Column<string>(nullable: false),
                    FeatureLeftParagraph = table.Column<string>(nullable: false),
                    FeatureLeftTitle = table.Column<string>(nullable: false),
                    FeatureMidIcon = table.Column<string>(nullable: false),
                    FeatureMidParagraph = table.Column<string>(nullable: false),
                    FeatureMidtTitle = table.Column<string>(nullable: false),
                    FeatureRightIcon = table.Column<string>(nullable: false),
                    FeatureRightParagraph = table.Column<string>(nullable: false),
                    FeatureRightTitle = table.Column<string>(nullable: false),
                    HeaderParagraph = table.Column<string>(nullable: false),
                    HeaderTitle = table.Column<string>(nullable: false),
                    ServiceId = table.Column<int>(nullable: false),
                    ServiceSection1Title = table.Column<string>(nullable: true),
                    ServiceSection2Title = table.Column<string>(nullable: true),
                    ServiceSection3Title = table.Column<string>(nullable: true),
                    UUId = table.Column<Guid>(nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicesPage", x => x.ServicesPageId);
                });

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    ServiceId = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    DeletedAt = table.Column<DateTimeOffset>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    ServicePageId = table.Column<int>(nullable: false),
                    UUId = table.Column<Guid>(nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.ServiceId);
                    table.ForeignKey(
                        name: "FK_Service_ServicesPage_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "ServicesPage",
                        principalColumn: "ServicesPageId",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "ServicesPage");
        }
    }
}
