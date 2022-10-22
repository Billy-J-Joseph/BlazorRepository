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
    [Migration("20221021084223_dbTest2")]
    partial class dbTest2
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
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

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
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("State")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Synchronise")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Tag")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

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
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Keterangan")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Kode")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("PKLink1")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("PKLink2")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("State")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Synchronise")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Tag")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

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
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("AlamatKerabat")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("AlamatTinggal")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("BPJS")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("CardIdNumber")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("CardIdPin")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("DokumenJaminan")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

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
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

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
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Keterangan")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("KodePosAsal")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("KodePosTinggal")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("KomunikasiLain")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("NIK")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("NPWP")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("NamaKerabat")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("NamaLengkap")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("NamaPanggilan")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("NomorIdentitas1")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("NomorIdentitas2")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("PKLink1")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("PKLink2")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<byte[]>("PasswordHint")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Rekening")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Seluler1")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Seluler2")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("State")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<bool>("StatusLogin")
                        .HasColumnType("bit");

                    b.Property<string>("Synchronise")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Tag")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<DateTime>("TanggalBerhenti")
                        .HasColumnType("date");

                    b.Property<DateTime>("TanggalLahir")
                        .HasColumnType("date");

                    b.Property<DateTime>("TanggalRekrut")
                        .HasColumnType("date");

                    b.Property<string>("Telepon")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("TeleponKerabat")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("TempatLahir")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("UserName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

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

            modelBuilder.Entity("BlazorApp1.Shared.Etms.T7OrderPenjualan", b =>
                {
                    b.Property<Guid>("IdDetilOrderPenjualan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Barang_Barang")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Barang_Kode1")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Barang_Kode2")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Barang_Merk")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Barang_Ukuran")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("Barang_Umur")
                        .HasColumnType("int");

                    b.Property<string>("Barang_Warna")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<decimal>("Berat")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("CatatanOrder")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("CatatanPersetujuan")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<DateTimeOffset>("DiskonBarang_WaktuInsert")
                        .HasColumnType("datetimeoffset(7)");

                    b.Property<string>("DiskonDetil")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<decimal>("DiskonNominal")
                        .HasColumnType("money");

                    b.Property<string>("DivisiBarang_Divisi")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<decimal>("Harga")
                        .HasColumnType("money");

                    b.Property<DateTimeOffset>("HargaBarang_WaktuInsert")
                        .HasColumnType("datetimeoffset(7)");

                    b.Property<Guid?>("IdBarang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdDetilKontrakPenjualan")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdDiskonBarang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdDivisiBarang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdHargaBarang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdKategoriBarang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdKurs")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdOperator")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdOrderPenjualan")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdSatuan")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdSubDivisiBarang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdSubKategoriBarang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("JenisBarang")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("JenisHargaDiskon")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("Jumlah")
                        .HasColumnType("decimal(10,2)");

                    b.Property<long>("JumlahRealisasi")
                        .HasColumnType("bigint");

                    b.Property<string>("KategoriBarang_Kategori")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<DateTimeOffset>("Kuantum_DiskonBarang_WaktuInsert")
                        .HasColumnType("datetimeoffset(7)");

                    b.Property<string>("Kuantum_DiskonDetil")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<decimal>("Kuantum_DiskonNominal")
                        .HasColumnType("money");

                    b.Property<decimal>("Kuantum_Harga")
                        .HasColumnType("money");

                    b.Property<DateTimeOffset>("Kuantum_HargaBarang_WaktuInsert")
                        .HasColumnType("datetimeoffset(7)");

                    b.Property<Guid?>("Kuantum_IdDiskonBarang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("Kuantum_IdHargaBarang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("Kuantum_IdSatuan")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Kuantum_JenisHargaDiskon")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("Kuantum_Jumlah")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("Kuantum_Kuantum")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)");

                    b.Property<decimal>("Kuantum_Total")
                        .HasColumnType("money");

                    b.Property<string>("Kurs_Kurs")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Kurs_Simbol")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<decimal>("NilaiKurs")
                        .HasColumnType("money");

                    b.Property<bool>("Pemutihan")
                        .HasColumnType("bit");

                    b.Property<bool>("Persetujuan")
                        .HasColumnType("bit");

                    b.Property<Guid?>("Referensi_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Referensi_IdTransaksi")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<DateTimeOffset>("Referensi_WaktuProses")
                        .HasColumnType("datetimeoffset(7)");

                    b.Property<byte>("Satuan_SKUGrup")
                        .HasColumnType("tinyint");

                    b.Property<string>("Satuan_SKUKode1")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Satuan_SKUKode2")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<byte>("Satuan_SKULevel")
                        .HasColumnType("tinyint");

                    b.Property<decimal>("Satuan_SKURasio")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("Satuan_Satuan")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("Satuan_UseSerialNumber")
                        .HasColumnType("bit");

                    b.Property<bool>("StatusTerealisasi")
                        .HasColumnType("bit");

                    b.Property<string>("SubDivisiBarang_SubDivisi")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("SubKategoriBarang_SubKategori")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Synchronise")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<decimal>("Total")
                        .HasColumnType("money");

                    b.Property<DateTimeOffset>("WaktuPersetujuan")
                        .HasColumnType("datetimeoffset(7)");

                    b.HasKey("IdDetilOrderPenjualan");

                    b.ToTable("T7OrderPenjualan");
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
