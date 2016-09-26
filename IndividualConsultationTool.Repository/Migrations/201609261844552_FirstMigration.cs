namespace IndividualConsultationTool.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adress",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Country = c.String(),
                        Region = c.String(),
                        City = c.String(),
                        PostalCode = c.String(),
                        Street = c.String(),
                        CabinetId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cabinet",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        DoctorId = c.Int(nullable: false),
                        AdressId = c.Int(nullable: false),
                        ConsultationsId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Adress", t => t.Id)
                .ForeignKey("dbo.Doctor", t => t.DoctorId, cascadeDelete: true)
                .Index(t => t.Id)
                .Index(t => t.DoctorId);
            
            CreateTable(
                "dbo.Consultation",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ConsultationType = c.Int(nullable: false),
                        PaymentStatus = c.Int(nullable: false),
                        Description = c.String(),
                        Private = c.Boolean(nullable: false),
                        ConsultationDate = c.DateTime(nullable: false),
                        Price = c.Single(nullable: false),
                        CabinetId = c.Int(nullable: false),
                        FactureId = c.Int(nullable: false),
                        ChainId = c.Int(nullable: false),
                        PatientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cabinet", t => t.CabinetId, cascadeDelete: true)
                .ForeignKey("dbo.ConsultationChain", t => t.ChainId, cascadeDelete: true)
                .ForeignKey("dbo.Patient", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.CabinetId)
                .Index(t => t.ChainId)
                .Index(t => t.PatientId);
            
            CreateTable(
                "dbo.ConsultationChain",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        ConsultationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Facture",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        FactureNumber = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                        ToPayInWords = c.String(),
                        PaymentMethod = c.Int(nullable: false),
                        ConsultationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Consultation", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Patient",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        FirstName = c.String(),
                        Surname = c.String(),
                        ContactId = c.Int(nullable: false),
                        ConsultationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contact", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Contact",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                        DoctorId = c.Int(nullable: false),
                        PatientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Doctor", t => t.DoctorId, cascadeDelete: true)
                .Index(t => t.DoctorId);
            
            CreateTable(
                "dbo.Doctor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        Surname = c.String(),
                        Password = c.String(),
                        ContactId = c.Int(nullable: false),
                        CabinetId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cabinet", "DoctorId", "dbo.Doctor");
            DropForeignKey("dbo.Consultation", "PatientId", "dbo.Patient");
            DropForeignKey("dbo.Patient", "Id", "dbo.Contact");
            DropForeignKey("dbo.Contact", "DoctorId", "dbo.Doctor");
            DropForeignKey("dbo.Facture", "Id", "dbo.Consultation");
            DropForeignKey("dbo.Consultation", "ChainId", "dbo.ConsultationChain");
            DropForeignKey("dbo.Consultation", "CabinetId", "dbo.Cabinet");
            DropForeignKey("dbo.Cabinet", "Id", "dbo.Adress");
            DropIndex("dbo.Contact", new[] { "DoctorId" });
            DropIndex("dbo.Patient", new[] { "Id" });
            DropIndex("dbo.Facture", new[] { "Id" });
            DropIndex("dbo.Consultation", new[] { "PatientId" });
            DropIndex("dbo.Consultation", new[] { "ChainId" });
            DropIndex("dbo.Consultation", new[] { "CabinetId" });
            DropIndex("dbo.Cabinet", new[] { "DoctorId" });
            DropIndex("dbo.Cabinet", new[] { "Id" });
            DropTable("dbo.Doctor");
            DropTable("dbo.Contact");
            DropTable("dbo.Patient");
            DropTable("dbo.Facture");
            DropTable("dbo.ConsultationChain");
            DropTable("dbo.Consultation");
            DropTable("dbo.Cabinet");
            DropTable("dbo.Adress");
        }
    }
}
