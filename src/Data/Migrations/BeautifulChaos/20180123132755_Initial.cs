using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Data.Migrations.BeautifulChaos
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Page",
                columns: table => new
                {
                    PageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PageName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Page", x => x.PageId);
                });

            migrationBuilder.CreateTable(
                name: "About",
                columns: table => new
                {
                    AboutId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AboutImage1 = table.Column<string>(nullable: true),
                    AboutImage2 = table.Column<string>(nullable: true),
                    AboutImage3 = table.Column<string>(nullable: true),
                    Content1Header = table.Column<string>(nullable: true),
                    Content1Paragraph = table.Column<string>(nullable: true),
                    DescriptionBlock1Header = table.Column<string>(nullable: true),
                    DescriptionBlock1Image = table.Column<string>(nullable: true),
                    DescriptionBlock1Paragraph = table.Column<string>(nullable: true),
                    DescriptionBlock2Header = table.Column<string>(nullable: true),
                    DescriptionBlock2Image = table.Column<string>(nullable: true),
                    DescriptionBlock2Paragraph = table.Column<string>(nullable: true),
                    HeaderParagraph = table.Column<string>(nullable: true),
                    HeaderTitle = table.Column<string>(nullable: true),
                    PageId = table.Column<int>(nullable: false),
                    TeamParagraph = table.Column<string>(nullable: true),
                    TeamTitle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_About", x => x.AboutId);
                    table.ForeignKey(
                        name: "FK_About_Page_PageId",
                        column: x => x.PageId,
                        principalTable: "Page",
                        principalColumn: "PageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContentColumns",
                columns: table => new
                {
                    ContentColumnId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: true),
                    DeletedAt = table.Column<DateTimeOffset>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    PageId = table.Column<int>(nullable: false),
                    PageName = table.Column<string>(nullable: true),
                    Paragraph = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    UUId = table.Column<Guid>(nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentColumns", x => x.ContentColumnId);
                    table.ForeignKey(
                        name: "FK_ContentColumns_Page_PageId",
                        column: x => x.PageId,
                        principalTable: "Page",
                        principalColumn: "PageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServicesPage",
                columns: table => new
                {
                    ServicesPageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Content1Header = table.Column<string>(nullable: true),
                    Content1Paragraph = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: true),
                    DeletedAt = table.Column<DateTimeOffset>(nullable: true),
                    HeaderParagraph = table.Column<string>(nullable: true),
                    HeaderTitle = table.Column<string>(nullable: true),
                    PageId = table.Column<int>(nullable: false),
                    ServiceSection1Title = table.Column<string>(nullable: true),
                    ServiceSection2Title = table.Column<string>(nullable: true),
                    ServiceSection3Title = table.Column<string>(nullable: true),
                    UUId = table.Column<Guid>(nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicesPage", x => x.ServicesPageId);
                    table.ForeignKey(
                        name: "FK_ServicesPage_Page_PageId",
                        column: x => x.PageId,
                        principalTable: "Page",
                        principalColumn: "PageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TestimonialsPage",
                columns: table => new
                {
                    TestimonialsPageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContentSectionHeader = table.Column<string>(nullable: true),
                    ContentSectionParagraph = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: true),
                    DeletedAt = table.Column<DateTimeOffset>(nullable: true),
                    HeaderTitle = table.Column<string>(nullable: true),
                    LeftContentParagraph = table.Column<string>(nullable: true),
                    LeftContentTitle = table.Column<string>(nullable: true),
                    MiddleContentParagraph = table.Column<string>(nullable: true),
                    MiddleContentTitle = table.Column<string>(nullable: true),
                    PageId = table.Column<int>(nullable: false),
                    RightContentParagraph = table.Column<string>(nullable: true),
                    RightContentTitle = table.Column<string>(nullable: true),
                    UUId = table.Column<Guid>(nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestimonialsPage", x => x.TestimonialsPageId);
                    table.ForeignKey(
                        name: "FK_TestimonialsPage_Page_PageId",
                        column: x => x.PageId,
                        principalTable: "Page",
                        principalColumn: "PageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ServiceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: true),
                    DeletedAt = table.Column<DateTimeOffset>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    ServicesPageId = table.Column<int>(nullable: false),
                    UUId = table.Column<Guid>(nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ServiceId);
                    table.ForeignKey(
                        name: "FK_Services_ServicesPage_ServicesPageId",
                        column: x => x.ServicesPageId,
                        principalTable: "ServicesPage",
                        principalColumn: "ServicesPageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Testimonials",
                columns: table => new
                {
                    TestimonialId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TestimonialContent = table.Column<string>(nullable: true),
                    TestimonialsPageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testimonials", x => x.TestimonialId);
                    table.ForeignKey(
                        name: "FK_Testimonials_TestimonialsPage_TestimonialsPageId",
                        column: x => x.TestimonialsPageId,
                        principalTable: "TestimonialsPage",
                        principalColumn: "TestimonialsPageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_About_PageId",
                table: "About",
                column: "PageId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContentColumns_PageId",
                table: "ContentColumns",
                column: "PageId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_ServicesPageId",
                table: "Services",
                column: "ServicesPageId");

            migrationBuilder.CreateIndex(
                name: "IX_ServicesPage_PageId",
                table: "ServicesPage",
                column: "PageId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Testimonials_TestimonialsPageId",
                table: "Testimonials",
                column: "TestimonialsPageId");

            migrationBuilder.CreateIndex(
                name: "IX_TestimonialsPage_PageId",
                table: "TestimonialsPage",
                column: "PageId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "About");

            migrationBuilder.DropTable(
                name: "ContentColumns");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Testimonials");

            migrationBuilder.DropTable(
                name: "ServicesPage");

            migrationBuilder.DropTable(
                name: "TestimonialsPage");

            migrationBuilder.DropTable(
                name: "Page");
        }
    }
}
