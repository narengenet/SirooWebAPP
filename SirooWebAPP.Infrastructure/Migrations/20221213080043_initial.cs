using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SirooWebAPP.Infrastructure.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Advertises",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsVideo = table.Column<bool>(type: "bit", nullable: false),
                    LikeReward = table.Column<int>(type: "int", nullable: false),
                    ViewReward = table.Column<int>(type: "int", nullable: false),
                    Expiracy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Caption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ViewQuota = table.Column<int>(type: "int", nullable: false),
                    RemainedViewQuota = table.Column<int>(type: "int", nullable: false),
                    IsSpecial = table.Column<bool>(type: "bit", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MediaSourceURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAvtivated = table.Column<bool>(type: "bit", nullable: false),
                    IsRejected = table.Column<bool>(type: "bit", nullable: false),
                    Owner = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsPremium = table.Column<bool>(type: "bit", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advertises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Chips",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Points = table.Column<int>(type: "int", nullable: false),
                    UsedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SerialNumber = table.Column<long>(type: "bigint", nullable: false),
                    IsUsed = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chips", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConstantDictionaries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConstantKey = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConstantValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConstantDictionaries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DonnationTickets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Donner = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<long>(type: "bigint", nullable: false),
                    RemainedCapacity = table.Column<int>(type: "int", nullable: false),
                    IsCredit = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonnationTickets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Draws",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsLottery = table.Column<bool>(type: "bit", nullable: false),
                    Owner = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActivated = table.Column<bool>(type: "bit", nullable: false),
                    IsFinished = table.Column<bool>(type: "bit", nullable: false),
                    IsArchived = table.Column<bool>(type: "bit", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Draws", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Likers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LikedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Advertise = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Likers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OnlineUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    User = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Guid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastCheckin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserDevice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnlineUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PointUsages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Donner = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Receiver = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DonnationTicket = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsUsed = table.Column<bool>(type: "bit", nullable: false),
                    Value = table.Column<long>(type: "bigint", nullable: false),
                    IsCredit = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PointUsages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prizes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Draw = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WinnerCount = table.Column<int>(type: "int", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ValueInMoney = table.Column<long>(type: "bigint", nullable: true),
                    IsActivated = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prizes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PrizesWinners",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Prize = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    User = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Draw = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WiningPoint = table.Column<long>(type: "bigint", nullable: false),
                    WiningDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrizesWinners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Purchases",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    User = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PurchasedCredit = table.Column<long>(type: "bigint", nullable: false),
                    MoneyPaied = table.Column<long>(type: "bigint", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActivated = table.Column<bool>(type: "bit", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransactionPercents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Transaction = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReferenceID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FromUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ToUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FromAmount = table.Column<long>(type: "bigint", nullable: false),
                    ToAmount = table.Column<long>(type: "bigint", nullable: false),
                    Percentage = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionPercents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    User = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReferenceID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsSuccessfull = table.Column<bool>(type: "bit", nullable: false),
                    Amount = table.Column<long>(type: "bigint", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Family = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cellphone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActivated = table.Column<bool>(type: "bit", nullable: false),
                    ConfirmationCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Points = table.Column<long>(type: "bigint", nullable: false),
                    Credits = table.Column<long>(type: "bigint", nullable: false),
                    Money = table.Column<long>(type: "bigint", nullable: false),
                    DefaultCredit = table.Column<long>(type: "bigint", nullable: false),
                    DonnationActive = table.Column<bool>(type: "bit", nullable: false),
                    ProfileMediaURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inviter = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsersRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    User = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Role = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Viewers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ViewedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Advertise = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Viewers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ConstantDictionaries",
                columns: new[] { "Id", "ConstantKey", "ConstantValue", "Created", "CreatedBy", "Description", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[,]
                {
                    { new Guid("0125fa58-5309-4763-9c43-8d7dfde7bbde"), "points_reward_premium_video_ads", "200", new DateTime(2022, 12, 13, 11, 30, 43, 265, DateTimeKind.Local).AddTicks(293), new Guid("9ec28035-7fa7-41b3-8d2b-c3f7d3560f43"), "امتیاز ثبت آگهی تبلیغاتی ویدئویی", true, false, null, null },
                    { new Guid("1702bdd6-8f59-432d-a12b-79614c69a32d"), "points_reward_premium_image_ads", "40", new DateTime(2022, 12, 13, 11, 30, 43, 265, DateTimeKind.Local).AddTicks(298), new Guid("9ec28035-7fa7-41b3-8d2b-c3f7d3560f43"), "امتیاز ثبت آگهی تبلیغاتی تصویری", true, false, null, null },
                    { new Guid("1ee0f13c-a238-44c0-9a0a-0a878ac5af7e"), "def_percent_for_countryadmin", "4", new DateTime(2022, 12, 13, 11, 30, 43, 265, DateTimeKind.Local).AddTicks(278), new Guid("9ec28035-7fa7-41b3-8d2b-c3f7d3560f43"), "درصد مدیر مناطق", true, false, null, null },
                    { new Guid("3a3241e3-db15-43c2-acff-749fedffa3be"), "def_chips_usage_perday", "-1", new DateTime(2022, 12, 13, 11, 30, 43, 265, DateTimeKind.Local).AddTicks(282), new Guid("9ec28035-7fa7-41b3-8d2b-c3f7d3560f43"), "تعداد استفاده از کارت اعتباری هر کاربر در روز", true, false, null, null },
                    { new Guid("3ae448bb-1f0d-46a5-be26-12fc74f5ab5f"), "def_points_for_client_invitation", "50", new DateTime(2022, 12, 13, 11, 30, 43, 265, DateTimeKind.Local).AddTicks(255), new Guid("9ec28035-7fa7-41b3-8d2b-c3f7d3560f43"), "امتیاز برای معرف وقتی کاربر ثبت نام کرد.", true, false, null, null },
                    { new Guid("3beb9862-166e-4acb-aa3b-b8908c9cd32f"), "def_points_for_image_like", "1", new DateTime(2022, 12, 13, 11, 30, 43, 265, DateTimeKind.Local).AddTicks(259), new Guid("9ec28035-7fa7-41b3-8d2b-c3f7d3560f43"), "امتیاز پیش فرض برای لایک پست تصویری", true, false, null, null },
                    { new Guid("43e1add8-e753-482e-a145-b49a19944db5"), "def_money_to_premium_video_ads", "200000", new DateTime(2022, 12, 13, 11, 30, 43, 265, DateTimeKind.Local).AddTicks(286), new Guid("9ec28035-7fa7-41b3-8d2b-c3f7d3560f43"), "هزینه درج آگهی تبلیغاتی ویدئویی", true, false, null, null },
                    { new Guid("5add833c-da99-4146-a1d6-e851637fd4c5"), "credit_for_video_ads", "1000", new DateTime(2022, 12, 13, 11, 30, 43, 265, DateTimeKind.Local).AddTicks(241), new Guid("9ec28035-7fa7-41b3-8d2b-c3f7d3560f43"), "اعتبار لازم برای ثبت آگهی ویدئویی", true, false, null, null },
                    { new Guid("65a8ae3c-1259-4404-8375-a42a2d72da43"), "credit_for_client_registration_by_store_invitation", "50", new DateTime(2022, 12, 13, 11, 30, 43, 265, DateTimeKind.Local).AddTicks(245), new Guid("9ec28035-7fa7-41b3-8d2b-c3f7d3560f43"), "اعتبار برای فروشنده ای که باعث ثبت نام مشتری شد", true, false, null, null },
                    { new Guid("6d0d929d-6ea5-419c-b400-4ade3b156711"), "def_points_for_client_registration", "100", new DateTime(2022, 12, 13, 11, 30, 43, 265, DateTimeKind.Local).AddTicks(251), new Guid("9ec28035-7fa7-41b3-8d2b-c3f7d3560f43"), "امتیاز اولیه برای کاربری که ثبت نام میکند.", true, false, null, null },
                    { new Guid("72b15093-d902-42d2-aee8-3b5a4799661d"), "store_def_credit_reg", "1000", new DateTime(2022, 12, 13, 11, 30, 43, 265, DateTimeKind.Local).AddTicks(214), new Guid("9ec28035-7fa7-41b3-8d2b-c3f7d3560f43"), "اعتبار اولیه فروشگاه برای ثبت نام اولین بار", true, false, null, null },
                    { new Guid("76fbe472-4d0a-4d4a-a4e0-4da990ef4fd7"), "credit_for_image_ads", "500", new DateTime(2022, 12, 13, 11, 30, 43, 265, DateTimeKind.Local).AddTicks(238), new Guid("9ec28035-7fa7-41b3-8d2b-c3f7d3560f43"), "اعتبار لازم برای ثبت آگهی تصویری", true, false, null, null },
                    { new Guid("840ccb2b-2533-41c9-be0a-ba078364bc69"), "store_point_usage_per_day", "2", new DateTime(2022, 12, 13, 11, 30, 43, 265, DateTimeKind.Local).AddTicks(222), new Guid("9ec28035-7fa7-41b3-8d2b-c3f7d3560f43"), "تعداد دفعات استفاده از کارت تخفیف هر مغازه در روز برای یک مشتری", true, false, null, null },
                    { new Guid("b3047694-1c4f-41e7-b7ab-e05a7ad4637c"), "stores_max_donnation_point", "500", new DateTime(2022, 12, 13, 11, 30, 43, 265, DateTimeKind.Local).AddTicks(225), new Guid("9ec28035-7fa7-41b3-8d2b-c3f7d3560f43"), "حداکثر امتیازی که فروشگاه میتواند در هر نوتب هدیه بدهد", true, false, null, null },
                    { new Guid("c0af89dd-bbad-46f1-81da-4804d8f82ec3"), "def_percent_for_marketer", "10", new DateTime(2022, 12, 13, 11, 30, 43, 265, DateTimeKind.Local).AddTicks(270), new Guid("9ec28035-7fa7-41b3-8d2b-c3f7d3560f43"), "درصد بازاریاب", true, false, null, null },
                    { new Guid("c9b3e007-daf8-49f2-8ac5-d996ea05a498"), "money_to_credit_ratio", "500", new DateTime(2022, 12, 13, 11, 30, 43, 265, DateTimeKind.Local).AddTicks(233), new Guid("9ec28035-7fa7-41b3-8d2b-c3f7d3560f43"), "نسبت هر اعتبار به تومان", true, false, null, null },
                    { new Guid("e0cf4707-ebb3-4dbf-9ea2-2e4cdbde9776"), "def_points_for_video_like", "4", new DateTime(2022, 12, 13, 11, 30, 43, 265, DateTimeKind.Local).AddTicks(263), new Guid("9ec28035-7fa7-41b3-8d2b-c3f7d3560f43"), "امتیاز پیش فرض برای لایک پست ویدئویی", true, false, null, null },
                    { new Guid("f0946f23-fa22-4d0a-96fd-7d5be10706c1"), "def_money_to_premium_image_ads", "50000", new DateTime(2022, 12, 13, 11, 30, 43, 265, DateTimeKind.Local).AddTicks(289), new Guid("9ec28035-7fa7-41b3-8d2b-c3f7d3560f43"), "هزینه درج آگهی تبلیغاتی تصویری", true, false, null, null },
                    { new Guid("fe19f649-ce4d-43aa-87c7-76e29d8ed478"), "def_percent_for_zoneadmin", "6", new DateTime(2022, 12, 13, 11, 30, 43, 265, DateTimeKind.Local).AddTicks(274), new Guid("9ec28035-7fa7-41b3-8d2b-c3f7d3560f43"), "درصد مدیر منطقه", true, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Priority", "RoleDescription", "RoleName" },
                values: new object[,]
                {
                    { new Guid("415f36a4-ac02-4667-8703-ef5b98f067ec"), null, null, true, false, null, null, 3, "مدیر منطقه", "zoneadmin" },
                    { new Guid("456b8f5d-62ff-4d17-bba8-5a47077df3ea"), null, null, true, false, null, null, 5, "فروشگاه", "store" },
                    { new Guid("5d43f998-0c4e-486f-b9a6-6be4b38eca60"), null, null, true, false, null, null, 6, "مشتری", "client" },
                    { new Guid("6f8b857f-5c71-40b6-8dae-47850fee1ed7"), null, null, true, false, null, null, 1, "مدیر سامانه", "admin" },
                    { new Guid("98fe0c64-bb7a-42de-af9c-e94153a9ef20"), null, null, true, false, null, null, 0, "مدیر کل", "super" },
                    { new Guid("a4d6a7fc-91d6-498a-b981-a7196da47a2b"), null, null, true, false, null, null, 2, "مدیر کل مناطق", "countryadmin" },
                    { new Guid("ae3de154-0352-4817-a0e1-7e4ee1a7f513"), null, null, true, false, null, null, 4, "بازاریاب", "marketer" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CardNumber", "Cellphone", "ConfirmationCode", "Created", "Credits", "DefaultCredit", "DonnationActive", "Family", "Inviter", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Money", "Name", "Notes", "Points", "ProfileMediaURL", "Username" },
                values: new object[,]
                {
                    { new Guid("9a608b90-fcfc-4a3d-ab48-27220ccff404"), null, "09901069557", null, new DateTime(2022, 12, 13, 11, 30, 43, 264, DateTimeKind.Local).AddTicks(9848), 1000L, 0L, true, "دابویی مشک آبادی", null, true, false, null, null, 0L, "عبدالرحمن", null, 100L, "uploads/2022/9/photo.jpg", "dabooei" },
                    { new Guid("9ec28035-7fa7-41b3-8d2b-c3f7d3560f43"), null, "09394125130", "111111", new DateTime(2022, 12, 13, 11, 30, 43, 264, DateTimeKind.Local).AddTicks(9891), 0L, 0L, false, "Jouybari", new Guid("9a608b90-fcfc-4a3d-ab48-27220ccff404"), true, false, null, null, 850000L, "Sina", null, 90L, "uploads/2022/9/sina2.jpg", "sinful" }
                });

            migrationBuilder.InsertData(
                table: "UsersRoles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "Role", "User" },
                values: new object[,]
                {
                    { new Guid("404a4f1d-c8c9-4a65-a572-a663a1eaa083"), null, new Guid("9a608b90-fcfc-4a3d-ab48-27220ccff404"), false, null, null, new Guid("456b8f5d-62ff-4d17-bba8-5a47077df3ea"), new Guid("9a608b90-fcfc-4a3d-ab48-27220ccff404") },
                    { new Guid("a6de3459-090d-4258-ac00-454aacfea87b"), null, new Guid("9ec28035-7fa7-41b3-8d2b-c3f7d3560f43"), false, null, null, new Guid("98fe0c64-bb7a-42de-af9c-e94153a9ef20"), new Guid("9ec28035-7fa7-41b3-8d2b-c3f7d3560f43") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Advertises");

            migrationBuilder.DropTable(
                name: "Chips");

            migrationBuilder.DropTable(
                name: "ConstantDictionaries");

            migrationBuilder.DropTable(
                name: "DonnationTickets");

            migrationBuilder.DropTable(
                name: "Draws");

            migrationBuilder.DropTable(
                name: "Likers");

            migrationBuilder.DropTable(
                name: "OnlineUsers");

            migrationBuilder.DropTable(
                name: "PointUsages");

            migrationBuilder.DropTable(
                name: "Prizes");

            migrationBuilder.DropTable(
                name: "PrizesWinners");

            migrationBuilder.DropTable(
                name: "Purchases");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "TransactionPercents");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "UsersRoles");

            migrationBuilder.DropTable(
                name: "Viewers");
        }
    }
}
