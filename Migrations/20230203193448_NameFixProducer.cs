﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace imovie.Migrations
{
    /// <inheritdoc />
    public partial class NameFixProducer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Prducers_ProducerId",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prducers",
                table: "Prducers");

            migrationBuilder.RenameTable(
                name: "Prducers",
                newName: "Producers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Producers",
                table: "Producers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Producers_ProducerId",
                table: "Movies",
                column: "ProducerId",
                principalTable: "Producers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Producers_ProducerId",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Producers",
                table: "Producers");

            migrationBuilder.RenameTable(
                name: "Producers",
                newName: "Prducers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prducers",
                table: "Prducers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Prducers_ProducerId",
                table: "Movies",
                column: "ProducerId",
                principalTable: "Prducers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
