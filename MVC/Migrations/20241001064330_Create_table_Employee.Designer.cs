﻿// <auto-generated />
using MVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVC.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241001064330_Create_table_Employee")]
    partial class Create_table_Employee
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("MVC.Models.Person", b =>
                {
                    b.Property<string>("CCCD")
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("TEXT");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("QueQuan")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CCCD");

                    b.ToTable("Person");

                    b.HasDiscriminator().HasValue("Person");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("MVC.Models.SinhVien", b =>
                {
                    b.Property<string>("SVID")
                        .HasColumnType("TEXT");

                    b.Property<string>("DC")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("SVID");

                    b.ToTable("SinhVien");
                });

            modelBuilder.Entity("MVC.Models.Employee", b =>
                {
                    b.HasBaseType("MVC.Models.Person");

                    b.Property<string>("EmployeeID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}
