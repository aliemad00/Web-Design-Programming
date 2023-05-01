using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace industry4._0.Migrations
{
    public partial class MyMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FeedbackPost",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HEading = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StarRating = table.Column<int>(type: "int", nullable: false),
                    Feedback = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Agree = table.Column<int>(type: "int", nullable: false),
                    Disagree = table.Column<int>(type: "int", nullable: false),
                    CompanyOrganisationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    canIncreaseAgree = table.Column<bool>(type: "bit", nullable: false),
                    canIncreaseDisagree = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedbackPost", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FeedbackPost");
        }
    }
}
