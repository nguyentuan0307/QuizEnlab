using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuizEnlab.Migrations
{
    /// <inheritdoc />
    public partial class DatabaseInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Quiz",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quiz", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Answer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answer_Question_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserAnswer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuizId = table.Column<int>(type: "int", nullable: false),
                    AnswerIdSelected = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAnswer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserAnswer_Answer_AnswerIdSelected",
                        column: x => x.AnswerIdSelected,
                        principalTable: "Answer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserAnswer_Quiz_QuizId",
                        column: x => x.QuizId,
                        principalTable: "Quiz",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "Id", "Text" },
                values: new object[,]
                {
                    { 1, "Câu hỏi 1" },
                    { 2, "Câu hỏi 2" },
                    { 3, "Câu hỏi 3" },
                    { 4, "Câu hỏi 4" },
                    { 5, "Câu hỏi 5" },
                    { 6, "Câu hỏi 6" },
                    { 7, "Câu hỏi 7" },
                    { 8, "Câu hỏi 8" },
                    { 9, "Câu hỏi 9" },
                    { 10, "Câu hỏi 10" }
                });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "Id", "IsCorrect", "QuestionId", "Text" },
                values: new object[,]
                {
                    { 1, true, 1, "Đáp án 1" },
                    { 2, false, 1, "Đáp án 2" },
                    { 3, false, 1, "Đáp án 3" },
                    { 4, false, 1, "Đáp án 4" },
                    { 5, true, 2, "Đáp án 1" },
                    { 6, false, 2, "Đáp án 2" },
                    { 7, false, 2, "Đáp án 3" },
                    { 8, false, 2, "Đáp án 4" },
                    { 9, true, 3, "Đáp án 1" },
                    { 10, false, 3, "Đáp án 2" },
                    { 11, false, 3, "Đáp án 3" },
                    { 12, false, 3, "Đáp án 4" },
                    { 13, true, 4, "Đáp án 1" },
                    { 14, false, 4, "Đáp án 2" },
                    { 15, false, 4, "Đáp án 3" },
                    { 16, false, 4, "Đáp án 4" },
                    { 17, true, 5, "Đáp án 1" },
                    { 18, false, 5, "Đáp án 2" },
                    { 19, false, 5, "Đáp án 3" },
                    { 20, false, 5, "Đáp án 4" },
                    { 21, true, 6, "Đáp án 1" },
                    { 22, false, 6, "Đáp án 2" },
                    { 23, false, 6, "Đáp án 3" },
                    { 24, false, 6, "Đáp án 4" },
                    { 25, true, 7, "Đáp án 1" },
                    { 26, false, 7, "Đáp án 2" },
                    { 27, false, 7, "Đáp án 3" },
                    { 28, false, 7, "Đáp án 4" },
                    { 29, true, 8, "Đáp án 1" },
                    { 30, false, 8, "Đáp án 2" },
                    { 31, false, 8, "Đáp án 3" },
                    { 32, false, 8, "Đáp án 4" },
                    { 33, true, 9, "Đáp án 1" },
                    { 34, false, 9, "Đáp án 2" },
                    { 35, false, 9, "Đáp án 3" },
                    { 36, false, 9, "Đáp án 4" },
                    { 37, true, 10, "Đáp án 1" },
                    { 38, false, 10, "Đáp án 2" },
                    { 39, false, 10, "Đáp án 3" },
                    { 40, false, 10, "Đáp án 4" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answer_QuestionId",
                table: "Answer",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAnswer_AnswerIdSelected",
                table: "UserAnswer",
                column: "AnswerIdSelected");

            migrationBuilder.CreateIndex(
                name: "IX_UserAnswer_QuizId",
                table: "UserAnswer",
                column: "QuizId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserAnswer");

            migrationBuilder.DropTable(
                name: "Answer");

            migrationBuilder.DropTable(
                name: "Quiz");

            migrationBuilder.DropTable(
                name: "Question");
        }
    }
}
