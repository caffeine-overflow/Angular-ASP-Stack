using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App.API.Migrations
{
    public partial class ExtendedUserClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "city",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "country",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "created",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "dateofbirth",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "gender",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "interests",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "lastactive",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "lookingfor",
                table: "Users",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "photos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    url = table.Column<string>(nullable: true),
                    description = table.Column<int>(nullable: false),
                    dateadded = table.Column<DateTime>(nullable: false),
                    ismain = table.Column<bool>(nullable: false),
                    userid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_photos", x => x.id);
                    table.ForeignKey(
                        name: "FK_photos_Users_userid",
                        column: x => x.userid,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_photos_userid",
                table: "photos",
                column: "userid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "photos");

            migrationBuilder.DropColumn(
                name: "city",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "country",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "created",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "dateofbirth",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "gender",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "interests",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "lastactive",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "lookingfor",
                table: "Users");
        }
    }
}
