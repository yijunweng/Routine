﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Routine.Api.Data;

namespace Routine.Api.Migrations
{
    [DbContext(typeof(RoutineDbContext))]
    [Migration("20240616091949_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Routine.Api.Entities.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Introduction")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("T_Companies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bbdee09c-089b-4d30-bece-44df5923716c"),
                            Introduction = "Great Company",
                            Name = "Microsoft"
                        },
                        new
                        {
                            Id = new Guid("6fb600c1-9011-4fd7-9234-881379716440"),
                            Introduction = "Don't be evil",
                            Name = "Google"
                        },
                        new
                        {
                            Id = new Guid("5efc910b-2f45-43df-afae-620d40542853"),
                            Introduction = "Fubao Company",
                            Name = "Alipapa"
                        },
                        new
                        {
                            Id = new Guid("bbdee09c-089b-4d30-bece-44df59237100"),
                            Introduction = "From Shenzhen",
                            Name = "Tencent"
                        },
                        new
                        {
                            Id = new Guid("6fb600c1-9011-4fd7-9234-881379716400"),
                            Introduction = "From Beijing",
                            Name = "Baidu"
                        },
                        new
                        {
                            Id = new Guid("5efc910b-2f45-43df-afae-620d40542800"),
                            Introduction = "Photoshop?",
                            Name = "Adobe"
                        },
                        new
                        {
                            Id = new Guid("bbdee09c-089b-4d30-bece-44df59237111"),
                            Introduction = "Wow",
                            Name = "SpaceX"
                        },
                        new
                        {
                            Id = new Guid("6fb600c1-9011-4fd7-9234-881379716411"),
                            Introduction = "Football Club",
                            Name = "AC Milan"
                        },
                        new
                        {
                            Id = new Guid("5efc910b-2f45-43df-afae-620d40542811"),
                            Introduction = "From Jiangsu",
                            Name = "Suning"
                        },
                        new
                        {
                            Id = new Guid("bbdee09c-089b-4d30-bece-44df59237122"),
                            Introduction = "Blocked",
                            Name = "Twitter"
                        },
                        new
                        {
                            Id = new Guid("6fb600c1-9011-4fd7-9234-881379716422"),
                            Introduction = "Blocked",
                            Name = "Youtube"
                        },
                        new
                        {
                            Id = new Guid("5efc910b-2f45-43df-afae-620d40542822"),
                            Introduction = "- -",
                            Name = "360"
                        },
                        new
                        {
                            Id = new Guid("bbdee09c-089b-4d30-bece-44df59237133"),
                            Introduction = "Brothers",
                            Name = "Jingdong"
                        },
                        new
                        {
                            Id = new Guid("6fb600c1-9011-4fd7-9234-881379716433"),
                            Introduction = "Music?",
                            Name = "NetEase"
                        },
                        new
                        {
                            Id = new Guid("5efc910b-2f45-43df-afae-620d40542833"),
                            Introduction = "Store",
                            Name = "Amazon"
                        },
                        new
                        {
                            Id = new Guid("bbdee09c-089b-4d30-bece-44df59237144"),
                            Introduction = "Not Exists?",
                            Name = "AOL"
                        },
                        new
                        {
                            Id = new Guid("6fb600c1-9011-4fd7-9234-881379716444"),
                            Introduction = "Who?",
                            Name = "Yahoo"
                        },
                        new
                        {
                            Id = new Guid("5efc910b-2f45-43df-afae-620d40542844"),
                            Introduction = "Is it a company?",
                            Name = "Firefox"
                        });
                });

            modelBuilder.Entity("Routine.Api.Entities.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmployeeNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("T_Employees");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4b501cb3-d168-4cc0-b375-48fb33f318a4"),
                            CompanyId = new Guid("bbdee09c-089b-4d30-bece-44df5923716c"),
                            DateOfBirth = new DateTime(1976, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "MSFT231",
                            FirstName = "Nick",
                            Gender = 1,
                            LastName = "Carter"
                        },
                        new
                        {
                            Id = new Guid("7eaa532c-1be5-472c-a738-94fd26e5fad6"),
                            CompanyId = new Guid("bbdee09c-089b-4d30-bece-44df5923716c"),
                            DateOfBirth = new DateTime(1981, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "MSFT245",
                            FirstName = "Vince",
                            Gender = 1,
                            LastName = "Carter"
                        },
                        new
                        {
                            Id = new Guid("72457e73-ea34-4e02-b575-8d384e82a481"),
                            CompanyId = new Guid("6fb600c1-9011-4fd7-9234-881379716440"),
                            DateOfBirth = new DateTime(1986, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "G003",
                            FirstName = "Mary",
                            Gender = 2,
                            LastName = "King"
                        },
                        new
                        {
                            Id = new Guid("7644b71d-d74e-43e2-ac32-8cbadd7b1c3a"),
                            CompanyId = new Guid("6fb600c1-9011-4fd7-9234-881379716440"),
                            DateOfBirth = new DateTime(1977, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "G097",
                            FirstName = "Kevin",
                            Gender = 1,
                            LastName = "Richardson"
                        },
                        new
                        {
                            Id = new Guid("679dfd33-32e4-4393-b061-f7abb8956f53"),
                            CompanyId = new Guid("5efc910b-2f45-43df-afae-620d40542853"),
                            DateOfBirth = new DateTime(1967, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "A009",
                            FirstName = "卡",
                            Gender = 2,
                            LastName = "里"
                        },
                        new
                        {
                            Id = new Guid("1861341e-b42b-410c-ae21-cf11f36fc574"),
                            CompanyId = new Guid("5efc910b-2f45-43df-afae-620d40542853"),
                            DateOfBirth = new DateTime(1957, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "A404",
                            FirstName = "Not",
                            Gender = 1,
                            LastName = "Man"
                        });
                });

            modelBuilder.Entity("Routine.Api.Entities.Employee", b =>
                {
                    b.HasOne("Routine.Api.Entities.Company", "Company")
                        .WithMany("Employees")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
