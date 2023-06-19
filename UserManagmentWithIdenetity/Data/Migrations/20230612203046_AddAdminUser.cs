using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserManagmentWithIdenetity.Data.Migrations
{
    public partial class AddAdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [security].[Users] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [FirstName], [LastName], [ProfilePicture]) VALUES (N'242b3a88-cc75-4072-9183-f96273a625f0', N'admin', N'ADMIN', N'admin@test.com', N'ADMIN@TEST.COM', 0, N'AQAAAAEAACcQAAAAEJ3HXUDeGAboMloVCpyfy+qFa7XGQ6WUFvKDk99Ysi2Bub/oq406xhs/WnbTRI9KXg==', N'5RNOQNKGRR7K2J5SQGE6DKSYQHOTWXRZ', N'd8fa68bb-2e65-4728-a967-0317a440cf27', NULL, 0, 0, NULL, 1, 0, N'AliAdmin', N'sayedd', NULL)\r\n");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [security].[Users] WHERE Id = '242b3a88-cc75-4072-9183-f96273a625f0'");
        }
    }
}
