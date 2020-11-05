﻿// <auto-generated />
using System;
using BD_of_the_Realtor_Firm.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BD_of_the_Realtor_Firm.Migrations
{
    [DbContext(typeof(BD_of_the_Realtor_FirmContext))]
    [Migration("20201104114351_3")]
    partial class _3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BD_of_the_Realtor_Firm.Models.Apartments", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("BuyersID")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("SellersID")
                        .HasColumnType("bigint");

                    b.Property<long>("Type_ID")
                        .HasColumnType("bigint");

                    b.Property<string>("Type_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("BuyersID");

                    b.HasIndex("SellersID");

                    b.ToTable("Apartments");
                });

            modelBuilder.Entity("BD_of_the_Realtor_Firm.Models.Buyers", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Area")
                        .HasColumnType("int");

                    b.Property<string>("Bathroom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Buyers_ID")
                        .HasColumnType("bigint");

                    b.Property<long?>("ContractsID")
                        .HasColumnType("bigint");

                    b.Property<string>("Full_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mark_phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number_rooms")
                        .HasColumnType("int");

                    b.Property<string>("Passport_data")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<long>("TypeID")
                        .HasColumnType("bigint");

                    b.Property<string>("Wishes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("data")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("ContractsID");

                    b.ToTable("Buyers");
                });

            modelBuilder.Entity("BD_of_the_Realtor_Firm.Models.Contracts", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("BuyersID")
                        .HasColumnType("bigint");

                    b.Property<int>("Cost")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<long>("SellersID")
                        .HasColumnType("bigint");

                    b.Property<long>("StaffID")
                        .HasColumnType("bigint");

                    b.Property<long>("TypeID")
                        .HasColumnType("bigint");

                    b.Property<int>("amount")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("BD_of_the_Realtor_Firm.Models.Positions", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("Position_ID")
                        .HasColumnType("bigint");

                    b.Property<string>("Position_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Requirements")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Responsibilities")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.Property<long?>("StaffID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("StaffID");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("BD_of_the_Realtor_Firm.Models.Sellers", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address_apartament")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Area")
                        .HasColumnType("int");

                    b.Property<string>("Bathroom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("ContractsID")
                        .HasColumnType("bigint");

                    b.Property<string>("Full_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Information")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mark_phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number_rooms")
                        .HasColumnType("int");

                    b.Property<string>("Passport_data")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<long>("Sellers_ID")
                        .HasColumnType("bigint");

                    b.Property<long>("TypeID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("data")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("ContractsID");

                    b.ToTable("Sellers");
                });

            modelBuilder.Entity("BD_of_the_Realtor_Firm.Models.Servis", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("ContractsID")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<long>("Servis_ID")
                        .HasColumnType("bigint");

                    b.Property<string>("Servis_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ContractsID");

                    b.ToTable("Servis");
                });

            modelBuilder.Entity("BD_of_the_Realtor_Firm.Models.Staff", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<long?>("ContractsID")
                        .HasColumnType("bigint");

                    b.Property<string>("Full_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Passport_data")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("PositionID")
                        .HasColumnType("bigint");

                    b.Property<long>("Staff_ID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("ContractsID");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("BD_of_the_Realtor_Firm.Models.Apartments", b =>
                {
                    b.HasOne("BD_of_the_Realtor_Firm.Models.Buyers", null)
                        .WithMany("Type_ID")
                        .HasForeignKey("BuyersID");

                    b.HasOne("BD_of_the_Realtor_Firm.Models.Sellers", null)
                        .WithMany("Type_ID")
                        .HasForeignKey("SellersID");
                });

            modelBuilder.Entity("BD_of_the_Realtor_Firm.Models.Buyers", b =>
                {
                    b.HasOne("BD_of_the_Realtor_Firm.Models.Contracts", null)
                        .WithMany("Buyers_ID")
                        .HasForeignKey("ContractsID");
                });

            modelBuilder.Entity("BD_of_the_Realtor_Firm.Models.Positions", b =>
                {
                    b.HasOne("BD_of_the_Realtor_Firm.Models.Staff", null)
                        .WithMany("Position_ID")
                        .HasForeignKey("StaffID");
                });

            modelBuilder.Entity("BD_of_the_Realtor_Firm.Models.Sellers", b =>
                {
                    b.HasOne("BD_of_the_Realtor_Firm.Models.Contracts", null)
                        .WithMany("Sellers_ID")
                        .HasForeignKey("ContractsID");
                });

            modelBuilder.Entity("BD_of_the_Realtor_Firm.Models.Servis", b =>
                {
                    b.HasOne("BD_of_the_Realtor_Firm.Models.Contracts", null)
                        .WithMany("Type_ID")
                        .HasForeignKey("ContractsID");
                });

            modelBuilder.Entity("BD_of_the_Realtor_Firm.Models.Staff", b =>
                {
                    b.HasOne("BD_of_the_Realtor_Firm.Models.Contracts", null)
                        .WithMany("staff_ID")
                        .HasForeignKey("ContractsID");
                });
#pragma warning restore 612, 618
        }
    }
}
