namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers]
                ([Id]
                ,[Email]
                ,[EmailConfirmed]
                ,[PasswordHash]
                ,[SecurityStamp]
                ,[PhoneNumber]
                ,[PhoneNumberConfirmed]
                ,[TwoFactorEnabled]
                ,[LockoutEndDateUtc]
                ,[LockoutEnabled]
                ,[AccessFailedCount]
                ,[UserName])
            VALUES
                ('442b54f0-f479-4ca6-a1f8-19ae640fdf9f'
                ,'admin@example.com'
                ,0
                ,'ANwxxrW3vU0WPWvCRaturSC64dCh/BLaP0P6QiivU+PZbSZoBWHmdNZ5CCAL/tACwA=='
                ,'3069576d-1f0d-4ab3-ad40-2a7ec1e00e30'
                ,''
                ,0
                ,0
                ,''
                ,1
                ,0
                ,'admin@example.com')");

            Sql(@"INSERT INTO [dbo].[AspNetUsers]
                ([Id]
                ,[Email]
                ,[EmailConfirmed]
                ,[PasswordHash]
                ,[SecurityStamp]
                ,[PhoneNumber]
                ,[PhoneNumberConfirmed]
                ,[TwoFactorEnabled]
                ,[LockoutEndDateUtc]
                ,[LockoutEnabled]
                ,[AccessFailedCount]
                ,[UserName])
            VALUES
                ('647d28eb-93ca-4fa3-92ff-6401091f5d7d'
                ,'guest@example.com'
                ,0
                ,'AK4wHAHrYxL3dQgjlciN5gFzXHDsGpyMM2vhNt2yuO5CKr8lakwnKtjEv99FOP6EWA=='
                ,'472243ff-9184-4564-bf72-af52e6ed3242'
                ,''
                ,0
                ,0
                ,''
                ,1
                ,0
                ,'guest@example.com')");
            

            Sql(@"INSERT INTO [dbo].[AspNetRoles]
                ([Id]
                ,[Name])
            VALUES  
                ('c1d2eccc-1d76-4234-b4ea-8172ad2a9fde'
                ,'CanManageMovies')");

            Sql(@"INSERT INTO [dbo].[AspNetUserRoles]
                ([UserId]
                ,[RoleId])
            VALUES
                ('442b54f0-f479-4ca6-a1f8-19ae640fdf9f'
                ,'c1d2eccc-1d76-4234-b4ea-8172ad2a9fde')");

        }
        
        public override void Down()
        {
        }
    }
}
