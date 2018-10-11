using Microsoft.EntityFrameworkCore.Migrations;

namespace EricABP.Migrations
{
    public partial class Pb2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumbers_Persons_PersonId",
                table: "PhoneNumbers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PhoneNumbers",
                table: "PhoneNumbers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Persons",
                table: "Persons");

            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.RenameTable(
                name: "PhoneNumbers",
                newName: "PhoneNumber",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Persons",
                newName: "Person",
                newSchema: "dbo");

            migrationBuilder.RenameIndex(
                name: "IX_PhoneNumbers_PersonId",
                schema: "dbo",
                table: "PhoneNumber",
                newName: "IX_PhoneNumber_PersonId");

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "AbpLanguageTexts",
                maxLength: 67108864,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 500);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhoneNumber",
                schema: "dbo",
                table: "PhoneNumber",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Person",
                schema: "dbo",
                table: "Person",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumber_Person_PersonId",
                schema: "dbo",
                table: "PhoneNumber",
                column: "PersonId",
                principalSchema: "dbo",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumber_Person_PersonId",
                schema: "dbo",
                table: "PhoneNumber");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PhoneNumber",
                schema: "dbo",
                table: "PhoneNumber");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Person",
                schema: "dbo",
                table: "Person");

            migrationBuilder.RenameTable(
                name: "PhoneNumber",
                schema: "dbo",
                newName: "PhoneNumbers");

            migrationBuilder.RenameTable(
                name: "Person",
                schema: "dbo",
                newName: "Persons");

            migrationBuilder.RenameIndex(
                name: "IX_PhoneNumber_PersonId",
                table: "PhoneNumbers",
                newName: "IX_PhoneNumbers_PersonId");

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "AbpLanguageTexts",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 67108864);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhoneNumbers",
                table: "PhoneNumbers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Persons",
                table: "Persons",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumbers_Persons_PersonId",
                table: "PhoneNumbers",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
