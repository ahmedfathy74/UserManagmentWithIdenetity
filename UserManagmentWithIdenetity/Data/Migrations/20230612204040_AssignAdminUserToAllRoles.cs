using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserManagmentWithIdenetity.Data.Migrations
{
    public partial class AssignAdminUserToAllRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO  [security].[UserRoles](UserId,RoleId) SELECT '242b3a88-cc75-4072-9183-f96273a625f0',Id FROM [security].[Roles]");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [security].[UserRoles] WHERE UserId='242b3a88-cc75-4072-9183-f96273a625f0'");
        }
    }
}
