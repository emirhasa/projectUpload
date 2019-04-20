using Microsoft.EntityFrameworkCore.Migrations;

namespace Seminarski_fitness_centar_IB130116.Migrations
{
    public partial class m4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdminLevel",
                table: "Users");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdminLevel",
                table: "Users",
                nullable: false,
                defaultValue: 0);
        }
    }
}
