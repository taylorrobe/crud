using Microsoft.EntityFrameworkCore.Migrations;

namespace Crud_u_like.Migrations
{
    public partial class addStaticData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                SET IDENTITY_INSERT [dbo].[CaseStatus] ON
                INSERT INTO [dbo].[CaseStatus]
                (	[Id],
                    [Name]
                )
                VALUES
                (1, N'Active'),
                (2, N'Delayed'),
                (3, N'Complete')
                SET IDENTITY_INSERT [dbo].[CaseStatus] OFF

                SET IDENTITY_INSERT [dbo].[CaseType] ON
                INSERT INTO [dbo].[CaseType]
                (	[Id],
                    [Name]
                )
                VALUES
                (1, N'Remortgage'),
                (2, N'Purchase')
                SET IDENTITY_INSERT [dbo].[CaseType] OFF                
                ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
