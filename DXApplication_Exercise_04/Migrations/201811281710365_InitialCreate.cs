/****************************** Ghost.github.io ******************************\
*	Module Name:	201811281710365_InitialCreate.cs
*	Project:		DXApplication_Exercise_04
*	Copyright (C) 2018 Kamal Khayati, All rights reserved.
*	This software may be modified and distributed under the terms of the MIT license.  See LICENSE file for details.
*
*	Written by Kamal Khayati <Kamal1355@gmail.com>,  2018 / 11 / 29   02:24 È.Ù
*	
***********************************************************************************/
namespace DXApplication_Exercise_04.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GroupName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Histors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Long(nullable: false),
                        DatePass = c.String(),
                        GroupName = c.String(),
                        TrueItem = c.Int(nullable: false),
                        FalseItem = c.Int(nullable: false),
                        NoneItem = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GroupId = c.Int(nullable: false),
                        Class = c.String(),
                        QuestionText = c.String(),
                        Case1 = c.String(),
                        Case2 = c.String(),
                        Case3 = c.String(),
                        Case4 = c.String(),
                        Answer = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FName = c.String(),
                        LName = c.String(),
                        Class = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Questions");
            DropTable("dbo.Histors");
            DropTable("dbo.Groups");
        }
    }
}
