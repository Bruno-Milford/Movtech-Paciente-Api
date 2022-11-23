using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalApi.Migrations
{
    /// <inheritdoc />
    public partial class Hospitalization : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hospitalizations",
                columns: table => new
                {
                    codInternacao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codPaciente = table.Column<int>(type: "int", nullable: false),
                    Paciente = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Nascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaePaciente = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    dataEntradaInternacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    horaEntradaInternacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dataSaidaInternacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    horaSaidaInternacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cns = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    ClinicaMedica = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    localizacao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    leito = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    centroCusto = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    hipoteseDiagnostica = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    medico = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    crm = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    diagnostico = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    situacao = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospitalizations", x => x.codInternacao);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hospitalizations");
        }
    }
}
