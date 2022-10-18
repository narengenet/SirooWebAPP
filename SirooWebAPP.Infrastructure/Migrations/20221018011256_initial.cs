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
                columns: new[] { "Id", "Caption", "Created", "CreatedBy", "CreationDate", "Expiracy", "IsAvtivated", "IsDeleted", "IsRejected", "IsSpecial", "IsVideo", "LastModified", "LastModifiedBy", "LikeReward", "MediaSourceURL", "Notes", "Owner", "RemainedViewQuota", "ViewQuota", "ViewReward" },
                values: new object[,]
                {
                    { new Guid("11b02b04-794b-4446-a4bb-8597b7a9bbb9"), "ال جی", null, new Guid("144a2dc5-49da-40f6-b73c-d66141172f4b"), new DateTime(2022, 10, 16, 4, 42, 55, 959, DateTimeKind.Local).AddTicks(4380), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, false, null, false, null, null, 2, "uploads/2022/9/1-53754-1.mp4_snapshot_01.04_[2022.05.26_09.50.52].jpg", null, new Guid("d376e671-618b-436d-8495-106de378e047"), 100, 100, 4 },
                    { new Guid("21935ec1-0c8c-41c5-80ce-ade9794beea3"), "کیش کدپولو", null, new Guid("144a2dc5-49da-40f6-b73c-d66141172f4b"), new DateTime(2022, 10, 17, 4, 42, 55, 959, DateTimeKind.Local).AddTicks(4352), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, false, null, true, null, null, 4, "uploads/2022/9/1-56192-4_6008031941360618419.MP4", null, new Guid("144a2dc5-49da-40f6-b73c-d66141172f4b"), 100, 100, 4 },
                    { new Guid("8f8c349d-7728-4734-bcce-ea0f8238c14e"), "دیجی کالا", null, new Guid("144a2dc5-49da-40f6-b73c-d66141172f4b"), new DateTime(2022, 10, 15, 4, 42, 55, 959, DateTimeKind.Local).AddTicks(4424), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, false, null, false, null, null, 2, "uploads/2022/9/1-36433-1.jpg", null, new Guid("144a2dc5-49da-40f6-b73c-d66141172f4b"), 100, 100, 4 },
                    { new Guid("97709e8f-764c-4e6d-8a2d-d6c63c3aa492"), "سامسونگ", null, new Guid("144a2dc5-49da-40f6-b73c-d66141172f4b"), new DateTime(2022, 10, 13, 4, 42, 55, 959, DateTimeKind.Local).AddTicks(4404), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, false, null, false, null, null, 2, "uploads/2022/9/1582619178545.jpg", null, new Guid("ebe37a11-f6c8-4109-8e23-d780c83631f7"), 100, 100, 4 }
                });

            migrationBuilder.InsertData(
                table: "ConstantDictionaries",
                columns: new[] { "Id", "ConstantKey", "ConstantValue", "Created", "CreatedBy", "Description", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[,]
                {
                    { new Guid("27307c39-9d9c-4799-8a67-ed59dbed9fdc"), "def_points_for_image_like", "2", new DateTime(2022, 10, 18, 4, 42, 55, 959, DateTimeKind.Local).AddTicks(4715), new Guid("144a2dc5-49da-40f6-b73c-d66141172f4b"), "امتیاز پیش فرض برای لایک پست تصویری", true, false, null, null },
                    { new Guid("2c07ef70-d17a-42c5-b0f4-25d82bde351d"), "credit_for_image_ads", "500", new DateTime(2022, 10, 18, 4, 42, 55, 959, DateTimeKind.Local).AddTicks(4679), new Guid("144a2dc5-49da-40f6-b73c-d66141172f4b"), "اعتبار لازم برای ثبت آگهی تصویری", true, false, null, null },
                    { new Guid("371d3168-d5cb-4256-b94f-02d7c4481ad2"), "store_def_credit_reg", "1000", new DateTime(2022, 10, 18, 4, 42, 55, 959, DateTimeKind.Local).AddTicks(4658), new Guid("144a2dc5-49da-40f6-b73c-d66141172f4b"), "اعتبار اولیه فروشگاه برای ثبت نام اولین بار", true, false, null, null },
                    { new Guid("5b396290-7dbe-4f6f-ada4-eb83663a20b5"), "stores_max_donnation_point", "500", new DateTime(2022, 10, 18, 4, 42, 55, 959, DateTimeKind.Local).AddTicks(4672), new Guid("144a2dc5-49da-40f6-b73c-d66141172f4b"), "حداکثر امتیازی که فروشگاه میتواند در هر نوتب هدیه بدهد", true, false, null, null },
                    { new Guid("66e7846e-6ce3-4f35-a4fc-e83eeeb49c80"), "money_to_credit_ratio", "50", new DateTime(2022, 10, 18, 4, 42, 55, 959, DateTimeKind.Local).AddTicks(4675), new Guid("144a2dc5-49da-40f6-b73c-d66141172f4b"), "نسبت هر اعتبار به تومان", true, false, null, null },
                    { new Guid("8efff32d-b581-4156-becd-3cf05ab4aaae"), "store_point_usage_per_day", "2", new DateTime(2022, 10, 18, 4, 42, 55, 959, DateTimeKind.Local).AddTicks(4664), new Guid("144a2dc5-49da-40f6-b73c-d66141172f4b"), "تعداد دفعات استفاده از کارت تخفیف هر مغازه در روز برای یک مشتری", true, false, null, null },
                    { new Guid("a6510391-28e6-4c4a-b21e-f5ce62d055d3"), "credit_for_video_ads", "1000", new DateTime(2022, 10, 18, 4, 42, 55, 959, DateTimeKind.Local).AddTicks(4699), new Guid("144a2dc5-49da-40f6-b73c-d66141172f4b"), "اعتبار لازم برای ثبت آگهی ویدئویی", true, false, null, null },
                    { new Guid("b26bfa53-34d6-4f01-9471-cb31c4d878a3"), "def_points_for_video_like", "4", new DateTime(2022, 10, 18, 4, 42, 55, 959, DateTimeKind.Local).AddTicks(4721), new Guid("144a2dc5-49da-40f6-b73c-d66141172f4b"), "امتیاز پیش فرض برای لایک پست ویدئویی", true, false, null, null },
                    { new Guid("c4487ba3-91d8-4156-ab1c-0d5f52f23be6"), "def_points_for_client_registration", "100", new DateTime(2022, 10, 18, 4, 42, 55, 959, DateTimeKind.Local).AddTicks(4708), new Guid("144a2dc5-49da-40f6-b73c-d66141172f4b"), "اعتبار برای فروشنده ای که باعث ثبت نام مشتری شد", true, false, null, null },
                    { new Guid("cb497089-e57c-45f5-95d8-f6fe3511b262"), "credit_for_client_registration_by_store_invitation", "50", new DateTime(2022, 10, 18, 4, 42, 55, 959, DateTimeKind.Local).AddTicks(4703), new Guid("144a2dc5-49da-40f6-b73c-d66141172f4b"), "اعتبار برای فروشنده ای که باعث ثبت نام مشتری شد", true, false, null, null },
                    { new Guid("d0433ea0-a743-42c4-9ae1-62a892d292f3"), "def_points_for_client_invitation", "50", new DateTime(2022, 10, 18, 4, 42, 55, 959, DateTimeKind.Local).AddTicks(4711), new Guid("144a2dc5-49da-40f6-b73c-d66141172f4b"), "اعتبار برای فروشنده ای که باعث ثبت نام مشتری شد", true, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "DonnationTickets",
                columns: new[] { "Id", "Created", "Donner", "IsCredit", "IsDeleted", "LastModified", "LastModifiedBy", "RemainedCapacity", "Value" },
                values: new object[,]
                {
                    { new Guid("2ec34f68-4b1b-4941-afd0-9ea6022ffa6c"), null, new Guid("76876ce6-b0ae-48fe-9d88-92887e4b0bd7"), false, false, null, null, 5, 100L },
                    { new Guid("f56110fb-5bc3-43b4-b8e2-01895eaa3beb"), null, new Guid("76876ce6-b0ae-48fe-9d88-92887e4b0bd7"), false, false, null, null, 2, 150L }
                });

            migrationBuilder.InsertData(
                table: "Draws",
                columns: new[] { "Id", "Created", "CreatedBy", "EndDate", "IsActivated", "IsDeleted", "IsFinished", "IsLottery", "LastModified", "LastModifiedBy", "Name", "Owner", "StartDate" },
                values: new object[,]
                {
                    { new Guid("454e57ce-557b-4cf0-aafb-b05bd940bea6"), new DateTime(2022, 10, 18, 4, 42, 55, 959, DateTimeKind.Local).AddTicks(4444), new Guid("144a2dc5-49da-40f6-b73c-d66141172f4b"), new DateTime(2022, 12, 17, 4, 42, 55, 959, DateTimeKind.Local).AddTicks(4448), true, false, false, false, null, null, "اذر 1401", new Guid("ebe37a11-f6c8-4109-8e23-d780c83631f7"), new DateTime(2022, 11, 17, 4, 42, 55, 959, DateTimeKind.Local).AddTicks(4446) },
                    { new Guid("8a8e06c5-adcb-4203-a614-689d800c7cfa"), new DateTime(2022, 10, 18, 4, 42, 55, 959, DateTimeKind.Local).AddTicks(4452), new Guid("144a2dc5-49da-40f6-b73c-d66141172f4b"), new DateTime(2022, 10, 8, 4, 42, 55, 959, DateTimeKind.Local).AddTicks(4456), true, false, true, false, null, null, "شهریور 1401", new Guid("d376e671-618b-436d-8495-106de378e047"), new DateTime(2022, 9, 18, 4, 42, 55, 959, DateTimeKind.Local).AddTicks(4454) },
                    { new Guid("ccc8d380-3f96-4456-8bc9-f290f0546e83"), new DateTime(2022, 10, 18, 4, 42, 55, 959, DateTimeKind.Local).AddTicks(4435), new Guid("144a2dc5-49da-40f6-b73c-d66141172f4b"), new DateTime(2022, 11, 2, 4, 42, 55, 959, DateTimeKind.Local).AddTicks(4439), true, false, false, false, null, null, "آبان 1401", new Guid("144a2dc5-49da-40f6-b73c-d66141172f4b"), new DateTime(2022, 10, 18, 4, 42, 55, 959, DateTimeKind.Local).AddTicks(4437) }
                });

            migrationBuilder.InsertData(
                table: "Prizes",
                columns: new[] { "Id", "Created", "CreatedBy", "Draw", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Name", "Priority", "WinnerCount" },
                values: new object[,]
                {
                    { new Guid("59ce342b-fa6f-45f2-8b3c-91aac6cb906a"), new DateTime(2022, 10, 18, 4, 42, 55, 959, DateTimeKind.Local).AddTicks(4611), new Guid("144a2dc5-49da-40f6-b73c-d66141172f4b"), new Guid("8a8e06c5-adcb-4203-a614-689d800c7cfa"), true, false, null, null, "20 میلیون تومان", 0, 5 },
                    { new Guid("5eeb6c54-338d-4cf0-bfec-f9dd27aee3ad"), new DateTime(2022, 10, 18, 4, 42, 55, 959, DateTimeKind.Local).AddTicks(4617), new Guid("144a2dc5-49da-40f6-b73c-d66141172f4b"), new Guid("8a8e06c5-adcb-4203-a614-689d800c7cfa"), true, false, null, null, "10 میلیون تومان", 1, 10 },
                    { new Guid("7744e393-3fcf-4289-94fa-5b209ee49766"), new DateTime(2022, 10, 18, 4, 42, 55, 959, DateTimeKind.Local).AddTicks(4562), new Guid("144a2dc5-49da-40f6-b73c-d66141172f4b"), new Guid("454e57ce-557b-4cf0-aafb-b05bd940bea6"), true, false, null, null, "2 میلیون تومان", 0, 5 },
                    { new Guid("8f260dc2-cf4d-4e71-8d39-c7fd5018951b"), new DateTime(2022, 10, 18, 4, 42, 55, 959, DateTimeKind.Local).AddTicks(4571), new Guid("144a2dc5-49da-40f6-b73c-d66141172f4b"), new Guid("454e57ce-557b-4cf0-aafb-b05bd940bea6"), true, false, null, null, "500 هزار تومان", 2, 15 },
                    { new Guid("9c48a31b-e7a6-476c-af36-e3f02d927fa2"), new DateTime(2022, 10, 18, 4, 42, 55, 959, DateTimeKind.Local).AddTicks(4504), new Guid("144a2dc5-49da-40f6-b73c-d66141172f4b"), new Guid("ccc8d380-3f96-4456-8bc9-f290f0546e83"), true, false, null, null, "200 هزار تومان", 0, 1 },
                    { new Guid("a3c8b345-5eea-4868-9520-12f7b7a9935f"), new DateTime(2022, 10, 18, 4, 42, 55, 959, DateTimeKind.Local).AddTicks(4515), new Guid("144a2dc5-49da-40f6-b73c-d66141172f4b"), new Guid("ccc8d380-3f96-4456-8bc9-f290f0546e83"), true, false, null, null, "50 هزار تومان", 2, 3 },
                    { new Guid("aa5cf756-e7fb-4e8c-8c52-1731bc3d7317"), new DateTime(2022, 10, 18, 4, 42, 55, 959, DateTimeKind.Local).AddTicks(4568), new Guid("144a2dc5-49da-40f6-b73c-d66141172f4b"), new Guid("454e57ce-557b-4cf0-aafb-b05bd940bea6"), true, false, null, null, "1 میلیون تومان", 1, 10 },
                    { new Guid("be8cc50b-7b09-4584-b308-f43496b833a3"), new DateTime(2022, 10, 18, 4, 42, 55, 959, DateTimeKind.Local).AddTicks(4511), new Guid("144a2dc5-49da-40f6-b73c-d66141172f4b"), new Guid("ccc8d380-3f96-4456-8bc9-f290f0546e83"), true, false, null, null, "100 هزار تومان", 1, 2 },
                    { new Guid("da719fe7-b008-42f4-ab8c-1bbf65daf322"), new DateTime(2022, 10, 18, 4, 42, 55, 959, DateTimeKind.Local).AddTicks(4620), new Guid("144a2dc5-49da-40f6-b73c-d66141172f4b"), new Guid("8a8e06c5-adcb-4203-a614-689d800c7cfa"), true, false, null, null, "500 هزار تومان", 2, 15 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Priority", "RoleDescription", "RoleName" },
                values: new object[,]
                {
                    { new Guid("55903f51-54f6-4353-82d7-a7bbd760239e"), null, null, true, false, null, null, 1, "مدیر سامانه", "admin" },
                    { new Guid("82e19333-70f2-4bb4-bab7-d17082a53a61"), null, null, true, false, null, null, 4, "فروشگاه", "store" },
                    { new Guid("97989ad0-5f7d-47d5-bf6d-36795cf2f365"), null, null, true, false, null, null, 5, "مشتری", "client" },
                    { new Guid("9e643898-e1f6-4c1b-a8af-7d98631c800d"), null, null, true, false, null, null, 0, "مدیر کل", "super" },
                    { new Guid("a614c200-38fe-48d5-ad4e-cda92ace5b5b"), null, null, true, false, null, null, 2, "مدیر منطقه", "zoneadmin" },
                    { new Guid("da1f3a60-7bd7-4e80-8430-3608803409c9"), null, null, true, false, null, null, 3, "بازاریاب", "marketer" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Cellphone", "ConfirmationCode", "Created", "Credits", "DefaultCredit", "DonnationActive", "Family", "Inviter", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Name", "Points", "ProfileMediaURL", "Username" },
                values: new object[,]
                {
                    { new Guid("144a2dc5-49da-40f6-b73c-d66141172f4b"), "09394125130", null, new DateTime(2022, 10, 18, 4, 42, 55, 959, DateTimeKind.Local).AddTicks(3933), 0L, 0L, false, "Jouybari", new Guid("76876ce6-b0ae-48fe-9d88-92887e4b0bd7"), true, false, null, null, "Sina", 90L, "uploads/2022/9/sina2.jpg", "sinful" },
                    { new Guid("3f8efafb-6d52-4613-b92d-cd413af4df6c"), "09112281237", null, new DateTime(2022, 10, 18, 4, 42, 55, 959, DateTimeKind.Local).AddTicks(3946), 0L, 0L, false, "سرپرست", null, true, false, null, null, "عبداله", 60L, "uploads/2022/9/photo.jpg", "abdolah" },
                    { new Guid("58a9f7a5-ad8c-463b-a8fd-6cc0fb01c3e3"), "09181650151", null, new DateTime(2022, 10, 18, 4, 42, 55, 959, DateTimeKind.Local).AddTicks(3949), 0L, 0L, false, "شفایی", null, true, false, null, null, "امیر", 50L, "uploads/2022/9/photo.jpg", "amirsh" },
                    { new Guid("6628ae9e-2896-41e8-875b-c82cdfb6b23b"), "09181616196", null, new DateTime(2022, 10, 18, 4, 42, 55, 959, DateTimeKind.Local).AddTicks(3953), 0L, 0L, false, "سرپرست", null, true, false, null, null, "مریم", 40L, "uploads/2022/9/photo.jpg", "pari" },
                    { new Guid("76876ce6-b0ae-48fe-9d88-92887e4b0bd7"), "09901069557", null, new DateTime(2022, 10, 18, 4, 42, 55, 959, DateTimeKind.Local).AddTicks(3883), 1000L, 0L, true, "دابویی مشک آبادی", null, true, false, null, null, "عبدالرحمن", 100L, "uploads/2022/9/photo.jpg", "dabooei" },
                    { new Guid("7a13d0b7-8e27-45a0-af9b-08097c21fea9"), "09111291908", null, new DateTime(2022, 10, 18, 4, 42, 55, 959, DateTimeKind.Local).AddTicks(3958), 0L, 0L, false, "سرپرست", null, true, false, null, null, "رجبعلی", 30L, "uploads/2022/9/photo.jpg", "haji" },
                    { new Guid("d376e671-618b-436d-8495-106de378e047"), "09111769591", null, new DateTime(2022, 10, 18, 4, 42, 55, 959, DateTimeKind.Local).AddTicks(3938), 0L, 0L, false, "پردلان", new Guid("76876ce6-b0ae-48fe-9d88-92887e4b0bd7"), true, false, null, null, "محسن", 80L, "uploads/2022/9/99.jpg", "vinona" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Cellphone", "ConfirmationCode", "Created", "Credits", "DefaultCredit", "DonnationActive", "Family", "Inviter", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Name", "Points", "ProfileMediaURL", "Username" },
                values: new object[] { new Guid("ebe37a11-f6c8-4109-8e23-d780c83631f7"), "09161234567", null, new DateTime(2022, 10, 18, 4, 42, 55, 959, DateTimeKind.Local).AddTicks(3942), 0L, 0L, false, "احمدی", new Guid("76876ce6-b0ae-48fe-9d88-92887e4b0bd7"), true, false, null, null, "سامان", 70L, "uploads/2022/9/photo.jpg", "saman" });

            migrationBuilder.InsertData(
                table: "UsersRoles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "Role", "User" },
                values: new object[,]
                {
                    { new Guid("00874769-4bf3-48f8-99f8-d3b7615936ed"), null, new Guid("3f8efafb-6d52-4613-b92d-cd413af4df6c"), false, null, null, new Guid("97989ad0-5f7d-47d5-bf6d-36795cf2f365"), new Guid("7a13d0b7-8e27-45a0-af9b-08097c21fea9") },
                    { new Guid("08c3bd5b-30f1-45ad-a902-e18e9d336338"), null, new Guid("76876ce6-b0ae-48fe-9d88-92887e4b0bd7"), false, null, null, new Guid("82e19333-70f2-4bb4-bab7-d17082a53a61"), new Guid("76876ce6-b0ae-48fe-9d88-92887e4b0bd7") },
                    { new Guid("4b5d399b-82c7-4ab1-9132-4f654b57ed77"), null, new Guid("144a2dc5-49da-40f6-b73c-d66141172f4b"), false, null, null, new Guid("9e643898-e1f6-4c1b-a8af-7d98631c800d"), new Guid("144a2dc5-49da-40f6-b73c-d66141172f4b") },
                    { new Guid("650ad81b-0457-41ce-b215-5aedc306a820"), null, new Guid("144a2dc5-49da-40f6-b73c-d66141172f4b"), false, null, null, new Guid("da1f3a60-7bd7-4e80-8430-3608803409c9"), new Guid("ebe37a11-f6c8-4109-8e23-d780c83631f7") },
                    { new Guid("6d46b498-8f8a-4b2b-a7a9-d80b5fa611b6"), null, new Guid("3f8efafb-6d52-4613-b92d-cd413af4df6c"), false, null, null, new Guid("97989ad0-5f7d-47d5-bf6d-36795cf2f365"), new Guid("6628ae9e-2896-41e8-875b-c82cdfb6b23b") },
                    { new Guid("6d79c427-6029-4cd3-8911-65c379bf7cab"), null, new Guid("144a2dc5-49da-40f6-b73c-d66141172f4b"), false, null, null, new Guid("a614c200-38fe-48d5-ad4e-cda92ace5b5b"), new Guid("d376e671-618b-436d-8495-106de378e047") },
                    { new Guid("8bf0b4ce-00f6-4a63-a198-00e595a0df15"), null, new Guid("3f8efafb-6d52-4613-b92d-cd413af4df6c"), false, null, null, new Guid("97989ad0-5f7d-47d5-bf6d-36795cf2f365"), new Guid("3f8efafb-6d52-4613-b92d-cd413af4df6c") },
                    { new Guid("aac23ce0-d438-49e6-8db0-dbf88470ac4e"), null, new Guid("3f8efafb-6d52-4613-b92d-cd413af4df6c"), false, null, null, new Guid("97989ad0-5f7d-47d5-bf6d-36795cf2f365"), new Guid("58a9f7a5-ad8c-463b-a8fd-6cc0fb01c3e3") }
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
