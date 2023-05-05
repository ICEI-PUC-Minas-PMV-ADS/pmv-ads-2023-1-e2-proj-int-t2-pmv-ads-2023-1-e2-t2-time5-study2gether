using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Study2gether.Migrations
{
    public partial class addReactions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    idAnswer = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    idPost = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reactions_Answers_idAnswer",
                        column: x => x.idAnswer,
                        principalTable: "Answers",
                        principalColumn: "idAnswer",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reactions_Post_idPost",
                        column: x => x.idPost,
                        principalTable: "Post",
                        principalColumn: "idPost",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reactions_Users_idUser",
                        column: x => x.idUser,
                        principalTable: "Users",
                        principalColumn: "idUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reactions_idAnswer",
                table: "Reactions",
                column: "idAnswer");

            migrationBuilder.CreateIndex(
                name: "IX_Reactions_idPost",
                table: "Reactions",
                column: "idPost");

            migrationBuilder.CreateIndex(
                name: "IX_Reactions_idUser",
                table: "Reactions",
                column: "idUser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reactions");
        }
    }
}
