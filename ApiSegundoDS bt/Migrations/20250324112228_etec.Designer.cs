﻿// <auto-generated />
using System;
using ApiSegundoDS_bt.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiSegundoDS_bt.Migrations
{
    [DbContext(typeof(ApiSegundoDS_btContext))]
    [Migration("20250324112228_etec")]
    partial class etec
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ApiSegundoDS_bt.models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("datanascimento")
                        .HasColumnType("datetime2");

                    b.Property<int>("escolaid")
                        .HasColumnType("int");

                    b.Property<string>("mae")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("matricula")
                        .HasColumnType("int");

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("professorid")
                        .HasColumnType("int");

                    b.Property<string>("rma")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Aluno");
                });

            modelBuilder.Entity("ApiSegundoDS_bt.models.escola", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("alunoid")
                        .HasColumnType("int");

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("professorid")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("escola");
                });

            modelBuilder.Entity("ApiSegundoDS_bt.models.professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Alunoid")
                        .HasColumnType("int");

                    b.Property<string>("componentecurricular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("escolaid")
                        .HasColumnType("int");

                    b.Property<string>("mae")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("rma")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("professor");
                });
#pragma warning restore 612, 618
        }
    }
}
