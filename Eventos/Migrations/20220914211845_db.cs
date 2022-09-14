using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eventos.Migrations
{
    public partial class db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TEvento",
                columns: table => new
                {
                    ID        = table.Column<int>     (type: "int"          , nullable: false).Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioID = table.Column<int>     (type: "int"          , nullable: false),
                    FechaAlta = table.Column<DateTime>(type: "datetime2"    , nullable: false),
                    Latitud   = table.Column<string>  (type: "nvarchar(max)", nullable: true),
                    Longitud  = table.Column<string>  (type: "nvarchar(max)", nullable: true),
                    Origen    = table.Column<string>  (type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TEvento", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TEvento");
        }
    }
}
