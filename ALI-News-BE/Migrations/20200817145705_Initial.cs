using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ALI_News_BE.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Domain",
                columns: table => new
                {
                    Id = table.Column<byte[]>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<DateTime>(nullable: false),
                    DisplayName = table.Column<string>(nullable: false),
                    BaseUrl = table.Column<string>(nullable: false),
                    Url = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Domain", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<byte[]>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Summary = table.Column<string>(nullable: false),
                    Content = table.Column<string>(nullable: false),
                    Thumbnail = table.Column<string>(nullable: true),
                    BublicationDate = table.Column<DateTime>(nullable: false),
                    AggregatorId = table.Column<byte[]>(nullable: true),
                    SourceId = table.Column<byte[]>(nullable: true),
                    Keywords = table.Column<string>(nullable: true),
                    Categories = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                    table.ForeignKey(
                        name: "FK_News_Domain_AggregatorId",
                        column: x => x.AggregatorId,
                        principalTable: "Domain",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_News_Domain_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Domain",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Local",
                columns: table => new
                {
                    Id = table.Column<byte[]>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<DateTime>(nullable: false),
                    NewsId = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Local", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Local_News_NewsId",
                        column: x => x.NewsId,
                        principalTable: "News",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Local_NewsId",
                table: "Local",
                column: "NewsId");

            migrationBuilder.CreateIndex(
                name: "IX_News_AggregatorId",
                table: "News",
                column: "AggregatorId");

            migrationBuilder.CreateIndex(
                name: "IX_News_SourceId",
                table: "News",
                column: "SourceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Local");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Domain");
        }
    }
}
