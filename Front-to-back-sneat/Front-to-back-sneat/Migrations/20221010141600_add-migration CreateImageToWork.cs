using Microsoft.EntityFrameworkCore.Migrations;

namespace Front_to_back_sneat.Migrations
{
    public partial class addmigrationCreateImageToWork : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Works",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Works");
        }
    }
}
