﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SirooWebAPP.Infrastructure.Contexts;

#nullable disable

namespace SirooWebAPP.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SirooWebAPP.Core.Domain.Advertise", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Caption")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Expiracy")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsAvtivated")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsSpecial")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVideo")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LikeReward")
                        .HasColumnType("int");

                    b.Property<string>("MediaSourceURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Owner")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("RemainedViewQuota")
                        .HasColumnType("int");

                    b.Property<int>("ViewQuota")
                        .HasColumnType("int");

                    b.Property<int>("ViewReward")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Advertises");

                    b.HasData(
                        new
                        {
                            Id = new Guid("13b8a316-6373-4650-9c50-100722c17f83"),
                            Caption = "کیش کدپولو",
                            CreatedBy = new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea"),
                            CreationDate = new DateTime(2022, 10, 10, 4, 3, 58, 332, DateTimeKind.Local).AddTicks(7352),
                            Expiracy = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsAvtivated = true,
                            IsDeleted = false,
                            IsVideo = true,
                            LikeReward = 200,
                            MediaSourceURL = "uploads/2022/9/1-56192-4_6008031941360618419.MP4",
                            Name = "کیش",
                            Owner = new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea"),
                            RemainedViewQuota = 100,
                            ViewQuota = 100,
                            ViewReward = 4
                        },
                        new
                        {
                            Id = new Guid("5bd5619d-9bab-42f5-817b-19f8e0bb4f31"),
                            Caption = "ال جی",
                            CreatedBy = new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea"),
                            CreationDate = new DateTime(2022, 10, 9, 4, 3, 58, 332, DateTimeKind.Local).AddTicks(7460),
                            Expiracy = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsAvtivated = true,
                            IsDeleted = false,
                            IsVideo = false,
                            LikeReward = 20,
                            MediaSourceURL = "uploads/2022/9/1-53754-1.mp4_snapshot_01.04_[2022.05.26_09.50.52].jpg",
                            Name = "کیش",
                            Owner = new Guid("4f487c6b-61db-40ac-8db1-8bbc8e548b1c"),
                            RemainedViewQuota = 100,
                            ViewQuota = 100,
                            ViewReward = 4
                        },
                        new
                        {
                            Id = new Guid("eb503092-dca1-4125-b2d6-b80a5e80d03e"),
                            Caption = "سامسونگ",
                            CreatedBy = new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea"),
                            CreationDate = new DateTime(2022, 10, 6, 4, 3, 58, 332, DateTimeKind.Local).AddTicks(7508),
                            Expiracy = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsAvtivated = true,
                            IsDeleted = false,
                            IsVideo = false,
                            LikeReward = 50,
                            MediaSourceURL = "uploads/2022/9/1582619178545.jpg",
                            Name = "کیش",
                            Owner = new Guid("bd057cb4-c437-46d1-ad25-bc6056528452"),
                            RemainedViewQuota = 100,
                            ViewQuota = 100,
                            ViewReward = 4
                        },
                        new
                        {
                            Id = new Guid("2c6ea6de-53a8-444c-ad01-1a28597e0821"),
                            Caption = "دیجی کالا",
                            CreatedBy = new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea"),
                            CreationDate = new DateTime(2022, 10, 8, 4, 3, 58, 332, DateTimeKind.Local).AddTicks(7553),
                            Expiracy = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsAvtivated = true,
                            IsDeleted = false,
                            IsVideo = false,
                            LikeReward = 40,
                            MediaSourceURL = "uploads/2022/9/1-36433-1.jpg",
                            Name = "کیش",
                            Owner = new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea"),
                            RemainedViewQuota = 100,
                            ViewQuota = 100,
                            ViewReward = 4
                        });
                });

            modelBuilder.Entity("SirooWebAPP.Core.Domain.Draws", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActivated")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsFinished")
                        .HasColumnType("bit");

                    b.Property<bool>("IsLottery")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Owner")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Draws");

                    b.HasData(
                        new
                        {
                            Id = new Guid("aa902125-a9e6-448b-ab26-28f44c203572"),
                            Created = new DateTime(2022, 10, 11, 4, 3, 58, 332, DateTimeKind.Local).AddTicks(7596),
                            CreatedBy = new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea"),
                            EndDate = new DateTime(2022, 10, 26, 4, 3, 58, 332, DateTimeKind.Local).AddTicks(7613),
                            IsActivated = true,
                            IsDeleted = false,
                            IsFinished = false,
                            IsLottery = false,
                            Name = "آبان 1401",
                            Owner = new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea"),
                            StartDate = new DateTime(2022, 10, 11, 4, 3, 58, 332, DateTimeKind.Local).AddTicks(7610)
                        },
                        new
                        {
                            Id = new Guid("bf6a378b-ae94-45b1-b7a5-ba70ac78ea20"),
                            Created = new DateTime(2022, 10, 11, 4, 3, 58, 332, DateTimeKind.Local).AddTicks(7708),
                            CreatedBy = new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea"),
                            EndDate = new DateTime(2022, 12, 10, 4, 3, 58, 332, DateTimeKind.Local).AddTicks(7719),
                            IsActivated = true,
                            IsDeleted = false,
                            IsFinished = false,
                            IsLottery = false,
                            Name = "اذر 1401",
                            Owner = new Guid("bd057cb4-c437-46d1-ad25-bc6056528452"),
                            StartDate = new DateTime(2022, 11, 10, 4, 3, 58, 332, DateTimeKind.Local).AddTicks(7716)
                        },
                        new
                        {
                            Id = new Guid("d3df2349-565d-4624-9182-b94188ba20cd"),
                            Created = new DateTime(2022, 10, 11, 4, 3, 58, 332, DateTimeKind.Local).AddTicks(7727),
                            CreatedBy = new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea"),
                            EndDate = new DateTime(2022, 10, 1, 4, 3, 58, 332, DateTimeKind.Local).AddTicks(7734),
                            IsActivated = true,
                            IsDeleted = false,
                            IsFinished = true,
                            IsLottery = false,
                            Name = "شهریور 1401",
                            Owner = new Guid("4f487c6b-61db-40ac-8db1-8bbc8e548b1c"),
                            StartDate = new DateTime(2022, 9, 11, 4, 3, 58, 332, DateTimeKind.Local).AddTicks(7731)
                        });
                });

            modelBuilder.Entity("SirooWebAPP.Core.Domain.Likers", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Advertise")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("LikedBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Likers");
                });

            modelBuilder.Entity("SirooWebAPP.Core.Domain.OnlineUsers", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Guid")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastCheckin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("User")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserDevice")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OnlineUsers");
                });

            modelBuilder.Entity("SirooWebAPP.Core.Domain.Prizes", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Draw")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActivated")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<int>("WinnerCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Prizes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b889e207-4365-44a4-8524-aac02baa47f1"),
                            Created = new DateTime(2022, 10, 11, 4, 3, 58, 332, DateTimeKind.Local).AddTicks(7906),
                            CreatedBy = new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea"),
                            Draw = new Guid("aa902125-a9e6-448b-ab26-28f44c203572"),
                            IsActivated = true,
                            IsDeleted = false,
                            Name = "200 هزار تومان",
                            Priority = 0,
                            WinnerCount = 5
                        },
                        new
                        {
                            Id = new Guid("1531085a-adb7-4cd5-92c5-7a237194c503"),
                            Created = new DateTime(2022, 10, 11, 4, 3, 58, 332, DateTimeKind.Local).AddTicks(7936),
                            CreatedBy = new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea"),
                            Draw = new Guid("aa902125-a9e6-448b-ab26-28f44c203572"),
                            IsActivated = true,
                            IsDeleted = false,
                            Name = "100 هزار تومان",
                            Priority = 1,
                            WinnerCount = 10
                        },
                        new
                        {
                            Id = new Guid("5d78ae89-c228-467b-82fa-ee5844e400ce"),
                            Created = new DateTime(2022, 10, 11, 4, 3, 58, 332, DateTimeKind.Local).AddTicks(7947),
                            CreatedBy = new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea"),
                            Draw = new Guid("aa902125-a9e6-448b-ab26-28f44c203572"),
                            IsActivated = true,
                            IsDeleted = false,
                            Name = "50 هزار تومان",
                            Priority = 2,
                            WinnerCount = 15
                        },
                        new
                        {
                            Id = new Guid("7ff39343-9ab3-4836-8bb9-73710a18ed51"),
                            Created = new DateTime(2022, 10, 11, 4, 3, 58, 332, DateTimeKind.Local).AddTicks(8064),
                            CreatedBy = new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea"),
                            Draw = new Guid("bf6a378b-ae94-45b1-b7a5-ba70ac78ea20"),
                            IsActivated = true,
                            IsDeleted = false,
                            Name = "2 میلیون تومان",
                            Priority = 0,
                            WinnerCount = 5
                        },
                        new
                        {
                            Id = new Guid("670a25b2-e261-497a-a56a-29d2c1ae63ce"),
                            Created = new DateTime(2022, 10, 11, 4, 3, 58, 332, DateTimeKind.Local).AddTicks(8079),
                            CreatedBy = new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea"),
                            Draw = new Guid("bf6a378b-ae94-45b1-b7a5-ba70ac78ea20"),
                            IsActivated = true,
                            IsDeleted = false,
                            Name = "1 میلیون تومان",
                            Priority = 1,
                            WinnerCount = 10
                        },
                        new
                        {
                            Id = new Guid("9cc1cc33-71bb-4417-a455-0066055abf14"),
                            Created = new DateTime(2022, 10, 11, 4, 3, 58, 332, DateTimeKind.Local).AddTicks(8086),
                            CreatedBy = new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea"),
                            Draw = new Guid("bf6a378b-ae94-45b1-b7a5-ba70ac78ea20"),
                            IsActivated = true,
                            IsDeleted = false,
                            Name = "500 هزار تومان",
                            Priority = 2,
                            WinnerCount = 15
                        },
                        new
                        {
                            Id = new Guid("6caee7d2-ba38-4509-9047-429532650230"),
                            Created = new DateTime(2022, 10, 11, 4, 3, 58, 332, DateTimeKind.Local).AddTicks(8179),
                            CreatedBy = new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea"),
                            Draw = new Guid("d3df2349-565d-4624-9182-b94188ba20cd"),
                            IsActivated = true,
                            IsDeleted = false,
                            Name = "20 میلیون تومان",
                            Priority = 0,
                            WinnerCount = 5
                        },
                        new
                        {
                            Id = new Guid("0ca8eb85-1d63-44c0-9b98-968323a62ea5"),
                            Created = new DateTime(2022, 10, 11, 4, 3, 58, 332, DateTimeKind.Local).AddTicks(8191),
                            CreatedBy = new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea"),
                            Draw = new Guid("d3df2349-565d-4624-9182-b94188ba20cd"),
                            IsActivated = true,
                            IsDeleted = false,
                            Name = "10 میلیون تومان",
                            Priority = 1,
                            WinnerCount = 10
                        },
                        new
                        {
                            Id = new Guid("ce34069f-885d-4733-b5a8-6a5bbe2662f3"),
                            Created = new DateTime(2022, 10, 11, 4, 3, 58, 332, DateTimeKind.Local).AddTicks(8199),
                            CreatedBy = new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea"),
                            Draw = new Guid("d3df2349-565d-4624-9182-b94188ba20cd"),
                            IsActivated = true,
                            IsDeleted = false,
                            Name = "500 هزار تومان",
                            Priority = 2,
                            WinnerCount = 15
                        });
                });

            modelBuilder.Entity("SirooWebAPP.Core.Domain.Roles", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActivated")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<string>("RoleDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8a4a26a9-2982-4e69-816f-1b195ecaeaf7"),
                            IsActivated = true,
                            IsDeleted = false,
                            Priority = 0,
                            RoleDescription = "مدیر کل",
                            RoleName = "super"
                        },
                        new
                        {
                            Id = new Guid("07bc46d1-e0e9-4614-b72f-498179e3300b"),
                            IsActivated = true,
                            IsDeleted = false,
                            Priority = 1,
                            RoleDescription = "مدیر سامانه",
                            RoleName = "admin"
                        },
                        new
                        {
                            Id = new Guid("14d576a8-91f1-46de-9b46-2053fb040a1f"),
                            IsActivated = true,
                            IsDeleted = false,
                            Priority = 2,
                            RoleDescription = "مدیر منطقه",
                            RoleName = "zoneadmin"
                        },
                        new
                        {
                            Id = new Guid("256ac4bb-a4b6-40f8-a222-a01f46826141"),
                            IsActivated = true,
                            IsDeleted = false,
                            Priority = 3,
                            RoleDescription = "بازاریاب",
                            RoleName = "marketer"
                        },
                        new
                        {
                            Id = new Guid("8a0df3cc-2c1c-4519-b374-69d5679eabac"),
                            IsActivated = true,
                            IsDeleted = false,
                            Priority = 4,
                            RoleDescription = "فروشگاه",
                            RoleName = "store"
                        },
                        new
                        {
                            Id = new Guid("367cf5eb-75bd-49ef-81b5-4172e81f8b53"),
                            IsActivated = true,
                            IsDeleted = false,
                            Priority = 5,
                            RoleDescription = "مشتری",
                            RoleName = "client"
                        });
                });

            modelBuilder.Entity("SirooWebAPP.Core.Domain.Users", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cellphone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConfirmationCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<long>("Credits")
                        .HasColumnType("bigint");

                    b.Property<string>("Family")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("InviterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActivated")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Points")
                        .HasColumnType("bigint");

                    b.Property<string>("ProfileMediaURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("InviterId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea"),
                            Cellphone = "09394125130",
                            Credits = 0L,
                            Family = "Jouybari",
                            IsActivated = false,
                            IsDeleted = false,
                            Name = "Sina",
                            Points = 0L,
                            ProfileMediaURL = "uploads/2022/9/sina2.jpg",
                            Username = "sinful"
                        },
                        new
                        {
                            Id = new Guid("4f487c6b-61db-40ac-8db1-8bbc8e548b1c"),
                            Cellphone = "09111769591",
                            Credits = 0L,
                            Family = "پردلان",
                            IsActivated = false,
                            IsDeleted = false,
                            Name = "محسن",
                            Points = 0L,
                            ProfileMediaURL = "uploads/2022/9/99.jpg",
                            Username = "vinona"
                        },
                        new
                        {
                            Id = new Guid("bd057cb4-c437-46d1-ad25-bc6056528452"),
                            Cellphone = "09163681249",
                            Credits = 0L,
                            Family = "یاراحمدی",
                            IsActivated = false,
                            IsDeleted = false,
                            Name = "سپیده",
                            Points = 0L,
                            ProfileMediaURL = "uploads/2022/9/photo.jpg",
                            Username = "sepideh"
                        });
                });

            modelBuilder.Entity("SirooWebAPP.Core.Domain.UsersRoles", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Role")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("User")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("UsersRoles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("805b876e-7a40-4cde-8b0a-1eca9b3e0f12"),
                            CreatedBy = new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea"),
                            IsDeleted = false,
                            Role = new Guid("8a4a26a9-2982-4e69-816f-1b195ecaeaf7"),
                            User = new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea")
                        },
                        new
                        {
                            Id = new Guid("f8d1f73d-7ea8-46fd-a156-291892a87945"),
                            CreatedBy = new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea"),
                            IsDeleted = false,
                            Role = new Guid("07bc46d1-e0e9-4614-b72f-498179e3300b"),
                            User = new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea")
                        },
                        new
                        {
                            Id = new Guid("41ef6138-5272-4012-8bce-071a0077ea73"),
                            CreatedBy = new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea"),
                            IsDeleted = false,
                            Role = new Guid("256ac4bb-a4b6-40f8-a222-a01f46826141"),
                            User = new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea")
                        },
                        new
                        {
                            Id = new Guid("b46e4f33-a7b4-4b26-bd40-7d6320dfd136"),
                            CreatedBy = new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea"),
                            IsDeleted = false,
                            Role = new Guid("256ac4bb-a4b6-40f8-a222-a01f46826141"),
                            User = new Guid("bd057cb4-c437-46d1-ad25-bc6056528452")
                        },
                        new
                        {
                            Id = new Guid("2b07cc4c-2bc5-4e04-a0ff-80502e78d912"),
                            CreatedBy = new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea"),
                            IsDeleted = false,
                            Role = new Guid("14d576a8-91f1-46de-9b46-2053fb040a1f"),
                            User = new Guid("4f487c6b-61db-40ac-8db1-8bbc8e548b1c")
                        });
                });

            modelBuilder.Entity("SirooWebAPP.Core.Domain.Viewers", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Advertise")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ViewedBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Viewers");
                });

            modelBuilder.Entity("SirooWebAPP.Core.Domain.Users", b =>
                {
                    b.HasOne("SirooWebAPP.Core.Domain.Users", "Inviter")
                        .WithMany("Inviteds")
                        .HasForeignKey("InviterId");

                    b.Navigation("Inviter");
                });

            modelBuilder.Entity("SirooWebAPP.Core.Domain.Users", b =>
                {
                    b.Navigation("Inviteds");
                });
#pragma warning restore 612, 618
        }
    }
}
