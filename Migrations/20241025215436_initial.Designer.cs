﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Minimal.API.DbContexts;

#nullable disable

namespace Minimal.API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241025215436_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("FoodIngredient", b =>
                {
                    b.Property<int>("FoodsId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IngredientsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("FoodsId", "IngredientsId");

                    b.HasIndex("IngredientsId");

                    b.ToTable("FoodIngredient");

                    b.HasData(
                        new
                        {
                            FoodsId = 1,
                            IngredientsId = 1
                        },
                        new
                        {
                            FoodsId = 1,
                            IngredientsId = 2
                        },
                        new
                        {
                            FoodsId = 1,
                            IngredientsId = 3
                        },
                        new
                        {
                            FoodsId = 1,
                            IngredientsId = 4
                        },
                        new
                        {
                            FoodsId = 1,
                            IngredientsId = 5
                        },
                        new
                        {
                            FoodsId = 1,
                            IngredientsId = 6
                        },
                        new
                        {
                            FoodsId = 1,
                            IngredientsId = 7
                        },
                        new
                        {
                            FoodsId = 1,
                            IngredientsId = 8
                        },
                        new
                        {
                            FoodsId = 1,
                            IngredientsId = 14
                        },
                        new
                        {
                            FoodsId = 2,
                            IngredientsId = 9
                        },
                        new
                        {
                            FoodsId = 2,
                            IngredientsId = 19
                        },
                        new
                        {
                            FoodsId = 2,
                            IngredientsId = 11
                        },
                        new
                        {
                            FoodsId = 2,
                            IngredientsId = 12
                        },
                        new
                        {
                            FoodsId = 2,
                            IngredientsId = 13
                        },
                        new
                        {
                            FoodsId = 2,
                            IngredientsId = 2
                        },
                        new
                        {
                            FoodsId = 2,
                            IngredientsId = 21
                        },
                        new
                        {
                            FoodsId = 2,
                            IngredientsId = 8
                        },
                        new
                        {
                            FoodsId = 3,
                            IngredientsId = 1
                        },
                        new
                        {
                            FoodsId = 3,
                            IngredientsId = 12
                        },
                        new
                        {
                            FoodsId = 3,
                            IngredientsId = 17
                        },
                        new
                        {
                            FoodsId = 3,
                            IngredientsId = 14
                        },
                        new
                        {
                            FoodsId = 3,
                            IngredientsId = 2
                        },
                        new
                        {
                            FoodsId = 3,
                            IngredientsId = 16
                        },
                        new
                        {
                            FoodsId = 3,
                            IngredientsId = 23
                        },
                        new
                        {
                            FoodsId = 3,
                            IngredientsId = 8
                        },
                        new
                        {
                            FoodsId = 4,
                            IngredientsId = 1
                        },
                        new
                        {
                            FoodsId = 4,
                            IngredientsId = 18
                        },
                        new
                        {
                            FoodsId = 4,
                            IngredientsId = 16
                        },
                        new
                        {
                            FoodsId = 4,
                            IngredientsId = 20
                        },
                        new
                        {
                            FoodsId = 4,
                            IngredientsId = 22
                        },
                        new
                        {
                            FoodsId = 4,
                            IngredientsId = 2
                        },
                        new
                        {
                            FoodsId = 4,
                            IngredientsId = 21
                        },
                        new
                        {
                            FoodsId = 4,
                            IngredientsId = 8
                        },
                        new
                        {
                            FoodsId = 5,
                            IngredientsId = 24
                        },
                        new
                        {
                            FoodsId = 5,
                            IngredientsId = 10
                        },
                        new
                        {
                            FoodsId = 5,
                            IngredientsId = 23
                        },
                        new
                        {
                            FoodsId = 5,
                            IngredientsId = 2
                        },
                        new
                        {
                            FoodsId = 5,
                            IngredientsId = 12
                        },
                        new
                        {
                            FoodsId = 5,
                            IngredientsId = 18
                        },
                        new
                        {
                            FoodsId = 5,
                            IngredientsId = 14
                        },
                        new
                        {
                            FoodsId = 5,
                            IngredientsId = 20
                        },
                        new
                        {
                            FoodsId = 5,
                            IngredientsId = 13
                        });
                });

            modelBuilder.Entity("Minimal.API.Entities.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Foods");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Ensopado Flamengo de Carne de Vaca com Chicória"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Mexilhões com Batatas Fritas"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Ragu alla Bolognese"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Rendang"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Masala de Peixe"
                        });
                });

            modelBuilder.Entity("Minimal.API.Entities.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Ingredients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Carne de Vaca"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Cebola"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Cerveja Escura"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Fatia de Pão Integral"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Mostarda"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Chicória"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Maionese"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Vários Temperos"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Mexilhões"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Aipo"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Batatas Fritas"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Tomate"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Extrato de Tomate"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Folha de Louro"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Cenoura"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Alho"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Vinho Tinto"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Leite de Coco"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Gengibre"
                        },
                        new
                        {
                            Id = 20,
                            Name = "Pimenta Malagueta"
                        },
                        new
                        {
                            Id = 21,
                            Name = "Tamarindo"
                        },
                        new
                        {
                            Id = 22,
                            Name = "Peixe Firme"
                        },
                        new
                        {
                            Id = 23,
                            Name = "Pasta de Gengibre e Alho"
                        },
                        new
                        {
                            Id = 24,
                            Name = "Garam Masala"
                        });
                });

            modelBuilder.Entity("FoodIngredient", b =>
                {
                    b.HasOne("Minimal.API.Entities.Food", null)
                        .WithMany()
                        .HasForeignKey("FoodsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Minimal.API.Entities.Ingredient", null)
                        .WithMany()
                        .HasForeignKey("IngredientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
