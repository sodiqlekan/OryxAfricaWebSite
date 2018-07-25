using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OryxCore.Data.Migrations
{
    public partial class mold : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Partners");

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Partners",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Partners");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Partners",
                nullable: true);
        }
    }
}
