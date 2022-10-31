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
                    Inviter = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                table: "Advertises",
                columns: new[] { "Id", "Caption", "Created", "CreatedBy", "CreationDate", "Expiracy", "IsAvtivated", "IsDeleted", "IsRejected", "IsSpecial", "IsVideo", "LastModified", "LastModifiedBy", "LikeReward", "MediaSourceURL", "Notes", "Owner", "RemainedViewQuota", "ViewQuota", "ViewReward" },
                values: new object[,]
                {
                    { new Guid("194a62ca-56fd-4665-884c-d69906186838"), "دیجی کالا", null, new Guid("06e3f75b-d764-412f-8438-0b290e6f432a"), new DateTime(2022, 10, 29, 1, 33, 27, 303, DateTimeKind.Local).AddTicks(7160), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, false, null, false, new DateTime(2022, 10, 29, 1, 33, 27, 303, DateTimeKind.Local).AddTicks(7163), null, 2, "uploads/2022/9/1-36433-1.jpg", null, new Guid("06e3f75b-d764-412f-8438-0b290e6f432a"), 100, 100, 4 },
                    { new Guid("9c58ce97-74c7-4bd2-a126-7c96e290ae82"), "کیش کدپولو", null, new Guid("06e3f75b-d764-412f-8438-0b290e6f432a"), new DateTime(2022, 10, 31, 1, 33, 27, 303, DateTimeKind.Local).AddTicks(7003), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, false, null, true, new DateTime(2022, 10, 31, 1, 33, 27, 303, DateTimeKind.Local).AddTicks(7009), null, 4, "uploads/2022/9/1-56192-4_6008031941360618419.MP4", null, new Guid("06e3f75b-d764-412f-8438-0b290e6f432a"), 100, 100, 4 },
                    { new Guid("b1fa41b0-07f2-4aca-be9c-e8c484daf5d8"), "ال جی", null, new Guid("06e3f75b-d764-412f-8438-0b290e6f432a"), new DateTime(2022, 10, 30, 1, 33, 27, 303, DateTimeKind.Local).AddTicks(7033), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, false, null, false, new DateTime(2022, 10, 30, 1, 33, 27, 303, DateTimeKind.Local).AddTicks(7037), null, 2, "uploads/2022/9/1-53754-1.mp4_snapshot_01.04_[2022.05.26_09.50.52].jpg", null, new Guid("c4b01545-f132-4eb5-bded-96c6a43dc356"), 100, 100, 4 },
                    { new Guid("b83008aa-5063-4dc6-b7df-8b76d3030966"), "سامسونگ", null, new Guid("06e3f75b-d764-412f-8438-0b290e6f432a"), new DateTime(2022, 10, 27, 1, 33, 27, 303, DateTimeKind.Local).AddTicks(7132), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, false, null, false, new DateTime(2022, 10, 27, 1, 33, 27, 303, DateTimeKind.Local).AddTicks(7136), null, 2, "uploads/2022/9/1582619178545.jpg", null, new Guid("9cd75091-19cd-4bc0-baca-ebf28a5ec164"), 100, 100, 4 }
                });

            migrationBuilder.InsertData(
                table: "ConstantDictionaries",
                columns: new[] { "Id", "ConstantKey", "ConstantValue", "Created", "CreatedBy", "Description", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[,]
                {
                    { new Guid("22d36727-765c-472c-a9f0-443688d6c551"), "credit_for_video_ads", "1000", new DateTime(2022, 11, 1, 1, 33, 27, 303, DateTimeKind.Local).AddTicks(7436), new Guid("06e3f75b-d764-412f-8438-0b290e6f432a"), "اعتبار لازم برای ثبت آگهی ویدئویی", true, false, null, null },
                    { new Guid("25cff73f-28a2-4d6e-897a-018e84daa367"), "store_def_credit_reg", "1000", new DateTime(2022, 11, 1, 1, 33, 27, 303, DateTimeKind.Local).AddTicks(7411), new Guid("06e3f75b-d764-412f-8438-0b290e6f432a"), "اعتبار اولیه فروشگاه برای ثبت نام اولین بار", true, false, null, null },
                    { new Guid("27247393-ee32-480e-87db-d9a0d84a2181"), "stores_max_donnation_point", "500", new DateTime(2022, 11, 1, 1, 33, 27, 303, DateTimeKind.Local).AddTicks(7425), new Guid("06e3f75b-d764-412f-8438-0b290e6f432a"), "حداکثر امتیازی که فروشگاه میتواند در هر نوتب هدیه بدهد", true, false, null, null },
                    { new Guid("2c282e21-5751-47e1-b529-c85093d58daf"), "def_points_for_client_registration", "100", new DateTime(2022, 11, 1, 1, 33, 27, 303, DateTimeKind.Local).AddTicks(7455), new Guid("06e3f75b-d764-412f-8438-0b290e6f432a"), "اعتبار برای فروشنده ای که باعث ثبت نام مشتری شد", true, false, null, null },
                    { new Guid("4a79bcbb-7a8e-4330-ac33-e7388e3e41b2"), "def_percent_for_zoneadmin", "6", new DateTime(2022, 11, 1, 1, 33, 27, 303, DateTimeKind.Local).AddTicks(7477), new Guid("06e3f75b-d764-412f-8438-0b290e6f432a"), "درصد مدیر منطقه", true, false, null, null },
                    { new Guid("6c5e4ede-6bd7-46a4-a124-edcb915cb04a"), "def_percent_for_countryadmin", "4", new DateTime(2022, 11, 1, 1, 33, 27, 303, DateTimeKind.Local).AddTicks(7481), new Guid("06e3f75b-d764-412f-8438-0b290e6f432a"), "درصد مدیر مناطق", true, false, null, null },
                    { new Guid("76caf806-12cd-4cf9-9950-848a66e2e8a4"), "def_percent_for_marketer", "10", new DateTime(2022, 11, 1, 1, 33, 27, 303, DateTimeKind.Local).AddTicks(7472), new Guid("06e3f75b-d764-412f-8438-0b290e6f432a"), "درصد بازاریاب", true, false, null, null },
                    { new Guid("788ff544-f1dc-4116-99db-5ece2eb0a7ee"), "def_points_for_image_like", "1", new DateTime(2022, 11, 1, 1, 33, 27, 303, DateTimeKind.Local).AddTicks(7465), new Guid("06e3f75b-d764-412f-8438-0b290e6f432a"), "امتیاز پیش فرض برای لایک پست تصویری", true, false, null, null },
                    { new Guid("90711c4b-3217-4dc8-95d0-07a4a0802a62"), "def_points_for_video_like", "4", new DateTime(2022, 11, 1, 1, 33, 27, 303, DateTimeKind.Local).AddTicks(7468), new Guid("06e3f75b-d764-412f-8438-0b290e6f432a"), "امتیاز پیش فرض برای لایک پست ویدئویی", true, false, null, null },
                    { new Guid("9d12f90e-510c-4f7b-ab2e-2a04ba86b4cf"), "def_points_for_client_invitation", "50", new DateTime(2022, 11, 1, 1, 33, 27, 303, DateTimeKind.Local).AddTicks(7458), new Guid("06e3f75b-d764-412f-8438-0b290e6f432a"), "اعتبار برای فروشنده ای که باعث ثبت نام مشتری شد", true, false, null, null },
                    { new Guid("9fef241c-9597-4f13-b99c-e4d7f47ea30a"), "money_to_credit_ratio", "500", new DateTime(2022, 11, 1, 1, 33, 27, 303, DateTimeKind.Local).AddTicks(7429), new Guid("06e3f75b-d764-412f-8438-0b290e6f432a"), "نسبت هر اعتبار به تومان", true, false, null, null },
                    { new Guid("b30848be-3cd3-4182-85e6-d13951d1de23"), "credit_for_client_registration_by_store_invitation", "50", new DateTime(2022, 11, 1, 1, 33, 27, 303, DateTimeKind.Local).AddTicks(7442), new Guid("06e3f75b-d764-412f-8438-0b290e6f432a"), "اعتبار برای فروشنده ای که باعث ثبت نام مشتری شد", true, false, null, null },
                    { new Guid("b81ea38b-b81b-4daa-bf6e-32d8797acb7b"), "credit_for_image_ads", "500", new DateTime(2022, 11, 1, 1, 33, 27, 303, DateTimeKind.Local).AddTicks(7432), new Guid("06e3f75b-d764-412f-8438-0b290e6f432a"), "اعتبار لازم برای ثبت آگهی تصویری", true, false, null, null },
                    { new Guid("ebdb477c-ed86-49f1-ac74-dca6bfa6ecb1"), "store_point_usage_per_day", "2", new DateTime(2022, 11, 1, 1, 33, 27, 303, DateTimeKind.Local).AddTicks(7421), new Guid("06e3f75b-d764-412f-8438-0b290e6f432a"), "تعداد دفعات استفاده از کارت تخفیف هر مغازه در روز برای یک مشتری", true, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "DonnationTickets",
                columns: new[] { "Id", "Created", "Donner", "IsCredit", "IsDeleted", "LastModified", "LastModifiedBy", "RemainedCapacity", "Value" },
                values: new object[,]
                {
                    { new Guid("2c5362c5-a90b-4a43-bc43-b975cf7bf964"), null, new Guid("10260d0c-a1ab-47ea-8883-7ec3d487b27a"), false, false, null, null, 5, 100L },
                    { new Guid("5d7ed48a-848a-4d25-99ad-fab9b0a29748"), null, new Guid("10260d0c-a1ab-47ea-8883-7ec3d487b27a"), false, false, null, null, 2, 150L }
                });

            migrationBuilder.InsertData(
                table: "Draws",
                columns: new[] { "Id", "Created", "CreatedBy", "EndDate", "IsActivated", "IsDeleted", "IsFinished", "IsLottery", "LastModified", "LastModifiedBy", "Name", "Owner", "StartDate" },
                values: new object[,]
                {
                    { new Guid("4ccf2b4e-cfde-4c5f-bc4d-7de46eab5d70"), new DateTime(2022, 11, 1, 1, 33, 27, 303, DateTimeKind.Local).AddTicks(7169), new Guid("06e3f75b-d764-412f-8438-0b290e6f432a"), new DateTime(2022, 11, 16, 1, 33, 27, 303, DateTimeKind.Local).AddTicks(7174), true, false, false, false, null, null, "آبان 1401", new Guid("06e3f75b-d764-412f-8438-0b290e6f432a"), new DateTime(2022, 11, 1, 1, 33, 27, 303, DateTimeKind.Local).AddTicks(7171) },
                    { new Guid("a82e6bf3-1b30-47a4-9aad-733df12ed1e2"), new DateTime(2022, 11, 1, 1, 33, 27, 303, DateTimeKind.Local).AddTicks(7179), new Guid("06e3f75b-d764-412f-8438-0b290e6f432a"), new DateTime(2022, 12, 31, 1, 33, 27, 303, DateTimeKind.Local).AddTicks(7183), true, false, false, false, null, null, "اذر 1401", new Guid("9cd75091-19cd-4bc0-baca-ebf28a5ec164"), new DateTime(2022, 12, 1, 1, 33, 27, 303, DateTimeKind.Local).AddTicks(7181) },
                    { new Guid("ebf1743a-45fb-4b11-8c56-190e015587e5"), new DateTime(2022, 11, 1, 1, 33, 27, 303, DateTimeKind.Local).AddTicks(7187), new Guid("06e3f75b-d764-412f-8438-0b290e6f432a"), new DateTime(2022, 10, 22, 1, 33, 27, 303, DateTimeKind.Local).AddTicks(7191), true, false, false, false, null, null, "شهریور 1401", new Guid("c4b01545-f132-4eb5-bded-96c6a43dc356"), new DateTime(2022, 10, 2, 1, 33, 27, 303, DateTimeKind.Local).AddTicks(7189) }
                });

            migrationBuilder.InsertData(
                table: "Prizes",
                columns: new[] { "Id", "Created", "CreatedBy", "Draw", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Name", "Priority", "WinnerCount" },
                values: new object[,]
                {
                    { new Guid("18c05754-b699-4639-aaa5-4ffd541fdcd8"), new DateTime(2022, 11, 1, 1, 33, 27, 303, DateTimeKind.Local).AddTicks(7340), new Guid("06e3f75b-d764-412f-8438-0b290e6f432a"), new Guid("ebf1743a-45fb-4b11-8c56-190e015587e5"), true, false, null, null, "10 میلیون تومان", 1, 10 },
                    { new Guid("2f95994f-79a0-49ed-9c5d-f319bb2872bf"), new DateTime(2022, 11, 1, 1, 33, 27, 303, DateTimeKind.Local).AddTicks(7298), new Guid("06e3f75b-d764-412f-8438-0b290e6f432a"), new Guid("a82e6bf3-1b30-47a4-9aad-733df12ed1e2"), true, false, null, null, "500 هزار تومان", 2, 15 },
                    { new Guid("3efedd2a-4bbb-480a-ad63-9bab05a875ec"), new DateTime(2022, 11, 1, 1, 33, 27, 303, DateTimeKind.Local).AddTicks(7294), new Guid("06e3f75b-d764-412f-8438-0b290e6f432a"), new Guid("a82e6bf3-1b30-47a4-9aad-733df12ed1e2"), true, false, null, null, "1 میلیون تومان", 1, 10 },
                    { new Guid("4f183d84-826b-49fb-9ba5-b0ef0525d85a"), new DateTime(2022, 11, 1, 1, 33, 27, 303, DateTimeKind.Local).AddTicks(7239), new Guid("06e3f75b-d764-412f-8438-0b290e6f432a"), new Guid("4ccf2b4e-cfde-4c5f-bc4d-7de46eab5d70"), true, false, null, null, "100 هزار تومان", 1, 2 },
                    { new Guid("56f42532-f231-41a3-ba13-929e16b76566"), new DateTime(2022, 11, 1, 1, 33, 27, 303, DateTimeKind.Local).AddTicks(7335), new Guid("06e3f75b-d764-412f-8438-0b290e6f432a"), new Guid("ebf1743a-45fb-4b11-8c56-190e015587e5"), true, false, null, null, "20 میلیون تومان", 0, 5 },
                    { new Guid("b4afeb9d-1da4-40c7-bd56-fc8945a1aaba"), new DateTime(2022, 11, 1, 1, 33, 27, 303, DateTimeKind.Local).AddTicks(7344), new Guid("06e3f75b-d764-412f-8438-0b290e6f432a"), new Guid("ebf1743a-45fb-4b11-8c56-190e015587e5"), true, false, null, null, "500 هزار تومان", 2, 15 },
                    { new Guid("b76c0920-4ac6-46b5-a306-4967200211d1"), new DateTime(2022, 11, 1, 1, 33, 27, 303, DateTimeKind.Local).AddTicks(7288), new Guid("06e3f75b-d764-412f-8438-0b290e6f432a"), new Guid("a82e6bf3-1b30-47a4-9aad-733df12ed1e2"), true, false, null, null, "2 میلیون تومان", 0, 5 },
                    { new Guid("d19e30e9-6e36-4fac-9bb6-c43a2c238d80"), new DateTime(2022, 11, 1, 1, 33, 27, 303, DateTimeKind.Local).AddTicks(7246), new Guid("06e3f75b-d764-412f-8438-0b290e6f432a"), new Guid("4ccf2b4e-cfde-4c5f-bc4d-7de46eab5d70"), true, false, null, null, "50 هزار تومان", 2, 3 },
                    { new Guid("f258a8c0-07b6-4652-97a7-8495458d33c1"), new DateTime(2022, 11, 1, 1, 33, 27, 303, DateTimeKind.Local).AddTicks(7234), new Guid("06e3f75b-d764-412f-8438-0b290e6f432a"), new Guid("4ccf2b4e-cfde-4c5f-bc4d-7de46eab5d70"), true, false, null, null, "200 هزار تومان", 0, 1 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Priority", "RoleDescription", "RoleName" },
                values: new object[,]
                {
                    { new Guid("2fe95bb5-c37e-4ba9-8bd7-33478d772acd"), null, null, true, false, null, null, 6, "مشتری", "client" },
                    { new Guid("3eb45d34-09ed-477d-afc4-b45a75b6a65f"), null, null, true, false, null, null, 0, "مدیر کل", "super" },
                    { new Guid("529fbca9-11b4-4848-860b-b55d26a5318e"), null, null, true, false, null, null, 4, "بازاریاب", "marketer" },
                    { new Guid("acb74c56-1b27-4f71-9d5b-13136feb22e9"), null, null, true, false, null, null, 1, "مدیر سامانه", "admin" },
                    { new Guid("c6a48412-7ce7-406b-917b-67989e9bec71"), null, null, true, false, null, null, 2, "مدیر کل مناطق", "countryadmin" },
                    { new Guid("d66833d6-b950-4aaa-8391-a0def902c377"), null, null, true, false, null, null, 3, "مدیر منطقه", "zoneadmin" },
                    { new Guid("e1dee1c1-47c0-44c3-9097-105888996575"), null, null, true, false, null, null, 5, "فروشگاه", "store" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Cellphone", "ConfirmationCode", "Created", "Credits", "DefaultCredit", "DonnationActive", "Family", "Inviter", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Money", "Name", "Points", "ProfileMediaURL", "Username" },
                values: new object[,]
                {
                    { new Guid("06e3f75b-d764-412f-8438-0b290e6f432a"), "09394125130", null, new DateTime(2022, 11, 1, 1, 33, 27, 303, DateTimeKind.Local).AddTicks(6305), 0L, 0L, false, "Jouybari", new Guid("10260d0c-a1ab-47ea-8883-7ec3d487b27a"), true, false, null, null, 0L, "Sina", 90L, "uploads/2022/9/sina2.jpg", "sinful" },
                    { new Guid("10260d0c-a1ab-47ea-8883-7ec3d487b27a"), "09901069557", null, new DateTime(2022, 11, 1, 1, 33, 27, 303, DateTimeKind.Local).AddTicks(6260), 1000L, 0L, true, "دابویی مشک آبادی", null, true, false, null, null, 0L, "عبدالرحمن", 100L, "uploads/2022/9/photo.jpg", "dabooei" },
                    { new Guid("17a92c6c-23b9-4dfc-b5b8-708eb4ca513f"), "09181616111", null, new DateTime(2022, 11, 1, 1, 33, 27, 303, DateTimeKind.Local).AddTicks(6329), 0L, 0L, false, "سرپرست", null, true, false, null, null, 0L, "مریم", 40L, "uploads/2022/9/photo.jpg", "pari" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Cellphone", "ConfirmationCode", "Created", "Credits", "DefaultCredit", "DonnationActive", "Family", "Inviter", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Money", "Name", "Points", "ProfileMediaURL", "Username" },
                values: new object[,]
                {
                    { new Guid("58782a64-0d6b-4d43-ad47-9aa6bb563e52"), "09181650111", null, new DateTime(2022, 11, 1, 1, 33, 27, 303, DateTimeKind.Local).AddTicks(6322), 0L, 0L, false, "شفایی", null, true, false, null, null, 0L, "امیر", 50L, "uploads/2022/9/photo.jpg", "amirsh" },
                    { new Guid("6362794d-b181-46eb-8440-a53d165f77d6"), "09111291908", null, new DateTime(2022, 11, 1, 1, 33, 27, 303, DateTimeKind.Local).AddTicks(6332), 0L, 0L, false, "سرپرست", null, true, false, null, null, 0L, "رجبعلی", 30L, "uploads/2022/9/photo.jpg", "haji" },
                    { new Guid("9cd75091-19cd-4bc0-baca-ebf28a5ec164"), "09161234567", null, new DateTime(2022, 11, 1, 1, 33, 27, 303, DateTimeKind.Local).AddTicks(6314), 0L, 0L, false, "احمدی", new Guid("10260d0c-a1ab-47ea-8883-7ec3d487b27a"), true, false, null, null, 0L, "سامان", 70L, "uploads/2022/9/photo.jpg", "saman" },
                    { new Guid("c4b01545-f132-4eb5-bded-96c6a43dc356"), "09111769591", null, new DateTime(2022, 11, 1, 1, 33, 27, 303, DateTimeKind.Local).AddTicks(6310), 0L, 0L, false, "پردلان", new Guid("10260d0c-a1ab-47ea-8883-7ec3d487b27a"), true, false, null, null, 0L, "محسن", 80L, "uploads/2022/9/99.jpg", "vinona" },
                    { new Guid("eee7a69f-debc-48a2-9250-522ef76f179a"), "09112281237", null, new DateTime(2022, 11, 1, 1, 33, 27, 303, DateTimeKind.Local).AddTicks(6317), 0L, 0L, false, "سرپرست", null, true, false, null, null, 0L, "عبداله", 60L, "uploads/2022/9/photo.jpg", "abdolah" }
                });

            migrationBuilder.InsertData(
                table: "UsersRoles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "Role", "User" },
                values: new object[,]
                {
                    { new Guid("0260ec22-04eb-45f5-bc7b-034debf6886d"), null, new Guid("10260d0c-a1ab-47ea-8883-7ec3d487b27a"), false, null, null, new Guid("e1dee1c1-47c0-44c3-9097-105888996575"), new Guid("10260d0c-a1ab-47ea-8883-7ec3d487b27a") },
                    { new Guid("2ba0fbf0-0358-4158-beb1-371b47c99353"), null, new Guid("eee7a69f-debc-48a2-9250-522ef76f179a"), false, null, null, new Guid("2fe95bb5-c37e-4ba9-8bd7-33478d772acd"), new Guid("58782a64-0d6b-4d43-ad47-9aa6bb563e52") },
                    { new Guid("322fe6a6-35f8-4cd8-947f-ec27892ab475"), null, new Guid("eee7a69f-debc-48a2-9250-522ef76f179a"), false, null, null, new Guid("2fe95bb5-c37e-4ba9-8bd7-33478d772acd"), new Guid("6362794d-b181-46eb-8440-a53d165f77d6") },
                    { new Guid("51aa47e7-ffc4-486c-9126-4f108a9356e5"), null, new Guid("06e3f75b-d764-412f-8438-0b290e6f432a"), false, null, null, new Guid("3eb45d34-09ed-477d-afc4-b45a75b6a65f"), new Guid("06e3f75b-d764-412f-8438-0b290e6f432a") },
                    { new Guid("9263f3ad-2fa8-4c49-966c-55c3b59af78d"), null, new Guid("eee7a69f-debc-48a2-9250-522ef76f179a"), false, null, null, new Guid("2fe95bb5-c37e-4ba9-8bd7-33478d772acd"), new Guid("17a92c6c-23b9-4dfc-b5b8-708eb4ca513f") },
                    { new Guid("ac6aeda5-30ae-40f6-800a-b091c491b0ee"), null, new Guid("06e3f75b-d764-412f-8438-0b290e6f432a"), false, null, null, new Guid("d66833d6-b950-4aaa-8391-a0def902c377"), new Guid("c4b01545-f132-4eb5-bded-96c6a43dc356") },
                    { new Guid("c9c503e0-16fb-4dfd-baee-e0cd2e77ea23"), null, new Guid("eee7a69f-debc-48a2-9250-522ef76f179a"), false, null, null, new Guid("2fe95bb5-c37e-4ba9-8bd7-33478d772acd"), new Guid("eee7a69f-debc-48a2-9250-522ef76f179a") },
                    { new Guid("cf902b6b-a3bb-4e39-80fd-6a3bb9c5a5de"), null, new Guid("06e3f75b-d764-412f-8438-0b290e6f432a"), false, null, null, new Guid("529fbca9-11b4-4848-860b-b55d26a5318e"), new Guid("9cd75091-19cd-4bc0-baca-ebf28a5ec164") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Advertises");

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
