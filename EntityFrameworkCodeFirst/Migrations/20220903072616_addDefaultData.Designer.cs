﻿// <auto-generated />
using System;
using EntityFrameworkCodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntityFrameworkCodeFirst.Migrations
{
    [DbContext(typeof(EmployeeManageDbContext))]
    [Migration("20220903072616_addDefaultData")]
    partial class addDefaultData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EntityFrameworkCodeFirst.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("DepartmentEmployee");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 9, 3, 7, 26, 16, 579, DateTimeKind.Utc).AddTicks(9820),
                            Name = "HR"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2022, 9, 3, 7, 26, 16, 579, DateTimeKind.Utc).AddTicks(9821),
                            Name = "IT"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2022, 9, 3, 7, 26, 16, 579, DateTimeKind.Utc).AddTicks(9822),
                            Name = "Sales"
                        });
                });

            modelBuilder.Entity("EntityFrameworkCodeFirst.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("EmpCode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("FristName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 18,
                            CreatedDate = new DateTime(2022, 9, 3, 7, 26, 16, 579, DateTimeKind.Utc).AddTicks(9885),
                            DepartmentId = 2,
                            EmpCode = "Long.Nguyen",
                            FristName = "Long",
                            LastName = "Nguyen"
                        },
                        new
                        {
                            Id = 2,
                            Age = 18,
                            CreatedDate = new DateTime(2022, 9, 3, 7, 26, 16, 579, DateTimeKind.Utc).AddTicks(9887),
                            DepartmentId = 1,
                            EmpCode = "Long.Hoang",
                            FristName = "Long",
                            LastName = "Hoang"
                        },
                        new
                        {
                            Id = 3,
                            Age = 19,
                            CreatedDate = new DateTime(2022, 9, 3, 7, 26, 16, 579, DateTimeKind.Utc).AddTicks(9887),
                            DepartmentId = 2,
                            EmpCode = "Long.Manh",
                            FristName = "Long",
                            LastName = "Manh"
                        });
                });

            modelBuilder.Entity("EntityFrameworkCodeFirst.Models.Employee", b =>
                {
                    b.HasOne("EntityFrameworkCodeFirst.Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("EntityFrameworkCodeFirst.Models.Department", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
