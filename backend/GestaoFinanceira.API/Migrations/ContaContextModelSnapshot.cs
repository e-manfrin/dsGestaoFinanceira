﻿// <auto-generated />
using System;
using GestaoFinanceira.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GestaoFinanceira.API.Migrations
{
    [DbContext(typeof(ContaContext))]
    partial class ContaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.8");

            modelBuilder.Entity("GestaoFinanceira.API.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("NomeCatergoria")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categoria");

                    b.HasData(
                        new
                        {
                            Id = 3,
                            NomeCatergoria = "Alimentação"
                        },
                        new
                        {
                            Id = 4,
                            NomeCatergoria = "Salário"
                        });
                });

            modelBuilder.Entity("GestaoFinanceira.API.Models.Conta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoriaID")
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("Data")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<double>("Valor")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaID");

                    b.ToTable("Contas");

                    b.HasData(
                        new
                        {
                            Id = 10,
                            CategoriaID = 3,
                            Data = new DateOnly(2022, 7, 5),
                            Descricao = "Conta de luz",
                            Valor = 190.90000000000001
                        },
                        new
                        {
                            Id = 11,
                            CategoriaID = 4,
                            Data = new DateOnly(2022, 8, 5),
                            Descricao = "Conta de Água",
                            Valor = 90.599999999999994
                        },
                        new
                        {
                            Id = 12,
                            CategoriaID = 4,
                            Data = new DateOnly(2022, 8, 5),
                            Descricao = "Conta de Gás",
                            Valor = 100.09999999999999
                        });
                });

            modelBuilder.Entity("GestaoFinanceira.API.Models.Conta", b =>
                {
                    b.HasOne("GestaoFinanceira.API.Models.Categoria", "Categorias")
                        .WithMany("Conta")
                        .HasForeignKey("CategoriaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categorias");
                });

            modelBuilder.Entity("GestaoFinanceira.API.Models.Categoria", b =>
                {
                    b.Navigation("Conta");
                });
#pragma warning restore 612, 618
        }
    }
}
