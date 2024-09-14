﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeBlend.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class inital111 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Cashes",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATE");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Cashes",
                type: "DATE",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");
        }
    }
}
