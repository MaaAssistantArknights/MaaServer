﻿// <auto-generated />
using System;
using MaaDownloadServer.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MaaDownloadServer.Migrations
{
    [DbContext(typeof(MaaDownloadServerDbContext))]
    partial class MaaDownloadServerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.1");

            modelBuilder.Entity("MaaDownloadServer.Model.Entities.ArkItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<string>("Category")
                        .HasColumnType("TEXT")
                        .HasColumnName("category");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT")
                        .HasColumnName("description");

                    b.Property<string>("Image")
                        .HasColumnType("TEXT")
                        .HasColumnName("image");

                    b.Property<int>("ItemId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("item_id");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasColumnName("name");

                    b.Property<string>("ObtainApproach")
                        .HasColumnType("TEXT")
                        .HasColumnName("obtain_approach");

                    b.Property<int>("Rarity")
                        .HasColumnType("INTEGER")
                        .HasColumnName("rarity");

                    b.Property<string>("Usage")
                        .HasColumnType("TEXT")
                        .HasColumnName("usage");

                    b.HasKey("Id");

                    b.ToTable("ark_item");
                });

            modelBuilder.Entity("MaaDownloadServer.Model.Entities.Package", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("id");

                    b.Property<string>("Architecture")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("architecture");

                    b.Property<string>("Platform")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("platform");

                    b.Property<DateTime>("PublishTime")
                        .HasColumnType("TEXT")
                        .HasColumnName("publish_time");

                    b.Property<string>("UpdateLog")
                        .HasColumnType("TEXT")
                        .HasColumnName("update_log");

                    b.Property<string>("Version")
                        .HasColumnType("TEXT")
                        .HasColumnName("version");

                    b.HasKey("Id");

                    b.ToTable("package");
                });

            modelBuilder.Entity("MaaDownloadServer.Model.Entities.PublicContent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("id");

                    b.Property<DateTime>("AddTime")
                        .HasColumnType("TEXT")
                        .HasColumnName("add_time");

                    b.Property<DateTime>("Duration")
                        .HasColumnType("TEXT")
                        .HasColumnName("duration");

                    b.Property<string>("Hash")
                        .HasColumnType("TEXT")
                        .HasColumnName("hash");

                    b.Property<string>("Tag")
                        .HasColumnType("TEXT")
                        .HasColumnName("tag");

                    b.HasKey("Id");

                    b.ToTable("public_content");
                });

            modelBuilder.Entity("MaaDownloadServer.Model.Entities.Resource", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("id");

                    b.Property<string>("FileName")
                        .HasColumnType("TEXT")
                        .HasColumnName("file_name");

                    b.Property<string>("Hash")
                        .HasColumnType("TEXT")
                        .HasColumnName("hash");

                    b.Property<string>("Path")
                        .HasColumnType("TEXT")
                        .HasColumnName("path");

                    b.HasKey("Id");

                    b.ToTable("resource");
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
