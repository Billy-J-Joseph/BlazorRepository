﻿// <auto-generated />
using System;
using BlazorApp1.Server.Data_Access;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorApp1.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221021072305_dbTest")]
    partial class dbTest
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BlazorApp1.Shared.Etms.T0DivisiPerusahaan", b =>
                {
                    b.Property<Guid>("IdDivisiPerusahaan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Divisi")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<Guid?>("IdCreator")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdLogHeader")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdOperator")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdValidator")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("IsDVisible")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDefault")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsRVisible")
                        .HasColumnType("bit");

                    b.Property<string>("Keterangan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Synchronise")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Tag")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("WaktuInsert")
                        .HasColumnType("datetimeoffset(7)");

                    b.Property<DateTimeOffset?>("WaktuUpdate")
                        .HasColumnType("datetimeoffset(7)");

                    b.HasKey("IdDivisiPerusahaan");

                    b.ToTable("T0DivisiPerusahaan");
                });

            modelBuilder.Entity("BlazorApp1.Shared.Etms.T0Jabatan", b =>
                {
                    b.Property<Guid>("IdJabatan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.Property<Guid?>("IdCreator")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdKategoriJadwalKerjaKaryawan")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdLogHeader")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdOperator")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdValidator")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("IsDVisible")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDefault")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsRVisible")
                        .HasColumnType("bit");

                    b.Property<string>("Jabatan")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Keterangan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kode")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PKLink1")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PKLink2")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Synchronise")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Tag")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("WaktuInsert")
                        .HasColumnType("datetimeoffset(7)");

                    b.Property<DateTimeOffset?>("WaktuUpdate")
                        .HasColumnType("datetimeoffset(7)");

                    b.HasKey("IdJabatan");

                    b.ToTable("T0Jabatan");
                });

            modelBuilder.Entity("BlazorApp1.Shared.Etms.T1Karyawan", b =>
                {
                    b.Property<Guid>("IdKaryawan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnOrder(0);

                    b.Property<string>("AlamatAsal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AlamatKerabat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AlamatTinggal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BPJS")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CardIdNumber")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CardIdPin")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("DokumenJaminan")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte[]>("FingerPrint0")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("FingerPrint1")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("FingerPrint2")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("FingerPrint3")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("FingerPrint4")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("FingerPrint5")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("FingerPrint6")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("FingerPrint7")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("FingerPrint8")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("FingerPrint9")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("HubunganKerabat")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid?>("IdCreator")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdDivisiPerusahaan")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnOrder(2);

                    b.Property<Guid?>("IdJabatan")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnOrder(1);

                    b.Property<long>("IdKecamatanAsal")
                        .HasColumnType("bigint");

                    b.Property<long>("IdKecamatanTinggal")
                        .HasColumnType("bigint");

                    b.Property<long>("IdKelurahanAsal")
                        .HasColumnType("bigint");

                    b.Property<long>("IdKelurahanTinggal")
                        .HasColumnType("bigint");

                    b.Property<long>("IdKotaAsal")
                        .HasColumnType("bigint");

                    b.Property<long>("IdKotaTinggal")
                        .HasColumnType("bigint");

                    b.Property<Guid?>("IdLogHeader")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdOperator")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdValidator")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("IsDVisible")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDefault")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsRVisible")
                        .HasColumnType("bit");

                    b.Property<string>("JenisKelamin")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Keterangan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KodePosAsal")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("KodePosTinggal")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("KomunikasiLain")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NIK")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NPWP")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NamaKerabat")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NamaLengkap")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NamaPanggilan")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NomorIdentitas1")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NomorIdentitas2")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PKLink1")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PKLink2")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte[]>("PasswordHint")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Rekening")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Seluler1")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Seluler2")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<bool>("StatusLogin")
                        .HasColumnType("bit");

                    b.Property<string>("Synchronise")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Tag")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TanggalBerhenti")
                        .HasColumnType("date");

                    b.Property<DateTime>("TanggalLahir")
                        .HasColumnType("date");

                    b.Property<DateTime>("TanggalRekrut")
                        .HasColumnType("date");

                    b.Property<string>("Telepon")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TeleponKerabat")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TempatLahir")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte[]>("UserPassword")
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTimeOffset?>("WaktuInsert")
                        .HasColumnType("datetimeoffset(7)");

                    b.Property<DateTimeOffset?>("WaktuUpdate")
                        .HasColumnType("datetimeoffset(7)");

                    b.HasKey("IdKaryawan");

                    b.HasIndex("IdDivisiPerusahaan");

                    b.HasIndex("IdJabatan");

                    b.ToTable("T1Karyawan");
                });

            modelBuilder.Entity("BlazorApp1.Shared.Etms.T1Karyawan", b =>
                {
                    b.HasOne("BlazorApp1.Shared.Etms.T0DivisiPerusahaan", "T0DivisiPerusahaan")
                        .WithMany()
                        .HasForeignKey("IdDivisiPerusahaan");

                    b.HasOne("BlazorApp1.Shared.Etms.T0Jabatan", "T0Jabatan")
                        .WithMany("ListKaryawan")
                        .HasForeignKey("IdJabatan");

                    b.Navigation("T0DivisiPerusahaan");

                    b.Navigation("T0Jabatan");
                });

            modelBuilder.Entity("BlazorApp1.Shared.Etms.T0Jabatan", b =>
                {
                    b.Navigation("ListKaryawan");
                });
#pragma warning restore 612, 618
        }
    }
}
