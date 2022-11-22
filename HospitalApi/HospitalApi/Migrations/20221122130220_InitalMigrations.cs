using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalApi.Migrations
{
    /// <inheritdoc />
    public partial class InitalMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    codPaciente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomePaciente = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    sexoPaciente = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    dataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    nomeMaePaciente = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    cpfPaciente = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    rgPaciente = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    cns = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    corPaciente = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    nacionalidade = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    naturalidade = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    grauInstrucaoPaciente = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    profissaoPaciente = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    responsavelPaciente = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    cep = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    endereco = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    bairro = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    cidade = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    uf = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    telefone = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    celular = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    contato = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    telefoneContato = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    observacao = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.codPaciente);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
