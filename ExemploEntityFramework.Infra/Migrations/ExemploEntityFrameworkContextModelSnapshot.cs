﻿// <auto-generated />
using System;
using ExemploEntityFramework.Infra.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExemploEntityFramework.Infra.Migrations
{
    [DbContext(typeof(ExemploEntityFrameworkContext))]
    partial class ExemploEntityFrameworkContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ExemploEntityFramework.Domain.Contracts.Entities.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("datetime")
                        .HasColumnName("data_alteracao");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime")
                        .HasColumnName("data_cadastro");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(100)")
                        .HasColumnName("nome");

                    b.Property<bool>("Status")
                        .HasColumnType("bit")
                        .HasColumnName("status");

                    b.HasKey("Id");

                    b.ToTable("tb_clientes", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
