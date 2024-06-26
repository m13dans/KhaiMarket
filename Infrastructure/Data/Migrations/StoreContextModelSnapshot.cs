﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.data.migrations;

[DbContext(typeof(StoreContext))]
partial class StoreContextModelSnapshot : ModelSnapshot
{
    protected override void BuildModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
        modelBuilder.HasAnnotation("ProductVersion", "8.0.1");

        modelBuilder.Entity("Core.Entities.Category", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<string>("Name")
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.ToTable("ProductTypes");
            });

        modelBuilder.Entity("Core.Entities.Product", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<int?>("CategoryId")
                    .HasColumnType("INTEGER");

                b.Property<string>("Description")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("TEXT");

                b.Property<string>("ImageUrl")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("TEXT");

                b.Property<decimal>("Price")
                    .HasColumnType("decimal(18,2)");

                b.Property<int?>("ProductBrandId")
                    .HasColumnType("INTEGER");

                b.HasKey("Id");

                b.HasIndex("CategoryId");

                b.HasIndex("ProductBrandId");

                b.ToTable("Products");
            });

        modelBuilder.Entity("Core.Entities.ProductBrand", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<string>("Name")
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.ToTable("ProductBrands");
            });

        modelBuilder.Entity("Core.Entities.Review", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<string>("Comment")
                    .HasColumnType("TEXT");

                b.Property<int>("NumStars")
                    .HasColumnType("INTEGER");

                b.Property<int?>("ProductId")
                    .HasColumnType("INTEGER");

                b.Property<string>("VoterName")
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.HasIndex("ProductId");

                b.ToTable("Review");
            });

        modelBuilder.Entity("Core.Entities.Product", b =>
            {
                b.HasOne("Core.Entities.Category", "Category")
                    .WithMany()
                    .HasForeignKey("CategoryId");

                b.HasOne("Core.Entities.ProductBrand", "ProductBrand")
                    .WithMany()
                    .HasForeignKey("ProductBrandId");

                b.Navigation("Category");

                b.Navigation("ProductBrand");
            });

        modelBuilder.Entity("Core.Entities.Review", b =>
            {
                b.HasOne("Core.Entities.Product", null)
                    .WithMany("Reviews")
                    .HasForeignKey("ProductId");
            });

        modelBuilder.Entity("Core.Entities.Product", b =>
            {
                b.Navigation("Reviews");
            });
#pragma warning restore 612, 618
    }
}
