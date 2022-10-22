using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Server.Migrations
{
    public partial class dbTest3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "WaktuPersetujuan",
                table: "T7OrderPenjualan",
                type: "datetimeoffset(7)",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset(7)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Total",
                table: "T7OrderPenjualan",
                type: "money",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<bool>(
                name: "StatusTerealisasi",
                table: "T7OrderPenjualan",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "Satuan_UseSerialNumber",
                table: "T7OrderPenjualan",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<decimal>(
                name: "Satuan_SKURasio",
                table: "T7OrderPenjualan",
                type: "decimal(10,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<byte>(
                name: "Satuan_SKULevel",
                table: "T7OrderPenjualan",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AlterColumn<byte>(
                name: "Satuan_SKUGrup",
                table: "T7OrderPenjualan",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Referensi_WaktuProses",
                table: "T7OrderPenjualan",
                type: "datetimeoffset(7)",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset(7)");

            migrationBuilder.AlterColumn<bool>(
                name: "Persetujuan",
                table: "T7OrderPenjualan",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "Pemutihan",
                table: "T7OrderPenjualan",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<decimal>(
                name: "NilaiKurs",
                table: "T7OrderPenjualan",
                type: "money",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<decimal>(
                name: "Kuantum_Total",
                table: "T7OrderPenjualan",
                type: "money",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<decimal>(
                name: "Kuantum_Jumlah",
                table: "T7OrderPenjualan",
                type: "decimal(10,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Kuantum_HargaBarang_WaktuInsert",
                table: "T7OrderPenjualan",
                type: "datetimeoffset(7)",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset(7)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Kuantum_Harga",
                table: "T7OrderPenjualan",
                type: "money",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<decimal>(
                name: "Kuantum_DiskonNominal",
                table: "T7OrderPenjualan",
                type: "money",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Kuantum_DiskonBarang_WaktuInsert",
                table: "T7OrderPenjualan",
                type: "datetimeoffset(7)",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset(7)");

            migrationBuilder.AlterColumn<long>(
                name: "JumlahRealisasi",
                table: "T7OrderPenjualan",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<decimal>(
                name: "Jumlah",
                table: "T7OrderPenjualan",
                type: "decimal(10,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "HargaBarang_WaktuInsert",
                table: "T7OrderPenjualan",
                type: "datetimeoffset(7)",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset(7)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Harga",
                table: "T7OrderPenjualan",
                type: "money",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<decimal>(
                name: "DiskonNominal",
                table: "T7OrderPenjualan",
                type: "money",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DiskonBarang_WaktuInsert",
                table: "T7OrderPenjualan",
                type: "datetimeoffset(7)",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset(7)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Berat",
                table: "T7OrderPenjualan",
                type: "decimal(10,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<int>(
                name: "Barang_Umur",
                table: "T7OrderPenjualan",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "T6OrderPenjualan",
                columns: table => new
                {
                    IdOrderPenjualan = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Periode = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    WaktuProses = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuInsert = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WaktuUpdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Simpan = table.Column<int>(type: "int", nullable: true),
                    CetakFaktur = table.Column<int>(type: "int", nullable: true),
                    NoTransaksi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IdTransaksi = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IdCompany = table.Column<string>(type: "char(3)", unicode: false, nullable: true),
                    IdLogHeader = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdSupervisor = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdInspector = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCreator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOperator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdValidator = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Application_ApplicationName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Supervisor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Inspector = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Creator = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Operator = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Validator = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    State = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Batal = table.Column<bool>(type: "bit", nullable: true),
                    Catatan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Preview = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Synchronise = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IdJenisTransaksi = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdJenisCustomer = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdAlamatCustomer_KirimBarang = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdAlamatCustomer_KirimDokumen = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdAlamatCustomer_Legal = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdPenyeliaCustomer = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCompany_Pengirim = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdKaryawan_Salesman = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WaktuKirim = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    KodePOCustomer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Attn = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DeliveryBy = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    DiskonDetil = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DiskonNominal = table.Column<decimal>(type: "money", nullable: true),
                    PPNDetil = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PPNNominal = table.Column<decimal>(type: "money", nullable: true),
                    GrandTotal = table.Column<decimal>(type: "money", nullable: true),
                    JenisTransaksi_Jenis = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    JenisCustomer_Jenis = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_Nama = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Customer_Inisial = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_Alamat = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Customer_KodePos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_Kota = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_Email1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_Phone1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_FaxPhone1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_StatusPKP = table.Column<bool>(type: "bit", nullable: true),
                    Customer_NPWP = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_Customer = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    AlamatCustomer_KirimBarang_NamaAlamat = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AlamatCustomer_KirimBarang_Alamat = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AlamatCustomer_KirimBarang_Kota = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AlamatCustomer_KirimBarang_KodePos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AlamatCustomer_KirimBarang_Koordinat = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AlamatCustomer_KirimDokumen_NamaAlamat = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AlamatCustomer_KirimDokumen_Alamat = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AlamatCustomer_KirimDokumen_Kota = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AlamatCustomer_KirimDokumen_KodePos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AlamatCustomer_KirimDokumen_Koordinat = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AlamatCustomer_Legal_NamaAlamat = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AlamatCustomer_Legal_Alamat = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AlamatCustomer_Legal_Kota = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AlamatCustomer_Legal_KodePos = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AlamatCustomer_Legal_KTP = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AlamatCustomer_Legal_NPWP = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PenyeliaCustomer_Nama = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    PenyeliaCustomer_Prefix = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PenyeliaCustomer_JenisKelamin = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PenyeliaCustomer_Jabatan = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PenyeliaCustomer_Phone1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PenyeliaCustomer_Phone2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PenyeliaCustomer_Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Karyawan_Salesman_NamaPanggilan = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Pembayaran_Total = table.Column<decimal>(type: "money", nullable: true),
                    Pembayaran_Keterangan = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Pembayaran_Via = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Pembayaran_StatusTerbayar = table.Column<bool>(type: "bit", nullable: true),
                    PKLink1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PKLink2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T6OrderPenjualan", x => x.IdOrderPenjualan);
                });

            migrationBuilder.CreateIndex(
                name: "IX_T7OrderPenjualan_IdOrderPenjualan",
                table: "T7OrderPenjualan",
                column: "IdOrderPenjualan");

            migrationBuilder.AddForeignKey(
                name: "FK_T7OrderPenjualan_T6OrderPenjualan_IdOrderPenjualan",
                table: "T7OrderPenjualan",
                column: "IdOrderPenjualan",
                principalTable: "T6OrderPenjualan",
                principalColumn: "IdOrderPenjualan");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T7OrderPenjualan_T6OrderPenjualan_IdOrderPenjualan",
                table: "T7OrderPenjualan");

            migrationBuilder.DropTable(
                name: "T6OrderPenjualan");

            migrationBuilder.DropIndex(
                name: "IX_T7OrderPenjualan_IdOrderPenjualan",
                table: "T7OrderPenjualan");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "WaktuPersetujuan",
                table: "T7OrderPenjualan",
                type: "datetimeoffset(7)",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Total",
                table: "T7OrderPenjualan",
                type: "money",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "StatusTerealisasi",
                table: "T7OrderPenjualan",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Satuan_UseSerialNumber",
                table: "T7OrderPenjualan",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Satuan_SKURasio",
                table: "T7OrderPenjualan",
                type: "decimal(10,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "Satuan_SKULevel",
                table: "T7OrderPenjualan",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "Satuan_SKUGrup",
                table: "T7OrderPenjualan",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Referensi_WaktuProses",
                table: "T7OrderPenjualan",
                type: "datetimeoffset(7)",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Persetujuan",
                table: "T7OrderPenjualan",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Pemutihan",
                table: "T7OrderPenjualan",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "NilaiKurs",
                table: "T7OrderPenjualan",
                type: "money",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Kuantum_Total",
                table: "T7OrderPenjualan",
                type: "money",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Kuantum_Jumlah",
                table: "T7OrderPenjualan",
                type: "decimal(10,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Kuantum_HargaBarang_WaktuInsert",
                table: "T7OrderPenjualan",
                type: "datetimeoffset(7)",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Kuantum_Harga",
                table: "T7OrderPenjualan",
                type: "money",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Kuantum_DiskonNominal",
                table: "T7OrderPenjualan",
                type: "money",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Kuantum_DiskonBarang_WaktuInsert",
                table: "T7OrderPenjualan",
                type: "datetimeoffset(7)",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "JumlahRealisasi",
                table: "T7OrderPenjualan",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Jumlah",
                table: "T7OrderPenjualan",
                type: "decimal(10,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "HargaBarang_WaktuInsert",
                table: "T7OrderPenjualan",
                type: "datetimeoffset(7)",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Harga",
                table: "T7OrderPenjualan",
                type: "money",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DiskonNominal",
                table: "T7OrderPenjualan",
                type: "money",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DiskonBarang_WaktuInsert",
                table: "T7OrderPenjualan",
                type: "datetimeoffset(7)",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Berat",
                table: "T7OrderPenjualan",
                type: "decimal(10,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Barang_Umur",
                table: "T7OrderPenjualan",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
