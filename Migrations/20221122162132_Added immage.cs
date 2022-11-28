﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcMovieAuth.Migrations
{
    public partial class Addedimmage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Movie",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "Movie");
        }
    }
}
