using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogSite.DataAccess.Migrations
{
    public partial class add_column_comment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BlogPoint",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BlogPoint",
                table: "Comments");
        }
    }
}
