using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimplVMService.Migrations
{
    /// <inheritdoc />
    public partial class fingerprint3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "BioID",
                table: "AspNetUsers",
                type: "varbinary(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BioID",
                table: "AspNetUsers");
        }
    }
}
