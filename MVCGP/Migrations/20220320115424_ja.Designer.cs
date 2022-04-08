﻿// <auto-generated />
using MVCGP.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVCGP.Migrations
{
    [DbContext(typeof(MVCGPContext))]
    [Migration("20220320115424_ja")]
    partial class ja
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MVCGP.Models.Cotizar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.Property<int>("SemanasId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductoId");

                    b.HasIndex("SemanasId");

                    b.ToTable("Cotizar");
                });

            modelBuilder.Entity("MVCGP.Models.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KeyProduct")
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("PrecioProducto")
                        .HasColumnType("decimal (38,17)");

                    b.Property<string>("nombreProducto")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Producto");
                });

            modelBuilder.Entity("MVCGP.Models.Semanas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KeySemana")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Plazoss")
                        .HasColumnType("int");

                    b.Property<decimal>("TasaN")
                        .HasColumnType("decimal (38,17)");

                    b.Property<decimal>("TasaP")
                        .HasColumnType("decimal (38,17)");

                    b.HasKey("Id");

                    b.ToTable("Semanas");
                });

            modelBuilder.Entity("MVCGP.Models.Cotizar", b =>
                {
                    b.HasOne("MVCGP.Models.Producto", "Producto")
                        .WithMany()
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVCGP.Models.Semanas", "Semanas")
                        .WithMany()
                        .HasForeignKey("SemanasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producto");

                    b.Navigation("Semanas");
                });
#pragma warning restore 612, 618
        }
    }
}
