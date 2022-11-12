﻿// <auto-generated />
using System;
using LibraryManagementSystem.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LibraryManagementSystem.Infrastructure.Migrations
{
    [DbContext(typeof(LibraryDbContext))]
    [Migration("20221112132904_UpdateEntityV1")]
    partial class UpdateEntityV1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LibraryManagementSystem.Domain.Entities.Author", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Authors", (string)null);
                });

            modelBuilder.Entity("LibraryManagementSystem.Domain.Entities.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AuthorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PublisherId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TypeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("PublisherId1");

                    b.HasIndex("TypeId");

                    b.ToTable("Books", (string)null);
                });

            modelBuilder.Entity("LibraryManagementSystem.Domain.Entities.BookStatus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("BookStatus", (string)null);
                });

            modelBuilder.Entity("LibraryManagementSystem.Domain.Entities.BookType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("BookTypes", (string)null);
                });

            modelBuilder.Entity("LibraryManagementSystem.Domain.Entities.CallCard", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("LibraryCardId1")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("LibraryCardId1");

                    b.ToTable("CallCards", (string)null);
                });

            modelBuilder.Entity("LibraryManagementSystem.Domain.Entities.LibraryCard", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("LibraryCards", (string)null);
                });

            modelBuilder.Entity("LibraryManagementSystem.Domain.Entities.LibraryConfiguration", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("LibraryConfigurations", (string)null);
                });

            modelBuilder.Entity("LibraryManagementSystem.Domain.Entities.Publisher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.ToTable("Publishers", (string)null);
                });

            modelBuilder.Entity("LibraryManagementSystem.Domain.Entities.Book", b =>
                {
                    b.HasOne("LibraryManagementSystem.Domain.Entities.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryManagementSystem.Domain.Entities.Publisher", "Publisher")
                        .WithMany()
                        .HasForeignKey("PublisherId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryManagementSystem.Domain.Entities.BookType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Publisher");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("LibraryManagementSystem.Domain.Entities.CallCard", b =>
                {
                    b.HasOne("LibraryManagementSystem.Domain.Entities.LibraryCard", "LibraryCard")
                        .WithMany()
                        .HasForeignKey("LibraryCardId1");

                    b.Navigation("LibraryCard");
                });
#pragma warning restore 612, 618
        }
    }
}
