using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppBlogCore.Data.Migrations
{
    /// <inheritdoc />
    public partial class ProcedimientospCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedmiento = @"CREATE PROCEDURE spGetCategorias AS BEGIN SELECT * FROM Categorias END";

            migrationBuilder.Sql(procedmiento);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string procedmiento = @"DROP PROCEDURE spGetCategorias";

            migrationBuilder.Sql(procedmiento);
        }
    }
}
