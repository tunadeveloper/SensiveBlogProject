using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SensiveProject.DataAccessLayer.Migrations
{
    public partial class addArticleTagCloudPrimaryKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArticleTagClouds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticleId = table.Column<int>(type: "int", nullable: false),
                    TagCloudId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleTagClouds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArticleTagClouds_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "ArticleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleTagClouds_TagClouds_TagCloudId",
                        column: x => x.TagCloudId,
                        principalTable: "TagClouds",
                        principalColumn: "TagCloudId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArticleTagClouds_ArticleId",
                table: "ArticleTagClouds",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleTagClouds_TagCloudId",
                table: "ArticleTagClouds",
                column: "TagCloudId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleTagClouds");
        }
    }
}
