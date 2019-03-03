using Microsoft.EntityFrameworkCore.Migrations;

namespace FCBarcelonaStore.Migrations
{
    public partial class FeedbackModelChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Message",
                table: "Feedbacks",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Message",
                table: "Feedbacks");
        }
    }
}
