using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace HotelABC.Migrations
{
    /// <inheritdoc />
    public partial class example : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    PkEmpleado = table.Column<string>(type: "varchar(255)", nullable: false),
                    Rfc = table.Column<string>(type: "longtext", nullable: false),
                    Nombre = table.Column<string>(type: "longtext", nullable: false),
                    ApellidoMat = table.Column<string>(type: "longtext", nullable: false),
                    ApellidoPat = table.Column<string>(type: "longtext", nullable: false),
                    Telefono = table.Column<int>(type: "int", nullable: false),
                    Correo = table.Column<string>(type: "longtext", nullable: false),
                    Password = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.PkEmpleado);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Huespedes",
                columns: table => new
                {
                    PKid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false),
                    ApellidoPat = table.Column<string>(type: "longtext", nullable: false),
                    ApellidoMat = table.Column<string>(type: "longtext", nullable: false),
                    Correo = table.Column<string>(type: "longtext", nullable: false),
                    Telefono = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Huespedes", x => x.PKid);
                })
                .Annotation("MySQL:Charset", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "Huespedes");
        }
    }
}
