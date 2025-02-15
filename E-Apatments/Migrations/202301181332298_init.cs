namespace E_Apatments.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ApartmentAllDetas",
                c => new
                    {
                        Location = c.String(nullable: false, maxLength: 128),
                        MultiStoriedBuildingQuantity = c.Int(nullable: false),
                        BuildingNameStarted = c.String(nullable: false),
                        Class1ApartmentsQuantity = c.Int(nullable: false),
                        Class2ApartmentsQuantity = c.Int(nullable: false),
                        Class3ApartmentsQuantity = c.Int(nullable: false),
                        StateApartmentsQuantity = c.Int(nullable: false),
                        ParkingSpaceQuantity = c.Int(nullable: false),
                        ParkingSpaceNameStarted = c.String(nullable: false),
                        AddedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Location);
            
            CreateTable(
                "dbo.ApartmentDetais",
                c => new
                    {
                        ApartmentType = c.String(nullable: false, maxLength: 128),
                        RefundableDeposit = c.Int(nullable: false),
                        FirstMonthRent = c.Int(nullable: false),
                        ParkingSpaceQuantity = c.Int(nullable: false),
                        Updated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ApartmentType);
            
            CreateTable(
                "dbo.CustomRegis",
                c => new
                    {
                        NICPassportNo = c.String(nullable: false, maxLength: 128),
                        CusId = c.Guid(nullable: false),
                        AcountType = c.String(nullable: false),
                        Name = c.String(nullable: false),
                        AlternateAddress = c.String(nullable: false),
                        ContactNumber = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Dependent1 = c.String(),
                        Dependent2 = c.String(),
                        Dependent3 = c.String(),
                        Dependent4 = c.String(),
                        OtherDependent = c.String(),
                        Username = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Status = c.String(),
                        ApartmentType = c.String(),
                        BuildingNo = c.String(),
                        RoomNo = c.String(),
                        RefundorNot = c.String(),
                        RegisterAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.NICPassportNo);
            
            CreateTable(
                "dbo.ExtendDetails",
                c => new
                    {
                        NICorPassport = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false),
                        NumberofDaysExtend = c.Int(nullable: false),
                        FreshLeasePrice = c.Int(nullable: false),
                        ApproveorNot = c.String(),
                    })
                .PrimaryKey(t => t.NICorPassport);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 128),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Username);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.ExtendDetails");
            DropTable("dbo.CustomRegis");
            DropTable("dbo.ApartmentDetais");
            DropTable("dbo.ApartmentAllDetas");
        }
    }
}
