using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizEnlab.Migrations
{
    /// <inheritdoc />
    public partial class AddScoreForQuiz : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserAnswersCount",
                table: "Quiz",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserAnswersCountCorrect",
                table: "Quiz",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserAnswersCount",
                table: "Quiz");

            migrationBuilder.DropColumn(
                name: "UserAnswersCountCorrect",
                table: "Quiz");
        }
    }
}
