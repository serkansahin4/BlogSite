using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogSite.DataAccess.Migrations
{
    public partial class notification_add_color_property : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Notifications",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Notifications");
        }
    }
}
