using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SensiveProject.DataAccessLayer.Migrations
{
    public partial class mig11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tag",
                table: "Articles");

            migrationBuilder.CreateTable(
                name: "ArticleTagCloud",
                columns: table => new
                {
                    ArticlesArticleId = table.Column<int>(type: "int", nullable: false),
                    TagsTagCloudId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleTagCloud", x => new { x.ArticlesArticleId, x.TagsTagCloudId });
                    table.ForeignKey(
                        name: "FK_ArticleTagCloud_Articles_ArticlesArticleId",
                        column: x => x.ArticlesArticleId,
                        principalTable: "Articles",
                        principalColumn: "ArticleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleTagCloud_TagClouds_TagsTagCloudId",
                        column: x => x.TagsTagCloudId,
                        principalTable: "TagClouds",
                        principalColumn: "TagCloudId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArticleTagCloud_TagsTagCloudId",
                table: "ArticleTagCloud",
                column: "TagsTagCloudId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleTagCloud");

            migrationBuilder.AddColumn<string>(
                name: "Tag",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
