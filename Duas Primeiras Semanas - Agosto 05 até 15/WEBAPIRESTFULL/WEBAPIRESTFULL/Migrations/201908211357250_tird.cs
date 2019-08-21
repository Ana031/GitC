namespace WEBAPIRESTFULL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tird : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Locacao", "Ativo", c => c.Boolean());
            AlterColumn("dbo.Locacao", "DatInc", c => c.DateTime());
            AlterColumn("dbo.Locacao", "DatAlt", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Locacao", "DatAlt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Locacao", "DatInc", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Locacao", "Ativo", c => c.Boolean(nullable: false));
        }
    }
}
