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
                    ConstantSecondValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PriorityIndex = table.Column<int>(type: "int", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FromUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TheMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    ReplyMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsReplied = table.Column<bool>(type: "bit", nullable: false),
                    ReadDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReplyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DiamondUsages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    User = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DiamondsWon = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiamondUsages", x => x.Id);
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
                    Diamonds = table.Column<int>(type: "int", nullable: true),
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
                columns: new[] { "Id", "Category", "ConstantKey", "ConstantSecondValue", "ConstantValue", "Created", "CreatedBy", "Description", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "PriorityIndex" },
                values: new object[,]
                {
                    { new Guid("003a32c1-8f29-44a8-8eb4-ecbfc562945e"), "آگهی تبلیغاتی", "points_reward_premium_video_ads", null, "200", new DateTime(2022, 12, 29, 17, 37, 44, 322, DateTimeKind.Local).AddTicks(4310), new Guid("96d241b2-5ad1-45ba-990c-f643554eddc5"), "امتیاز ثبت آگهی تبلیغاتی ویدئویی", true, false, null, null, 12 },
                    { new Guid("15e7ffb2-1bfb-40a0-8091-92928378e4c2"), "ثبت نام", "def_points_for_client_registration", null, "100", new DateTime(2022, 12, 29, 17, 37, 44, 322, DateTimeKind.Local).AddTicks(4323), new Guid("96d241b2-5ad1-45ba-990c-f643554eddc5"), "امتیاز اولیه برای کاربری که ثبت نام میکند.", true, false, null, null, 17 },
                    { new Guid("1cf5a59e-aeee-4f67-a59d-bd82bcad8830"), "فروشگاه", "stores_max_donnation_point", null, "500", new DateTime(2022, 12, 29, 17, 37, 44, 322, DateTimeKind.Local).AddTicks(4336), new Guid("96d241b2-5ad1-45ba-990c-f643554eddc5"), "حداکثر امتیازی که فروشگاه میتواند در هر نوتب هدیه بدهد", true, false, null, null, 21 },
                    { new Guid("1f4da612-f4b8-43a8-a0b7-a2225f3a3ff4"), "اعتبار", "credit_for_video_ads", null, "1000", new DateTime(2022, 12, 29, 17, 37, 44, 322, DateTimeKind.Local).AddTicks(4361), new Guid("96d241b2-5ad1-45ba-990c-f643554eddc5"), "اعتبار لازم برای ثبت آگهی ویدئویی", true, false, null, null, 28 },
                    { new Guid("214a9c75-d494-4b2f-9eb0-c0a54a995716"), "درصدها", "def_percent_for_zoneadmin", null, "6", new DateTime(2022, 12, 29, 17, 37, 44, 322, DateTimeKind.Local).AddTicks(4352), new Guid("96d241b2-5ad1-45ba-990c-f643554eddc5"), "درصد مدیر منطقه", true, false, null, null, 25 },
                    { new Guid("2aec862b-8da8-402e-b453-50c4e6f8451c"), "گردونه", "min_points_to_spin_diamond_wheel", null, "200", new DateTime(2022, 12, 29, 17, 37, 44, 322, DateTimeKind.Local).AddTicks(4263), new Guid("96d241b2-5ad1-45ba-990c-f643554eddc5"), "حداقل امتیاز برای چرخاندن گردونه شانس الماس بار اول", true, false, null, null, -2 },
                    { new Guid("3021a096-9115-41da-b0b5-76a6dd74f581"), "مالی", "money_to_credit_ratio", null, "1000", new DateTime(2022, 12, 29, 17, 37, 44, 322, DateTimeKind.Local).AddTicks(4347), new Guid("96d241b2-5ad1-45ba-990c-f643554eddc5"), "نسبت هر اعتبار به تومان", true, false, null, null, 23 },
                    { new Guid("30cc6cd5-6f68-474d-a49b-1e89f03c77c9"), "گردونه", "diamond_second_priority", "20", "5", new DateTime(2022, 12, 29, 17, 37, 44, 322, DateTimeKind.Local).AddTicks(4276), new Guid("96d241b2-5ad1-45ba-990c-f643554eddc5"), "اولویت دوم تعداد الماس و درصد شانس", true, false, null, null, 1 },
                    { new Guid("3c44051d-a0da-4e8e-ab67-21822be21089"), "گردونه", "diamond_first_priority", "60", "2", new DateTime(2022, 12, 29, 17, 37, 44, 322, DateTimeKind.Local).AddTicks(4273), new Guid("96d241b2-5ad1-45ba-990c-f643554eddc5"), "اولویت اول تعداد الماس و درصد شانس", true, false, null, null, 0 },
                    { new Guid("46a98ef4-386f-4895-a503-669adb73609e"), "گردونه", "diamond_seventh_priority", "0.5", "150", new DateTime(2022, 12, 29, 17, 37, 44, 322, DateTimeKind.Local).AddTicks(4292), new Guid("96d241b2-5ad1-45ba-990c-f643554eddc5"), "اولویت هفتم تعداد الماس و درصد شانس", true, false, null, null, 6 },
                    { new Guid("52e8306e-4ffe-4441-8f68-84e760fff651"), "ثبت نام", "def_points_for_client_invitation", null, "50", new DateTime(2022, 12, 29, 17, 37, 44, 322, DateTimeKind.Local).AddTicks(4326), new Guid("96d241b2-5ad1-45ba-990c-f643554eddc5"), "امتیاز برای معرف وقتی کاربر ثبت نام کرد.", true, false, null, null, 18 },
                    { new Guid("5519c52a-0961-4e70-8a6a-9bb2399d3cf2"), "فروشگاه", "store_def_credit_reg", null, "0", new DateTime(2022, 12, 29, 17, 37, 44, 322, DateTimeKind.Local).AddTicks(4330), new Guid("96d241b2-5ad1-45ba-990c-f643554eddc5"), "اعتبار اولیه فروشگاه برای ثبت نام اولین بار", true, false, null, null, 19 },
                    { new Guid("5d687220-63f0-40eb-89d6-d226c7b315c6"), "گردونه", "diamond_tenth_priority", "0", "500", new DateTime(2022, 12, 29, 17, 37, 44, 322, DateTimeKind.Local).AddTicks(4300), new Guid("96d241b2-5ad1-45ba-990c-f643554eddc5"), "امتیاز دهم آگهی تبلیغاتی تصویری", true, false, null, null, 9 },
                    { new Guid("6659449e-ff84-4816-b461-18d00e3064bf"), "اعتبار", "credit_for_image_ads", null, "500", new DateTime(2022, 12, 29, 17, 37, 44, 322, DateTimeKind.Local).AddTicks(4359), new Guid("96d241b2-5ad1-45ba-990c-f643554eddc5"), "اعتبار لازم برای ثبت آگهی تصویری", true, false, null, null, 27 },
                    { new Guid("696d3451-857b-496f-b4c8-b330d91901c2"), "آگهی تبلیغاتی", "points_reward_premium_image_ads", null, "40", new DateTime(2022, 12, 29, 17, 37, 44, 322, DateTimeKind.Local).AddTicks(4312), new Guid("96d241b2-5ad1-45ba-990c-f643554eddc5"), "امتیاز ثبت آگهی تبلیغاتی تصویری", true, false, null, null, 13 },
                    { new Guid("6da2d038-5deb-44e8-b0ea-1f17ae58e9d5"), "درصدها", "def_percent_for_countryadmin", null, "4", new DateTime(2022, 12, 29, 17, 37, 44, 322, DateTimeKind.Local).AddTicks(4354), new Guid("96d241b2-5ad1-45ba-990c-f643554eddc5"), "درصد مدیر مناطق", true, false, null, null, 26 },
                    { new Guid("7466f3b6-c1b6-4e9f-800f-6a03073eec77"), "لایک ها", "def_points_for_image_like", null, "1", new DateTime(2022, 12, 29, 17, 37, 44, 322, DateTimeKind.Local).AddTicks(4318), new Guid("96d241b2-5ad1-45ba-990c-f643554eddc5"), "امتیاز پیش فرض برای لایک پست تصویری", true, false, null, null, 15 },
                    { new Guid("8c914fc7-019e-41fe-82c9-745407aca303"), "درصدها", "def_percent_for_marketer", null, "10", new DateTime(2022, 12, 29, 17, 37, 44, 322, DateTimeKind.Local).AddTicks(4349), new Guid("96d241b2-5ad1-45ba-990c-f643554eddc5"), "درصد بازاریاب", true, false, null, null, 24 },
                    { new Guid("8d766dae-0f06-4beb-8fcf-3f0296e721c6"), "کارت اعتباری", "def_chips_usage_perday", null, "-1", new DateTime(2022, 12, 29, 17, 37, 44, 322, DateTimeKind.Local).AddTicks(4315), new Guid("96d241b2-5ad1-45ba-990c-f643554eddc5"), "تعداد استفاده از کارت اعتباری هر کاربر در روز", true, false, null, null, 14 },
                    { new Guid("9aa0c0c6-d32f-4dc1-aed2-b4f59f1c32b1"), "آگهی تبلیغاتی", "def_money_to_premium_video_ads", null, "200000", new DateTime(2022, 12, 29, 17, 37, 44, 322, DateTimeKind.Local).AddTicks(4303), new Guid("96d241b2-5ad1-45ba-990c-f643554eddc5"), "هزینه درج آگهی تبلیغاتی ویدئویی", true, false, null, null, 10 },
                    { new Guid("9f41dbd7-1af5-4bcf-a4a2-2555da6de4a1"), "گردونه", "diamond_fivth_priority", "2.5", "50", new DateTime(2022, 12, 29, 17, 37, 44, 322, DateTimeKind.Local).AddTicks(4285), new Guid("96d241b2-5ad1-45ba-990c-f643554eddc5"), "اولویت پنجم تعداد الماس و درصد شانس", true, false, null, null, 4 },
                    { new Guid("c8053928-f8c2-4771-9273-635848b16198"), "گردونه", "diamond_sixth_priority", "1.5", "100", new DateTime(2022, 12, 29, 17, 37, 44, 322, DateTimeKind.Local).AddTicks(4289), new Guid("96d241b2-5ad1-45ba-990c-f643554eddc5"), "اولویت ششم تعداد الماس و درصد شانس", true, false, null, null, 5 },
                    { new Guid("c81ca16c-a409-451f-9d6e-763efdd311e3"), "گردونه", "diamond_fourth_priority", "5", "20", new DateTime(2022, 12, 29, 17, 37, 44, 322, DateTimeKind.Local).AddTicks(4283), new Guid("96d241b2-5ad1-45ba-990c-f643554eddc5"), "اولویت چهارم تعداد الماس و درصد شانس", true, false, null, null, 3 },
                    { new Guid("c9904e7a-bc42-49af-9948-908465dbc2ce"), "آگهی تبلیغاتی", "def_money_to_premium_image_ads", null, "50000", new DateTime(2022, 12, 29, 17, 37, 44, 322, DateTimeKind.Local).AddTicks(4307), new Guid("96d241b2-5ad1-45ba-990c-f643554eddc5"), "هزینه درج آگهی تبلیغاتی تصویری", true, false, null, null, 11 },
                    { new Guid("cf3babda-82a3-4a9e-9871-255894975b30"), "لایک ها", "def_points_for_video_like", null, "15", new DateTime(2022, 12, 29, 17, 37, 44, 322, DateTimeKind.Local).AddTicks(4321), new Guid("96d241b2-5ad1-45ba-990c-f643554eddc5"), "امتیاز پیش فرض برای لایک پست ویدئویی", true, false, null, null, 16 },
                    { new Guid("d080f812-de43-4704-8bb2-faa32839391a"), "گردونه", "added_points_to_each_spin_diamond_wheel_after_first_time", null, "100", new DateTime(2022, 12, 29, 17, 37, 44, 322, DateTimeKind.Local).AddTicks(4268), new Guid("96d241b2-5ad1-45ba-990c-f643554eddc5"), "افزایش تعداد امتیاز به اضای هر بار چرخاندن گردونه شانس در یک روز", true, false, null, null, -1 },
                    { new Guid("d20eefb6-b626-46e3-a829-40a1b03d4959"), "فروشگاه", "credit_for_client_registration_by_store_invitation", null, "50", new DateTime(2022, 12, 29, 17, 37, 44, 322, DateTimeKind.Local).AddTicks(4344), new Guid("96d241b2-5ad1-45ba-990c-f643554eddc5"), "اعتبار برای فروشنده ای که باعث ثبت نام مشتری شد", true, false, null, null, 22 },
                    { new Guid("d2400698-c4ec-4468-8912-f79ec0f68826"), "فروشگاه", "store_point_usage_per_day", null, "-1", new DateTime(2022, 12, 29, 17, 37, 44, 322, DateTimeKind.Local).AddTicks(4333), new Guid("96d241b2-5ad1-45ba-990c-f643554eddc5"), "تعداد دفعات استفاده از کارت تخفیف هر فروشگاه در روز برای یک مشتری", true, false, null, null, 20 },
                    { new Guid("d807cea4-7699-462a-99da-d1279486615c"), "گردونه", "diamond_nineth_priority", "0", "400", new DateTime(2022, 12, 29, 17, 37, 44, 322, DateTimeKind.Local).AddTicks(4297), new Guid("96d241b2-5ad1-45ba-990c-f643554eddc5"), "امتیاز نهم آگهی تبلیغاتی تصویری", true, false, null, null, 8 },
                    { new Guid("dff17bdd-4d6d-4712-8645-a1bd7bdd6360"), "گردونه", "diamond_third_priority", "10", "10", new DateTime(2022, 12, 29, 17, 37, 44, 322, DateTimeKind.Local).AddTicks(4279), new Guid("96d241b2-5ad1-45ba-990c-f643554eddc5"), "اولویت سوم تعداد الماس و درصد شانس", true, false, null, null, 2 },
                    { new Guid("f48c8216-e467-457a-a70a-684cbe7495e3"), "گردونه", "diamond_eighth_priority", "0", "200", new DateTime(2022, 12, 29, 17, 37, 44, 322, DateTimeKind.Local).AddTicks(4295), new Guid("96d241b2-5ad1-45ba-990c-f643554eddc5"), "اولویت هشتم تعداد الماس و درصد شانس", true, false, null, null, 7 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Priority", "RoleDescription", "RoleName" },
                values: new object[,]
                {
                    { new Guid("0fa3c699-bee6-4185-b650-23213e343993"), null, null, true, false, null, null, 1, "مدیر سامانه", "admin" },
                    { new Guid("1488a9fd-3be0-4fd0-826c-72d892d54b63"), null, null, true, false, null, null, 3, "مدیر منطقه", "zoneadmin" },
                    { new Guid("5ab5ce5b-b001-47cb-85d2-ae3655c3cbdb"), null, null, true, false, null, null, 6, "مشتری", "client" },
                    { new Guid("acb33ec3-6dfe-4ca7-a7bd-bc75ab7f4719"), null, null, true, false, null, null, 2, "مدیر کل مناطق", "countryadmin" },
                    { new Guid("cd3dfd7e-bafe-4df6-830a-2b55f583f67f"), null, null, true, false, null, null, 0, "مدیر کل", "super" },
                    { new Guid("fc533a9c-d55a-46e4-a0df-ca7b07a2ba95"), null, null, true, false, null, null, 4, "بازاریاب", "marketer" },
                    { new Guid("fdb443be-0d04-435d-8531-544b3a4aeaf3"), null, null, true, false, null, null, 5, "فروشگاه", "store" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CardNumber", "Cellphone", "ConfirmationCode", "Created", "Credits", "DefaultCredit", "Diamonds", "DonnationActive", "Family", "Inviter", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Money", "Name", "Notes", "Points", "ProfileMediaURL", "Username" },
                values: new object[,]
                {
                    { new Guid("96d241b2-5ad1-45ba-990c-f643554eddc5"), null, "09394125130", "111111", new DateTime(2022, 12, 29, 17, 37, 44, 322, DateTimeKind.Local).AddTicks(4075), 0L, 0L, null, false, "Jouybari", new Guid("eaf7d028-a5e4-466d-8567-6d218b791dc1"), true, false, null, null, 850000L, "Sina", null, 90L, "uploads/2022/9/sina2.jpg", "sinful" },
                    { new Guid("eaf7d028-a5e4-466d-8567-6d218b791dc1"), null, "09901069557", null, new DateTime(2022, 12, 29, 17, 37, 44, 322, DateTimeKind.Local).AddTicks(4026), 1000L, 0L, null, true, "دابویی مشک آبادی", null, true, false, null, null, 0L, "عبدالرحمن", null, 100L, "uploads/2022/9/photo.jpg", "dabooei" }
                });

            migrationBuilder.InsertData(
                table: "UsersRoles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "Role", "User" },
                values: new object[,]
                {
                    { new Guid("b39d9ab5-c0c1-49ba-b8d1-bdbb936a3d77"), null, new Guid("eaf7d028-a5e4-466d-8567-6d218b791dc1"), false, null, null, new Guid("fdb443be-0d04-435d-8531-544b3a4aeaf3"), new Guid("eaf7d028-a5e4-466d-8567-6d218b791dc1") },
                    { new Guid("eed46e41-51c6-42ee-8bad-6418fd553fd7"), null, new Guid("96d241b2-5ad1-45ba-990c-f643554eddc5"), false, null, null, new Guid("cd3dfd7e-bafe-4df6-830a-2b55f583f67f"), new Guid("96d241b2-5ad1-45ba-990c-f643554eddc5") }
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
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "DiamondUsages");

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
