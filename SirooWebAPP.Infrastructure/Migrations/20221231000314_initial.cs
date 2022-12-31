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
                    { new Guid("0063659c-bf8a-456b-a871-d53ae313084c"), "مالی", "money_to_credit_ratio", null, "1000", new DateTime(2022, 12, 31, 3, 33, 13, 931, DateTimeKind.Local).AddTicks(669), new Guid("2f3a05b3-ef0e-4e6f-bbf5-e0d2776918bd"), "نسبت هر اعتبار به تومان", true, false, null, null, 23 },
                    { new Guid("113cd482-611d-4368-b63c-cb1f4a2967f6"), "آگهی تبلیغاتی", "def_money_to_premium_video_ads", null, "200000", new DateTime(2022, 12, 31, 3, 33, 13, 931, DateTimeKind.Local).AddTicks(606), new Guid("2f3a05b3-ef0e-4e6f-bbf5-e0d2776918bd"), "هزینه درج آگهی تبلیغاتی ویدئویی", true, false, null, null, 10 },
                    { new Guid("2378e602-d413-4065-afb5-570578698b57"), "آگهی تبلیغاتی", "def_money_to_premium_image_ads", null, "50000", new DateTime(2022, 12, 31, 3, 33, 13, 931, DateTimeKind.Local).AddTicks(610), new Guid("2f3a05b3-ef0e-4e6f-bbf5-e0d2776918bd"), "هزینه درج آگهی تبلیغاتی تصویری", true, false, null, null, 11 },
                    { new Guid("2b656e78-cd69-42b2-a58c-39210c31a2e4"), "گردونه", "diamond_third_priority", "10", "11,20", new DateTime(2022, 12, 31, 3, 33, 13, 931, DateTimeKind.Local).AddTicks(492), new Guid("2f3a05b3-ef0e-4e6f-bbf5-e0d2776918bd"), "اولویت سوم تعداد الماس و درصد شانس", true, false, null, null, 2 },
                    { new Guid("39af4dc8-a3f4-49ed-95a1-d2bea8d7f494"), "ثبت نام", "def_points_for_client_invitation", null, "50", new DateTime(2022, 12, 31, 3, 33, 13, 931, DateTimeKind.Local).AddTicks(646), new Guid("2f3a05b3-ef0e-4e6f-bbf5-e0d2776918bd"), "امتیاز برای معرف وقتی کاربر ثبت نام کرد.", true, false, null, null, 18 },
                    { new Guid("3fd27b2f-b84d-47e9-9046-ee02872a28ad"), "گردونه", "diamond_tenth_priority", "0", "999,1000", new DateTime(2022, 12, 31, 3, 33, 13, 931, DateTimeKind.Local).AddTicks(598), new Guid("2f3a05b3-ef0e-4e6f-bbf5-e0d2776918bd"), "امتیاز دهم آگهی تبلیغاتی تصویری", true, false, null, null, 9 },
                    { new Guid("4466fd87-27eb-4577-b8f4-f64af7d2627a"), "فروشگاه", "store_point_usage_per_day", null, "-1", new DateTime(2022, 12, 31, 3, 33, 13, 931, DateTimeKind.Local).AddTicks(655), new Guid("2f3a05b3-ef0e-4e6f-bbf5-e0d2776918bd"), "تعداد دفعات استفاده از کارت تخفیف هر فروشگاه در روز برای یک مشتری", true, false, null, null, 20 },
                    { new Guid("4a715372-eeee-4985-974d-46d18972ea2b"), "درصدها", "def_percent_for_marketer", null, "10", new DateTime(2022, 12, 31, 3, 33, 13, 931, DateTimeKind.Local).AddTicks(673), new Guid("2f3a05b3-ef0e-4e6f-bbf5-e0d2776918bd"), "درصد بازاریاب", true, false, null, null, 24 },
                    { new Guid("4b925192-5b2e-4728-8c4b-7f4c42286995"), "لایک ها", "def_points_for_image_like", null, "1", new DateTime(2022, 12, 31, 3, 33, 13, 931, DateTimeKind.Local).AddTicks(631), new Guid("2f3a05b3-ef0e-4e6f-bbf5-e0d2776918bd"), "امتیاز پیش فرض برای لایک پست تصویری", true, false, null, null, 15 },
                    { new Guid("55b0b775-9797-4688-b849-9cdda4e7cb1c"), "فروشگاه", "store_def_credit_reg", null, "0", new DateTime(2022, 12, 31, 3, 33, 13, 931, DateTimeKind.Local).AddTicks(650), new Guid("2f3a05b3-ef0e-4e6f-bbf5-e0d2776918bd"), "اعتبار اولیه فروشگاه برای ثبت نام اولین بار", true, false, null, null, 19 },
                    { new Guid("5602b272-5da9-44ee-88f4-7889f5cda20f"), "گردونه", "min_points_to_spin_diamond_wheel", null, "200", new DateTime(2022, 12, 31, 3, 33, 13, 931, DateTimeKind.Local).AddTicks(465), new Guid("2f3a05b3-ef0e-4e6f-bbf5-e0d2776918bd"), "حداقل امتیاز برای چرخاندن گردونه شانس الماس بار اول", true, false, null, null, -2 },
                    { new Guid("64df079b-7922-4ec2-8588-f39e8cb2ecaf"), "گردونه", "diamond_second_priority", "20", "6,10", new DateTime(2022, 12, 31, 3, 33, 13, 931, DateTimeKind.Local).AddTicks(483), new Guid("2f3a05b3-ef0e-4e6f-bbf5-e0d2776918bd"), "اولویت دوم تعداد الماس و درصد شانس", true, false, null, null, 1 },
                    { new Guid("6bb810e2-aaf5-4a3f-bf3d-fe4a9d2e1b5c"), "آگهی تبلیغاتی", "points_reward_premium_video_ads", null, "200", new DateTime(2022, 12, 31, 3, 33, 13, 931, DateTimeKind.Local).AddTicks(616), new Guid("2f3a05b3-ef0e-4e6f-bbf5-e0d2776918bd"), "امتیاز ثبت آگهی تبلیغاتی ویدئویی", true, false, null, null, 12 },
                    { new Guid("6d113b14-8898-4b41-9b65-393ef4f9dba9"), "گردونه", "diamond_seventh_priority", "3", "101,200", new DateTime(2022, 12, 31, 3, 33, 13, 931, DateTimeKind.Local).AddTicks(581), new Guid("2f3a05b3-ef0e-4e6f-bbf5-e0d2776918bd"), "اولویت هفتم تعداد الماس و درصد شانس", true, false, null, null, 6 },
                    { new Guid("7b8495e1-a078-4f3b-aa92-cd6d522608cc"), "درصدها", "def_percent_for_zoneadmin", null, "6", new DateTime(2022, 12, 31, 3, 33, 13, 931, DateTimeKind.Local).AddTicks(678), new Guid("2f3a05b3-ef0e-4e6f-bbf5-e0d2776918bd"), "درصد مدیر منطقه", true, false, null, null, 25 },
                    { new Guid("7cb9d41a-d338-4a04-a350-ba6830cd07fb"), "درصدها", "def_percent_for_countryadmin", null, "4", new DateTime(2022, 12, 31, 3, 33, 13, 931, DateTimeKind.Local).AddTicks(685), new Guid("2f3a05b3-ef0e-4e6f-bbf5-e0d2776918bd"), "درصد مدیر مناطق", true, false, null, null, 26 },
                    { new Guid("86ec1d13-431c-48e0-b193-57c9575487d3"), "اعتبار", "credit_for_video_ads", null, "1000", new DateTime(2022, 12, 31, 3, 33, 13, 931, DateTimeKind.Local).AddTicks(693), new Guid("2f3a05b3-ef0e-4e6f-bbf5-e0d2776918bd"), "اعتبار لازم برای ثبت آگهی ویدئویی", true, false, null, null, 28 },
                    { new Guid("877da1a1-ceea-44c7-8139-d7816d1e106f"), "اعتبار", "credit_for_image_ads", null, "500", new DateTime(2022, 12, 31, 3, 33, 13, 931, DateTimeKind.Local).AddTicks(689), new Guid("2f3a05b3-ef0e-4e6f-bbf5-e0d2776918bd"), "اعتبار لازم برای ثبت آگهی تصویری", true, false, null, null, 27 },
                    { new Guid("8e91fac7-df5f-4452-9413-fc62c9aa6a50"), "فروشگاه", "stores_max_donnation_point", null, "500", new DateTime(2022, 12, 31, 3, 33, 13, 931, DateTimeKind.Local).AddTicks(661), new Guid("2f3a05b3-ef0e-4e6f-bbf5-e0d2776918bd"), "حداکثر امتیازی که فروشگاه میتواند در هر نوتب هدیه بدهد", true, false, null, null, 21 },
                    { new Guid("987641c6-9aa2-4108-b1e6-85ab289f4a93"), "گردونه", "diamond_eighth_priority", "2", "201,300", new DateTime(2022, 12, 31, 3, 33, 13, 931, DateTimeKind.Local).AddTicks(589), new Guid("2f3a05b3-ef0e-4e6f-bbf5-e0d2776918bd"), "اولویت هشتم تعداد الماس و درصد شانس", true, false, null, null, 7 },
                    { new Guid("9e81d802-3215-4b43-9dfb-3e80d852b330"), "گردونه", "diamond_nineth_priority", "0", "301,500", new DateTime(2022, 12, 31, 3, 33, 13, 931, DateTimeKind.Local).AddTicks(593), new Guid("2f3a05b3-ef0e-4e6f-bbf5-e0d2776918bd"), "امتیاز نهم آگهی تبلیغاتی تصویری", true, false, null, null, 8 },
                    { new Guid("9f83a9bf-6ea4-47d2-a9e4-b4c9077a4ab5"), "گردونه", "added_points_to_each_spin_diamond_wheel_after_first_time", null, "100", new DateTime(2022, 12, 31, 3, 33, 13, 931, DateTimeKind.Local).AddTicks(473), new Guid("2f3a05b3-ef0e-4e6f-bbf5-e0d2776918bd"), "افزایش تعداد امتیاز به اضای هر بار چرخاندن گردونه شانس در یک روز", true, false, null, null, -1 },
                    { new Guid("a1c878b1-57b1-4cf1-abdb-14479708ede4"), "گردونه", "diamond_first_priority", "50", "1,5", new DateTime(2022, 12, 31, 3, 33, 13, 931, DateTimeKind.Local).AddTicks(478), new Guid("2f3a05b3-ef0e-4e6f-bbf5-e0d2776918bd"), "اولویت اول تعداد الماس و درصد شانس", true, false, null, null, 0 },
                    { new Guid("a801bc28-8d81-499e-ae65-31c6c6d21cec"), "ثبت نام", "def_points_for_client_registration", null, "100", new DateTime(2022, 12, 31, 3, 33, 13, 931, DateTimeKind.Local).AddTicks(639), new Guid("2f3a05b3-ef0e-4e6f-bbf5-e0d2776918bd"), "امتیاز اولیه برای کاربری که ثبت نام میکند.", true, false, null, null, 17 },
                    { new Guid("a9bcf4d0-7b70-4ba5-b556-9a083afd3388"), "گردونه", "diamond_sixth_priority", "4", "51,100", new DateTime(2022, 12, 31, 3, 33, 13, 931, DateTimeKind.Local).AddTicks(508), new Guid("2f3a05b3-ef0e-4e6f-bbf5-e0d2776918bd"), "اولویت ششم تعداد الماس و درصد شانس", true, false, null, null, 5 },
                    { new Guid("ac2e34cf-2222-4331-b7ff-b45ffef29a6c"), "فروشگاه", "credit_for_client_registration_by_store_invitation", null, "50", new DateTime(2022, 12, 31, 3, 33, 13, 931, DateTimeKind.Local).AddTicks(665), new Guid("2f3a05b3-ef0e-4e6f-bbf5-e0d2776918bd"), "اعتبار برای فروشنده ای که باعث ثبت نام مشتری شد", true, false, null, null, 22 },
                    { new Guid("d8eea91b-5ab7-41bb-a63a-7317cd53a585"), "گردونه", "diamond_fourth_priority", "6", "21,30", new DateTime(2022, 12, 31, 3, 33, 13, 931, DateTimeKind.Local).AddTicks(497), new Guid("2f3a05b3-ef0e-4e6f-bbf5-e0d2776918bd"), "اولویت چهارم تعداد الماس و درصد شانس", true, false, null, null, 3 },
                    { new Guid("e58a378a-cd3c-4166-b1f2-d03be1a3a1a8"), "لایک ها", "def_points_for_video_like", null, "15", new DateTime(2022, 12, 31, 3, 33, 13, 931, DateTimeKind.Local).AddTicks(635), new Guid("2f3a05b3-ef0e-4e6f-bbf5-e0d2776918bd"), "امتیاز پیش فرض برای لایک پست ویدئویی", true, false, null, null, 16 },
                    { new Guid("e9aa3a5c-b58a-4c01-afd4-cad256110774"), "کارت اعتباری", "def_chips_usage_perday", null, "-1", new DateTime(2022, 12, 31, 3, 33, 13, 931, DateTimeKind.Local).AddTicks(625), new Guid("2f3a05b3-ef0e-4e6f-bbf5-e0d2776918bd"), "تعداد استفاده از کارت اعتباری هر کاربر در روز", true, false, null, null, 14 },
                    { new Guid("ed098694-1eaf-4dd4-9401-75e5a8900216"), "گردونه", "diamond_fivth_priority", "5", "31,50", new DateTime(2022, 12, 31, 3, 33, 13, 931, DateTimeKind.Local).AddTicks(503), new Guid("2f3a05b3-ef0e-4e6f-bbf5-e0d2776918bd"), "اولویت پنجم تعداد الماس و درصد شانس", true, false, null, null, 4 },
                    { new Guid("f8da789c-0749-4de2-9b95-f4cac4ba5b78"), "آگهی تبلیغاتی", "points_reward_premium_image_ads", null, "40", new DateTime(2022, 12, 31, 3, 33, 13, 931, DateTimeKind.Local).AddTicks(621), new Guid("2f3a05b3-ef0e-4e6f-bbf5-e0d2776918bd"), "امتیاز ثبت آگهی تبلیغاتی تصویری", true, false, null, null, 13 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Priority", "RoleDescription", "RoleName" },
                values: new object[,]
                {
                    { new Guid("1c1e6d28-bad8-48cc-9c48-6f156f8145fb"), null, null, true, false, null, null, 3, "مدیر منطقه", "zoneadmin" },
                    { new Guid("1fb8bb2a-e71d-488b-8a60-99448d40409e"), null, null, true, false, null, null, 2, "مدیر کل مناطق", "countryadmin" },
                    { new Guid("2a83d5e1-092e-4282-a584-03192b454252"), null, null, true, false, null, null, 4, "بازاریاب", "marketer" },
                    { new Guid("4fc29ab8-43e1-4e71-92fc-1599f8f148f4"), null, null, true, false, null, null, 5, "فروشگاه", "store" },
                    { new Guid("67c0467b-d535-4f46-b7fe-0578bbe4abb0"), null, null, true, false, null, null, 6, "مشتری", "client" },
                    { new Guid("7b8d7470-6482-4cdb-9012-8cf9eaef9447"), null, null, true, false, null, null, 0, "مدیر کل", "super" },
                    { new Guid("ccd1cf84-e83c-48ae-9b45-a5954792f077"), null, null, true, false, null, null, 1, "مدیر سامانه", "admin" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CardNumber", "Cellphone", "ConfirmationCode", "Created", "Credits", "DefaultCredit", "Diamonds", "DonnationActive", "Family", "Inviter", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Money", "Name", "Notes", "Points", "ProfileMediaURL", "Username" },
                values: new object[,]
                {
                    { new Guid("2f3a05b3-ef0e-4e6f-bbf5-e0d2776918bd"), null, "09394125130", "111111", new DateTime(2022, 12, 31, 3, 33, 13, 931, DateTimeKind.Local).AddTicks(206), 0L, 0L, 0, false, "Jouybari", new Guid("647ba905-1102-4380-baad-deb7c957ac3b"), true, false, null, null, 850000L, "Sina", null, 90L, "uploads/2022/9/sina2.jpg", "sinful" },
                    { new Guid("647ba905-1102-4380-baad-deb7c957ac3b"), null, "09901069557", null, new DateTime(2022, 12, 31, 3, 33, 13, 931, DateTimeKind.Local).AddTicks(160), 1000L, 0L, 0, true, "دابویی مشک آبادی", null, true, false, null, null, 0L, "عبدالرحمن", null, 100L, "uploads/2022/9/photo.jpg", "dabooei" }
                });

            migrationBuilder.InsertData(
                table: "UsersRoles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "Role", "User" },
                values: new object[,]
                {
                    { new Guid("557baf36-ec93-48ec-8a18-07ffa67b8c13"), null, new Guid("2f3a05b3-ef0e-4e6f-bbf5-e0d2776918bd"), false, null, null, new Guid("7b8d7470-6482-4cdb-9012-8cf9eaef9447"), new Guid("2f3a05b3-ef0e-4e6f-bbf5-e0d2776918bd") },
                    { new Guid("dc51ae97-5b76-4701-8ee1-6022347263ed"), null, new Guid("647ba905-1102-4380-baad-deb7c957ac3b"), false, null, null, new Guid("4fc29ab8-43e1-4e71-92fc-1599f8f148f4"), new Guid("647ba905-1102-4380-baad-deb7c957ac3b") }
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
