using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Helpdesk_Ticket_Management_System.Migrations
{
    /// <inheritdoc />
    public partial class updateagaindbcontext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_CustomSetup_CustomRoleId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "CustomSetup");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CustomRoleId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CustomRoleId",
                table: "AspNetUsers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomRoleId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CustomSetup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomSetup", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CustomRoleId",
                table: "AspNetUsers",
                column: "CustomRoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_CustomSetup_CustomRoleId",
                table: "AspNetUsers",
                column: "CustomRoleId",
                principalTable: "CustomSetup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
