using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OryxCore.Data.Migrations
{
    public partial class mole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageName",
                table: "Partners",
                newName: "ImageSourceFileName");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Partners",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageContentType",
                table: "Partners",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Partners");

            migrationBuilder.DropColumn(
                name: "ImageContentType",
                table: "Partners");

            migrationBuilder.RenameColumn(
                name: "ImageSourceFileName",
                table: "Partners",
                newName: "ImageName");
        }
    }
}
