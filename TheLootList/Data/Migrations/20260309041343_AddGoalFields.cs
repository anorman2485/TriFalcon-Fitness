using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TriFalcon_Fitness.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddGoalFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "GoalWeight",
                table: "AspNetUsers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "TargetCardioType",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "TargetDistance",
                table: "AspNetUsers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "TargetDuration",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TargetExercise",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "TargetStrengthWeight",
                table: "AspNetUsers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GoalWeight",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TargetCardioType",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TargetDistance",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TargetDuration",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TargetExercise",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TargetStrengthWeight",
                table: "AspNetUsers");
        }
    }
}
