namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'110b23d3-7c04-4d29-a784-6899cb09e5b1', N'guest@vidly.com', 0, N'AHXRQDZ/5YRRSy0dQaiUIZsX7DtpVrF1MAW5Tm3NpUwlUgsv3vYcqlCRe2ZlB7ZGSQ==', N'0fe8a75c-7176-41a1-b146-9f1e14a22346', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'132c6387-d9b2-4854-888d-bca4d47c27e5', N'admin@vidly.com', 0, N'AHVVJLTlHuWfVXLjnvUqxY367B9JyjEJgwH6QKGAotEFPjqxSTgMOvRieDv/Reilfg==', N'bf2b309c-b1fc-470d-823e-278427224ad9', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'94240a51-abd8-4953-a2e7-a2ea76019f38', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'132c6387-d9b2-4854-888d-bca4d47c27e5', N'94240a51-abd8-4953-a2e7-a2ea76019f38')
");
        }
        
        public override void Down()
        {
        }
    }
}

