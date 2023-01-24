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
                name: "ChallengeUserData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    User = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Graph = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Family = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NationalID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdentityID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cellphone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsMarried = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChallengeUserData", x => x.Id);
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
                    Parent = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GrandParent = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsFirstChildOfParent = table.Column<bool>(type: "bit", nullable: false),
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
                    { new Guid("099f400c-cc19-414b-9147-695d65c00fd1"), "درصدها", "def_percent_for_zoneadmin", null, "6", new DateTime(2023, 1, 24, 14, 41, 10, 534, DateTimeKind.Local).AddTicks(6101), new Guid("54ebefd6-9e69-4b9f-95f9-ab0df4fad5cf"), "درصد مدیر منطقه", true, false, null, null, 25 },
                    { new Guid("0bcaf041-2fec-4fba-b7d8-f06103ea7ab4"), "ثبت نام", "def_points_for_client_invitation", null, "50", new DateTime(2023, 1, 24, 14, 41, 10, 534, DateTimeKind.Local).AddTicks(6081), new Guid("54ebefd6-9e69-4b9f-95f9-ab0df4fad5cf"), "امتیاز برای معرف وقتی کاربر ثبت نام کرد.", true, false, null, null, 18 },
                    { new Guid("0d3fb0de-e3d9-4789-83cc-d85823241db0"), "گردونه", "diamond_tenth_priority", "0", "999,1000", new DateTime(2023, 1, 24, 14, 41, 10, 534, DateTimeKind.Local).AddTicks(6052), new Guid("54ebefd6-9e69-4b9f-95f9-ab0df4fad5cf"), "امتیاز دهم آگهی تبلیغاتی تصویری", true, false, null, null, 9 },
                    { new Guid("0fd9e3fb-9a08-4094-8c70-5ecb53b8d959"), "گردونه", "diamond_sixth_priority", "4", "51,100", new DateTime(2023, 1, 24, 14, 41, 10, 534, DateTimeKind.Local).AddTicks(6040), new Guid("54ebefd6-9e69-4b9f-95f9-ab0df4fad5cf"), "اولویت ششم تعداد الماس و درصد شانس", true, false, null, null, 5 },
                    { new Guid("1189c11b-51c2-4cef-b3c8-dae8b1418ba2"), "آگهی تبلیغاتی", "points_reward_premium_image_ads", null, "1000", new DateTime(2023, 1, 24, 14, 41, 10, 534, DateTimeKind.Local).AddTicks(6063), new Guid("54ebefd6-9e69-4b9f-95f9-ab0df4fad5cf"), "امتیاز ثبت آگهی تبلیغاتی تصویری", true, false, null, null, 13 },
                    { new Guid("19a0604b-d2cb-4e55-ad4a-229e823d3fe0"), "فروشگاه", "store_point_usage_per_day", null, "-1", new DateTime(2023, 1, 24, 14, 41, 10, 534, DateTimeKind.Local).AddTicks(6088), new Guid("54ebefd6-9e69-4b9f-95f9-ab0df4fad5cf"), "تعداد دفعات استفاده از کارت تخفیف هر فروشگاه در روز برای یک مشتری", true, false, null, null, 20 },
                    { new Guid("1a71402f-522a-4a26-8e22-3249357ca20a"), "گردونه", "diamond_fivth_priority", "5", "31,50", new DateTime(2023, 1, 24, 14, 41, 10, 534, DateTimeKind.Local).AddTicks(6038), new Guid("54ebefd6-9e69-4b9f-95f9-ab0df4fad5cf"), "اولویت پنجم تعداد الماس و درصد شانس", true, false, null, null, 4 },
                    { new Guid("1b91b3a6-1a5d-47ad-beba-216a5eb49ba2"), "چالش", "money_needed_to_attend_in_challenge", null, "3000000", new DateTime(2023, 1, 24, 14, 41, 10, 534, DateTimeKind.Local).AddTicks(6115), new Guid("54ebefd6-9e69-4b9f-95f9-ab0df4fad5cf"), "موجودی ریالی برای شرکت در چالش", true, false, null, null, 30 },
                    { new Guid("21ac2c48-00a0-4dc3-b95e-d90b68292baf"), "لایک ها", "def_points_for_video_like", null, "15", new DateTime(2023, 1, 24, 14, 41, 10, 534, DateTimeKind.Local).AddTicks(6075), new Guid("54ebefd6-9e69-4b9f-95f9-ab0df4fad5cf"), "امتیاز پیش فرض برای لایک پست ویدئویی", true, false, null, null, 16 },
                    { new Guid("372598d7-7893-49d3-b5ed-04b0505bf84a"), "ثبت نام", "def_points_for_client_registration", null, "100", new DateTime(2023, 1, 24, 14, 41, 10, 534, DateTimeKind.Local).AddTicks(6078), new Guid("54ebefd6-9e69-4b9f-95f9-ab0df4fad5cf"), "امتیاز اولیه برای کاربری که ثبت نام میکند.", true, false, null, null, 17 },
                    { new Guid("37e3d408-c5ed-4bb1-b4be-4ca8ca7c53f3"), "فروشگاه", "store_def_credit_reg", null, "0", new DateTime(2023, 1, 24, 14, 41, 10, 534, DateTimeKind.Local).AddTicks(6085), new Guid("54ebefd6-9e69-4b9f-95f9-ab0df4fad5cf"), "اعتبار اولیه فروشگاه برای ثبت نام اولین بار", true, false, null, null, 19 },
                    { new Guid("406389a8-55ea-4b57-8adf-c42987e37b18"), "چالش", "prize_for_invite_to_challenge", null, "1000000", new DateTime(2023, 1, 24, 14, 41, 10, 534, DateTimeKind.Local).AddTicks(6118), new Guid("54ebefd6-9e69-4b9f-95f9-ab0df4fad5cf"), "کارمزد برای معرفی کاربران به چالش", true, false, null, null, 31 },
                    { new Guid("42d3c493-55b6-4fd4-b5bd-5583673542a0"), "گردونه", "diamond_fourth_priority", "6", "21,30", new DateTime(2023, 1, 24, 14, 41, 10, 534, DateTimeKind.Local).AddTicks(6035), new Guid("54ebefd6-9e69-4b9f-95f9-ab0df4fad5cf"), "اولویت چهارم تعداد الماس و درصد شانس", true, false, null, null, 3 },
                    { new Guid("50cc41d0-0bb5-4b96-a6c7-654a96908b5e"), "گردونه", "added_points_to_each_spin_diamond_wheel_after_first_time", null, "100", new DateTime(2023, 1, 24, 14, 41, 10, 534, DateTimeKind.Local).AddTicks(6022), new Guid("54ebefd6-9e69-4b9f-95f9-ab0df4fad5cf"), "افزایش تعداد امتیاز به اضای هر بار چرخاندن گردونه شانس در یک روز", true, false, null, null, -1 },
                    { new Guid("5b228792-5cbb-41d7-b421-b29023c49143"), "درصدها", "def_percent_for_marketer", null, "10", new DateTime(2023, 1, 24, 14, 41, 10, 534, DateTimeKind.Local).AddTicks(6098), new Guid("54ebefd6-9e69-4b9f-95f9-ab0df4fad5cf"), "درصد بازاریاب", true, false, null, null, 24 },
                    { new Guid("5d53a346-8025-43e1-85df-d12e7e4e3ab2"), "آگهی تبلیغاتی", "points_reward_premium_video_ads", null, "200", new DateTime(2023, 1, 24, 14, 41, 10, 534, DateTimeKind.Local).AddTicks(6061), new Guid("54ebefd6-9e69-4b9f-95f9-ab0df4fad5cf"), "امتیاز ثبت آگهی تبلیغاتی ویدئویی", true, false, null, null, 12 },
                    { new Guid("5daf3585-dee3-43c6-9e95-ebbc708e57e9"), "گردونه", "diamond_first_priority", "50", "1,5", new DateTime(2023, 1, 24, 14, 41, 10, 534, DateTimeKind.Local).AddTicks(6024), new Guid("54ebefd6-9e69-4b9f-95f9-ab0df4fad5cf"), "اولویت اول تعداد الماس و درصد شانس", true, false, null, null, 0 },
                    { new Guid("67e93c49-5a66-422d-8e00-861a690d7d92"), "گردونه", "diamond_eighth_priority", "2", "201,300", new DateTime(2023, 1, 24, 14, 41, 10, 534, DateTimeKind.Local).AddTicks(6045), new Guid("54ebefd6-9e69-4b9f-95f9-ab0df4fad5cf"), "اولویت هشتم تعداد الماس و درصد شانس", true, false, null, null, 7 },
                    { new Guid("70ec0925-2468-4106-85fc-e8fe883def8c"), "فروشگاه", "credit_for_client_registration_by_store_invitation", null, "50", new DateTime(2023, 1, 24, 14, 41, 10, 534, DateTimeKind.Local).AddTicks(6093), new Guid("54ebefd6-9e69-4b9f-95f9-ab0df4fad5cf"), "اعتبار برای فروشنده ای که باعث ثبت نام مشتری شد", true, false, null, null, 22 },
                    { new Guid("748ac8bd-2c45-49b4-aa80-11e3db534588"), "گردونه", "diamond_second_priority", "20", "6,10", new DateTime(2023, 1, 24, 14, 41, 10, 534, DateTimeKind.Local).AddTicks(6027), new Guid("54ebefd6-9e69-4b9f-95f9-ab0df4fad5cf"), "اولویت دوم تعداد الماس و درصد شانس", true, false, null, null, 1 },
                    { new Guid("86e65d74-d937-459f-abe9-03a1edbffe04"), "لایک ها", "def_points_for_image_like", null, "1", new DateTime(2023, 1, 24, 14, 41, 10, 534, DateTimeKind.Local).AddTicks(6073), new Guid("54ebefd6-9e69-4b9f-95f9-ab0df4fad5cf"), "امتیاز پیش فرض برای لایک پست تصویری", true, false, null, null, 15 },
                    { new Guid("87f64430-77d4-4bcb-b9a5-d3b3a25beff6"), "گردونه", "diamond_nineth_priority", "0", "301,500", new DateTime(2023, 1, 24, 14, 41, 10, 534, DateTimeKind.Local).AddTicks(6048), new Guid("54ebefd6-9e69-4b9f-95f9-ab0df4fad5cf"), "امتیاز نهم آگهی تبلیغاتی تصویری", true, false, null, null, 8 },
                    { new Guid("a354b6d4-27f5-4e54-ad4b-87119772dfe0"), "گردونه", "diamond_seventh_priority", "3", "101,200", new DateTime(2023, 1, 24, 14, 41, 10, 534, DateTimeKind.Local).AddTicks(6043), new Guid("54ebefd6-9e69-4b9f-95f9-ab0df4fad5cf"), "اولویت هفتم تعداد الماس و درصد شانس", true, false, null, null, 6 },
                    { new Guid("a8db3f2c-17a4-457d-9c7c-f643dcfbfeef"), "آگهی تبلیغاتی", "def_money_to_premium_image_ads", null, "200000", new DateTime(2023, 1, 24, 14, 41, 10, 534, DateTimeKind.Local).AddTicks(6058), new Guid("54ebefd6-9e69-4b9f-95f9-ab0df4fad5cf"), "هزینه درج آگهی تبلیغاتی تصویری", true, false, null, null, 11 },
                    { new Guid("b66d155b-ab10-48a0-a566-3cc2ae00ad82"), "آگهی تبلیغاتی", "def_money_to_premium_video_ads", null, "1000000", new DateTime(2023, 1, 24, 14, 41, 10, 534, DateTimeKind.Local).AddTicks(6054), new Guid("54ebefd6-9e69-4b9f-95f9-ab0df4fad5cf"), "هزینه درج آگهی تبلیغاتی ویدئویی", true, false, null, null, 10 },
                    { new Guid("bfbd64e7-8c60-49d7-8871-8f943feda895"), "کارت اعتباری", "def_chips_usage_perday", null, "-1", new DateTime(2023, 1, 24, 14, 41, 10, 534, DateTimeKind.Local).AddTicks(6070), new Guid("54ebefd6-9e69-4b9f-95f9-ab0df4fad5cf"), "تعداد استفاده از کارت اعتباری هر کاربر در روز", true, false, null, null, 14 },
                    { new Guid("c07233eb-c334-4f98-9505-e1367e1e9d1f"), "فروشگاه", "stores_max_donnation_point", null, "500", new DateTime(2023, 1, 24, 14, 41, 10, 534, DateTimeKind.Local).AddTicks(6090), new Guid("54ebefd6-9e69-4b9f-95f9-ab0df4fad5cf"), "حداکثر امتیازی که فروشگاه میتواند در هر نوتب هدیه بدهد", true, false, null, null, 21 },
                    { new Guid("cd5fb72e-5fda-4f05-a540-9a10e8457824"), "مالی", "money_to_credit_ratio", null, "1000", new DateTime(2023, 1, 24, 14, 41, 10, 534, DateTimeKind.Local).AddTicks(6096), new Guid("54ebefd6-9e69-4b9f-95f9-ab0df4fad5cf"), "نسبت هر اعتبار به تومان", true, false, null, null, 23 },
                    { new Guid("d8b8e57d-4963-4371-968c-e554972829cd"), "درصدها", "def_percent_for_countryadmin", null, "4", new DateTime(2023, 1, 24, 14, 41, 10, 534, DateTimeKind.Local).AddTicks(6103), new Guid("54ebefd6-9e69-4b9f-95f9-ab0df4fad5cf"), "درصد مدیر مناطق", true, false, null, null, 26 },
                    { new Guid("df45c49d-68d6-4e64-92eb-163f69e2d299"), "اعتبار", "credit_for_image_ads", null, "500", new DateTime(2023, 1, 24, 14, 41, 10, 534, DateTimeKind.Local).AddTicks(6107), new Guid("54ebefd6-9e69-4b9f-95f9-ab0df4fad5cf"), "اعتبار لازم برای ثبت آگهی تصویری", true, false, null, null, 27 },
                    { new Guid("e578fd27-de45-4b3e-aa25-0aa9d920c93b"), "چالش", "expire_dates_for_challenge", null, "60", new DateTime(2023, 1, 24, 14, 41, 10, 534, DateTimeKind.Local).AddTicks(6113), new Guid("54ebefd6-9e69-4b9f-95f9-ab0df4fad5cf"), "تعداد روزهای مجاز برای چالش", true, false, null, null, 29 },
                    { new Guid("e81e57dd-7d13-413a-af9c-bc3c66ddabf6"), "گردونه", "diamond_third_priority", "10", "11,20", new DateTime(2023, 1, 24, 14, 41, 10, 534, DateTimeKind.Local).AddTicks(6030), new Guid("54ebefd6-9e69-4b9f-95f9-ab0df4fad5cf"), "اولویت سوم تعداد الماس و درصد شانس", true, false, null, null, 2 },
                    { new Guid("eddf3209-1414-4908-b683-e4628ee33570"), "گردونه", "min_points_to_spin_diamond_wheel", null, "200", new DateTime(2023, 1, 24, 14, 41, 10, 534, DateTimeKind.Local).AddTicks(6016), new Guid("54ebefd6-9e69-4b9f-95f9-ab0df4fad5cf"), "حداقل امتیاز برای چرخاندن گردونه شانس الماس بار اول", true, false, null, null, -2 },
                    { new Guid("f067d080-f7ef-46ca-a4de-b7895bf0c205"), "اعتبار", "credit_for_video_ads", null, "1000", new DateTime(2023, 1, 24, 14, 41, 10, 534, DateTimeKind.Local).AddTicks(6110), new Guid("54ebefd6-9e69-4b9f-95f9-ab0df4fad5cf"), "اعتبار لازم برای ثبت آگهی ویدئویی", true, false, null, null, 28 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Priority", "RoleDescription", "RoleName" },
                values: new object[,]
                {
                    { new Guid("08f1afa7-49fe-46e3-904f-00fa090a0d9f"), null, null, true, false, null, null, 1, "مدیر سامانه", "admin" },
                    { new Guid("0f59c49d-ec20-4ceb-b939-fc130dcd3f26"), null, null, true, false, null, null, 3, "مدیر منطقه", "zoneadmin" },
                    { new Guid("24c238e3-11a9-44dd-89c2-82b8de6b8195"), null, null, true, false, null, null, 5, "فروشگاه", "store" },
                    { new Guid("285de520-0f66-43ec-94b0-b78bc8ff25a6"), null, null, true, false, null, null, 6, "مشتری", "client" },
                    { new Guid("424b315f-8c4f-4bec-84c7-55e2f9c43638"), null, null, true, false, null, null, 2, "مدیر کل مناطق", "countryadmin" },
                    { new Guid("cf765405-1daa-40dc-ae74-ea1ebfb5fe45"), null, null, true, false, null, null, 4, "بازاریاب", "marketer" },
                    { new Guid("d3627b10-14d2-4de9-905a-2a23dec07056"), null, null, true, false, null, null, 0, "مدیر کل", "super" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CardNumber", "Cellphone", "ConfirmationCode", "Created", "Credits", "DefaultCredit", "Diamonds", "DonnationActive", "Family", "Inviter", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Money", "Name", "Notes", "Points", "ProfileMediaURL", "Username" },
                values: new object[] { new Guid("0295f800-3c12-4b93-b6fd-bed32e04bd86"), null, "09111111111", "111111", new DateTime(2023, 1, 24, 14, 41, 10, 534, DateTimeKind.Local).AddTicks(5684), 0L, 0L, 0, false, "user1", null, true, false, null, null, 0L, "first", null, 90L, "uploads/2022/9/sina2.jpg", "firstuser" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CardNumber", "Cellphone", "ConfirmationCode", "Created", "Credits", "DefaultCredit", "Diamonds", "DonnationActive", "Family", "Inviter", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Money", "Name", "Notes", "Points", "ProfileMediaURL", "Username" },
                values: new object[,]
                {
                    { new Guid("1749e916-17dc-4166-8ae9-642c8349d77d"), null, "09166666666", "111111", new DateTime(2023, 1, 24, 14, 41, 10, 534, DateTimeKind.Local).AddTicks(5708), 0L, 0L, 0, false, "user6", null, true, false, null, null, 0L, "sixth", null, 90L, "uploads/2022/9/sina2.jpg", "sixthuser" },
                    { new Guid("25b1bc19-8162-4280-86fb-ad11f36a6a16"), null, "09100000000", "111111", new DateTime(2023, 1, 24, 14, 41, 10, 534, DateTimeKind.Local).AddTicks(5720), 0L, 0L, 0, false, "user10", null, true, false, null, null, 0L, "tenth", null, 90L, "uploads/2022/9/sina2.jpg", "tenthuser" },
                    { new Guid("2d2a66b5-c86b-4f11-825a-a5becabb2345"), null, "09133333333", "111111", new DateTime(2023, 1, 24, 14, 41, 10, 534, DateTimeKind.Local).AddTicks(5700), 0L, 0L, 0, false, "user3", null, true, false, null, null, 0L, "third", null, 90L, "uploads/2022/9/sina2.jpg", "thirduser" },
                    { new Guid("54ebefd6-9e69-4b9f-95f9-ab0df4fad5cf"), null, "09394125130", "111111", new DateTime(2023, 1, 24, 14, 41, 10, 534, DateTimeKind.Local).AddTicks(5680), 0L, 0L, 0, false, "Jouybari", new Guid("5826f444-473d-4f2b-8532-f8bfc8961e89"), true, false, null, null, 850000L, "Sina", null, 90L, "uploads/2022/9/sina2.jpg", "sinful" },
                    { new Guid("5826f444-473d-4f2b-8532-f8bfc8961e89"), null, "09901069557", null, new DateTime(2023, 1, 24, 14, 41, 10, 534, DateTimeKind.Local).AddTicks(5645), 1000L, 0L, 0, true, "دابویی مشک آبادی", null, true, false, null, null, 0L, "عبدالرحمن", null, 100L, "uploads/2022/9/photo.jpg", "dabooei" },
                    { new Guid("67717ae1-e2ce-4554-abc6-172fd5882457"), null, "09122222222", "111111", new DateTime(2023, 1, 24, 14, 41, 10, 534, DateTimeKind.Local).AddTicks(5687), 0L, 0L, 0, false, "user2", null, true, false, null, null, 0L, "second", null, 90L, "uploads/2022/9/sina2.jpg", "seconduser" },
                    { new Guid("8d6d23b7-2ce0-44e9-9962-696d8d0aaa3c"), null, "09155555555", "111111", new DateTime(2023, 1, 24, 14, 41, 10, 534, DateTimeKind.Local).AddTicks(5705), 0L, 0L, 0, false, "user5", null, true, false, null, null, 0L, "fivth", null, 90L, "uploads/2022/9/sina2.jpg", "fivthuser" },
                    { new Guid("8f6a671c-410b-472e-a614-119d575072ca"), null, "09188888888", "111111", new DateTime(2023, 1, 24, 14, 41, 10, 534, DateTimeKind.Local).AddTicks(5715), 0L, 0L, 0, false, "user8", null, true, false, null, null, 0L, "eighth", null, 90L, "uploads/2022/9/sina2.jpg", "eighthuser" },
                    { new Guid("9a259729-844f-4043-82d1-11fd12adb036"), null, "09144444444", "111111", new DateTime(2023, 1, 24, 14, 41, 10, 534, DateTimeKind.Local).AddTicks(5703), 0L, 0L, 0, false, "user4", null, true, false, null, null, 0L, "fourth", null, 90L, "uploads/2022/9/sina2.jpg", "fourthuser" },
                    { new Guid("c635d022-9c42-474c-b44e-8d38d0349c2b"), null, "09177777777", "111111", new DateTime(2023, 1, 24, 14, 41, 10, 534, DateTimeKind.Local).AddTicks(5712), 0L, 0L, 0, false, "user7", null, true, false, null, null, 0L, "seventh", null, 90L, "uploads/2022/9/sina2.jpg", "seventhuser" },
                    { new Guid("e1e41c76-deb3-40fb-b747-38ec71b2ecd7"), null, "09199999999", "111111", new DateTime(2023, 1, 24, 14, 41, 10, 534, DateTimeKind.Local).AddTicks(5717), 0L, 0L, 0, false, "user9", null, true, false, null, null, 0L, "ninth", null, 90L, "uploads/2022/9/sina2.jpg", "ninthuser" }
                });

            migrationBuilder.InsertData(
                table: "UsersRoles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "Role", "User" },
                values: new object[,]
                {
                    { new Guid("349134d8-7186-492c-979a-dfc7f080cc1d"), null, new Guid("8d6d23b7-2ce0-44e9-9962-696d8d0aaa3c"), false, null, null, new Guid("285de520-0f66-43ec-94b0-b78bc8ff25a6"), new Guid("8d6d23b7-2ce0-44e9-9962-696d8d0aaa3c") },
                    { new Guid("4253ddd3-8577-4024-8ff7-6e5670b81f52"), null, new Guid("0295f800-3c12-4b93-b6fd-bed32e04bd86"), false, null, null, new Guid("285de520-0f66-43ec-94b0-b78bc8ff25a6"), new Guid("0295f800-3c12-4b93-b6fd-bed32e04bd86") },
                    { new Guid("5a6997b9-52d7-4dd5-a798-1e65123369ec"), null, new Guid("5826f444-473d-4f2b-8532-f8bfc8961e89"), false, null, null, new Guid("24c238e3-11a9-44dd-89c2-82b8de6b8195"), new Guid("5826f444-473d-4f2b-8532-f8bfc8961e89") },
                    { new Guid("5bc3a959-3f7d-44b8-b81d-726c62dc836f"), null, new Guid("8f6a671c-410b-472e-a614-119d575072ca"), false, null, null, new Guid("285de520-0f66-43ec-94b0-b78bc8ff25a6"), new Guid("8f6a671c-410b-472e-a614-119d575072ca") },
                    { new Guid("6aeb85aa-4be2-484a-879e-63379035233b"), null, new Guid("54ebefd6-9e69-4b9f-95f9-ab0df4fad5cf"), false, null, null, new Guid("d3627b10-14d2-4de9-905a-2a23dec07056"), new Guid("54ebefd6-9e69-4b9f-95f9-ab0df4fad5cf") },
                    { new Guid("94db8d22-0b66-4411-939d-b1485150fd57"), null, new Guid("25b1bc19-8162-4280-86fb-ad11f36a6a16"), false, null, null, new Guid("285de520-0f66-43ec-94b0-b78bc8ff25a6"), new Guid("25b1bc19-8162-4280-86fb-ad11f36a6a16") },
                    { new Guid("a142db26-03da-43e7-9c2a-1c0e08c186ed"), null, new Guid("9a259729-844f-4043-82d1-11fd12adb036"), false, null, null, new Guid("285de520-0f66-43ec-94b0-b78bc8ff25a6"), new Guid("9a259729-844f-4043-82d1-11fd12adb036") },
                    { new Guid("b3ad5ac8-2842-46fd-9bf4-b62d80862518"), null, new Guid("1749e916-17dc-4166-8ae9-642c8349d77d"), false, null, null, new Guid("285de520-0f66-43ec-94b0-b78bc8ff25a6"), new Guid("1749e916-17dc-4166-8ae9-642c8349d77d") },
                    { new Guid("d942a6d3-0ece-4b09-a661-3dfd52fe0023"), null, new Guid("e1e41c76-deb3-40fb-b747-38ec71b2ecd7"), false, null, null, new Guid("285de520-0f66-43ec-94b0-b78bc8ff25a6"), new Guid("e1e41c76-deb3-40fb-b747-38ec71b2ecd7") },
                    { new Guid("db60ecc5-1584-4a15-8fd0-30bd78ccbf59"), null, new Guid("25b1bc19-8162-4280-86fb-ad11f36a6a16"), false, null, null, new Guid("285de520-0f66-43ec-94b0-b78bc8ff25a6"), new Guid("25b1bc19-8162-4280-86fb-ad11f36a6a16") },
                    { new Guid("f4901833-68a9-4c62-8a4d-e557c1fa9efb"), null, new Guid("67717ae1-e2ce-4554-abc6-172fd5882457"), false, null, null, new Guid("285de520-0f66-43ec-94b0-b78bc8ff25a6"), new Guid("67717ae1-e2ce-4554-abc6-172fd5882457") },
                    { new Guid("fca34ed6-c641-485a-81e2-f0600aaaad55"), null, new Guid("c635d022-9c42-474c-b44e-8d38d0349c2b"), false, null, null, new Guid("285de520-0f66-43ec-94b0-b78bc8ff25a6"), new Guid("c635d022-9c42-474c-b44e-8d38d0349c2b") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Advertises");

            migrationBuilder.DropTable(
                name: "ChallengeUserData");

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
