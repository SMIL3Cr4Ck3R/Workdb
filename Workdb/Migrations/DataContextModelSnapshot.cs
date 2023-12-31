﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Workdb.Data;

#nullable disable

namespace Workdb.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Workdb.Models.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CityId"));

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CityId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Workdb.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<int>("EmployeeAge")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeCityCityId")
                        .HasColumnType("int");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("EmployeeSalary")
                        .HasColumnType("float");

                    b.HasKey("EmployeeId");

                    b.HasIndex("EmployeeCityCityId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Workdb.Models.EmployeeTransferSalary", b =>
                {
                    b.Property<int>("EmployeeTransferSalaryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeTransferSalaryId"));

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("MonthOfTransfer")
                        .HasColumnType("int");

                    b.Property<DateTime>("TransferDate")
                        .HasColumnType("datetime2");

                    b.HasKey("EmployeeTransferSalaryId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeeTransferSalaries");
                });

            modelBuilder.Entity("Workdb.Models.Employee", b =>
                {
                    b.HasOne("Workdb.Models.City", "EmployeeCity")
                        .WithMany()
                        .HasForeignKey("EmployeeCityCityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmployeeCity");
                });

            modelBuilder.Entity("Workdb.Models.EmployeeTransferSalary", b =>
                {
                    b.HasOne("Workdb.Models.Employee", "Employee")
                        .WithMany("EmployeeTransferSalaryList")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Workdb.Models.Employee", b =>
                {
                    b.Navigation("EmployeeTransferSalaryList");
                });
#pragma warning restore 612, 618
        }
    }
}
