using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Server.Migrations
{
    public partial class dbTest5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "T1KaryawanIdKaryawan",
                table: "T6OrderPenjualan",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "T0Company",
                columns: table => new
                {
                    IdCompany = table.Column<string>(type: "char(3)", unicode: false, nullable: false),
                    IdDirektur = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true),
                    IsRVisible = table.Column<bool>(type: "bit", nullable: true),
                    IsDVisible = table.Column<bool>(type: "bit", nullable: true),
                    Tag = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IdKota = table.Column<long>(type: "bigint", nullable: true),
                    IdKaryawan_Direktur = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdVendor_KPP = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Prefix = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Nama = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Inisial = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Departemen = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Slogan = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Alamat = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    KodePos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    KotakPos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Website1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Website2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Email1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Email2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Phone1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Phone2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FaxPhone1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FaxPhone2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LogoPath = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    StatusPKP = table.Column<bool>(type: "bit", nullable: true),
                    NPWP = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Keterangan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    PKLink1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PKLink2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T0Company", x => x.IdCompany);
                    table.ForeignKey(
                        name: "FK_T0Company_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T0Company_T1Karyawan_IdDirektur",
                        column: x => x.IdDirektur,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T0Company_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T0Company_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                });

            migrationBuilder.CreateTable(
                name: "T0Form",
                columns: table => new
                {
                    IdForm = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdParent = table.Column<long>(type: "bigint", nullable: false),
                    Kategori = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Form = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Inisial = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Kode = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    NamaTabel = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NamaPK = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Icon = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    CanLihatData = table.Column<bool>(type: "bit", nullable: false),
                    CanBatasLihatData = table.Column<bool>(type: "bit", nullable: false),
                    CanDataBaru = table.Column<bool>(type: "bit", nullable: false),
                    CanBatasDataBaru = table.Column<bool>(type: "bit", nullable: false),
                    CanUbahData = table.Column<bool>(type: "bit", nullable: false),
                    CanHapus = table.Column<bool>(type: "bit", nullable: false),
                    CanBatal = table.Column<bool>(type: "bit", nullable: false),
                    CanCetak = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    CanSupervisi = table.Column<bool>(type: "bit", nullable: false),
                    CanInspeksi = table.Column<bool>(type: "bit", nullable: false),
                    CanLihatRekamanAktivitas = table.Column<bool>(type: "bit", nullable: false),
                    CanValidasi = table.Column<bool>(type: "bit", nullable: false),
                    Setting1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Setting2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Setting3 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Setting4 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Setting5 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Setting6 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Setting21 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Setting22 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Setting23 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Setting24 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Setting25 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Setting26 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Setting31 = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Setting32 = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Setting33 = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Setting34 = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Setting35 = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Setting36 = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Tag = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T0Form", x => x.IdForm);
                    table.ForeignKey(
                        name: "FK_T0Form_T1Karyawan_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T0Form_T1Karyawan_IdOperator",
                        column: x => x.IdOperator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                    table.ForeignKey(
                        name: "FK_T0Form_T1Karyawan_IdValidator",
                        column: x => x.IdValidator,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan");
                });

            migrationBuilder.CreateTable(
                name: "T9Privileges",
                columns: table => new
                {
                    IdKaryawan = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdForm = table.Column<long>(type: "bigint", nullable: false),
                    IdCompany = table.Column<string>(type: "char(3)", unicode: false, nullable: false),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Urutan = table.Column<byte>(type: "tinyint", nullable: true),
                    Grup = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    BatasLihatData = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DataBaru = table.Column<byte>(type: "tinyint", nullable: true),
                    BatasDataBaru = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Cetak = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Supervisi = table.Column<bool>(type: "bit", nullable: true),
                    Inspeksi = table.Column<bool>(type: "bit", nullable: true),
                    LihatRekamanAktivitas = table.Column<bool>(type: "bit", nullable: true),
                    ValidasiPassword = table.Column<bool>(type: "bit", nullable: true),
                    PoinApprove = table.Column<short>(type: "smallint", nullable: true),
                    PoinDecline = table.Column<short>(type: "smallint", nullable: true),
                    Setting1 = table.Column<bool>(type: "bit", nullable: true),
                    Setting2 = table.Column<bool>(type: "bit", nullable: true),
                    Setting3 = table.Column<bool>(type: "bit", nullable: true),
                    Setting4 = table.Column<bool>(type: "bit", nullable: true),
                    Setting5 = table.Column<bool>(type: "bit", nullable: true),
                    Setting6 = table.Column<bool>(type: "bit", nullable: true),
                    Setting21 = table.Column<byte>(type: "tinyint", nullable: true),
                    Setting22 = table.Column<byte>(type: "tinyint", nullable: true),
                    Setting23 = table.Column<byte>(type: "tinyint", nullable: true),
                    Setting24 = table.Column<byte>(type: "tinyint", nullable: true),
                    Setting25 = table.Column<byte>(type: "tinyint", nullable: true),
                    Setting26 = table.Column<byte>(type: "tinyint", nullable: true),
                    Setting31 = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Setting32 = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Setting33 = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Setting34 = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Setting35 = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Setting36 = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T9Privileges", x => new { x.IdKaryawan, x.IdForm, x.IdCompany });
                    table.ForeignKey(
                        name: "FK_T9Privileges_T0Company_IdCompany",
                        column: x => x.IdCompany,
                        principalTable: "T0Company",
                        principalColumn: "IdCompany",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T9Privileges_T0Form_IdForm",
                        column: x => x.IdForm,
                        principalTable: "T0Form",
                        principalColumn: "IdForm",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T9Privileges_T1Karyawan_IdKaryawan",
                        column: x => x.IdKaryawan,
                        principalTable: "T1Karyawan",
                        principalColumn: "IdKaryawan",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_T7OrderPenjualan_IdOperator",
                table: "T7OrderPenjualan",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T6OrderPenjualan_T1KaryawanIdKaryawan",
                table: "T6OrderPenjualan",
                column: "T1KaryawanIdKaryawan");

            migrationBuilder.CreateIndex(
                name: "IX_T0Company_IdCreator",
                table: "T0Company",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T0Company_IdDirektur",
                table: "T0Company",
                column: "IdDirektur");

            migrationBuilder.CreateIndex(
                name: "IX_T0Company_IdOperator",
                table: "T0Company",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T0Company_IdValidator",
                table: "T0Company",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T0Form_IdCreator",
                table: "T0Form",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_T0Form_IdOperator",
                table: "T0Form",
                column: "IdOperator");

            migrationBuilder.CreateIndex(
                name: "IX_T0Form_IdValidator",
                table: "T0Form",
                column: "IdValidator");

            migrationBuilder.CreateIndex(
                name: "IX_T9Privileges_IdCompany",
                table: "T9Privileges",
                column: "IdCompany");

            migrationBuilder.CreateIndex(
                name: "IX_T9Privileges_IdForm",
                table: "T9Privileges",
                column: "IdForm");

            migrationBuilder.AddForeignKey(
                name: "FK_T6OrderPenjualan_T1Karyawan_T1KaryawanIdKaryawan",
                table: "T6OrderPenjualan",
                column: "T1KaryawanIdKaryawan",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");

            migrationBuilder.AddForeignKey(
                name: "FK_T7OrderPenjualan_T1Karyawan_IdOperator",
                table: "T7OrderPenjualan",
                column: "IdOperator",
                principalTable: "T1Karyawan",
                principalColumn: "IdKaryawan");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T6OrderPenjualan_T1Karyawan_T1KaryawanIdKaryawan",
                table: "T6OrderPenjualan");

            migrationBuilder.DropForeignKey(
                name: "FK_T7OrderPenjualan_T1Karyawan_IdOperator",
                table: "T7OrderPenjualan");

            migrationBuilder.DropTable(
                name: "T9Privileges");

            migrationBuilder.DropTable(
                name: "T0Company");

            migrationBuilder.DropTable(
                name: "T0Form");

            migrationBuilder.DropIndex(
                name: "IX_T7OrderPenjualan_IdOperator",
                table: "T7OrderPenjualan");

            migrationBuilder.DropIndex(
                name: "IX_T6OrderPenjualan_T1KaryawanIdKaryawan",
                table: "T6OrderPenjualan");

            migrationBuilder.DropColumn(
                name: "T1KaryawanIdKaryawan",
                table: "T6OrderPenjualan");
        }
    }
}
