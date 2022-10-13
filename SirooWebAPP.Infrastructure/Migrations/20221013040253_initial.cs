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
                    InviterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Users_InviterId",
                        column: x => x.InviterId,
                        principalTable: "Users",
                        principalColumn: "Id");
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
                    { new Guid("3d04c8e2-1fdb-42ec-a448-23f3e3611ce6"), "ال جی", null, new Guid("2e77d2ba-26e8-427e-9cc7-9fd3cb9400b6"), new DateTime(2022, 10, 11, 7, 32, 53, 380, DateTimeKind.Local).AddTicks(6249), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, null, false, null, null, 20, "uploads/2022/9/1-53754-1.mp4_snapshot_01.04_[2022.05.26_09.50.52].jpg", "کیش", new Guid("3b10c724-e40e-4f39-b2a0-964107407c53"), 100, 100, 4 },
                    { new Guid("5df8e82b-6e54-49f3-ae6f-14c9d8b974de"), "دیجی کالا", null, new Guid("2e77d2ba-26e8-427e-9cc7-9fd3cb9400b6"), new DateTime(2022, 10, 10, 7, 32, 53, 380, DateTimeKind.Local).AddTicks(6294), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, null, false, null, null, 40, "uploads/2022/9/1-36433-1.jpg", "کیش", new Guid("2e77d2ba-26e8-427e-9cc7-9fd3cb9400b6"), 100, 100, 4 },
                    { new Guid("a87ff3dc-a649-4339-a973-a2ba4fdfa560"), "کیش کدپولو", null, new Guid("2e77d2ba-26e8-427e-9cc7-9fd3cb9400b6"), new DateTime(2022, 10, 12, 7, 32, 53, 380, DateTimeKind.Local).AddTicks(6183), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, null, true, null, null, 200, "uploads/2022/9/1-56192-4_6008031941360618419.MP4", "کیش", new Guid("2e77d2ba-26e8-427e-9cc7-9fd3cb9400b6"), 100, 100, 4 },
                    { new Guid("ca9653ec-d028-4f92-a7f8-0a6891ee3f71"), "سامسونگ", null, new Guid("2e77d2ba-26e8-427e-9cc7-9fd3cb9400b6"), new DateTime(2022, 10, 8, 7, 32, 53, 380, DateTimeKind.Local).AddTicks(6274), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, null, false, null, null, 50, "uploads/2022/9/1582619178545.jpg", "کیش", new Guid("334896a0-5b3b-440a-b1b4-ace618d72d65"), 100, 100, 4 }
                });

            migrationBuilder.InsertData(
                table: "ConstantDictionaries",
                columns: new[] { "Id", "ConstantKey", "ConstantValue", "Created", "CreatedBy", "Description", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[,]
                {
                    { new Guid("1ebf02e1-577f-4a21-947d-70024642c38f"), "credit_for_image_ads", "500", new DateTime(2022, 10, 13, 7, 32, 53, 380, DateTimeKind.Local).AddTicks(6568), new Guid("2e77d2ba-26e8-427e-9cc7-9fd3cb9400b6"), "اعتبار لازم برای ثبت آگهی تصویری", true, false, null, null },
                    { new Guid("599719b5-72a0-489e-b055-d920e4e78974"), "store_def_credit_reg", "1000", new DateTime(2022, 10, 13, 7, 32, 53, 380, DateTimeKind.Local).AddTicks(6548), new Guid("2e77d2ba-26e8-427e-9cc7-9fd3cb9400b6"), "اعتبار اولیه فروشگاه برای ثبت نام اولین بار", true, false, null, null },
                    { new Guid("990090e6-c650-416c-87ff-643627c6978e"), "money_to_credit_ratio", "50", new DateTime(2022, 10, 13, 7, 32, 53, 380, DateTimeKind.Local).AddTicks(6564), new Guid("2e77d2ba-26e8-427e-9cc7-9fd3cb9400b6"), "نسبت هر اعتبار به تومان", true, false, null, null },
                    { new Guid("b379c899-ed51-4fe6-b583-e8429883d850"), "stores_max_donnation_point", "500", new DateTime(2022, 10, 13, 7, 32, 53, 380, DateTimeKind.Local).AddTicks(6561), new Guid("2e77d2ba-26e8-427e-9cc7-9fd3cb9400b6"), "حداکثر امتیازی که فروشگاه میتواند در هر نوتب هدیه بدهد", true, false, null, null },
                    { new Guid("d511f518-0b2a-4e60-a928-becbec877790"), "store_point_usage_per_day", "2", new DateTime(2022, 10, 13, 7, 32, 53, 380, DateTimeKind.Local).AddTicks(6557), new Guid("2e77d2ba-26e8-427e-9cc7-9fd3cb9400b6"), "تعداد دفعات استفاده از کارت تخفیف هر مغازه در روز برای یک مشتری", true, false, null, null },
                    { new Guid("da191c84-1f35-4672-ba6f-791fdc205a74"), "credit_for_video_ads", "1000", new DateTime(2022, 10, 13, 7, 32, 53, 380, DateTimeKind.Local).AddTicks(6571), new Guid("2e77d2ba-26e8-427e-9cc7-9fd3cb9400b6"), "اعتبار لازم برای ثبت آگهی تصویری", true, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "DonnationTickets",
                columns: new[] { "Id", "Created", "Donner", "IsCredit", "IsDeleted", "LastModified", "LastModifiedBy", "RemainedCapacity", "Value" },
                values: new object[,]
                {
                    { new Guid("35f9fe3b-5dc8-4c92-9852-8256baf15578"), null, new Guid("22dfe1d0-21b8-4561-9c4b-39dc1683f0e8"), false, false, null, null, 5, 100L },
                    { new Guid("965bfc93-382c-45a9-88a9-0764cb7a242b"), null, new Guid("22dfe1d0-21b8-4561-9c4b-39dc1683f0e8"), false, false, null, null, 2, 150L }
                });

            migrationBuilder.InsertData(
                table: "Draws",
                columns: new[] { "Id", "Created", "CreatedBy", "EndDate", "IsActivated", "IsDeleted", "IsFinished", "IsLottery", "LastModified", "LastModifiedBy", "Name", "Owner", "StartDate" },
                values: new object[,]
                {
                    { new Guid("29da131d-99d7-4016-beb1-436bdebf8276"), new DateTime(2022, 10, 13, 7, 32, 53, 380, DateTimeKind.Local).AddTicks(6302), new Guid("2e77d2ba-26e8-427e-9cc7-9fd3cb9400b6"), new DateTime(2022, 10, 28, 7, 32, 53, 380, DateTimeKind.Local).AddTicks(6308), true, false, false, false, null, null, "آبان 1401", new Guid("2e77d2ba-26e8-427e-9cc7-9fd3cb9400b6"), new DateTime(2022, 10, 13, 7, 32, 53, 380, DateTimeKind.Local).AddTicks(6306) },
                    { new Guid("85bad120-b8f8-4d39-b5e3-d38ba07833e3"), new DateTime(2022, 10, 13, 7, 32, 53, 380, DateTimeKind.Local).AddTicks(6321), new Guid("2e77d2ba-26e8-427e-9cc7-9fd3cb9400b6"), new DateTime(2022, 10, 3, 7, 32, 53, 380, DateTimeKind.Local).AddTicks(6325), true, false, true, false, null, null, "شهریور 1401", new Guid("3b10c724-e40e-4f39-b2a0-964107407c53"), new DateTime(2022, 9, 13, 7, 32, 53, 380, DateTimeKind.Local).AddTicks(6323) },
                    { new Guid("925b4263-94cc-4f0a-9eee-5353d27bb8ac"), new DateTime(2022, 10, 13, 7, 32, 53, 380, DateTimeKind.Local).AddTicks(6313), new Guid("2e77d2ba-26e8-427e-9cc7-9fd3cb9400b6"), new DateTime(2022, 12, 12, 7, 32, 53, 380, DateTimeKind.Local).AddTicks(6317), true, false, false, false, null, null, "اذر 1401", new Guid("334896a0-5b3b-440a-b1b4-ace618d72d65"), new DateTime(2022, 11, 12, 7, 32, 53, 380, DateTimeKind.Local).AddTicks(6315) }
                });

            migrationBuilder.InsertData(
                table: "Prizes",
                columns: new[] { "Id", "Created", "CreatedBy", "Draw", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Name", "Priority", "WinnerCount" },
                values: new object[,]
                {
                    { new Guid("1af536e0-aa3c-4e2b-8674-e3e9142b43c7"), new DateTime(2022, 10, 13, 7, 32, 53, 380, DateTimeKind.Local).AddTicks(6375), new Guid("2e77d2ba-26e8-427e-9cc7-9fd3cb9400b6"), new Guid("29da131d-99d7-4016-beb1-436bdebf8276"), true, false, null, null, "200 هزار تومان", 0, 5 },
                    { new Guid("3fb0e5d2-d289-4e62-909d-ec1cfd259983"), new DateTime(2022, 10, 13, 7, 32, 53, 380, DateTimeKind.Local).AddTicks(6381), new Guid("2e77d2ba-26e8-427e-9cc7-9fd3cb9400b6"), new Guid("29da131d-99d7-4016-beb1-436bdebf8276"), true, false, null, null, "100 هزار تومان", 1, 10 },
                    { new Guid("52bf3de6-51fc-4324-a790-939a950e675f"), new DateTime(2022, 10, 13, 7, 32, 53, 380, DateTimeKind.Local).AddTicks(6443), new Guid("2e77d2ba-26e8-427e-9cc7-9fd3cb9400b6"), new Guid("925b4263-94cc-4f0a-9eee-5353d27bb8ac"), true, false, null, null, "2 میلیون تومان", 0, 5 },
                    { new Guid("6e8ac049-0660-45ad-ad0a-3b30a7084d2b"), new DateTime(2022, 10, 13, 7, 32, 53, 380, DateTimeKind.Local).AddTicks(6452), new Guid("2e77d2ba-26e8-427e-9cc7-9fd3cb9400b6"), new Guid("925b4263-94cc-4f0a-9eee-5353d27bb8ac"), true, false, null, null, "500 هزار تومان", 2, 15 },
                    { new Guid("78704be6-ada0-49eb-8fdf-ed446e305b65"), new DateTime(2022, 10, 13, 7, 32, 53, 380, DateTimeKind.Local).AddTicks(6448), new Guid("2e77d2ba-26e8-427e-9cc7-9fd3cb9400b6"), new Guid("925b4263-94cc-4f0a-9eee-5353d27bb8ac"), true, false, null, null, "1 میلیون تومان", 1, 10 },
                    { new Guid("8bd35768-c333-4f8f-a5af-dbd2a1aab5d6"), new DateTime(2022, 10, 13, 7, 32, 53, 380, DateTimeKind.Local).AddTicks(6503), new Guid("2e77d2ba-26e8-427e-9cc7-9fd3cb9400b6"), new Guid("85bad120-b8f8-4d39-b5e3-d38ba07833e3"), true, false, null, null, "500 هزار تومان", 2, 15 },
                    { new Guid("9f085f60-d93e-4fba-afb1-f553c8c0b9a8"), new DateTime(2022, 10, 13, 7, 32, 53, 380, DateTimeKind.Local).AddTicks(6498), new Guid("2e77d2ba-26e8-427e-9cc7-9fd3cb9400b6"), new Guid("85bad120-b8f8-4d39-b5e3-d38ba07833e3"), true, false, null, null, "10 میلیون تومان", 1, 10 },
                    { new Guid("c429000f-1485-4ebd-abb2-32a9f0d877b8"), new DateTime(2022, 10, 13, 7, 32, 53, 380, DateTimeKind.Local).AddTicks(6389), new Guid("2e77d2ba-26e8-427e-9cc7-9fd3cb9400b6"), new Guid("29da131d-99d7-4016-beb1-436bdebf8276"), true, false, null, null, "50 هزار تومان", 2, 15 },
                    { new Guid("ddb24d6c-40c2-4a21-8b12-cd10cc37383d"), new DateTime(2022, 10, 13, 7, 32, 53, 380, DateTimeKind.Local).AddTicks(6493), new Guid("2e77d2ba-26e8-427e-9cc7-9fd3cb9400b6"), new Guid("85bad120-b8f8-4d39-b5e3-d38ba07833e3"), true, false, null, null, "20 میلیون تومان", 0, 5 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Priority", "RoleDescription", "RoleName" },
                values: new object[,]
                {
                    { new Guid("1776d40f-55d2-4343-8cdb-a293a20a70b7"), null, null, true, false, null, null, 3, "بازاریاب", "marketer" },
                    { new Guid("34495bb1-04cf-4869-b552-dae2819a9d50"), null, null, true, false, null, null, 0, "مدیر کل", "super" },
                    { new Guid("5155ab09-82ce-4aa0-b9c8-ee70d6495c06"), null, null, true, false, null, null, 1, "مدیر سامانه", "admin" },
                    { new Guid("7866990e-ad6c-4713-bb20-bbc7ddb6e3b0"), null, null, true, false, null, null, 5, "مشتری", "client" },
                    { new Guid("9cd69c5f-0c5d-44fa-a69b-931780b1cb24"), null, null, true, false, null, null, 4, "فروشگاه", "store" },
                    { new Guid("c5f661e3-4675-4ae5-a983-e7a1a44693a0"), null, null, true, false, null, null, 2, "مدیر منطقه", "zoneadmin" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Cellphone", "ConfirmationCode", "Created", "Credits", "DefaultCredit", "DonnationActive", "Family", "InviterId", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Name", "Points", "ProfileMediaURL", "Username" },
                values: new object[,]
                {
                    { new Guid("22dfe1d0-21b8-4561-9c4b-39dc1683f0e8"), "09901069557", null, null, 1000L, 0L, true, "دابویی مشک آبادی", null, false, false, null, null, "عبدالرحمن", 0L, "uploads/2022/9/photo.jpg", "dabooei" },
                    { new Guid("2e77d2ba-26e8-427e-9cc7-9fd3cb9400b6"), "09394125130", null, null, 0L, 0L, false, "Jouybari", null, false, false, null, null, "Sina", 0L, "uploads/2022/9/sina2.jpg", "sinful" },
                    { new Guid("334896a0-5b3b-440a-b1b4-ace618d72d65"), "09163681249", null, null, 0L, 0L, false, "یاراحمدی", null, false, false, null, null, "سپیده", 0L, "uploads/2022/9/photo.jpg", "sepideh" },
                    { new Guid("3b10c724-e40e-4f39-b2a0-964107407c53"), "09111769591", null, null, 0L, 0L, false, "پردلان", null, false, false, null, null, "محسن", 0L, "uploads/2022/9/99.jpg", "vinona" },
                    { new Guid("b21829ff-4811-45ee-a020-5819163d04cc"), "09112281237", null, null, 0L, 0L, false, "سرپرست", null, false, false, null, null, "عبداله", 0L, "uploads/2022/9/photo.jpg", "abdolah" }
                });

            migrationBuilder.InsertData(
                table: "UsersRoles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "Role", "User" },
                values: new object[,]
                {
                    { new Guid("0a21b5bf-9930-4627-8e41-5782bf2fdbf6"), null, new Guid("2e77d2ba-26e8-427e-9cc7-9fd3cb9400b6"), false, null, null, new Guid("34495bb1-04cf-4869-b552-dae2819a9d50"), new Guid("2e77d2ba-26e8-427e-9cc7-9fd3cb9400b6") },
                    { new Guid("2708ee6d-714e-4143-acce-65807c8d767b"), null, new Guid("b21829ff-4811-45ee-a020-5819163d04cc"), false, null, null, new Guid("7866990e-ad6c-4713-bb20-bbc7ddb6e3b0"), new Guid("b21829ff-4811-45ee-a020-5819163d04cc") },
                    { new Guid("640ce3f9-ea7b-48ff-8bd7-c36bc9931f00"), null, new Guid("22dfe1d0-21b8-4561-9c4b-39dc1683f0e8"), false, null, null, new Guid("9cd69c5f-0c5d-44fa-a69b-931780b1cb24"), new Guid("22dfe1d0-21b8-4561-9c4b-39dc1683f0e8") },
                    { new Guid("a632b099-78ed-4e31-a844-3b69145af0e8"), null, new Guid("2e77d2ba-26e8-427e-9cc7-9fd3cb9400b6"), false, null, null, new Guid("c5f661e3-4675-4ae5-a983-e7a1a44693a0"), new Guid("3b10c724-e40e-4f39-b2a0-964107407c53") },
                    { new Guid("e11f922c-a332-4f75-8fa3-dfbf10bbd644"), null, new Guid("2e77d2ba-26e8-427e-9cc7-9fd3cb9400b6"), false, null, null, new Guid("1776d40f-55d2-4343-8cdb-a293a20a70b7"), new Guid("334896a0-5b3b-440a-b1b4-ace618d72d65") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_InviterId",
                table: "Users",
                column: "InviterId");
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
