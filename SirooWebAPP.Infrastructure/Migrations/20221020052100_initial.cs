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
                    { new Guid("8554827f-796a-4fce-ae55-26f155829700"), "سامسونگ", null, new Guid("ca162cc3-51c1-44cf-a83c-02c822282faa"), new DateTime(2022, 10, 15, 8, 51, 0, 335, DateTimeKind.Local).AddTicks(1750), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, false, null, false, null, null, 2, "uploads/2022/9/1582619178545.jpg", null, new Guid("8124f9b8-e75b-4cbb-92a1-bb1e9ee63b9b"), 100, 100, 4 },
                    { new Guid("88fd8e05-deca-4ee7-a53f-e67e8e5c5221"), "دیجی کالا", null, new Guid("ca162cc3-51c1-44cf-a83c-02c822282faa"), new DateTime(2022, 10, 17, 8, 51, 0, 335, DateTimeKind.Local).AddTicks(1767), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, false, null, false, null, null, 2, "uploads/2022/9/1-36433-1.jpg", null, new Guid("ca162cc3-51c1-44cf-a83c-02c822282faa"), 100, 100, 4 },
                    { new Guid("95479692-4be4-4af6-9a6c-c403fe557fb6"), "کیش کدپولو", null, new Guid("ca162cc3-51c1-44cf-a83c-02c822282faa"), new DateTime(2022, 10, 19, 8, 51, 0, 335, DateTimeKind.Local).AddTicks(1703), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, false, null, true, null, null, 4, "uploads/2022/9/1-56192-4_6008031941360618419.MP4", null, new Guid("ca162cc3-51c1-44cf-a83c-02c822282faa"), 100, 100, 4 },
                    { new Guid("e53f380e-2333-48b3-b8e7-4b5ddcba2827"), "ال جی", null, new Guid("ca162cc3-51c1-44cf-a83c-02c822282faa"), new DateTime(2022, 10, 18, 8, 51, 0, 335, DateTimeKind.Local).AddTicks(1729), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, false, null, false, null, null, 2, "uploads/2022/9/1-53754-1.mp4_snapshot_01.04_[2022.05.26_09.50.52].jpg", null, new Guid("fe373b20-1e35-4f3a-91ce-7218c0549747"), 100, 100, 4 }
                });

            migrationBuilder.InsertData(
                table: "ConstantDictionaries",
                columns: new[] { "Id", "ConstantKey", "ConstantValue", "Created", "CreatedBy", "Description", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[,]
                {
                    { new Guid("02e24a6c-18d3-41b4-a88b-5b7fd58c51d7"), "store_point_usage_per_day", "2", new DateTime(2022, 10, 20, 8, 51, 0, 335, DateTimeKind.Local).AddTicks(2003), new Guid("ca162cc3-51c1-44cf-a83c-02c822282faa"), "تعداد دفعات استفاده از کارت تخفیف هر مغازه در روز برای یک مشتری", true, false, null, null },
                    { new Guid("12902c8e-a57b-45ec-99cb-772c5f5559af"), "def_points_for_image_like", "2", new DateTime(2022, 10, 20, 8, 51, 0, 335, DateTimeKind.Local).AddTicks(2036), new Guid("ca162cc3-51c1-44cf-a83c-02c822282faa"), "امتیاز پیش فرض برای لایک پست تصویری", true, false, null, null },
                    { new Guid("46e88c0b-0219-43f9-8491-889e3de33220"), "credit_for_client_registration_by_store_invitation", "50", new DateTime(2022, 10, 20, 8, 51, 0, 335, DateTimeKind.Local).AddTicks(2025), new Guid("ca162cc3-51c1-44cf-a83c-02c822282faa"), "اعتبار برای فروشنده ای که باعث ثبت نام مشتری شد", true, false, null, null },
                    { new Guid("803bfaa0-64a2-45d1-9da0-0b984867f611"), "credit_for_image_ads", "500", new DateTime(2022, 10, 20, 8, 51, 0, 335, DateTimeKind.Local).AddTicks(2018), new Guid("ca162cc3-51c1-44cf-a83c-02c822282faa"), "اعتبار لازم برای ثبت آگهی تصویری", true, false, null, null },
                    { new Guid("99575b7b-17cf-49e1-adeb-be3bc3200325"), "def_points_for_video_like", "4", new DateTime(2022, 10, 20, 8, 51, 0, 335, DateTimeKind.Local).AddTicks(2043), new Guid("ca162cc3-51c1-44cf-a83c-02c822282faa"), "امتیاز پیش فرض برای لایک پست ویدئویی", true, false, null, null },
                    { new Guid("ad1453d2-b579-4844-a23f-fee47b0b8af5"), "def_points_for_client_registration", "100", new DateTime(2022, 10, 20, 8, 51, 0, 335, DateTimeKind.Local).AddTicks(2029), new Guid("ca162cc3-51c1-44cf-a83c-02c822282faa"), "اعتبار برای فروشنده ای که باعث ثبت نام مشتری شد", true, false, null, null },
                    { new Guid("af0f9def-4f1d-4e2d-ab42-95cd04a121d9"), "def_points_for_client_invitation", "50", new DateTime(2022, 10, 20, 8, 51, 0, 335, DateTimeKind.Local).AddTicks(2033), new Guid("ca162cc3-51c1-44cf-a83c-02c822282faa"), "اعتبار برای فروشنده ای که باعث ثبت نام مشتری شد", true, false, null, null },
                    { new Guid("b2a85b4d-6c9a-4c0a-8814-978cd2f6c4e7"), "money_to_credit_ratio", "50", new DateTime(2022, 10, 20, 8, 51, 0, 335, DateTimeKind.Local).AddTicks(2014), new Guid("ca162cc3-51c1-44cf-a83c-02c822282faa"), "نسبت هر اعتبار به تومان", true, false, null, null },
                    { new Guid("dfd2c2b1-ddb9-4833-9457-94d4e71ce4ae"), "store_def_credit_reg", "1000", new DateTime(2022, 10, 20, 8, 51, 0, 335, DateTimeKind.Local).AddTicks(1997), new Guid("ca162cc3-51c1-44cf-a83c-02c822282faa"), "اعتبار اولیه فروشگاه برای ثبت نام اولین بار", true, false, null, null },
                    { new Guid("e7f61c79-0b38-4f49-8ccd-5e3bc2b624bc"), "credit_for_video_ads", "1000", new DateTime(2022, 10, 20, 8, 51, 0, 335, DateTimeKind.Local).AddTicks(2022), new Guid("ca162cc3-51c1-44cf-a83c-02c822282faa"), "اعتبار لازم برای ثبت آگهی ویدئویی", true, false, null, null },
                    { new Guid("f389ca28-6d19-4d00-9706-862e0f985118"), "stores_max_donnation_point", "500", new DateTime(2022, 10, 20, 8, 51, 0, 335, DateTimeKind.Local).AddTicks(2011), new Guid("ca162cc3-51c1-44cf-a83c-02c822282faa"), "حداکثر امتیازی که فروشگاه میتواند در هر نوتب هدیه بدهد", true, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "DonnationTickets",
                columns: new[] { "Id", "Created", "Donner", "IsCredit", "IsDeleted", "LastModified", "LastModifiedBy", "RemainedCapacity", "Value" },
                values: new object[,]
                {
                    { new Guid("0a505646-daac-4e09-a48e-0606773b783b"), null, new Guid("e4e8afa1-aa4d-4308-9259-2c192f142fdf"), false, false, null, null, 2, 150L },
                    { new Guid("ee7cfe30-26ae-40f3-a7eb-88d455724b2e"), null, new Guid("e4e8afa1-aa4d-4308-9259-2c192f142fdf"), false, false, null, null, 5, 100L }
                });

            migrationBuilder.InsertData(
                table: "Draws",
                columns: new[] { "Id", "Created", "CreatedBy", "EndDate", "IsActivated", "IsDeleted", "IsFinished", "IsLottery", "LastModified", "LastModifiedBy", "Name", "Owner", "StartDate" },
                values: new object[,]
                {
                    { new Guid("941b90fd-1307-4f68-99d9-f559a47d7f99"), new DateTime(2022, 10, 20, 8, 51, 0, 335, DateTimeKind.Local).AddTicks(1805), new Guid("ca162cc3-51c1-44cf-a83c-02c822282faa"), new DateTime(2022, 10, 10, 8, 51, 0, 335, DateTimeKind.Local).AddTicks(1809), true, false, true, false, null, null, "شهریور 1401", new Guid("fe373b20-1e35-4f3a-91ce-7218c0549747"), new DateTime(2022, 9, 20, 8, 51, 0, 335, DateTimeKind.Local).AddTicks(1807) },
                    { new Guid("a51e528a-5cb4-49e7-bc7d-f3393c6696fb"), new DateTime(2022, 10, 20, 8, 51, 0, 335, DateTimeKind.Local).AddTicks(1787), new Guid("ca162cc3-51c1-44cf-a83c-02c822282faa"), new DateTime(2022, 11, 4, 8, 51, 0, 335, DateTimeKind.Local).AddTicks(1792), true, false, false, false, null, null, "آبان 1401", new Guid("ca162cc3-51c1-44cf-a83c-02c822282faa"), new DateTime(2022, 10, 20, 8, 51, 0, 335, DateTimeKind.Local).AddTicks(1790) },
                    { new Guid("d9a783ba-b9da-4875-a9ae-9a9e9782bca6"), new DateTime(2022, 10, 20, 8, 51, 0, 335, DateTimeKind.Local).AddTicks(1798), new Guid("ca162cc3-51c1-44cf-a83c-02c822282faa"), new DateTime(2022, 12, 19, 8, 51, 0, 335, DateTimeKind.Local).AddTicks(1801), true, false, false, false, null, null, "اذر 1401", new Guid("8124f9b8-e75b-4cbb-92a1-bb1e9ee63b9b"), new DateTime(2022, 11, 19, 8, 51, 0, 335, DateTimeKind.Local).AddTicks(1799) }
                });

            migrationBuilder.InsertData(
                table: "Prizes",
                columns: new[] { "Id", "Created", "CreatedBy", "Draw", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Name", "Priority", "WinnerCount" },
                values: new object[,]
                {
                    { new Guid("0406188c-85f8-48cf-9baf-5d06e1a20941"), new DateTime(2022, 10, 20, 8, 51, 0, 335, DateTimeKind.Local).AddTicks(1861), new Guid("ca162cc3-51c1-44cf-a83c-02c822282faa"), new Guid("a51e528a-5cb4-49e7-bc7d-f3393c6696fb"), true, false, null, null, "100 هزار تومان", 1, 2 },
                    { new Guid("38389164-e940-41ac-8b3a-b73c21f2cc27"), new DateTime(2022, 10, 20, 8, 51, 0, 335, DateTimeKind.Local).AddTicks(1960), new Guid("ca162cc3-51c1-44cf-a83c-02c822282faa"), new Guid("941b90fd-1307-4f68-99d9-f559a47d7f99"), true, false, null, null, "10 میلیون تومان", 1, 10 },
                    { new Guid("53db1e93-4a80-4861-8170-84072bbccf51"), new DateTime(2022, 10, 20, 8, 51, 0, 335, DateTimeKind.Local).AddTicks(1916), new Guid("ca162cc3-51c1-44cf-a83c-02c822282faa"), new Guid("d9a783ba-b9da-4875-a9ae-9a9e9782bca6"), true, false, null, null, "1 میلیون تومان", 1, 10 },
                    { new Guid("5e781853-684c-4d3d-a24a-9e015317278e"), new DateTime(2022, 10, 20, 8, 51, 0, 335, DateTimeKind.Local).AddTicks(1920), new Guid("ca162cc3-51c1-44cf-a83c-02c822282faa"), new Guid("d9a783ba-b9da-4875-a9ae-9a9e9782bca6"), true, false, null, null, "500 هزار تومان", 2, 15 },
                    { new Guid("a6f115ca-ad41-4c91-9c61-d69ec23f862a"), new DateTime(2022, 10, 20, 8, 51, 0, 335, DateTimeKind.Local).AddTicks(1964), new Guid("ca162cc3-51c1-44cf-a83c-02c822282faa"), new Guid("941b90fd-1307-4f68-99d9-f559a47d7f99"), true, false, null, null, "500 هزار تومان", 2, 15 },
                    { new Guid("ad9ea84e-83b3-4b5e-bd1d-c2e4e5791c07"), new DateTime(2022, 10, 20, 8, 51, 0, 335, DateTimeKind.Local).AddTicks(1910), new Guid("ca162cc3-51c1-44cf-a83c-02c822282faa"), new Guid("d9a783ba-b9da-4875-a9ae-9a9e9782bca6"), true, false, null, null, "2 میلیون تومان", 0, 5 },
                    { new Guid("dab6218c-cf0d-4390-8bfd-8999eca4d9b2"), new DateTime(2022, 10, 20, 8, 51, 0, 335, DateTimeKind.Local).AddTicks(1865), new Guid("ca162cc3-51c1-44cf-a83c-02c822282faa"), new Guid("a51e528a-5cb4-49e7-bc7d-f3393c6696fb"), true, false, null, null, "50 هزار تومان", 2, 3 },
                    { new Guid("dc2d895f-4f6f-43fc-83e4-581fe7672b6b"), new DateTime(2022, 10, 20, 8, 51, 0, 335, DateTimeKind.Local).AddTicks(1954), new Guid("ca162cc3-51c1-44cf-a83c-02c822282faa"), new Guid("941b90fd-1307-4f68-99d9-f559a47d7f99"), true, false, null, null, "20 میلیون تومان", 0, 5 },
                    { new Guid("ee0abd9b-4b69-4b24-a2c5-4f891ebf6a6c"), new DateTime(2022, 10, 20, 8, 51, 0, 335, DateTimeKind.Local).AddTicks(1855), new Guid("ca162cc3-51c1-44cf-a83c-02c822282faa"), new Guid("a51e528a-5cb4-49e7-bc7d-f3393c6696fb"), true, false, null, null, "200 هزار تومان", 0, 1 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Priority", "RoleDescription", "RoleName" },
                values: new object[,]
                {
                    { new Guid("41e696ff-85f8-4fb4-9b77-b9ae7f1d7882"), null, null, true, false, null, null, 0, "مدیر کل", "super" },
                    { new Guid("8e0299f9-b3a1-4494-91e5-b37f8728e41e"), null, null, true, false, null, null, 1, "مدیر سامانه", "admin" },
                    { new Guid("be8c8551-e0a3-44a8-9fc1-c8933b223bd6"), null, null, true, false, null, null, 5, "مشتری", "client" },
                    { new Guid("cbd817f2-78e5-41d0-a627-19f37d7961bf"), null, null, true, false, null, null, 2, "مدیر منطقه", "zoneadmin" },
                    { new Guid("f3e35f4b-74bc-456e-834e-bbae92613d33"), null, null, true, false, null, null, 4, "فروشگاه", "store" },
                    { new Guid("fd7f615e-0236-47af-b733-ebee7082d5f7"), null, null, true, false, null, null, 3, "بازاریاب", "marketer" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Cellphone", "ConfirmationCode", "Created", "Credits", "DefaultCredit", "DonnationActive", "Family", "Inviter", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Money", "Name", "Points", "ProfileMediaURL", "Username" },
                values: new object[,]
                {
                    { new Guid("5c67ab41-61a2-4494-a80b-9e1283122860"), "09111291908", null, new DateTime(2022, 10, 20, 8, 51, 0, 335, DateTimeKind.Local).AddTicks(1314), 0L, 0L, false, "سرپرست", null, true, false, null, null, 0L, "رجبعلی", 30L, "uploads/2022/9/photo.jpg", "haji" },
                    { new Guid("6b554d9f-3807-4104-9ed8-5d557c9eaa2d"), "09112281237", null, new DateTime(2022, 10, 20, 8, 51, 0, 335, DateTimeKind.Local).AddTicks(1303), 0L, 0L, false, "سرپرست", null, true, false, null, null, 0L, "عبداله", 60L, "uploads/2022/9/photo.jpg", "abdolah" },
                    { new Guid("8124f9b8-e75b-4cbb-92a1-bb1e9ee63b9b"), "09161234567", null, new DateTime(2022, 10, 20, 8, 51, 0, 335, DateTimeKind.Local).AddTicks(1299), 0L, 0L, false, "احمدی", new Guid("e4e8afa1-aa4d-4308-9259-2c192f142fdf"), true, false, null, null, 0L, "سامان", 70L, "uploads/2022/9/photo.jpg", "saman" },
                    { new Guid("a268e24f-5e5d-4204-a3c0-c115cc7e3ea9"), "09181616196", null, new DateTime(2022, 10, 20, 8, 51, 0, 335, DateTimeKind.Local).AddTicks(1311), 0L, 0L, false, "سرپرست", null, true, false, null, null, 0L, "مریم", 40L, "uploads/2022/9/photo.jpg", "pari" },
                    { new Guid("b15e4c22-4fe8-4bc0-a569-60da0163cc9b"), "09181650151", null, new DateTime(2022, 10, 20, 8, 51, 0, 335, DateTimeKind.Local).AddTicks(1307), 0L, 0L, false, "شفایی", null, true, false, null, null, 0L, "امیر", 50L, "uploads/2022/9/photo.jpg", "amirsh" },
                    { new Guid("ca162cc3-51c1-44cf-a83c-02c822282faa"), "09394125130", null, new DateTime(2022, 10, 20, 8, 51, 0, 335, DateTimeKind.Local).AddTicks(1290), 0L, 0L, false, "Jouybari", new Guid("e4e8afa1-aa4d-4308-9259-2c192f142fdf"), true, false, null, null, 0L, "Sina", 90L, "uploads/2022/9/sina2.jpg", "sinful" },
                    { new Guid("e4e8afa1-aa4d-4308-9259-2c192f142fdf"), "09901069557", null, new DateTime(2022, 10, 20, 8, 51, 0, 335, DateTimeKind.Local).AddTicks(1231), 1000L, 0L, true, "دابویی مشک آبادی", null, true, false, null, null, 0L, "عبدالرحمن", 100L, "uploads/2022/9/photo.jpg", "dabooei" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Cellphone", "ConfirmationCode", "Created", "Credits", "DefaultCredit", "DonnationActive", "Family", "Inviter", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Money", "Name", "Points", "ProfileMediaURL", "Username" },
                values: new object[] { new Guid("fe373b20-1e35-4f3a-91ce-7218c0549747"), "09111769591", null, new DateTime(2022, 10, 20, 8, 51, 0, 335, DateTimeKind.Local).AddTicks(1294), 0L, 0L, false, "پردلان", new Guid("e4e8afa1-aa4d-4308-9259-2c192f142fdf"), true, false, null, null, 0L, "محسن", 80L, "uploads/2022/9/99.jpg", "vinona" });

            migrationBuilder.InsertData(
                table: "UsersRoles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "Role", "User" },
                values: new object[,]
                {
                    { new Guid("2378379c-697f-4873-8aec-8a3d0473a111"), null, new Guid("ca162cc3-51c1-44cf-a83c-02c822282faa"), false, null, null, new Guid("fd7f615e-0236-47af-b733-ebee7082d5f7"), new Guid("8124f9b8-e75b-4cbb-92a1-bb1e9ee63b9b") },
                    { new Guid("291fa052-8c3c-47ae-999f-8281dd515a73"), null, new Guid("e4e8afa1-aa4d-4308-9259-2c192f142fdf"), false, null, null, new Guid("f3e35f4b-74bc-456e-834e-bbae92613d33"), new Guid("e4e8afa1-aa4d-4308-9259-2c192f142fdf") },
                    { new Guid("45a53bb9-3e5e-4b47-9066-a51f27aabd02"), null, new Guid("ca162cc3-51c1-44cf-a83c-02c822282faa"), false, null, null, new Guid("cbd817f2-78e5-41d0-a627-19f37d7961bf"), new Guid("fe373b20-1e35-4f3a-91ce-7218c0549747") },
                    { new Guid("46d87348-f9a1-444c-a1c5-8db8b7273a90"), null, new Guid("6b554d9f-3807-4104-9ed8-5d557c9eaa2d"), false, null, null, new Guid("be8c8551-e0a3-44a8-9fc1-c8933b223bd6"), new Guid("b15e4c22-4fe8-4bc0-a569-60da0163cc9b") },
                    { new Guid("4b84ad5b-654f-40da-bd51-21542d93c2ec"), null, new Guid("6b554d9f-3807-4104-9ed8-5d557c9eaa2d"), false, null, null, new Guid("be8c8551-e0a3-44a8-9fc1-c8933b223bd6"), new Guid("5c67ab41-61a2-4494-a80b-9e1283122860") },
                    { new Guid("4ddc4687-66e7-4dee-ae53-b4049b0d611d"), null, new Guid("6b554d9f-3807-4104-9ed8-5d557c9eaa2d"), false, null, null, new Guid("be8c8551-e0a3-44a8-9fc1-c8933b223bd6"), new Guid("a268e24f-5e5d-4204-a3c0-c115cc7e3ea9") },
                    { new Guid("75310161-6489-4ec9-929a-6f6207233b71"), null, new Guid("ca162cc3-51c1-44cf-a83c-02c822282faa"), false, null, null, new Guid("41e696ff-85f8-4fb4-9b77-b9ae7f1d7882"), new Guid("ca162cc3-51c1-44cf-a83c-02c822282faa") },
                    { new Guid("7bb1ee79-826d-46c0-ab6f-cfe540be477e"), null, new Guid("6b554d9f-3807-4104-9ed8-5d557c9eaa2d"), false, null, null, new Guid("be8c8551-e0a3-44a8-9fc1-c8933b223bd6"), new Guid("6b554d9f-3807-4104-9ed8-5d557c9eaa2d") }
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
