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

                    b.Property<bool>("IsRejected")
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

                    b.Property<string>("Notes")
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
                });

            modelBuilder.Entity("SirooWebAPP.Core.Domain.ConstantDictionaries", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConstantKey")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConstantValue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ConstantDictionaries");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ad42e204-6c11-4840-af28-4b1a703056b6"),
                            ConstantKey = "store_def_credit_reg",
                            ConstantValue = "1000",
                            Created = new DateTime(2022, 11, 11, 12, 58, 13, 7, DateTimeKind.Local).AddTicks(2632),
                            CreatedBy = new Guid("27184628-2084-4984-9c3f-498f45cc42fd"),
                            Description = "اعتبار اولیه فروشگاه برای ثبت نام اولین بار",
                            IsActive = true,
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("ec14328f-cf58-4bec-a604-1f9341b21e34"),
                            ConstantKey = "store_point_usage_per_day",
                            ConstantValue = "2",
                            Created = new DateTime(2022, 11, 11, 12, 58, 13, 7, DateTimeKind.Local).AddTicks(2639),
                            CreatedBy = new Guid("27184628-2084-4984-9c3f-498f45cc42fd"),
                            Description = "تعداد دفعات استفاده از کارت تخفیف هر مغازه در روز برای یک مشتری",
                            IsActive = true,
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("cb3fdd10-1751-46e3-a4e0-db65d5eccd2e"),
                            ConstantKey = "stores_max_donnation_point",
                            ConstantValue = "500",
                            Created = new DateTime(2022, 11, 11, 12, 58, 13, 7, DateTimeKind.Local).AddTicks(2642),
                            CreatedBy = new Guid("27184628-2084-4984-9c3f-498f45cc42fd"),
                            Description = "حداکثر امتیازی که فروشگاه میتواند در هر نوتب هدیه بدهد",
                            IsActive = true,
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("e46c4762-42ec-49d1-ac00-bd6069fe66ae"),
                            ConstantKey = "money_to_credit_ratio",
                            ConstantValue = "500",
                            Created = new DateTime(2022, 11, 11, 12, 58, 13, 7, DateTimeKind.Local).AddTicks(2644),
                            CreatedBy = new Guid("27184628-2084-4984-9c3f-498f45cc42fd"),
                            Description = "نسبت هر اعتبار به تومان",
                            IsActive = true,
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("d4a6103d-a807-40b7-a4f2-f7f3e77d1d5a"),
                            ConstantKey = "credit_for_image_ads",
                            ConstantValue = "500",
                            Created = new DateTime(2022, 11, 11, 12, 58, 13, 7, DateTimeKind.Local).AddTicks(2647),
                            CreatedBy = new Guid("27184628-2084-4984-9c3f-498f45cc42fd"),
                            Description = "اعتبار لازم برای ثبت آگهی تصویری",
                            IsActive = true,
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("5cc3ad26-d533-4bc1-95b2-2f470f03cf8f"),
                            ConstantKey = "credit_for_video_ads",
                            ConstantValue = "1000",
                            Created = new DateTime(2022, 11, 11, 12, 58, 13, 7, DateTimeKind.Local).AddTicks(2650),
                            CreatedBy = new Guid("27184628-2084-4984-9c3f-498f45cc42fd"),
                            Description = "اعتبار لازم برای ثبت آگهی ویدئویی",
                            IsActive = true,
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("6d1ca68a-09d6-428a-9a42-93aa88a84892"),
                            ConstantKey = "credit_for_client_registration_by_store_invitation",
                            ConstantValue = "50",
                            Created = new DateTime(2022, 11, 11, 12, 58, 13, 7, DateTimeKind.Local).AddTicks(2654),
                            CreatedBy = new Guid("27184628-2084-4984-9c3f-498f45cc42fd"),
                            Description = "اعتبار برای فروشنده ای که باعث ثبت نام مشتری شد",
                            IsActive = true,
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("45d376ea-1626-4b75-bf91-4bb44b5a3faa"),
                            ConstantKey = "def_points_for_client_registration",
                            ConstantValue = "100",
                            Created = new DateTime(2022, 11, 11, 12, 58, 13, 7, DateTimeKind.Local).AddTicks(2656),
                            CreatedBy = new Guid("27184628-2084-4984-9c3f-498f45cc42fd"),
                            Description = "اعتبار برای فروشنده ای که باعث ثبت نام مشتری شد",
                            IsActive = true,
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("016cdbf9-6096-4efb-a79c-7185d4a2f0c7"),
                            ConstantKey = "def_points_for_client_invitation",
                            ConstantValue = "50",
                            Created = new DateTime(2022, 11, 11, 12, 58, 13, 7, DateTimeKind.Local).AddTicks(2659),
                            CreatedBy = new Guid("27184628-2084-4984-9c3f-498f45cc42fd"),
                            Description = "اعتبار برای فروشنده ای که باعث ثبت نام مشتری شد",
                            IsActive = true,
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("e8a4d509-c986-4f25-9d73-0b465153d477"),
                            ConstantKey = "def_points_for_image_like",
                            ConstantValue = "1",
                            Created = new DateTime(2022, 11, 11, 12, 58, 13, 7, DateTimeKind.Local).AddTicks(2662),
                            CreatedBy = new Guid("27184628-2084-4984-9c3f-498f45cc42fd"),
                            Description = "امتیاز پیش فرض برای لایک پست تصویری",
                            IsActive = true,
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("c7b33060-d8b6-46c0-a9c4-de856c65be2b"),
                            ConstantKey = "def_points_for_video_like",
                            ConstantValue = "4",
                            Created = new DateTime(2022, 11, 11, 12, 58, 13, 7, DateTimeKind.Local).AddTicks(2664),
                            CreatedBy = new Guid("27184628-2084-4984-9c3f-498f45cc42fd"),
                            Description = "امتیاز پیش فرض برای لایک پست ویدئویی",
                            IsActive = true,
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("6b6836a8-e245-4ccd-b232-bf990897bc35"),
                            ConstantKey = "def_percent_for_marketer",
                            ConstantValue = "10",
                            Created = new DateTime(2022, 11, 11, 12, 58, 13, 7, DateTimeKind.Local).AddTicks(2667),
                            CreatedBy = new Guid("27184628-2084-4984-9c3f-498f45cc42fd"),
                            Description = "درصد بازاریاب",
                            IsActive = true,
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("c9af5baf-17a9-44cc-9736-d9b91c4cabd0"),
                            ConstantKey = "def_percent_for_zoneadmin",
                            ConstantValue = "6",
                            Created = new DateTime(2022, 11, 11, 12, 58, 13, 7, DateTimeKind.Local).AddTicks(2669),
                            CreatedBy = new Guid("27184628-2084-4984-9c3f-498f45cc42fd"),
                            Description = "درصد مدیر منطقه",
                            IsActive = true,
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("a8e11c25-1603-4d61-a7b3-5919f45cbb29"),
                            ConstantKey = "def_percent_for_countryadmin",
                            ConstantValue = "4",
                            Created = new DateTime(2022, 11, 11, 12, 58, 13, 7, DateTimeKind.Local).AddTicks(2672),
                            CreatedBy = new Guid("27184628-2084-4984-9c3f-498f45cc42fd"),
                            Description = "درصد مدیر مناطق",
                            IsActive = true,
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("SirooWebAPP.Core.Domain.DonnationTickets", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Donner")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsCredit")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RemainedCapacity")
                        .HasColumnType("int");

                    b.Property<long>("Value")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("DonnationTickets");
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

            modelBuilder.Entity("SirooWebAPP.Core.Domain.PointUsages", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("DonnationTicket")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Donner")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsCredit")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsUsed")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Receiver")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("Value")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("PointUsages");
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
                });

            modelBuilder.Entity("SirooWebAPP.Core.Domain.PrizesWinners", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Draw")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Prize")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("User")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("WiningDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("WiningPoint")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("PrizesWinners");
                });

            modelBuilder.Entity("SirooWebAPP.Core.Domain.Purchases", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("MoneyPaied")
                        .HasColumnType("bigint");

                    b.Property<long>("PurchasedCredit")
                        .HasColumnType("bigint");

                    b.Property<Guid>("User")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Purchases");
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
                            Id = new Guid("4d1875cd-1e00-4c68-8b50-ef8231863df2"),
                            IsActivated = true,
                            IsDeleted = false,
                            Priority = 0,
                            RoleDescription = "مدیر کل",
                            RoleName = "super"
                        },
                        new
                        {
                            Id = new Guid("b5b4ae4d-61ff-4930-9ff0-c0849369b4a9"),
                            IsActivated = true,
                            IsDeleted = false,
                            Priority = 1,
                            RoleDescription = "مدیر سامانه",
                            RoleName = "admin"
                        },
                        new
                        {
                            Id = new Guid("2e5b1688-d6eb-409d-bb56-7801b49f27c6"),
                            IsActivated = true,
                            IsDeleted = false,
                            Priority = 2,
                            RoleDescription = "مدیر کل مناطق",
                            RoleName = "countryadmin"
                        },
                        new
                        {
                            Id = new Guid("0ce7f79b-ecba-4020-a8dc-1d88339ac983"),
                            IsActivated = true,
                            IsDeleted = false,
                            Priority = 3,
                            RoleDescription = "مدیر منطقه",
                            RoleName = "zoneadmin"
                        },
                        new
                        {
                            Id = new Guid("6d72330c-4794-4389-a698-a2d1a4a028e7"),
                            IsActivated = true,
                            IsDeleted = false,
                            Priority = 4,
                            RoleDescription = "بازاریاب",
                            RoleName = "marketer"
                        },
                        new
                        {
                            Id = new Guid("c6a95089-f535-48e5-81d1-9e2c30211395"),
                            IsActivated = true,
                            IsDeleted = false,
                            Priority = 5,
                            RoleDescription = "فروشگاه",
                            RoleName = "store"
                        },
                        new
                        {
                            Id = new Guid("fc15df1f-6ac8-41fd-b70e-7ac775a754cd"),
                            IsActivated = true,
                            IsDeleted = false,
                            Priority = 6,
                            RoleDescription = "مشتری",
                            RoleName = "client"
                        });
                });

            modelBuilder.Entity("SirooWebAPP.Core.Domain.TransactionPercents", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("FromAmount")
                        .HasColumnType("bigint");

                    b.Property<Guid>("FromUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Percentage")
                        .HasColumnType("int");

                    b.Property<string>("ReferenceID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("ToAmount")
                        .HasColumnType("bigint");

                    b.Property<Guid>("ToUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Transaction")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("TransactionPercents");
                });

            modelBuilder.Entity("SirooWebAPP.Core.Domain.Transactions", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("Amount")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSuccessfull")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReferenceID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("User")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Transactions");
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

                    b.Property<long>("DefaultCredit")
                        .HasColumnType("bigint");

                    b.Property<bool>("DonnationActive")
                        .HasColumnType("bit");

                    b.Property<string>("Family")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("Inviter")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActivated")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Money")
                        .HasColumnType("bigint");

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

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("27184628-2084-4984-9c3f-498f45cc42fd"),
                            Cellphone = "09394125130",
                            Created = new DateTime(2022, 11, 11, 12, 58, 13, 7, DateTimeKind.Local).AddTicks(2416),
                            Credits = 0L,
                            DefaultCredit = 0L,
                            DonnationActive = false,
                            Family = "Jouybari",
                            Inviter = new Guid("320022cc-c809-4a66-a32f-f9ed6e8ff015"),
                            IsActivated = true,
                            IsDeleted = false,
                            Money = 0L,
                            Name = "Sina",
                            Points = 90L,
                            ProfileMediaURL = "uploads/2022/9/sina2.jpg",
                            Username = "sinful"
                        },
                        new
                        {
                            Id = new Guid("320022cc-c809-4a66-a32f-f9ed6e8ff015"),
                            Cellphone = "09901069557",
                            Created = new DateTime(2022, 11, 11, 12, 58, 13, 7, DateTimeKind.Local).AddTicks(2372),
                            Credits = 1000L,
                            DefaultCredit = 0L,
                            DonnationActive = true,
                            Family = "دابویی مشک آبادی",
                            IsActivated = true,
                            IsDeleted = false,
                            Money = 0L,
                            Name = "عبدالرحمن",
                            Points = 100L,
                            ProfileMediaURL = "uploads/2022/9/photo.jpg",
                            Username = "dabooei"
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
                            Id = new Guid("36f347ff-2495-4409-89e8-110a26bd6a08"),
                            CreatedBy = new Guid("27184628-2084-4984-9c3f-498f45cc42fd"),
                            IsDeleted = false,
                            Role = new Guid("4d1875cd-1e00-4c68-8b50-ef8231863df2"),
                            User = new Guid("27184628-2084-4984-9c3f-498f45cc42fd")
                        },
                        new
                        {
                            Id = new Guid("9a2f37f1-a962-4c91-9be0-933dbb404700"),
                            CreatedBy = new Guid("320022cc-c809-4a66-a32f-f9ed6e8ff015"),
                            IsDeleted = false,
                            Role = new Guid("c6a95089-f535-48e5-81d1-9e2c30211395"),
                            User = new Guid("320022cc-c809-4a66-a32f-f9ed6e8ff015")
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
#pragma warning restore 612, 618
        }
    }
}
