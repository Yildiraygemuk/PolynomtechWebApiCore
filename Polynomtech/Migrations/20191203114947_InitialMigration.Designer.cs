﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Polynomtech.PolynomtechEntities;

namespace Polynomtech.Migrations
{
    [DbContext(typeof(PolynomDbContext))]
    [Migration("20191203114947_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Polynomtech.PolynomtechEntities.Brand", b =>
                {
                    b.Property<int>("BrandID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrandName");

                    b.Property<string>("Description");

                    b.HasKey("BrandID");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("Polynomtech.PolynomtechEntities.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("OrderDate");

                    b.Property<int?>("OrderDetailId");

                    b.Property<string>("Phone");

                    b.Property<string>("ShipAdress");

                    b.Property<int>("UserDetailId");

                    b.HasKey("OrderId");

                    b.HasIndex("OrderDetailId");

                    b.HasIndex("UserDetailId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Polynomtech.PolynomtechEntities.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Count");

                    b.Property<int>("OrderId");

                    b.Property<int>("ParfumeId");

                    b.Property<int>("Price");

                    b.HasKey("OrderDetailId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Polynomtech.PolynomtechEntities.Parfume", b =>
                {
                    b.Property<int>("ParfumeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrandId");

                    b.Property<int?>("OrderDetailId");

                    b.Property<string>("ParfumeName");

                    b.Property<string>("PhotoPath");

                    b.Property<decimal>("Price");

                    b.HasKey("ParfumeID");

                    b.HasIndex("BrandId");

                    b.HasIndex("OrderDetailId");

                    b.ToTable("Parfumes");
                });

            modelBuilder.Entity("Polynomtech.PolynomtechEntities.UserDetail", b =>
                {
                    b.Property<int>("UserDetailId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Phone");

                    b.Property<string>("UserName");

                    b.HasKey("UserDetailId");

                    b.ToTable("UserDetails");
                });

            modelBuilder.Entity("Polynomtech.PolynomtechEntities.Order", b =>
                {
                    b.HasOne("Polynomtech.PolynomtechEntities.OrderDetail", "OrderDetail")
                        .WithMany("Orders")
                        .HasForeignKey("OrderDetailId");

                    b.HasOne("Polynomtech.PolynomtechEntities.UserDetail", "UserDetail")
                        .WithMany("Orders")
                        .HasForeignKey("UserDetailId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Polynomtech.PolynomtechEntities.Parfume", b =>
                {
                    b.HasOne("Polynomtech.PolynomtechEntities.Brand", "Brand")
                        .WithMany("Parfumes")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Polynomtech.PolynomtechEntities.OrderDetail")
                        .WithMany("Parfumes")
                        .HasForeignKey("OrderDetailId");
                });
#pragma warning restore 612, 618
        }
    }
}
