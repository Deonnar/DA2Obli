namespace Tresana.Data.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class abc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Providers",
                c => new
                    {
                        ProviderId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        RUT = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProviderId);
            
            CreateTable(
                "dbo.ProviderFields",
                c => new
                    {
                        ProviderFieldId = c.Int(nullable: false, identity: true),
                        FieldName = c.String(),
                        Provider_ProviderId = c.Int(),
                    })
                .PrimaryKey(t => t.ProviderFieldId)
                .ForeignKey("dbo.Providers", t => t.Provider_ProviderId)
                .Index(t => t.Provider_ProviderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProviderFields", "Provider_ProviderId", "dbo.Providers");
            DropIndex("dbo.ProviderFields", new[] { "Provider_ProviderId" });
            DropTable("dbo.ProviderFields");
            DropTable("dbo.Providers");
        }
    }
}
