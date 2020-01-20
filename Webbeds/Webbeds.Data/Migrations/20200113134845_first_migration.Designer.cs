﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Webbeds.Data;

namespace Webbeds.Data.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20200113134845_first_migration")]
    partial class first_migration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Webbeds.Data.Entities.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("Webbeds.Data.Entities.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Adults")
                        .HasColumnType("int");

                    b.Property<int>("Children")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("hotelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("hotelId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("Webbeds.Data.Entities.Room", b =>
                {
                    b.HasOne("Webbeds.Data.Entities.Hotel", "hotel")
                        .WithMany("Rooms")
                        .HasForeignKey("hotelId");
                });
#pragma warning restore 612, 618
        }
    }
}
