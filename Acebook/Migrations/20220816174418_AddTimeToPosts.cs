using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace acebook.Migrations
{
    public partial class AddTimeToPosts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "TimePosted",
                table: "Posts",
                type: "timestamp without time zone",
                nullable: false,
                defaultValueSql: "now()"
                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimePosted",
                table: "Posts");
        }
    }
}
