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
            modelBuilder.HasAnnotation("ProductVersion", "6.0.3");

            modelBuilder.Entity("MaaDownloadServer.Model.Entities.DatabaseCache", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("id");

                    b.Property<string>("QueryId")
                        .HasColumnType("TEXT")
                        .HasColumnName("query_id");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT")
                        .HasColumnName("value");

                    b.HasKey("Id");

                    b.ToTable("database_cache");
                });

            modelBuilder.Entity("MaaDownloadServer.Model.Entities.DownloadCount", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("id");

                    b.Property<string>("ComponentName")
                        .HasColumnType("TEXT")
                        .HasColumnName("component_name");

                    b.Property<int>("Count")
                        .HasColumnType("INTEGER")
                        .HasColumnName("count");

                    b.Property<string>("FromVersion")
                        .HasColumnType("TEXT")
                        .HasColumnName("from_version");

                    b.Property<string>("ToVersion")
                        .HasColumnType("TEXT")
                        .HasColumnName("to_version");

                    b.HasKey("Id");

                    b.ToTable("download_count");
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

                    b.Property<string>("Component")
                        .HasColumnType("TEXT")
                        .HasColumnName("component");

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

                    b.Property<string>("FileExtension")
                        .HasColumnType("TEXT")
                        .HasColumnName("file_extension");

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
