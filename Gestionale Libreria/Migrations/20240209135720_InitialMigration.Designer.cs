﻿// <auto-generated />
using Gestionale_Libreria.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Gestionale_Libreria.Migrations
{
    [DbContext(typeof(LibreriaDBContext))]
    [Migration("20240209135720_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Gestionale_Libreria.Models.Libro", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("idGenere")
                        .HasColumnType("int");

                    b.Property<int>("idScaffale")
                        .HasColumnType("int");

                    b.Property<bool>("prestito")
                        .HasColumnType("bit");

                    b.Property<string>("titolo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Libri");
                });
#pragma warning restore 612, 618
        }
    }
}
