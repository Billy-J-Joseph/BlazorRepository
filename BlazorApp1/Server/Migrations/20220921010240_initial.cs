using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Server.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T0DivisiPerusahaan",
                columns: table => new
                {
                    IdDivisiPerusahaan = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true),
                    IsRVisible = table.Column<bool>(type: "bit", nullable: true),
                    IsDVisible = table.Column<bool>(type: "bit", nullable: true),
                    Tag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Synchronise = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Divisi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Keterangan = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T0DivisiPerusahaan", x => x.IdDivisiPerusahaan);
                });

            migrationBuilder.CreateTable(
                name: "T0Jabatan",
                columns: table => new
                {
                    IdJabatan = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true),
                    IsRVisible = table.Column<bool>(type: "bit", nullable: true),
                    IsDVisible = table.Column<bool>(type: "bit", nullable: true),
                    Tag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Synchronise = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Jabatan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Grade = table.Column<int>(type: "int", nullable: false),
                    Keterangan = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T0Jabatan", x => x.IdJabatan);
                });

            migrationBuilder.CreateTable(
                name: "T1Karyawan",
                columns: table => new
                {
                    IdKaryawan = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdJabatan = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdDivisiPerusahaan = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true),
                    IsRVisible = table.Column<bool>(type: "bit", nullable: true),
                    IsDVisible = table.Column<bool>(type: "bit", nullable: true),
                    Tag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Synchronise = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NamaLengkap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NamaPanggilan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alamat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JenisKelamin = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T1Karyawan", x => x.IdKaryawan);
                    table.ForeignKey(
                        name: "FK_T1Karyawan_T0DivisiPerusahaan_IdDivisiPerusahaan",
                        column: x => x.IdDivisiPerusahaan,
                        principalTable: "T0DivisiPerusahaan",
                        principalColumn: "IdDivisiPerusahaan");
                    table.ForeignKey(
                        name: "FK_T1Karyawan_T0Jabatan_IdJabatan",
                        column: x => x.IdJabatan,
                        principalTable: "T0Jabatan",
                        principalColumn: "IdJabatan");
                });

            migrationBuilder.CreateIndex(
                name: "IX_T1Karyawan_IdDivisiPerusahaan",
                table: "T1Karyawan",
                column: "IdDivisiPerusahaan");

            migrationBuilder.CreateIndex(
                name: "IX_T1Karyawan_IdJabatan",
                table: "T1Karyawan",
                column: "IdJabatan");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T1Karyawan");

            migrationBuilder.DropTable(
                name: "T0DivisiPerusahaan");

            migrationBuilder.DropTable(
                name: "T0Jabatan");
        }
    }
}
