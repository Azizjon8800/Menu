using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Menu.Migrations
{
    /// <inheritdoc />
    public partial class image : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://bravopizza.uz/wp-content/uploads/2020/04/superbravo.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://www.google.com/url?sa=i&url=https%3A%2F%2Fbravopizza.uz%2Fproduct%2Fmargarita%2F&psig=AOvVaw1FOcURrKf_J24OrTKrkVzt&ust=1718971133911000&source=images&cd=vfe&opi=89978449&ved=0CBEQjRxqFwoTCKCQrNCQ6oYDFQAAAAAdAAAAABAH");
        }
    }
}
