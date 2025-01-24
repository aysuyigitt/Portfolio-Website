using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPortfolyo.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePortfolioTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SubTitle",
                table: "Portfolios",
                newName: "Image");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Portfolios",
                newName: "SubTitle");
        }
    }
}
