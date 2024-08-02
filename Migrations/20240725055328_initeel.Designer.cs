﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using store.Data;

#nullable disable

namespace store.Migrations
{
    [DbContext(typeof(storeContext))]
    [Migration("20240725055328_initeel")]
    partial class initeel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("store.Models.BasketItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerBasketId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PictureUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerBasketId");

                    b.ToTable("BasketItem");
                });

            modelBuilder.Entity("store.Models.CustomerBasket", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ClientSecret")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DeliveryMethodId")
                        .HasColumnType("int");

                    b.Property<string>("PaymentIntentId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ShippingPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("CustomerBasket");
                });

            modelBuilder.Entity("store.Models.Famille", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Famille");
                });

            modelBuilder.Entity("store.Models.Produit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("FamilleId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal>("Prix")
                        .HasColumnType("decimal(16,3)");

                    b.Property<int?>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FamilleId");

                    b.HasIndex("TypeId");

                    b.ToTable("Produit");
                });

            modelBuilder.Entity("store.Models.Type", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Type");
                });

            modelBuilder.Entity("store.Models.BasketItem", b =>
                {
                    b.HasOne("store.Models.CustomerBasket", "CustomerBasket")
                        .WithMany("Items")
                        .HasForeignKey("CustomerBasketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CustomerBasket");
                });

            modelBuilder.Entity("store.Models.Produit", b =>
                {
                    b.HasOne("store.Models.Famille", "Famille")
                        .WithMany()
                        .HasForeignKey("FamilleId");

                    b.HasOne("store.Models.Type", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId");

                    b.Navigation("Famille");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("store.Models.CustomerBasket", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
