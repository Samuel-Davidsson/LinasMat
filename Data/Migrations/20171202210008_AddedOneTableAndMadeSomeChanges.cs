using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class AddedOneTableAndMadeSomeChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FoodType",
                table: "Ingredient");

            migrationBuilder.AddColumn<int>(
                name: "RecipeID",
                table: "Review",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FoodType",
                table: "Recipe",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Review_RecipeID",
                table: "Review",
                column: "RecipeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Recipe_RecipeID",
                table: "Review",
                column: "RecipeID",
                principalTable: "Recipe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Review_Recipe_RecipeID",
                table: "Review");

            migrationBuilder.DropIndex(
                name: "IX_Review_RecipeID",
                table: "Review");

            migrationBuilder.DropColumn(
                name: "RecipeID",
                table: "Review");

            migrationBuilder.DropColumn(
                name: "FoodType",
                table: "Recipe");

            migrationBuilder.AddColumn<int>(
                name: "FoodType",
                table: "Ingredient",
                nullable: false,
                defaultValue: 0);
        }
    }
}
