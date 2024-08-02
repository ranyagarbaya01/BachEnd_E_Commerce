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
    [Migration("20240729072917_inittttttt7777")]
    partial class inittttttt7777
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
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("CustomerBasketId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PictureUrl")
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerBasketId");

                    b.ToTable("BasketItem");
                });

            modelBuilder.Entity("store.Models.CustomerBasket", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ClientSecret")
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("DeliveryMethodId")
                        .HasColumnType("int");

                    b.Property<string>("PaymentIntentId")
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal>("ShippingPrice")
                        .HasColumnType("decimal(18,3)");

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

            modelBuilder.Entity("store.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte[]>("ImageData")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("Images");
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

                    b.Property<decimal>("PrixHT")
                        .HasColumnType("decimal(18,5)");

                    b.Property<decimal>("PrixTTC")
                        .HasColumnType("decimal(18,5)");

                    b.Property<decimal>("TVA")
                        .HasColumnType("decimal(18,5)");

                    b.Property<int?>("TypeId")
                        .HasColumnType("int");

                    b.Property<byte[]>("image")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

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

            modelBuilder.Entity("store.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("store.Models.BasketItem", b =>
                {
                    b.HasOne("store.Models.CustomerBasket", null)
                        .WithMany("Items")
                        .HasForeignKey("CustomerBasketId");
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
