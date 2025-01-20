﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using costumerManagement.Data;

#nullable disable

namespace back_end.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("costumerManagement.Models.Check", b =>
                {
                    b.Property<long>("identification")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<int>("customer")
                        .HasColumnType("int");

                    b.Property<double>("debt")
                        .HasColumnType("double");

                    b.HasKey("identification");

                    b.ToTable("check");
                });

            modelBuilder.Entity("costumerManagement.Models.Costumer", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<long>("check")
                        .HasColumnType("bigint");

                    b.Property<string>("fullName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("constumer");
                });
#pragma warning restore 612, 618
        }
    }
}
