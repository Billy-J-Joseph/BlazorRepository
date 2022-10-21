using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Server.Migrations
{
    public partial class dbTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Alamat",
                table: "T1Karyawan",
                newName: "KomunikasiLain");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "WaktuUpdate",
                table: "T1Karyawan",
                type: "datetimeoffset(7)",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "WaktuInsert",
                table: "T1Karyawan",
                type: "datetimeoffset(7)",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Synchronise",
                table: "T1Karyawan",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NamaPanggilan",
                table: "T1Karyawan",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NamaLengkap",
                table: "T1Karyawan",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "JenisKelamin",
                table: "T1Karyawan",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AlamatAsal",
                table: "T1Karyawan",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AlamatKerabat",
                table: "T1Karyawan",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AlamatTinggal",
                table: "T1Karyawan",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BPJS",
                table: "T1Karyawan",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CardIdNumber",
                table: "T1Karyawan",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CardIdPin",
                table: "T1Karyawan",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DokumenJaminan",
                table: "T1Karyawan",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "T1Karyawan",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "FingerPrint0",
                table: "T1Karyawan",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "FingerPrint1",
                table: "T1Karyawan",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "FingerPrint2",
                table: "T1Karyawan",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "FingerPrint3",
                table: "T1Karyawan",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "FingerPrint4",
                table: "T1Karyawan",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "FingerPrint5",
                table: "T1Karyawan",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "FingerPrint6",
                table: "T1Karyawan",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "FingerPrint7",
                table: "T1Karyawan",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "FingerPrint8",
                table: "T1Karyawan",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "FingerPrint9",
                table: "T1Karyawan",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HubunganKerabat",
                table: "T1Karyawan",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "IdKecamatanAsal",
                table: "T1Karyawan",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "IdKecamatanTinggal",
                table: "T1Karyawan",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "IdKelurahanAsal",
                table: "T1Karyawan",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "IdKelurahanTinggal",
                table: "T1Karyawan",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "IdKotaAsal",
                table: "T1Karyawan",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "IdKotaTinggal",
                table: "T1Karyawan",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "Keterangan",
                table: "T1Karyawan",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KodePosAsal",
                table: "T1Karyawan",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KodePosTinggal",
                table: "T1Karyawan",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NIK",
                table: "T1Karyawan",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NPWP",
                table: "T1Karyawan",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NamaKerabat",
                table: "T1Karyawan",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomorIdentitas1",
                table: "T1Karyawan",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomorIdentitas2",
                table: "T1Karyawan",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PKLink1",
                table: "T1Karyawan",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PKLink2",
                table: "T1Karyawan",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordHint",
                table: "T1Karyawan",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rekening",
                table: "T1Karyawan",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Seluler1",
                table: "T1Karyawan",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Seluler2",
                table: "T1Karyawan",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "StatusLogin",
                table: "T1Karyawan",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "TanggalBerhenti",
                table: "T1Karyawan",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "TanggalLahir",
                table: "T1Karyawan",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "TanggalRekrut",
                table: "T1Karyawan",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Telepon",
                table: "T1Karyawan",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TeleponKerabat",
                table: "T1Karyawan",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TempatLahir",
                table: "T1Karyawan",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "T1Karyawan",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "UserPassword",
                table: "T1Karyawan",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "WaktuUpdate",
                table: "T0Jabatan",
                type: "datetimeoffset(7)",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "WaktuInsert",
                table: "T0Jabatan",
                type: "datetimeoffset(7)",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Synchronise",
                table: "T0Jabatan",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Jabatan",
                table: "T0Jabatan",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "IdKategoriJadwalKerjaKaryawan",
                table: "T0Jabatan",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Kode",
                table: "T0Jabatan",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PKLink1",
                table: "T0Jabatan",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PKLink2",
                table: "T0Jabatan",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "WaktuUpdate",
                table: "T0DivisiPerusahaan",
                type: "datetimeoffset(7)",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "WaktuInsert",
                table: "T0DivisiPerusahaan",
                type: "datetimeoffset(7)",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Synchronise",
                table: "T0DivisiPerusahaan",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Divisi",
                table: "T0DivisiPerusahaan",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlamatAsal",
                table: "T1Karyawan");

            migrationBuilder.DropColumn(
                name: "AlamatKerabat",
                table: "T1Karyawan");

            migrationBuilder.DropColumn(
                name: "AlamatTinggal",
                table: "T1Karyawan");

            migrationBuilder.DropColumn(
                name: "BPJS",
                table: "T1Karyawan");

            migrationBuilder.DropColumn(
                name: "CardIdNumber",
                table: "T1Karyawan");

            migrationBuilder.DropColumn(
                name: "CardIdPin",
                table: "T1Karyawan");

            migrationBuilder.DropColumn(
                name: "DokumenJaminan",
                table: "T1Karyawan");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "T1Karyawan");

            migrationBuilder.DropColumn(
                name: "FingerPrint0",
                table: "T1Karyawan");

            migrationBuilder.DropColumn(
                name: "FingerPrint1",
                table: "T1Karyawan");

            migrationBuilder.DropColumn(
                name: "FingerPrint2",
                table: "T1Karyawan");

            migrationBuilder.DropColumn(
                name: "FingerPrint3",
                table: "T1Karyawan");

            migrationBuilder.DropColumn(
                name: "FingerPrint4",
                table: "T1Karyawan");

            migrationBuilder.DropColumn(
                name: "FingerPrint5",
                table: "T1Karyawan");

            migrationBuilder.DropColumn(
                name: "FingerPrint6",
                table: "T1Karyawan");

            migrationBuilder.DropColumn(
                name: "FingerPrint7",
                table: "T1Karyawan");

            migrationBuilder.DropColumn(
                name: "FingerPrint8",
                table: "T1Karyawan");

            migrationBuilder.DropColumn(
                name: "FingerPrint9",
                table: "T1Karyawan");

            migrationBuilder.DropColumn(
                name: "HubunganKerabat",
                table: "T1Karyawan");

            migrationBuilder.DropColumn(
                name: "IdKecamatanAsal",
                table: "T1Karyawan");

            migrationBuilder.DropColumn(
                name: "IdKecamatanTinggal",
                table: "T1Karyawan");

            migrationBuilder.DropColumn(
                name: "IdKelurahanAsal",
                table: "T1Karyawan");

            migrationBuilder.DropColumn(
                name: "IdKelurahanTinggal",
                table: "T1Karyawan");

            migrationBuilder.DropColumn(
                name: "IdKotaAsal",
                table: "T1Karyawan");

            migrationBuilder.DropColumn(
                name: "IdKotaTinggal",
                table: "T1Karyawan");

            migrationBuilder.DropColumn(
                name: "Keterangan",
                table: "T1Karyawan");

            migrationBuilder.DropColumn(
                name: "KodePosAsal",
                table: "T1Karyawan");

            migrationBuilder.DropColumn(
                name: "KodePosTinggal",
                table: "T1Karyawan");

            migrationBuilder.DropColumn(
                name: "NIK",
                table: "T1Karyawan");

            migrationBuilder.DropColumn(
                name: "NPWP",
                table: "T1Karyawan");

            migrationBuilder.DropColumn(
                name: "NamaKerabat",
                table: "T1Karyawan");

            migrationBuilder.DropColumn(
                name: "NomorIdentitas1",
                table: "T1Karyawan");

            migrationBuilder.DropColumn(
                name: "NomorIdentitas2",
                table: "T1Karyawan");

            migrationBuilder.DropColumn(
                name: "PKLink1",
                table: "T1Karyawan");

            migrationBuilder.DropColumn(
                name: "PKLink2",
                table: "T1Karyawan");

            migrationBuilder.DropColumn(
                name: "PasswordHint",
                table: "T1Karyawan");

            migrationBuilder.DropColumn(
                name: "Rekening",
                table: "T1Karyawan");

            migrationBuilder.DropColumn(
                name: "Seluler1",
                table: "T1Karyawan");

            migrationBuilder.DropColumn(
                name: "Seluler2",
                table: "T1Karyawan");

            migrationBuilder.DropColumn(
                name: "StatusLogin",
                table: "T1Karyawan");

            migrationBuilder.DropColumn(
                name: "TanggalBerhenti",
                table: "T1Karyawan");

            migrationBuilder.DropColumn(
                name: "TanggalLahir",
                table: "T1Karyawan");

            migrationBuilder.DropColumn(
                name: "TanggalRekrut",
                table: "T1Karyawan");

            migrationBuilder.DropColumn(
                name: "Telepon",
                table: "T1Karyawan");

            migrationBuilder.DropColumn(
                name: "TeleponKerabat",
                table: "T1Karyawan");

            migrationBuilder.DropColumn(
                name: "TempatLahir",
                table: "T1Karyawan");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "T1Karyawan");

            migrationBuilder.DropColumn(
                name: "UserPassword",
                table: "T1Karyawan");

            migrationBuilder.DropColumn(
                name: "IdKategoriJadwalKerjaKaryawan",
                table: "T0Jabatan");

            migrationBuilder.DropColumn(
                name: "Kode",
                table: "T0Jabatan");

            migrationBuilder.DropColumn(
                name: "PKLink1",
                table: "T0Jabatan");

            migrationBuilder.DropColumn(
                name: "PKLink2",
                table: "T0Jabatan");

            migrationBuilder.RenameColumn(
                name: "KomunikasiLain",
                table: "T1Karyawan",
                newName: "Alamat");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "WaktuUpdate",
                table: "T1Karyawan",
                type: "datetimeoffset",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "WaktuInsert",
                table: "T1Karyawan",
                type: "datetimeoffset",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Synchronise",
                table: "T1Karyawan",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NamaPanggilan",
                table: "T1Karyawan",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NamaLengkap",
                table: "T1Karyawan",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "JenisKelamin",
                table: "T1Karyawan",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "WaktuUpdate",
                table: "T0Jabatan",
                type: "datetimeoffset",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "WaktuInsert",
                table: "T0Jabatan",
                type: "datetimeoffset",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Synchronise",
                table: "T0Jabatan",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Jabatan",
                table: "T0Jabatan",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "WaktuUpdate",
                table: "T0DivisiPerusahaan",
                type: "datetimeoffset",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "WaktuInsert",
                table: "T0DivisiPerusahaan",
                type: "datetimeoffset",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Synchronise",
                table: "T0DivisiPerusahaan",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Divisi",
                table: "T0DivisiPerusahaan",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);
        }
    }
}
