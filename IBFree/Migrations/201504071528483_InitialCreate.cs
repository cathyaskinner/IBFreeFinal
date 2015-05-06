namespace IBFree.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BadFoods",
                c => new
                    {
                        NameId = c.Int(nullable: false),
                        Fructan = c.Boolean(nullable: false),
                        Sorbitol = c.Boolean(nullable: false),
                        Mannitol = c.Boolean(nullable: false),
                        Fructose = c.Boolean(nullable: false),
                        GOS = c.Boolean(nullable: false),
                        Lactose = c.Boolean(nullable: false),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.NameId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BadFoods");
        }
    }
}
