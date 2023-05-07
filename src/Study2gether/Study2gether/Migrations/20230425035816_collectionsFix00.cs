using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Study2gether.Migrations
{
    public partial class collectionsFix00 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Post_Axis");

            migrationBuilder.DropTable(
                name: "Post_Category");

            migrationBuilder.DropTable(
                name: "Post_Microfoundation");

            migrationBuilder.CreateTable(
                name: "AxisPost",
                columns: table => new
                {
                    AxesidAxis = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PostsidPost = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AxisPost", x => new { x.AxesidAxis, x.PostsidPost });
                    table.ForeignKey(
                        name: "FK_AxisPost_Axis_AxesidAxis",
                        column: x => x.AxesidAxis,
                        principalTable: "Axis",
                        principalColumn: "idAxis",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AxisPost_Post_PostsidPost",
                        column: x => x.PostsidPost,
                        principalTable: "Post",
                        principalColumn: "idPost",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryPost",
                columns: table => new
                {
                    CategoriesidCategory = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PostsidPost = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryPost", x => new { x.CategoriesidCategory, x.PostsidPost });
                    table.ForeignKey(
                        name: "FK_CategoryPost_Category_CategoriesidCategory",
                        column: x => x.CategoriesidCategory,
                        principalTable: "Category",
                        principalColumn: "idCategory",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryPost_Post_PostsidPost",
                        column: x => x.PostsidPost,
                        principalTable: "Post",
                        principalColumn: "idPost",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MicrofoundationPost",
                columns: table => new
                {
                    MicrofoundationsidMicrofoundation = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PostsidPost = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MicrofoundationPost", x => new { x.MicrofoundationsidMicrofoundation, x.PostsidPost });
                    table.ForeignKey(
                        name: "FK_MicrofoundationPost_Microfoundation_MicrofoundationsidMicrofoundation",
                        column: x => x.MicrofoundationsidMicrofoundation,
                        principalTable: "Microfoundation",
                        principalColumn: "idMicrofoundation",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MicrofoundationPost_Post_PostsidPost",
                        column: x => x.PostsidPost,
                        principalTable: "Post",
                        principalColumn: "idPost",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AxisPost_PostsidPost",
                table: "AxisPost",
                column: "PostsidPost");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryPost_PostsidPost",
                table: "CategoryPost",
                column: "PostsidPost");

            migrationBuilder.CreateIndex(
                name: "IX_MicrofoundationPost_PostsidPost",
                table: "MicrofoundationPost",
                column: "PostsidPost");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AxisPost");

            migrationBuilder.DropTable(
                name: "CategoryPost");

            migrationBuilder.DropTable(
                name: "MicrofoundationPost");

            migrationBuilder.CreateTable(
                name: "Post_Axis",
                columns: table => new
                {
                    idPost = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    idAxis = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post_Axis", x => new { x.idPost, x.idAxis });
                    table.ForeignKey(
                        name: "FK_Post_Axis_Axis_idAxis",
                        column: x => x.idAxis,
                        principalTable: "Axis",
                        principalColumn: "idAxis",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Post_Axis_Post_idPost",
                        column: x => x.idPost,
                        principalTable: "Post",
                        principalColumn: "idPost",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Post_Category",
                columns: table => new
                {
                    idPost = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    idCategory = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post_Category", x => new { x.idPost, x.idCategory });
                    table.ForeignKey(
                        name: "FK_Post_Category_Category_idCategory",
                        column: x => x.idCategory,
                        principalTable: "Category",
                        principalColumn: "idCategory",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Post_Category_Post_idPost",
                        column: x => x.idPost,
                        principalTable: "Post",
                        principalColumn: "idPost",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Post_Microfoundation",
                columns: table => new
                {
                    idPost = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    idMicrofoundation = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post_Microfoundation", x => new { x.idPost, x.idMicrofoundation });
                    table.ForeignKey(
                        name: "FK_Post_Microfoundation_Microfoundation_idMicrofoundation",
                        column: x => x.idMicrofoundation,
                        principalTable: "Microfoundation",
                        principalColumn: "idMicrofoundation",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Post_Microfoundation_Post_idPost",
                        column: x => x.idPost,
                        principalTable: "Post",
                        principalColumn: "idPost",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Post_Axis_idAxis",
                table: "Post_Axis",
                column: "idAxis");

            migrationBuilder.CreateIndex(
                name: "IX_Post_Category_idCategory",
                table: "Post_Category",
                column: "idCategory");

            migrationBuilder.CreateIndex(
                name: "IX_Post_Microfoundation_idMicrofoundation",
                table: "Post_Microfoundation",
                column: "idMicrofoundation");
        }
    }
}
