using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalApi.Migrations
{
    /// <inheritdoc />
    public partial class Movement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movements",
                columns: table => new
                {
                    codMovimentacao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codPacienteMov = table.Column<int>(type: "int", nullable: false),
                    codSequencia = table.Column<int>(type: "int", nullable: false),
                    nomePacienteMov = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    dataNascimentoMov = table.Column<DateTime>(type: "datetime2", nullable: false),
                    nomeMaePacienteMov = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    dataMovimentacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    horaMovimentacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    motivo = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    localizacao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    leitoMov = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    centroCustoMov = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    medicoMov = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    crmMov = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movements", x => x.codMovimentacao);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movements");
        }
    }
}
