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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ViewQuota = table.Column<int>(type: "int", nullable: false),
                    RemainedViewQuota = table.Column<int>(type: "int", nullable: false),
                    IsSpecial = table.Column<bool>(type: "bit", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MediaSourceURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAvtivated = table.Column<bool>(type: "bit", nullable: false),
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
                columns: new[] { "Id", "Caption", "Created", "CreatedBy", "CreationDate", "Expiracy", "IsAvtivated", "IsDeleted", "IsSpecial", "IsVideo", "LastModified", "LastModifiedBy", "LikeReward", "MediaSourceURL", "Name", "Owner", "RemainedViewQuota", "ViewQuota", "ViewReward" },
                values: new object[,]
                {
                    { new Guid("2c2e9753-977d-4bef-9c2f-696683dfec9d"), "کیش کدپولو", null, new Guid("2574f7e6-7ed4-43f2-b9f2-9f3cef39dca8"), new DateTime(2022, 10, 14, 9, 55, 27, 684, DateTimeKind.Local).AddTicks(7794), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, null, true, null, null, 200, "uploads/2022/9/1-56192-4_6008031941360618419.MP4", "کیش", new Guid("2574f7e6-7ed4-43f2-b9f2-9f3cef39dca8"), 100, 100, 4 },
                    { new Guid("47e09094-794b-4692-a5d6-50dd1f6a2cfd"), "ال جی", null, new Guid("2574f7e6-7ed4-43f2-b9f2-9f3cef39dca8"), new DateTime(2022, 10, 13, 9, 55, 27, 684, DateTimeKind.Local).AddTicks(7820), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, null, false, null, null, 20, "uploads/2022/9/1-53754-1.mp4_snapshot_01.04_[2022.05.26_09.50.52].jpg", "کیش", new Guid("6416db73-1936-4b46-bd32-cfd9f1a324a3"), 100, 100, 4 },
                    { new Guid("52005f52-f00f-4681-9db4-0d25debf5346"), "دیجی کالا", null, new Guid("2574f7e6-7ed4-43f2-b9f2-9f3cef39dca8"), new DateTime(2022, 10, 12, 9, 55, 27, 684, DateTimeKind.Local).AddTicks(7861), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, null, false, null, null, 40, "uploads/2022/9/1-36433-1.jpg", "کیش", new Guid("2574f7e6-7ed4-43f2-b9f2-9f3cef39dca8"), 100, 100, 4 },
                    { new Guid("9eb0240d-59f1-4980-8a6d-8897d75e6875"), "سامسونگ", null, new Guid("2574f7e6-7ed4-43f2-b9f2-9f3cef39dca8"), new DateTime(2022, 10, 10, 9, 55, 27, 684, DateTimeKind.Local).AddTicks(7841), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, null, false, null, null, 50, "uploads/2022/9/1582619178545.jpg", "کیش", new Guid("3092f859-4e23-4ac5-a255-c613cb6ccf32"), 100, 100, 4 }
                });

            migrationBuilder.InsertData(
                table: "ConstantDictionaries",
                columns: new[] { "Id", "ConstantKey", "ConstantValue", "Created", "CreatedBy", "Description", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[,]
                {
                    { new Guid("1caac9ee-b39c-4ac2-82c0-9c6519700045"), "def_points_for_client_invitation", "50", new DateTime(2022, 10, 15, 9, 55, 27, 684, DateTimeKind.Local).AddTicks(8119), new Guid("2574f7e6-7ed4-43f2-b9f2-9f3cef39dca8"), "اعتبار برای فروشنده ای که باعث ثبت نام مشتری شد", true, false, null, null },
                    { new Guid("2ae00f46-9a96-4e16-b329-7dc635eb58a0"), "credit_for_image_ads", "500", new DateTime(2022, 10, 15, 9, 55, 27, 684, DateTimeKind.Local).AddTicks(8104), new Guid("2574f7e6-7ed4-43f2-b9f2-9f3cef39dca8"), "اعتبار لازم برای ثبت آگهی تصویری", true, false, null, null },
                    { new Guid("30c31a83-6c3a-4a1c-9b14-b69dd6f4c463"), "stores_max_donnation_point", "500", new DateTime(2022, 10, 15, 9, 55, 27, 684, DateTimeKind.Local).AddTicks(8097), new Guid("2574f7e6-7ed4-43f2-b9f2-9f3cef39dca8"), "حداکثر امتیازی که فروشگاه میتواند در هر نوتب هدیه بدهد", true, false, null, null },
                    { new Guid("513ab043-7e1a-435a-973b-e99e089a18dc"), "store_def_credit_reg", "1000", new DateTime(2022, 10, 15, 9, 55, 27, 684, DateTimeKind.Local).AddTicks(8083), new Guid("2574f7e6-7ed4-43f2-b9f2-9f3cef39dca8"), "اعتبار اولیه فروشگاه برای ثبت نام اولین بار", true, false, null, null },
                    { new Guid("54b8decf-5750-4221-ba86-2f6cfa100735"), "money_to_credit_ratio", "50", new DateTime(2022, 10, 15, 9, 55, 27, 684, DateTimeKind.Local).AddTicks(8100), new Guid("2574f7e6-7ed4-43f2-b9f2-9f3cef39dca8"), "نسبت هر اعتبار به تومان", true, false, null, null },
                    { new Guid("805ca8a2-40dc-4347-bc91-2a89292d727b"), "store_point_usage_per_day", "2", new DateTime(2022, 10, 15, 9, 55, 27, 684, DateTimeKind.Local).AddTicks(8089), new Guid("2574f7e6-7ed4-43f2-b9f2-9f3cef39dca8"), "تعداد دفعات استفاده از کارت تخفیف هر مغازه در روز برای یک مشتری", true, false, null, null },
                    { new Guid("83efa7e8-e01a-47ed-ba06-8ee177c92eea"), "credit_for_video_ads", "1000", new DateTime(2022, 10, 15, 9, 55, 27, 684, DateTimeKind.Local).AddTicks(8107), new Guid("2574f7e6-7ed4-43f2-b9f2-9f3cef39dca8"), "اعتبار لازم برای ثبت آگهی تصویری", true, false, null, null },
                    { new Guid("84291d78-569e-47c1-92c1-c48b6f87ad91"), "credit_for_client_registration_by_store_invitation", "50", new DateTime(2022, 10, 15, 9, 55, 27, 684, DateTimeKind.Local).AddTicks(8111), new Guid("2574f7e6-7ed4-43f2-b9f2-9f3cef39dca8"), "اعتبار برای فروشنده ای که باعث ثبت نام مشتری شد", true, false, null, null },
                    { new Guid("d1beba3b-6c79-4680-91fd-f00b03b1c16c"), "def_points_for_client_registration", "100", new DateTime(2022, 10, 15, 9, 55, 27, 684, DateTimeKind.Local).AddTicks(8115), new Guid("2574f7e6-7ed4-43f2-b9f2-9f3cef39dca8"), "اعتبار برای فروشنده ای که باعث ثبت نام مشتری شد", true, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "DonnationTickets",
                columns: new[] { "Id", "Created", "Donner", "IsCredit", "IsDeleted", "LastModified", "LastModifiedBy", "RemainedCapacity", "Value" },
                values: new object[,]
                {
                    { new Guid("1dcd3b49-7ab3-407a-8c9a-2b996f2c56a8"), null, new Guid("ce36eaac-a2f9-4225-8f39-e50e5e7be0b1"), false, false, null, null, 2, 150L },
                    { new Guid("ca3ddded-35f1-4051-ad1b-554b32e0bce6"), null, new Guid("ce36eaac-a2f9-4225-8f39-e50e5e7be0b1"), false, false, null, null, 5, 100L }
                });

            migrationBuilder.InsertData(
                table: "Draws",
                columns: new[] { "Id", "Created", "CreatedBy", "EndDate", "IsActivated", "IsDeleted", "IsFinished", "IsLottery", "LastModified", "LastModifiedBy", "Name", "Owner", "StartDate" },
                values: new object[,]
                {
                    { new Guid("52263d76-31e9-4951-b46f-743eab8ab8ed"), new DateTime(2022, 10, 15, 9, 55, 27, 684, DateTimeKind.Local).AddTicks(7869), new Guid("2574f7e6-7ed4-43f2-b9f2-9f3cef39dca8"), new DateTime(2022, 10, 30, 9, 55, 27, 684, DateTimeKind.Local).AddTicks(7874), true, false, false, false, null, null, "آبان 1401", new Guid("2574f7e6-7ed4-43f2-b9f2-9f3cef39dca8"), new DateTime(2022, 10, 15, 9, 55, 27, 684, DateTimeKind.Local).AddTicks(7872) },
                    { new Guid("5b423bb8-e2a8-4cc8-a7ef-e5e4c29c0f0b"), new DateTime(2022, 10, 15, 9, 55, 27, 684, DateTimeKind.Local).AddTicks(7878), new Guid("2574f7e6-7ed4-43f2-b9f2-9f3cef39dca8"), new DateTime(2022, 12, 14, 9, 55, 27, 684, DateTimeKind.Local).AddTicks(7883), true, false, false, false, null, null, "اذر 1401", new Guid("3092f859-4e23-4ac5-a255-c613cb6ccf32"), new DateTime(2022, 11, 14, 9, 55, 27, 684, DateTimeKind.Local).AddTicks(7880) },
                    { new Guid("e0d432e9-00d3-479f-847a-035f8165df41"), new DateTime(2022, 10, 15, 9, 55, 27, 684, DateTimeKind.Local).AddTicks(7887), new Guid("2574f7e6-7ed4-43f2-b9f2-9f3cef39dca8"), new DateTime(2022, 10, 5, 9, 55, 27, 684, DateTimeKind.Local).AddTicks(7891), true, false, true, false, null, null, "شهریور 1401", new Guid("6416db73-1936-4b46-bd32-cfd9f1a324a3"), new DateTime(2022, 9, 15, 9, 55, 27, 684, DateTimeKind.Local).AddTicks(7889) }
                });

            migrationBuilder.InsertData(
                table: "Prizes",
                columns: new[] { "Id", "Created", "CreatedBy", "Draw", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Name", "Priority", "WinnerCount" },
                values: new object[,]
                {
                    { new Guid("1742b4c4-03aa-4de5-a4ae-20f6d904d898"), new DateTime(2022, 10, 15, 9, 55, 27, 684, DateTimeKind.Local).AddTicks(8048), new Guid("2574f7e6-7ed4-43f2-b9f2-9f3cef39dca8"), new Guid("e0d432e9-00d3-479f-847a-035f8165df41"), true, false, null, null, "500 هزار تومان", 2, 15 },
                    { new Guid("4252eb5d-0ae3-48f7-824c-7962cfb38de1"), new DateTime(2022, 10, 15, 9, 55, 27, 684, DateTimeKind.Local).AddTicks(7989), new Guid("2574f7e6-7ed4-43f2-b9f2-9f3cef39dca8"), new Guid("5b423bb8-e2a8-4cc8-a7ef-e5e4c29c0f0b"), true, false, null, null, "1 میلیون تومان", 1, 10 },
                    { new Guid("5d1dcd4f-7634-4d44-91fe-c8dccdcbda70"), new DateTime(2022, 10, 15, 9, 55, 27, 684, DateTimeKind.Local).AddTicks(7993), new Guid("2574f7e6-7ed4-43f2-b9f2-9f3cef39dca8"), new Guid("5b423bb8-e2a8-4cc8-a7ef-e5e4c29c0f0b"), true, false, null, null, "500 هزار تومان", 2, 15 },
                    { new Guid("5d7503c0-1919-4db4-b9dc-d1f6b5fd4b6f"), new DateTime(2022, 10, 15, 9, 55, 27, 684, DateTimeKind.Local).AddTicks(7936), new Guid("2574f7e6-7ed4-43f2-b9f2-9f3cef39dca8"), new Guid("52263d76-31e9-4951-b46f-743eab8ab8ed"), true, false, null, null, "100 هزار تومان", 1, 2 },
                    { new Guid("6a0dabb5-fd58-4530-84d2-5b13ce050962"), new DateTime(2022, 10, 15, 9, 55, 27, 684, DateTimeKind.Local).AddTicks(7940), new Guid("2574f7e6-7ed4-43f2-b9f2-9f3cef39dca8"), new Guid("52263d76-31e9-4951-b46f-743eab8ab8ed"), true, false, null, null, "50 هزار تومان", 2, 3 },
                    { new Guid("912c0c4c-469c-42fe-b919-b4ae55616a82"), new DateTime(2022, 10, 15, 9, 55, 27, 684, DateTimeKind.Local).AddTicks(7930), new Guid("2574f7e6-7ed4-43f2-b9f2-9f3cef39dca8"), new Guid("52263d76-31e9-4951-b46f-743eab8ab8ed"), true, false, null, null, "200 هزار تومان", 0, 1 },
                    { new Guid("a01cc5e1-0a58-4231-869d-641dc7c25c4f"), new DateTime(2022, 10, 15, 9, 55, 27, 684, DateTimeKind.Local).AddTicks(8045), new Guid("2574f7e6-7ed4-43f2-b9f2-9f3cef39dca8"), new Guid("e0d432e9-00d3-479f-847a-035f8165df41"), true, false, null, null, "10 میلیون تومان", 1, 10 },
                    { new Guid("ad1dda31-902c-44cf-a530-20ca4ab23736"), new DateTime(2022, 10, 15, 9, 55, 27, 684, DateTimeKind.Local).AddTicks(7983), new Guid("2574f7e6-7ed4-43f2-b9f2-9f3cef39dca8"), new Guid("5b423bb8-e2a8-4cc8-a7ef-e5e4c29c0f0b"), true, false, null, null, "2 میلیون تومان", 0, 5 },
                    { new Guid("e1097eec-afb1-455c-925c-b1b155559bc4"), new DateTime(2022, 10, 15, 9, 55, 27, 684, DateTimeKind.Local).AddTicks(8039), new Guid("2574f7e6-7ed4-43f2-b9f2-9f3cef39dca8"), new Guid("e0d432e9-00d3-479f-847a-035f8165df41"), true, false, null, null, "20 میلیون تومان", 0, 5 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Priority", "RoleDescription", "RoleName" },
                values: new object[,]
                {
                    { new Guid("09522dbb-12d4-4ec4-97a2-3ab9db5e4a6a"), null, null, true, false, null, null, 1, "مدیر سامانه", "admin" },
                    { new Guid("2c59257d-fe22-4864-8aff-4e8b15c014ef"), null, null, true, false, null, null, 5, "مشتری", "client" },
                    { new Guid("3c753c5a-150f-49b6-8692-a7c13fe9570a"), null, null, true, false, null, null, 4, "فروشگاه", "store" },
                    { new Guid("67e0281c-e510-4c1d-9de2-620a4d79fba1"), null, null, true, false, null, null, 2, "مدیر منطقه", "zoneadmin" },
                    { new Guid("71b64d25-ea12-4e7c-bb0a-e28d6f3bcea5"), null, null, true, false, null, null, 3, "بازاریاب", "marketer" },
                    { new Guid("dd48491a-bcfd-4ff7-958b-48ccee653cf2"), null, null, true, false, null, null, 0, "مدیر کل", "super" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Cellphone", "ConfirmationCode", "Created", "Credits", "DefaultCredit", "DonnationActive", "Family", "Inviter", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Name", "Points", "ProfileMediaURL", "Username" },
                values: new object[,]
                {
                    { new Guid("2574f7e6-7ed4-43f2-b9f2-9f3cef39dca8"), "09394125130", null, new DateTime(2022, 10, 15, 9, 55, 27, 684, DateTimeKind.Local).AddTicks(7403), 0L, 0L, false, "Jouybari", new Guid("ce36eaac-a2f9-4225-8f39-e50e5e7be0b1"), true, false, null, null, "Sina", 90L, "uploads/2022/9/sina2.jpg", "sinful" },
                    { new Guid("3092f859-4e23-4ac5-a255-c613cb6ccf32"), "09163681249", null, new DateTime(2022, 10, 15, 9, 55, 27, 684, DateTimeKind.Local).AddTicks(7412), 0L, 0L, false, "یاراحمدی", new Guid("ce36eaac-a2f9-4225-8f39-e50e5e7be0b1"), true, false, null, null, "سپیده", 70L, "uploads/2022/9/photo.jpg", "sepideh" },
                    { new Guid("434cce61-0c31-4653-9eca-41550b6415ee"), "09181616196", null, new DateTime(2022, 10, 15, 9, 55, 27, 684, DateTimeKind.Local).AddTicks(7423), 0L, 0L, false, "سرپرست", null, true, false, null, null, "مریم", 40L, "uploads/2022/9/photo.jpg", "pari" },
                    { new Guid("6416db73-1936-4b46-bd32-cfd9f1a324a3"), "09111769591", null, new DateTime(2022, 10, 15, 9, 55, 27, 684, DateTimeKind.Local).AddTicks(7408), 0L, 0L, false, "پردلان", new Guid("ce36eaac-a2f9-4225-8f39-e50e5e7be0b1"), true, false, null, null, "محسن", 80L, "uploads/2022/9/99.jpg", "vinona" },
                    { new Guid("8b26076b-b379-459a-8627-750674955605"), "09181650151", null, new DateTime(2022, 10, 15, 9, 55, 27, 684, DateTimeKind.Local).AddTicks(7419), 0L, 0L, false, "شفایی", null, true, false, null, null, "امیر", 50L, "uploads/2022/9/photo.jpg", "amirsh" },
                    { new Guid("af73d71a-3c1a-4a89-acfe-5ef0858a64da"), "09112281237", null, new DateTime(2022, 10, 15, 9, 55, 27, 684, DateTimeKind.Local).AddTicks(7415), 0L, 0L, false, "سرپرست", null, true, false, null, null, "عبداله", 60L, "uploads/2022/9/photo.jpg", "abdolah" },
                    { new Guid("c5c7cdbd-f86c-449d-8da6-5953bb35b1c8"), "09111291908", null, new DateTime(2022, 10, 15, 9, 55, 27, 684, DateTimeKind.Local).AddTicks(7427), 0L, 0L, false, "سرپرست", null, true, false, null, null, "رجبعلی", 30L, "uploads/2022/9/photo.jpg", "haji" },
                    { new Guid("ce36eaac-a2f9-4225-8f39-e50e5e7be0b1"), "09901069557", null, new DateTime(2022, 10, 15, 9, 55, 27, 684, DateTimeKind.Local).AddTicks(7352), 1000L, 0L, true, "دابویی مشک آبادی", null, true, false, null, null, "عبدالرحمن", 100L, "uploads/2022/9/photo.jpg", "dabooei" }
                });

            migrationBuilder.InsertData(
                table: "UsersRoles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "Role", "User" },
                values: new object[] { new Guid("176ead21-26f1-451d-8b48-035b9af48550"), null, new Guid("2574f7e6-7ed4-43f2-b9f2-9f3cef39dca8"), false, null, null, new Guid("67e0281c-e510-4c1d-9de2-620a4d79fba1"), new Guid("6416db73-1936-4b46-bd32-cfd9f1a324a3") });

            migrationBuilder.InsertData(
                table: "UsersRoles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "Role", "User" },
                values: new object[,]
                {
                    { new Guid("218ec1d9-f8fd-48db-8ddf-43b1db3aa9af"), null, new Guid("af73d71a-3c1a-4a89-acfe-5ef0858a64da"), false, null, null, new Guid("2c59257d-fe22-4864-8aff-4e8b15c014ef"), new Guid("af73d71a-3c1a-4a89-acfe-5ef0858a64da") },
                    { new Guid("5f443118-80bb-44ff-aae3-5a32922233b1"), null, new Guid("2574f7e6-7ed4-43f2-b9f2-9f3cef39dca8"), false, null, null, new Guid("dd48491a-bcfd-4ff7-958b-48ccee653cf2"), new Guid("2574f7e6-7ed4-43f2-b9f2-9f3cef39dca8") },
                    { new Guid("765562a2-4c8d-466c-9b64-f53b1bd97575"), null, new Guid("af73d71a-3c1a-4a89-acfe-5ef0858a64da"), false, null, null, new Guid("2c59257d-fe22-4864-8aff-4e8b15c014ef"), new Guid("c5c7cdbd-f86c-449d-8da6-5953bb35b1c8") },
                    { new Guid("7f72747b-e4e4-4d62-9c0e-ac4c58e5933c"), null, new Guid("af73d71a-3c1a-4a89-acfe-5ef0858a64da"), false, null, null, new Guid("2c59257d-fe22-4864-8aff-4e8b15c014ef"), new Guid("434cce61-0c31-4653-9eca-41550b6415ee") },
                    { new Guid("89b34c5e-08b4-4bd6-8d72-0e4e71589327"), null, new Guid("af73d71a-3c1a-4a89-acfe-5ef0858a64da"), false, null, null, new Guid("2c59257d-fe22-4864-8aff-4e8b15c014ef"), new Guid("8b26076b-b379-459a-8627-750674955605") },
                    { new Guid("973819e3-5c84-4f2a-89d1-242908c6eb64"), null, new Guid("2574f7e6-7ed4-43f2-b9f2-9f3cef39dca8"), false, null, null, new Guid("71b64d25-ea12-4e7c-bb0a-e28d6f3bcea5"), new Guid("3092f859-4e23-4ac5-a255-c613cb6ccf32") },
                    { new Guid("b8fd1356-111f-49b0-a708-01ae4fe0026a"), null, new Guid("ce36eaac-a2f9-4225-8f39-e50e5e7be0b1"), false, null, null, new Guid("3c753c5a-150f-49b6-8692-a7c13fe9570a"), new Guid("ce36eaac-a2f9-4225-8f39-e50e5e7be0b1") }
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
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "UsersRoles");

            migrationBuilder.DropTable(
                name: "Viewers");
        }
    }
}
