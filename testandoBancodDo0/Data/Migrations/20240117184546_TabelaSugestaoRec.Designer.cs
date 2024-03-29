﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using testandoBancodDo0.Context;

#nullable disable

namespace testandoBancodDo0.Data.Migrations
{
    [DbContext(typeof(AproveDbContext))]
    [Migration("20240117184546_TabelaSugestaoRec")]
    partial class TabelaSugestaoRec
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("testandoBancodDo0.Models.CadastroReceitaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Ingredientes")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ModoPreparo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("cad_receitas");
                });

            modelBuilder.Entity("testandoBancodDo0.Models.IngredientesModel", b =>
                {
                    b.Property<int>("idIngredientes")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("idIngredientes"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Quantidade")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UnidadeMedida")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("idIngredientes");

                    b.ToTable("tab_ingredientes");
                });

            modelBuilder.Entity("testandoBancodDo0.Models.ReceitaModel", b =>
                {
                    b.Property<int>("idReceita")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("idReceita"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ModoPreparo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("SugestaoReceitaidSugestao")
                        .HasColumnType("integer");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("idIngredientes")
                        .HasColumnType("integer");

                    b.Property<int>("idSugestao")
                        .HasColumnType("integer");

                    b.HasKey("idReceita");

                    b.HasIndex("SugestaoReceitaidSugestao");

                    b.HasIndex("idIngredientes");

                    b.ToTable("tab_receitas");
                });

            modelBuilder.Entity("testandoBancodDo0.Models.SugestaoReceitaModel", b =>
                {
                    b.Property<int>("idSugestao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("idSugestao"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Id")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Ingredientes")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ModoPreparo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("idSugestao");

                    b.HasIndex("Id");

                    b.ToTable("tab_sugestaoRec");
                });

            modelBuilder.Entity("testandoBancodDo0.Models.UsuarioModel", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("usuarios");
                });

            modelBuilder.Entity("testandoBancodDo0.Models.ReceitaModel", b =>
                {
                    b.HasOne("testandoBancodDo0.Models.SugestaoReceitaModel", "SugestaoReceita")
                        .WithMany()
                        .HasForeignKey("SugestaoReceitaidSugestao")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("testandoBancodDo0.Models.IngredientesModel", "Ingredientes")
                        .WithMany()
                        .HasForeignKey("idIngredientes")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredientes");

                    b.Navigation("SugestaoReceita");
                });

            modelBuilder.Entity("testandoBancodDo0.Models.SugestaoReceitaModel", b =>
                {
                    b.HasOne("testandoBancodDo0.Models.UsuarioModel", "Usuario")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
