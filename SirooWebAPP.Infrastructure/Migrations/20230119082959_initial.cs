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
                    PointCharged = table.Column<int>(type: "int", nullable: true),
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
                name: "Graphs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    User = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Parent = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GrandParent = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsFirstChildOfParent = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DirectChildCount = table.Column<int>(type: "int", nullable: false),
                    IsExpired = table.Column<bool>(type: "bit", nullable: false),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReceivedShared = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Graphs", x => x.Id);
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
                    { new Guid("0fb904f1-45df-4842-9ac8-8e0e89380167"), "آگهی تبلیغاتی", "def_money_to_premium_video_ads", null, "1000000", new DateTime(2023, 1, 19, 11, 59, 59, 22, DateTimeKind.Local).AddTicks(2451), new Guid("6a2bdd3c-dd9f-41e4-baf8-e2d0e489ad88"), "هزینه درج آگهی تبلیغاتی ویدئویی", true, false, null, null, 10 },
                    { new Guid("19e063c2-beef-48cd-8e5e-655ca935164e"), "اعتبار", "credit_for_image_ads", null, "500", new DateTime(2023, 1, 19, 11, 59, 59, 22, DateTimeKind.Local).AddTicks(2503), new Guid("6a2bdd3c-dd9f-41e4-baf8-e2d0e489ad88"), "اعتبار لازم برای ثبت آگهی تصویری", true, false, null, null, 27 },
                    { new Guid("2621e106-53e1-47d1-9aed-fbea07fdd522"), "ثبت نام", "def_points_for_client_invitation", null, "50", new DateTime(2023, 1, 19, 11, 59, 59, 22, DateTimeKind.Local).AddTicks(2474), new Guid("6a2bdd3c-dd9f-41e4-baf8-e2d0e489ad88"), "امتیاز برای معرف وقتی کاربر ثبت نام کرد.", true, false, null, null, 18 },
                    { new Guid("262f3a7a-686a-424b-acd1-5d76a7b96f1f"), "فروشگاه", "store_def_credit_reg", null, "0", new DateTime(2023, 1, 19, 11, 59, 59, 22, DateTimeKind.Local).AddTicks(2477), new Guid("6a2bdd3c-dd9f-41e4-baf8-e2d0e489ad88"), "اعتبار اولیه فروشگاه برای ثبت نام اولین بار", true, false, null, null, 19 },
                    { new Guid("26c8d2d5-7407-4408-b820-aaba9e9ab0c6"), "گردونه", "diamond_first_priority", "50", "1,5", new DateTime(2023, 1, 19, 11, 59, 59, 22, DateTimeKind.Local).AddTicks(2421), new Guid("6a2bdd3c-dd9f-41e4-baf8-e2d0e489ad88"), "اولویت اول تعداد الماس و درصد شانس", true, false, null, null, 0 },
                    { new Guid("2f50fba5-2494-4ea1-867c-00bdd4558b93"), "گردونه", "diamond_nineth_priority", "0", "301,500", new DateTime(2023, 1, 19, 11, 59, 59, 22, DateTimeKind.Local).AddTicks(2445), new Guid("6a2bdd3c-dd9f-41e4-baf8-e2d0e489ad88"), "امتیاز نهم آگهی تبلیغاتی تصویری", true, false, null, null, 8 },
                    { new Guid("5350e121-5a25-4793-b550-9e85b2220ae4"), "گردونه", "diamond_fourth_priority", "6", "21,30", new DateTime(2023, 1, 19, 11, 59, 59, 22, DateTimeKind.Local).AddTicks(2430), new Guid("6a2bdd3c-dd9f-41e4-baf8-e2d0e489ad88"), "اولویت چهارم تعداد الماس و درصد شانس", true, false, null, null, 3 },
                    { new Guid("6640f22c-42d8-446e-957b-769fa218b6f6"), "چالش", "prize_for_invite_to_challenge", null, "1000000", new DateTime(2023, 1, 19, 11, 59, 59, 22, DateTimeKind.Local).AddTicks(2515), new Guid("6a2bdd3c-dd9f-41e4-baf8-e2d0e489ad88"), "کارمزد برای معرفی کاربران به چالش", true, false, null, null, 31 },
                    { new Guid("66c938f4-9488-49b4-914f-37adf1a47656"), "اعتبار", "credit_for_video_ads", null, "1000", new DateTime(2023, 1, 19, 11, 59, 59, 22, DateTimeKind.Local).AddTicks(2506), new Guid("6a2bdd3c-dd9f-41e4-baf8-e2d0e489ad88"), "اعتبار لازم برای ثبت آگهی ویدئویی", true, false, null, null, 28 },
                    { new Guid("670beab6-6cca-4569-8e67-f54024d7ccf3"), "لایک ها", "def_points_for_image_like", null, "1", new DateTime(2023, 1, 19, 11, 59, 59, 22, DateTimeKind.Local).AddTicks(2466), new Guid("6a2bdd3c-dd9f-41e4-baf8-e2d0e489ad88"), "امتیاز پیش فرض برای لایک پست تصویری", true, false, null, null, 15 },
                    { new Guid("69e0b738-b428-4e6a-9c51-1eb40806568c"), "لایک ها", "def_points_for_video_like", null, "15", new DateTime(2023, 1, 19, 11, 59, 59, 22, DateTimeKind.Local).AddTicks(2469), new Guid("6a2bdd3c-dd9f-41e4-baf8-e2d0e489ad88"), "امتیاز پیش فرض برای لایک پست ویدئویی", true, false, null, null, 16 },
                    { new Guid("700e3e20-0cf0-4a93-a5cd-b517a255f2bf"), "فروشگاه", "store_point_usage_per_day", null, "-1", new DateTime(2023, 1, 19, 11, 59, 59, 22, DateTimeKind.Local).AddTicks(2479), new Guid("6a2bdd3c-dd9f-41e4-baf8-e2d0e489ad88"), "تعداد دفعات استفاده از کارت تخفیف هر فروشگاه در روز برای یک مشتری", true, false, null, null, 20 },
                    { new Guid("74f02b73-5e5e-43db-b7b4-d7a40d7aa4e5"), "آگهی تبلیغاتی", "points_reward_premium_video_ads", null, "200", new DateTime(2023, 1, 19, 11, 59, 59, 22, DateTimeKind.Local).AddTicks(2457), new Guid("6a2bdd3c-dd9f-41e4-baf8-e2d0e489ad88"), "امتیاز ثبت آگهی تبلیغاتی ویدئویی", true, false, null, null, 12 },
                    { new Guid("77dc8ead-5dd0-439e-8e86-b07681a33f91"), "مالی", "money_to_credit_ratio", null, "1000", new DateTime(2023, 1, 19, 11, 59, 59, 22, DateTimeKind.Local).AddTicks(2489), new Guid("6a2bdd3c-dd9f-41e4-baf8-e2d0e489ad88"), "نسبت هر اعتبار به تومان", true, false, null, null, 23 },
                    { new Guid("7ceea6ec-5f64-4af7-8f2d-e951f3842af6"), "گردونه", "diamond_tenth_priority", "0", "999,1000", new DateTime(2023, 1, 19, 11, 59, 59, 22, DateTimeKind.Local).AddTicks(2448), new Guid("6a2bdd3c-dd9f-41e4-baf8-e2d0e489ad88"), "امتیاز دهم آگهی تبلیغاتی تصویری", true, false, null, null, 9 },
                    { new Guid("807fc0d5-8f1e-4815-a4df-8ddf75d13dc5"), "گردونه", "min_points_to_spin_diamond_wheel", null, "200", new DateTime(2023, 1, 19, 11, 59, 59, 22, DateTimeKind.Local).AddTicks(2411), new Guid("6a2bdd3c-dd9f-41e4-baf8-e2d0e489ad88"), "حداقل امتیاز برای چرخاندن گردونه شانس الماس بار اول", true, false, null, null, -2 },
                    { new Guid("8642fb8c-b4fa-4a2b-8dfb-0f491e2c1f5b"), "فروشگاه", "credit_for_client_registration_by_store_invitation", null, "50", new DateTime(2023, 1, 19, 11, 59, 59, 22, DateTimeKind.Local).AddTicks(2485), new Guid("6a2bdd3c-dd9f-41e4-baf8-e2d0e489ad88"), "اعتبار برای فروشنده ای که باعث ثبت نام مشتری شد", true, false, null, null, 22 },
                    { new Guid("9221716a-a06e-43e6-9a8e-8274af1bd555"), "گردونه", "diamond_third_priority", "10", "11,20", new DateTime(2023, 1, 19, 11, 59, 59, 22, DateTimeKind.Local).AddTicks(2427), new Guid("6a2bdd3c-dd9f-41e4-baf8-e2d0e489ad88"), "اولویت سوم تعداد الماس و درصد شانس", true, false, null, null, 2 },
                    { new Guid("92e26a6f-e33f-46a8-a52c-e382b5c1c102"), "کارت اعتباری", "def_chips_usage_perday", null, "-1", new DateTime(2023, 1, 19, 11, 59, 59, 22, DateTimeKind.Local).AddTicks(2462), new Guid("6a2bdd3c-dd9f-41e4-baf8-e2d0e489ad88"), "تعداد استفاده از کارت اعتباری هر کاربر در روز", true, false, null, null, 14 },
                    { new Guid("98012b65-3a43-47b9-9963-f490982cc1bf"), "گردونه", "added_points_to_each_spin_diamond_wheel_after_first_time", null, "100", new DateTime(2023, 1, 19, 11, 59, 59, 22, DateTimeKind.Local).AddTicks(2418), new Guid("6a2bdd3c-dd9f-41e4-baf8-e2d0e489ad88"), "افزایش تعداد امتیاز به اضای هر بار چرخاندن گردونه شانس در یک روز", true, false, null, null, -1 },
                    { new Guid("9e8ae3d6-c54f-47ca-b0e8-c9d2d3cfe319"), "آگهی تبلیغاتی", "def_money_to_premium_image_ads", null, "200000", new DateTime(2023, 1, 19, 11, 59, 59, 22, DateTimeKind.Local).AddTicks(2454), new Guid("6a2bdd3c-dd9f-41e4-baf8-e2d0e489ad88"), "هزینه درج آگهی تبلیغاتی تصویری", true, false, null, null, 11 },
                    { new Guid("a54186af-0043-45f3-ac46-d2d7a726cffc"), "فروشگاه", "stores_max_donnation_point", null, "500", new DateTime(2023, 1, 19, 11, 59, 59, 22, DateTimeKind.Local).AddTicks(2482), new Guid("6a2bdd3c-dd9f-41e4-baf8-e2d0e489ad88"), "حداکثر امتیازی که فروشگاه میتواند در هر نوتب هدیه بدهد", true, false, null, null, 21 },
                    { new Guid("a75d669f-b693-42fa-8d8a-52ed90fa6f22"), "درصدها", "def_percent_for_countryadmin", null, "4", new DateTime(2023, 1, 19, 11, 59, 59, 22, DateTimeKind.Local).AddTicks(2496), new Guid("6a2bdd3c-dd9f-41e4-baf8-e2d0e489ad88"), "درصد مدیر مناطق", true, false, null, null, 26 },
                    { new Guid("a7e75613-5f9f-4551-96d3-f27d7abec515"), "آگهی تبلیغاتی", "points_reward_premium_image_ads", null, "1000", new DateTime(2023, 1, 19, 11, 59, 59, 22, DateTimeKind.Local).AddTicks(2459), new Guid("6a2bdd3c-dd9f-41e4-baf8-e2d0e489ad88"), "امتیاز ثبت آگهی تبلیغاتی تصویری", true, false, null, null, 13 },
                    { new Guid("afdd8d19-160b-4317-a09b-e081ea84c402"), "درصدها", "def_percent_for_marketer", null, "10", new DateTime(2023, 1, 19, 11, 59, 59, 22, DateTimeKind.Local).AddTicks(2491), new Guid("6a2bdd3c-dd9f-41e4-baf8-e2d0e489ad88"), "درصد بازاریاب", true, false, null, null, 24 },
                    { new Guid("b1bffebf-58d0-4f10-841e-c55ff65e5685"), "گردونه", "diamond_fivth_priority", "5", "31,50", new DateTime(2023, 1, 19, 11, 59, 59, 22, DateTimeKind.Local).AddTicks(2433), new Guid("6a2bdd3c-dd9f-41e4-baf8-e2d0e489ad88"), "اولویت پنجم تعداد الماس و درصد شانس", true, false, null, null, 4 },
                    { new Guid("b2aaef30-a7f5-40b7-982d-8e2acbc632f5"), "درصدها", "def_percent_for_zoneadmin", null, "6", new DateTime(2023, 1, 19, 11, 59, 59, 22, DateTimeKind.Local).AddTicks(2494), new Guid("6a2bdd3c-dd9f-41e4-baf8-e2d0e489ad88"), "درصد مدیر منطقه", true, false, null, null, 25 },
                    { new Guid("b6e0991f-3db9-4731-b526-33fd5695fff3"), "چالش", "expire_dates_for_challenge", null, "60", new DateTime(2023, 1, 19, 11, 59, 59, 22, DateTimeKind.Local).AddTicks(2508), new Guid("6a2bdd3c-dd9f-41e4-baf8-e2d0e489ad88"), "تعداد روزهای مجاز برای چالش", true, false, null, null, 29 },
                    { new Guid("dd49d545-79d8-4971-b605-747cde58c4f9"), "ثبت نام", "def_points_for_client_registration", null, "100", new DateTime(2023, 1, 19, 11, 59, 59, 22, DateTimeKind.Local).AddTicks(2471), new Guid("6a2bdd3c-dd9f-41e4-baf8-e2d0e489ad88"), "امتیاز اولیه برای کاربری که ثبت نام میکند.", true, false, null, null, 17 },
                    { new Guid("e9a2ae4c-df42-4a2e-b50d-c62f8942684a"), "گردونه", "diamond_second_priority", "20", "6,10", new DateTime(2023, 1, 19, 11, 59, 59, 22, DateTimeKind.Local).AddTicks(2424), new Guid("6a2bdd3c-dd9f-41e4-baf8-e2d0e489ad88"), "اولویت دوم تعداد الماس و درصد شانس", true, false, null, null, 1 },
                    { new Guid("f66ac39f-d1f7-44e7-bcf0-ebde42413ad0"), "چالش", "money_needed_to_attend_in_challenge", null, "3000000", new DateTime(2023, 1, 19, 11, 59, 59, 22, DateTimeKind.Local).AddTicks(2511), new Guid("6a2bdd3c-dd9f-41e4-baf8-e2d0e489ad88"), "موجودی ریالی برای شرکت در چالش", true, false, null, null, 30 },
                    { new Guid("fb376950-204a-45dd-bfa8-5afe1c4cdd92"), "گردونه", "diamond_eighth_priority", "2", "201,300", new DateTime(2023, 1, 19, 11, 59, 59, 22, DateTimeKind.Local).AddTicks(2442), new Guid("6a2bdd3c-dd9f-41e4-baf8-e2d0e489ad88"), "اولویت هشتم تعداد الماس و درصد شانس", true, false, null, null, 7 },
                    { new Guid("fde09109-20dd-4663-a57c-817b4f7725a9"), "گردونه", "diamond_sixth_priority", "4", "51,100", new DateTime(2023, 1, 19, 11, 59, 59, 22, DateTimeKind.Local).AddTicks(2436), new Guid("6a2bdd3c-dd9f-41e4-baf8-e2d0e489ad88"), "اولویت ششم تعداد الماس و درصد شانس", true, false, null, null, 5 },
                    { new Guid("fe2e1650-0683-4b4a-8c6b-2ba219c77689"), "گردونه", "diamond_seventh_priority", "3", "101,200", new DateTime(2023, 1, 19, 11, 59, 59, 22, DateTimeKind.Local).AddTicks(2438), new Guid("6a2bdd3c-dd9f-41e4-baf8-e2d0e489ad88"), "اولویت هفتم تعداد الماس و درصد شانس", true, false, null, null, 6 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Priority", "RoleDescription", "RoleName" },
                values: new object[,]
                {
                    { new Guid("1bfbf152-719a-4bcb-b3b4-a0933935d1a0"), null, null, true, false, null, null, 1, "مدیر سامانه", "admin" },
                    { new Guid("1e5b84e0-aa65-4a1c-beaa-b4f892e5dccb"), null, null, true, false, null, null, 2, "مدیر کل مناطق", "countryadmin" },
                    { new Guid("33e838c8-f9e9-487f-a6ea-cca7986a0ae9"), null, null, true, false, null, null, 0, "مدیر کل", "super" },
                    { new Guid("3dbde0cb-1d45-466c-8695-da8fd5d648c6"), null, null, true, false, null, null, 5, "فروشگاه", "store" },
                    { new Guid("4edf5a5f-de6e-4727-85ad-7983a49dcdab"), null, null, true, false, null, null, 3, "مدیر منطقه", "zoneadmin" },
                    { new Guid("6da624eb-a9e3-47ef-9d85-a454508fb2d0"), null, null, true, false, null, null, 6, "مشتری", "client" },
                    { new Guid("ca015b06-3609-4f88-884d-93921bc56062"), null, null, true, false, null, null, 4, "بازاریاب", "marketer" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CardNumber", "Cellphone", "ConfirmationCode", "Created", "Credits", "DefaultCredit", "Diamonds", "DonnationActive", "Family", "Inviter", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Money", "Name", "Notes", "Points", "ProfileMediaURL", "Username" },
                values: new object[] { new Guid("0615bfad-e715-4fd2-91d9-54358c6f60d0"), null, "09901069557", null, new DateTime(2023, 1, 19, 11, 59, 59, 22, DateTimeKind.Local).AddTicks(2067), 1000L, 0L, 0, true, "دابویی مشک آبادی", null, true, false, null, null, 0L, "عبدالرحمن", null, 100L, "uploads/2022/9/photo.jpg", "dabooei" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CardNumber", "Cellphone", "ConfirmationCode", "Created", "Credits", "DefaultCredit", "Diamonds", "DonnationActive", "Family", "Inviter", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Money", "Name", "Notes", "Points", "ProfileMediaURL", "Username" },
                values: new object[,]
                {
                    { new Guid("0c80814e-f18b-4cef-9e58-7b9606b15d51"), null, "09188888888", "111111", new DateTime(2023, 1, 19, 11, 59, 59, 22, DateTimeKind.Local).AddTicks(2129), 0L, 0L, 0, false, "user8", null, true, false, null, null, 0L, "eighth", null, 90L, "uploads/2022/9/sina2.jpg", "eighthuser" },
                    { new Guid("155ce4f0-f0eb-4dcc-b345-33836f931ae1"), null, "09166666666", "111111", new DateTime(2023, 1, 19, 11, 59, 59, 22, DateTimeKind.Local).AddTicks(2122), 0L, 0L, 0, false, "user6", null, true, false, null, null, 0L, "sixth", null, 90L, "uploads/2022/9/sina2.jpg", "sixthuser" },
                    { new Guid("2e25d455-6d2f-43bc-be7c-167e02b16ea8"), null, "09155555555", "111111", new DateTime(2023, 1, 19, 11, 59, 59, 22, DateTimeKind.Local).AddTicks(2119), 0L, 0L, 0, false, "user5", null, true, false, null, null, 0L, "fivth", null, 90L, "uploads/2022/9/sina2.jpg", "fivthuser" },
                    { new Guid("3024252f-a230-4239-aafd-f1571b195679"), null, "09144444444", "111111", new DateTime(2023, 1, 19, 11, 59, 59, 22, DateTimeKind.Local).AddTicks(2117), 0L, 0L, 0, false, "user4", null, true, false, null, null, 0L, "fourth", null, 90L, "uploads/2022/9/sina2.jpg", "fourthuser" },
                    { new Guid("5b11912b-94ba-4cbd-b928-bb99a13f1150"), null, "09122222222", "111111", new DateTime(2023, 1, 19, 11, 59, 59, 22, DateTimeKind.Local).AddTicks(2111), 0L, 0L, 0, false, "user2", null, true, false, null, null, 0L, "second", null, 90L, "uploads/2022/9/sina2.jpg", "seconduser" },
                    { new Guid("5cbc55df-aa62-49f5-8a25-54c6c40a4aca"), null, "09100000000", "111111", new DateTime(2023, 1, 19, 11, 59, 59, 22, DateTimeKind.Local).AddTicks(2135), 0L, 0L, 0, false, "user10", null, true, false, null, null, 0L, "tenth", null, 90L, "uploads/2022/9/sina2.jpg", "tenthuser" },
                    { new Guid("61c5d845-e619-49e1-8ec2-32c251e94ad4"), null, "09111111111", "111111", new DateTime(2023, 1, 19, 11, 59, 59, 22, DateTimeKind.Local).AddTicks(2108), 0L, 0L, 0, false, "user1", null, true, false, null, null, 0L, "first", null, 90L, "uploads/2022/9/sina2.jpg", "firstuser" },
                    { new Guid("6816422b-cf39-4a7e-a67d-39f1888afbe3"), null, "09199999999", "111111", new DateTime(2023, 1, 19, 11, 59, 59, 22, DateTimeKind.Local).AddTicks(2132), 0L, 0L, 0, false, "user9", null, true, false, null, null, 0L, "ninth", null, 90L, "uploads/2022/9/sina2.jpg", "ninthuser" },
                    { new Guid("6a2bdd3c-dd9f-41e4-baf8-e2d0e489ad88"), null, "09394125130", "111111", new DateTime(2023, 1, 19, 11, 59, 59, 22, DateTimeKind.Local).AddTicks(2105), 0L, 0L, 0, false, "Jouybari", new Guid("0615bfad-e715-4fd2-91d9-54358c6f60d0"), true, false, null, null, 850000L, "Sina", null, 90L, "uploads/2022/9/sina2.jpg", "sinful" },
                    { new Guid("8685d1ec-d43e-45ce-b1c5-debdbbde892b"), null, "09177777777", "111111", new DateTime(2023, 1, 19, 11, 59, 59, 22, DateTimeKind.Local).AddTicks(2127), 0L, 0L, 0, false, "user7", null, true, false, null, null, 0L, "seventh", null, 90L, "uploads/2022/9/sina2.jpg", "seventhuser" },
                    { new Guid("fc7e468f-9802-483b-a049-9f48a1049233"), null, "09133333333", "111111", new DateTime(2023, 1, 19, 11, 59, 59, 22, DateTimeKind.Local).AddTicks(2114), 0L, 0L, 0, false, "user3", null, true, false, null, null, 0L, "third", null, 90L, "uploads/2022/9/sina2.jpg", "thirduser" }
                });

            migrationBuilder.InsertData(
                table: "UsersRoles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "Role", "User" },
                values: new object[,]
                {
                    { new Guid("00580299-573f-48da-a63d-65474915023f"), null, new Guid("3024252f-a230-4239-aafd-f1571b195679"), false, null, null, new Guid("6da624eb-a9e3-47ef-9d85-a454508fb2d0"), new Guid("3024252f-a230-4239-aafd-f1571b195679") },
                    { new Guid("2ea19583-37b9-4b72-9ec0-1f235fea6e0f"), null, new Guid("155ce4f0-f0eb-4dcc-b345-33836f931ae1"), false, null, null, new Guid("6da624eb-a9e3-47ef-9d85-a454508fb2d0"), new Guid("155ce4f0-f0eb-4dcc-b345-33836f931ae1") },
                    { new Guid("361831a6-1d49-4681-aa12-df67d1b86476"), null, new Guid("5cbc55df-aa62-49f5-8a25-54c6c40a4aca"), false, null, null, new Guid("6da624eb-a9e3-47ef-9d85-a454508fb2d0"), new Guid("5cbc55df-aa62-49f5-8a25-54c6c40a4aca") },
                    { new Guid("3a91b596-1d12-46ba-a84d-e0be918d85cf"), null, new Guid("0615bfad-e715-4fd2-91d9-54358c6f60d0"), false, null, null, new Guid("3dbde0cb-1d45-466c-8695-da8fd5d648c6"), new Guid("0615bfad-e715-4fd2-91d9-54358c6f60d0") },
                    { new Guid("610ba756-2b9e-477e-a3a0-6a9c70d637f0"), null, new Guid("6a2bdd3c-dd9f-41e4-baf8-e2d0e489ad88"), false, null, null, new Guid("33e838c8-f9e9-487f-a6ea-cca7986a0ae9"), new Guid("6a2bdd3c-dd9f-41e4-baf8-e2d0e489ad88") },
                    { new Guid("6b50fefe-6620-4281-b87f-c2d7c4961f4e"), null, new Guid("5b11912b-94ba-4cbd-b928-bb99a13f1150"), false, null, null, new Guid("6da624eb-a9e3-47ef-9d85-a454508fb2d0"), new Guid("5b11912b-94ba-4cbd-b928-bb99a13f1150") },
                    { new Guid("7e0e9d5d-1c3e-4a73-a50e-278bf3bf106c"), null, new Guid("6816422b-cf39-4a7e-a67d-39f1888afbe3"), false, null, null, new Guid("6da624eb-a9e3-47ef-9d85-a454508fb2d0"), new Guid("6816422b-cf39-4a7e-a67d-39f1888afbe3") },
                    { new Guid("91c72595-eb60-4922-8938-be7459514d45"), null, new Guid("61c5d845-e619-49e1-8ec2-32c251e94ad4"), false, null, null, new Guid("6da624eb-a9e3-47ef-9d85-a454508fb2d0"), new Guid("61c5d845-e619-49e1-8ec2-32c251e94ad4") },
                    { new Guid("e6357b3d-d849-4e49-b7cb-5dc2db80c79d"), null, new Guid("2e25d455-6d2f-43bc-be7c-167e02b16ea8"), false, null, null, new Guid("6da624eb-a9e3-47ef-9d85-a454508fb2d0"), new Guid("2e25d455-6d2f-43bc-be7c-167e02b16ea8") },
                    { new Guid("ed97b525-5196-4521-84cc-9e4dc3ea6bf8"), null, new Guid("5cbc55df-aa62-49f5-8a25-54c6c40a4aca"), false, null, null, new Guid("6da624eb-a9e3-47ef-9d85-a454508fb2d0"), new Guid("5cbc55df-aa62-49f5-8a25-54c6c40a4aca") },
                    { new Guid("f052ea72-94a8-4f66-b7f2-46b0ee1312c5"), null, new Guid("8685d1ec-d43e-45ce-b1c5-debdbbde892b"), false, null, null, new Guid("6da624eb-a9e3-47ef-9d85-a454508fb2d0"), new Guid("8685d1ec-d43e-45ce-b1c5-debdbbde892b") },
                    { new Guid("ff6d0cb9-4d55-497b-a38a-65756748e7b8"), null, new Guid("0c80814e-f18b-4cef-9e58-7b9606b15d51"), false, null, null, new Guid("6da624eb-a9e3-47ef-9d85-a454508fb2d0"), new Guid("0c80814e-f18b-4cef-9e58-7b9606b15d51") }
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
                name: "Graphs");

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
