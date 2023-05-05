using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Study2gether.Migrations
{
    public partial class Initial00 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Axis",
                columns: table => new
                {
                    idAxis = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Axis", x => x.idAxis);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    idCategory = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.idCategory);
                });

            migrationBuilder.CreateTable(
                name: "Microfoundation",
                columns: table => new
                {
                    idMicrofoundation = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Microfoundation", x => x.idMicrofoundation);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    idUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    imageLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    socialMedia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isAdmin = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.idUser);
                });

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    idPost = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    views = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    idUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.idPost);
                    table.ForeignKey(
                        name: "FK_Post_Users_idUser",
                        column: x => x.idUser,
                        principalTable: "Users",
                        principalColumn: "idUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    idAnswer = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    idPost = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    idUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.idAnswer);
                    table.ForeignKey(
                        name: "FK_Answers_Post_idPost",
                        column: x => x.idPost,
                        principalTable: "Post",
                        principalColumn: "idPost",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Answers_Users_idUser",
                        column: x => x.idUser,
                        principalTable: "Users",
                        principalColumn: "idUser");
                });

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
                name: "IX_Answers_idPost",
                table: "Answers",
                column: "idPost");

            migrationBuilder.CreateIndex(
                name: "IX_Answers_idUser",
                table: "Answers",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_Post_idUser",
                table: "Post",
                column: "idUser");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Post_Axis");

            migrationBuilder.DropTable(
                name: "Post_Category");

            migrationBuilder.DropTable(
                name: "Post_Microfoundation");

            migrationBuilder.DropTable(
                name: "Axis");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Microfoundation");

            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
