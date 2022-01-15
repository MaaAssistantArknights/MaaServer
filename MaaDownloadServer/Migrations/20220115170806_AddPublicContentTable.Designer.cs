﻿// <auto-generated />
using System;
using MaaDownloadServer.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MaaDownloadServer.Migrations
{
    [DbContext(typeof(MaaDownloadServerDbContext))]
    [Migration("20220115170806_AddPublicContentTable")]
    partial class AddPublicContentTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.1");

            modelBuilder.Entity("MaaDownloadServer.Model.Entities.Package", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Architecture")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<uint>("DownloadTimes")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Platform")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("PublishTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Version")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Packages");
                });

            modelBuilder.Entity("MaaDownloadServer.Model.Entities.Resource", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("DownloadTimes")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FileName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Hash")
                        .HasColumnType("TEXT");

                    b.Property<string>("Path")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Resources");
                });

            modelBuilder.Entity("PackageResource", b =>
                {
                    b.Property<Guid>("PackagesId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ResourcesId")
                        .HasColumnType("TEXT");

                    b.HasKey("PackagesId", "ResourcesId");

                    b.HasIndex("ResourcesId");

                    b.ToTable("PackageResource");
                });

            modelBuilder.Entity("PackageResource", b =>
                {
                    b.HasOne("MaaDownloadServer.Model.Entities.Package", null)
                        .WithMany()
                        .HasForeignKey("PackagesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MaaDownloadServer.Model.Entities.Resource", null)
                        .WithMany()
                        .HasForeignKey("ResourcesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
