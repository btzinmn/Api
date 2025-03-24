using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiSegundoDS_bt.Migrations
{
    /// <inheritdoc />
    public partial class etec : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aluno",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rma = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mae = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    matricula = table.Column<int>(type: "int", nullable: true),
                    datanascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    escolaid = table.Column<int>(type: "int", nullable: false),
                    professorid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aluno", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "escola",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    professorid = table.Column<int>(type: "int", nullable: false),
                    CNPJ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    alunoid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_escola", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "professor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rma = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mae = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    componentecurricular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    escolaid = table.Column<int>(type: "int", nullable: false),
                    Alunoid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_professor", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aluno");

            migrationBuilder.DropTable(
                name: "escola");

            migrationBuilder.DropTable(
                name: "professor");
        }
    }
}
