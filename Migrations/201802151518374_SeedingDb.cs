namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedingDb : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into MembershipTypes (Name, SignUpFee, DurationInMonths, DiscountRate) Values ('Free plan', 0, 0, 0)");
            Sql("Insert Into MembershipTypes (Name, SignUpFee, DurationInMonths, DiscountRate) Values ('1 month plan', 30, 1, 10)");
            Sql("Insert Into MembershipTypes (Name, SignUpFee, DurationInMonths, DiscountRate) Values ('3 months plan', 90, 3, 15)");
            Sql("Insert Into MembershipTypes (Name, SignUpFee, DurationInMonths, DiscountRate) Values ('1 year plan', 300, 12, 20)");


            Sql("Insert Into Customers (Name, Birthdate, IsSubscribedToNewsletter, MembershipTypeId) Values ('Adrian', '1993-10-05', 0, 1)");
            Sql("Insert Into Customers (Name, Birthdate, IsSubscribedToNewsletter, MembershipTypeId) Values ('Alexandru', '1992-12-17', 1, 2)");
            Sql("Insert Into Customers (Name, Birthdate, IsSubscribedToNewsletter, MembershipTypeId) Values ('Ion', '1994-01-30', 0, 3)");
        }
        
        public override void Down()
        {
        }
    }
}
