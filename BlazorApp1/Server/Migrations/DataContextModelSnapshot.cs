﻿// <auto-generated />
using System;
using BlazorApp1.Server.Data_Access;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorApp1.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BlazorApp1.Shared.Etms.T0DivisiPerusahaan", b =>
                {
                    b.Property<Guid>("IdDivisiPerusahaan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Divisi")
                        .HasColumnType("nvarchar(max)");

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
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tag")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("WaktuInsert")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("WaktuUpdate")
                        .HasColumnType("datetimeoffset");

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
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Keterangan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Synchronise")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tag")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("WaktuInsert")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("WaktuUpdate")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("IdJabatan");

                    b.ToTable("T0Jabatan");
                });

            modelBuilder.Entity("BlazorApp1.Shared.Etms.T1Karyawan", b =>
                {
                    b.Property<Guid>("IdKaryawan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnOrder(0);

                    b.Property<string>("Alamat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("IdCreator")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdDivisiPerusahaan")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnOrder(2);

                    b.Property<Guid?>("IdJabatan")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnOrder(1);

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
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NamaLengkap")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NamaPanggilan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Synchronise")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tag")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("WaktuInsert")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("WaktuUpdate")
                        .HasColumnType("datetimeoffset");

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