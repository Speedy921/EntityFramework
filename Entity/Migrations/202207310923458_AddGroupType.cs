namespace Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGroupType : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Songs", "Group_id", "dbo.Groups");
            DropIndex("dbo.Songs", new[] { "Group_id" });
            DropColumn("dbo.Songs", "GroupId");
            RenameColumn(table: "dbo.Songs", name: "Group_id", newName: "Groupid");
            AlterColumn("dbo.Songs", "Groupid", c => c.Int(nullable: false));
            AlterColumn("dbo.Songs", "Groupid", c => c.Int(nullable: false));
            CreateIndex("dbo.Songs", "Groupid");
            AddForeignKey("dbo.Songs", "Groupid", "dbo.Groups", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Songs", "Groupid", "dbo.Groups");
            DropIndex("dbo.Songs", new[] { "Groupid" });
            AlterColumn("dbo.Songs", "Groupid", c => c.Int());
            AlterColumn("dbo.Songs", "Groupid", c => c.String());
            RenameColumn(table: "dbo.Songs", name: "Groupid", newName: "Group_id");
            AddColumn("dbo.Songs", "GroupId", c => c.String());
            CreateIndex("dbo.Songs", "Group_id");
            AddForeignKey("dbo.Songs", "Group_id", "dbo.Groups", "id");
        }
    }
}
