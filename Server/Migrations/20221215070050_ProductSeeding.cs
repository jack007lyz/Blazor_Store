using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace J7zECommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class ProductSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "written by Terry Brooks and published on April 21, 1999", "https://upload.wikimedia.org/wikipedia/en/c/ca/Phantommenacenovel_obiwan.jpg", 9.99m, "Star Wars Episode I: The Phantom Menace" },
                    { 2, "The biggest addition to the story is the fact that the Lars family are introduced and have their own subplot leading up to when they appear in the movie.", "https://upload.wikimedia.org/wikipedia/en/5/5d/Attackoftheclones_novel.jpg", 8.99m, "Star Wars: Episode II – Attack of the Clones" },
                    { 3, "The lightsaber fight between Anakin, Obi-Wan and Count Dooku is portrayed in far greater detail than in the film.", "https://upload.wikimedia.org/wikipedia/en/8/88/RevengeOfTheSithNovel.jpg", 7.99m, "Star Wars: Revenge of the Sith" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
