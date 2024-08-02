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
    [Migration("20240801154051_InitialCreate123456144455")]
    partial class InitialCreate123456144455
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("store.Models.Commande", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adresse")
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("CodePostal")
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("FraisLivraison")
                        .HasColumnType("int");

                    b.Property<string>("Gouvernorat")
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Heure")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("MFcin")
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("NomRaisonSocial")
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal>("TotalHT")
                        .HasColumnType("decimal(18,6)");

                    b.Property<decimal>("TotalTTC")
                        .HasColumnType("decimal(18,6)");

                    b.Property<decimal>("TotalTVA")
                        .HasColumnType("decimal(18,6)");

                    b.Property<int>("idUser")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("idUser");

                    b.ToTable("Commande");
                });

            modelBuilder.Entity("store.Models.DétailsCommande", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CommandeId")
                        .HasColumnType("int");

                    b.Property<decimal>("PrixTotal")
                        .HasColumnType("decimal(18,6)");

                    b.Property<decimal>("PrixUnitaire")
                        .HasColumnType("decimal(18,6)");

                    b.Property<int>("Qte")
                        .HasColumnType("int");

                    b.Property<int>("idProduit")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CommandeId");

                    b.HasIndex("idProduit");

                    b.ToTable("DétailsCommande");
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

                    b.Property<decimal>("PrixBarre")
                        .HasColumnType("decimal(18,6)");

                    b.Property<decimal>("PrixHT")
                        .HasColumnType("decimal(18,5)");

                    b.Property<decimal>("PrixTTC")
                        .HasColumnType("decimal(18,6)");

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

            modelBuilder.Entity("store.Models.Societe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Acitivite")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("MF")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("NumTel")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("RaisonSocial")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Rib")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<byte[]>("logo")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("Societe");
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

                    b.Property<string>("Adresse")
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("CodePostal")
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Gouvernorat")
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("MFcin")
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("NomRaisonSocial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("token")
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("store.Models.Commande", b =>
                {
                    b.HasOne("store.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("idUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("store.Models.DétailsCommande", b =>
                {
                    b.HasOne("store.Models.Commande", null)
                        .WithMany("Items")
                        .HasForeignKey("CommandeId");

                    b.HasOne("store.Models.Produit", "Produit")
                        .WithMany()
                        .HasForeignKey("idProduit")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produit");
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

            modelBuilder.Entity("store.Models.Commande", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
