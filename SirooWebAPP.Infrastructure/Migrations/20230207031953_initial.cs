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
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsExported = table.Column<bool>(type: "bit", nullable: true),
                    ChallengeModeIndex = table.Column<int>(type: "int", nullable: true),
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
                name: "ChatMessages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FromUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ToUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TheMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatMessages", x => x.Id);
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
                name: "GraphHistory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Graph = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    User = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ToUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GraphModeIndex = table.Column<int>(type: "int", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GraphHistory", x => x.Id);
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
                    GraphTypeIndex = table.Column<int>(type: "int", nullable: true),
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
                    { new Guid("03893fd9-cd31-4166-8f87-72ac2c6e2035"), "گردونه", "diamond_first_priority", "50", "1,5", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(3502), new Guid("a25da402-a10e-47bb-8871-29baaf111c7a"), "اولویت اول تعداد الماس و درصد شانس", true, false, null, null, 0 },
                    { new Guid("0d71fe9a-2ca7-43c0-b5bf-c1a78336ee67"), "آگهی تبلیغاتی", "points_reward_premium_image_ads", null, "1000", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(3568), new Guid("a25da402-a10e-47bb-8871-29baaf111c7a"), "امتیاز ثبت آگهی تبلیغاتی تصویری", true, false, null, null, 13 },
                    { new Guid("11c3c9de-cd71-4cb6-b530-420786ddfdc0"), "اعتبار", "credit_for_video_ads", null, "1000", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(3636), new Guid("a25da402-a10e-47bb-8871-29baaf111c7a"), "اعتبار لازم برای ثبت آگهی ویدئویی", true, false, null, null, 28 },
                    { new Guid("15be6c45-0091-40e6-9bc1-ed83b17fe6c6"), "لایک ها", "def_points_for_video_like", null, "15", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(3583), new Guid("a25da402-a10e-47bb-8871-29baaf111c7a"), "امتیاز پیش فرض برای لایک پست ویدئویی", true, false, null, null, 16 },
                    { new Guid("178652f6-6d3a-49a7-9d8f-882d07b61cf8"), "چالش", "expire_dates_for_challenge_1", null, "30", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(3641), new Guid("a25da402-a10e-47bb-8871-29baaf111c7a"), "تعداد روزهای مجاز برای چالش نوع 1", true, false, null, null, 29 },
                    { new Guid("1c026dd8-2017-4465-b8ea-695bff97fe39"), "چالش", "order_of_prize_payment_3", null, "2,3,5", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(3701), new Guid("a25da402-a10e-47bb-8871-29baaf111c7a"), "ترتیب پرداخت کارمزدها نوع 3", true, false, null, null, 42 },
                    { new Guid("1c643ce3-88ff-4719-904b-f24f311de874"), "گردونه", "diamond_eighth_priority", "2", "201,300", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(3540), new Guid("a25da402-a10e-47bb-8871-29baaf111c7a"), "اولویت هشتم تعداد الماس و درصد شانس", true, false, null, null, 7 },
                    { new Guid("2a4cf9b2-abe4-48f0-9c69-601af15a3d69"), "گردونه", "added_points_to_each_spin_diamond_wheel_after_first_time", null, "100", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(3494), new Guid("a25da402-a10e-47bb-8871-29baaf111c7a"), "افزایش تعداد امتیاز به اضای هر بار چرخاندن گردونه شانس در یک روز", true, false, null, null, -1 },
                    { new Guid("3aae8b69-a097-4952-87f4-5f50f8f3ccff"), "لایک ها", "def_points_for_image_like", null, "1", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(3576), new Guid("a25da402-a10e-47bb-8871-29baaf111c7a"), "امتیاز پیش فرض برای لایک پست تصویری", true, false, null, null, 15 },
                    { new Guid("3d725ca8-f707-4bae-b5d7-4ecc21523573"), "چالش", "money_needed_to_attend_in_challenge_1", null, "300000", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(3645), new Guid("a25da402-a10e-47bb-8871-29baaf111c7a"), "موجودی ریالی برای شرکت در چالش نوع 1", true, false, null, null, 30 },
                    { new Guid("4d930576-34cd-49d8-b8dd-d46fc5d8cb64"), "چالش", "prize_for_invite_to_challenge_1", null, "100000", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(3649), new Guid("a25da402-a10e-47bb-8871-29baaf111c7a"), "کارمزد برای معرفی کاربران به چالش نوع 1", true, false, null, null, 31 },
                    { new Guid("4e67d415-1ff7-4046-b9de-425594710bab"), "درصدها", "def_percent_for_marketer", null, "10", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(3619), new Guid("a25da402-a10e-47bb-8871-29baaf111c7a"), "درصد بازاریاب", true, false, null, null, 24 },
                    { new Guid("50a7a395-a73b-466f-b90e-d7a353cdbc65"), "ثبت نام", "def_points_for_client_registration", null, "100", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(3587), new Guid("a25da402-a10e-47bb-8871-29baaf111c7a"), "امتیاز اولیه برای کاربری که ثبت نام میکند.", true, false, null, null, 17 },
                    { new Guid("53ed41f4-8f3e-4aea-9cd5-ffcc1dc0b6bf"), "چالش", "money_needed_to_attend_in_challenge_3", null, "30000000", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(3692), new Guid("a25da402-a10e-47bb-8871-29baaf111c7a"), "موجودی ریالی برای شرکت در چالش نوع 3", true, false, null, null, 40 },
                    { new Guid("58a4a4e3-ea9a-4457-bdb7-a0d2554411e1"), "چالش", "maximum_number_of_prize_payment_3", null, "1000", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(3705), new Guid("a25da402-a10e-47bb-8871-29baaf111c7a"), "حداکثر تعداد پرداخت کارمزدها نوع 3", true, false, null, null, 43 },
                    { new Guid("5d22120a-a6a6-4093-a088-517dac16dafe"), "گردونه", "diamond_third_priority", "10", "11,20", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(3510), new Guid("a25da402-a10e-47bb-8871-29baaf111c7a"), "اولویت سوم تعداد الماس و درصد شانس", true, false, null, null, 2 },
                    { new Guid("64cb9cdb-6243-4fc4-a7bf-07dd2f78d100"), "فروشگاه", "stores_max_donnation_point", null, "500", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(3604), new Guid("a25da402-a10e-47bb-8871-29baaf111c7a"), "حداکثر امتیازی که فروشگاه میتواند در هر نوتب هدیه بدهد", true, false, null, null, 21 },
                    { new Guid("6c65e33f-aa8c-4429-8c1b-7175a6127034"), "آگهی تبلیغاتی", "def_money_to_premium_video_ads", null, "1000000", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(3554), new Guid("a25da402-a10e-47bb-8871-29baaf111c7a"), "هزینه درج آگهی تبلیغاتی ویدئویی", true, false, null, null, 10 },
                    { new Guid("6d255e93-5201-4852-8a86-f65bcc161510"), "فروشگاه", "store_point_usage_per_day", null, "-1", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(3600), new Guid("a25da402-a10e-47bb-8871-29baaf111c7a"), "تعداد دفعات استفاده از کارت تخفیف هر فروشگاه در روز برای یک مشتری", true, false, null, null, 20 },
                    { new Guid("77b67f61-3155-4e71-869e-1a0414440a53"), "درصدها", "def_percent_for_countryadmin", null, "4", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(3628), new Guid("a25da402-a10e-47bb-8871-29baaf111c7a"), "درصد مدیر مناطق", true, false, null, null, 26 },
                    { new Guid("7c6970e3-4f49-4a71-b81d-e44b16639751"), "چالش", "expire_dates_for_challenge_2", null, "60", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(3664), new Guid("a25da402-a10e-47bb-8871-29baaf111c7a"), "تعداد روزهای مجاز برای چالش نوع 2", true, false, null, null, 34 },
                    { new Guid("7d5064d7-2afd-43ca-af92-e806dc4f0d93"), "آگهی تبلیغاتی", "def_money_to_premium_image_ads", null, "200000", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(3560), new Guid("a25da402-a10e-47bb-8871-29baaf111c7a"), "هزینه درج آگهی تبلیغاتی تصویری", true, false, null, null, 11 },
                    { new Guid("881eb7f1-00a9-401a-b1fe-04ac812e810f"), "چالش", "maximum_number_of_prize_payment_2", null, "1000", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(3682), new Guid("a25da402-a10e-47bb-8871-29baaf111c7a"), "حداکثر تعداد پرداخت کارمزدها نوع 2", true, false, null, null, 38 },
                    { new Guid("8d755823-d538-4856-8189-1d605034e9c2"), "گردونه", "diamond_seventh_priority", "3", "101,200", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(3536), new Guid("a25da402-a10e-47bb-8871-29baaf111c7a"), "اولویت هفتم تعداد الماس و درصد شانس", true, false, null, null, 6 },
                    { new Guid("8f81882c-3c91-4e43-9a5c-4d38a149d950"), "چالش", "prize_for_invite_to_challenge_3", null, "10000000", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(3697), new Guid("a25da402-a10e-47bb-8871-29baaf111c7a"), "کارمزد برای معرفی کاربران به چالش نوع 3", true, false, null, null, 41 },
                    { new Guid("943f2de1-f651-42ac-bf51-6a7d302f727d"), "چالش", "expire_dates_for_challenge_3", null, "90", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(3685), new Guid("a25da402-a10e-47bb-8871-29baaf111c7a"), "تعداد روزهای مجاز برای چالش نوع 3", true, false, null, null, 39 },
                    { new Guid("967af631-464c-4289-b2dd-558c690832f2"), "درصدها", "def_percent_for_zoneadmin", null, "6", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(3624), new Guid("a25da402-a10e-47bb-8871-29baaf111c7a"), "درصد مدیر منطقه", true, false, null, null, 25 },
                    { new Guid("9888f2f0-a2a0-487b-80c1-66d86d9b78c5"), "گردونه", "diamond_sixth_priority", "4", "51,100", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(3523), new Guid("a25da402-a10e-47bb-8871-29baaf111c7a"), "اولویت ششم تعداد الماس و درصد شانس", true, false, null, null, 5 },
                    { new Guid("a6c5ea83-439f-430d-a066-b52d3c4c75d6"), "فروشگاه", "store_def_credit_reg", null, "0", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(3596), new Guid("a25da402-a10e-47bb-8871-29baaf111c7a"), "اعتبار اولیه فروشگاه برای ثبت نام اولین بار", true, false, null, null, 19 },
                    { new Guid("aa25af21-2af8-4f93-a8f9-31b6f34ba0b6"), "کارت اعتباری", "def_chips_usage_perday", null, "-1", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(3572), new Guid("a25da402-a10e-47bb-8871-29baaf111c7a"), "تعداد استفاده از کارت اعتباری هر کاربر در روز", true, false, null, null, 14 },
                    { new Guid("b47ced54-fa79-4cc3-a4af-f50c5b4bc5cc"), "چالش", "prize_for_invite_to_challenge_2", null, "1000000", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(3673), new Guid("a25da402-a10e-47bb-8871-29baaf111c7a"), "کارمزد برای معرفی کاربران به چالش نوع 2", true, false, null, null, 36 },
                    { new Guid("b8f83bcd-f0a7-4a6f-9371-9cb63e727b72"), "چالش", "order_of_prize_payment_1", null, "2,3,5", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(3656), new Guid("a25da402-a10e-47bb-8871-29baaf111c7a"), "ترتیب پرداخت کارمزدها نوع 1", true, false, null, null, 32 },
                    { new Guid("c2b51a1c-0f82-495f-ad4d-881970308405"), "گردونه", "diamond_fourth_priority", "6", "21,30", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(3515), new Guid("a25da402-a10e-47bb-8871-29baaf111c7a"), "اولویت چهارم تعداد الماس و درصد شانس", true, false, null, null, 3 },
                    { new Guid("c82b1013-d073-4640-b8d7-c55d2f3f0f87"), "چالش", "money_needed_to_attend_in_challenge_2", null, "3550000", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(3669), new Guid("a25da402-a10e-47bb-8871-29baaf111c7a"), "موجودی ریالی برای شرکت در چالش نوع 2", true, false, null, null, 35 },
                    { new Guid("c9d4d46d-75bd-45d4-ab66-1e542b31369c"), "چالش", "order_of_prize_payment_2", null, "2,3,5", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(3678), new Guid("a25da402-a10e-47bb-8871-29baaf111c7a"), "ترتیب پرداخت کارمزدها نوع 2", true, false, null, null, 37 },
                    { new Guid("ca8f751b-4166-45db-bf6b-d441d9e0fe1f"), "گردونه", "diamond_fivth_priority", "5", "31,50", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(3519), new Guid("a25da402-a10e-47bb-8871-29baaf111c7a"), "اولویت پنجم تعداد الماس و درصد شانس", true, false, null, null, 4 },
                    { new Guid("cc073825-c9c4-4712-82bb-4fbd309a5339"), "گردونه", "min_points_to_spin_diamond_wheel", null, "200", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(3486), new Guid("a25da402-a10e-47bb-8871-29baaf111c7a"), "حداقل امتیاز برای چرخاندن گردونه شانس الماس بار اول", true, false, null, null, -2 },
                    { new Guid("cc2d7aa6-2a5d-4d95-bb44-b2d1f526223b"), "فروشگاه", "credit_for_client_registration_by_store_invitation", null, "50", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(3608), new Guid("a25da402-a10e-47bb-8871-29baaf111c7a"), "اعتبار برای فروشنده ای که باعث ثبت نام مشتری شد", true, false, null, null, 22 },
                    { new Guid("cd4df2cb-d70c-4770-897f-e5a843a56b8c"), "گردونه", "diamond_nineth_priority", "0", "301,500", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(3546), new Guid("a25da402-a10e-47bb-8871-29baaf111c7a"), "امتیاز نهم آگهی تبلیغاتی تصویری", true, false, null, null, 8 },
                    { new Guid("d43ff69f-c4e2-49e3-bde6-f77abc3fc8a6"), "گردونه", "diamond_tenth_priority", "0", "999,1000", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(3550), new Guid("a25da402-a10e-47bb-8871-29baaf111c7a"), "امتیاز دهم آگهی تبلیغاتی تصویری", true, false, null, null, 9 },
                    { new Guid("d64f99a2-6814-4b83-9670-730f88ec4a26"), "اعتبار", "credit_for_image_ads", null, "500", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(3631), new Guid("a25da402-a10e-47bb-8871-29baaf111c7a"), "اعتبار لازم برای ثبت آگهی تصویری", true, false, null, null, 27 },
                    { new Guid("d657eb9c-da49-4cbd-ba65-b69750f5e8dd"), "چالش", "maximum_number_of_prize_payment_1", null, "1000", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(3660), new Guid("a25da402-a10e-47bb-8871-29baaf111c7a"), "حداکثر تعداد پرداخت کارمزدها نوع 1", true, false, null, null, 33 }
                });

            migrationBuilder.InsertData(
                table: "ConstantDictionaries",
                columns: new[] { "Id", "Category", "ConstantKey", "ConstantSecondValue", "ConstantValue", "Created", "CreatedBy", "Description", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "PriorityIndex" },
                values: new object[,]
                {
                    { new Guid("d6e5c08c-7eb2-405f-9661-b90bc50a5320"), "آگهی تبلیغاتی", "points_reward_premium_video_ads", null, "200", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(3564), new Guid("a25da402-a10e-47bb-8871-29baaf111c7a"), "امتیاز ثبت آگهی تبلیغاتی ویدئویی", true, false, null, null, 12 },
                    { new Guid("da5e8648-0aaa-485a-b4ea-f0a7751b4cb7"), "ثبت نام", "def_points_for_client_invitation", null, "50", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(3591), new Guid("a25da402-a10e-47bb-8871-29baaf111c7a"), "امتیاز برای معرف وقتی کاربر ثبت نام کرد.", true, false, null, null, 18 },
                    { new Guid("efd26894-ff3f-4f0e-a6f3-4331f84a8bda"), "گردونه", "diamond_second_priority", "20", "6,10", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(3506), new Guid("a25da402-a10e-47bb-8871-29baaf111c7a"), "اولویت دوم تعداد الماس و درصد شانس", true, false, null, null, 1 },
                    { new Guid("fdc76d41-1ee1-46e5-b1ab-4619a9044183"), "مالی", "money_to_credit_ratio", null, "1000", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(3612), new Guid("a25da402-a10e-47bb-8871-29baaf111c7a"), "نسبت هر اعتبار به تومان", true, false, null, null, 23 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Priority", "RoleDescription", "RoleName" },
                values: new object[,]
                {
                    { new Guid("1f11cd21-7123-4cc7-b8a6-112c36314ae9"), null, null, true, false, null, null, 0, "مدیر کل", "super" },
                    { new Guid("27aa78a8-2548-441b-a134-a345f12ff151"), null, null, true, false, null, null, 4, "بازاریاب", "marketer" },
                    { new Guid("32c9a924-8378-4bdc-aba1-4b41702034e4"), null, null, true, false, null, null, 3, "مدیر منطقه", "zoneadmin" },
                    { new Guid("885bfcf7-15a9-4077-a123-440256940169"), null, null, true, false, null, null, 2, "مدیر کل مناطق", "countryadmin" },
                    { new Guid("9f2b307f-cbff-4ee6-a301-1c4cef8f17be"), null, null, true, false, null, null, 6, "مشتری", "client" },
                    { new Guid("c15a0ba9-f835-4c3d-b82c-2c6a5606f6c2"), null, null, true, false, null, null, 5, "فروشگاه", "store" },
                    { new Guid("debe7724-98e5-4d40-bd75-688f167a93ba"), null, null, true, false, null, null, 1, "مدیر سامانه", "admin" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CardNumber", "Cellphone", "ConfirmationCode", "Created", "Credits", "DefaultCredit", "Diamonds", "DonnationActive", "Family", "Inviter", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Money", "Name", "Notes", "Points", "ProfileMediaURL", "Username" },
                values: new object[,]
                {
                    { new Guid("2e64646c-21bd-48a9-8c74-950c2cf8ecb1"), null, "09188888888", "111111", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(2980), 0L, 0L, 0, false, "user8", null, true, false, null, null, 3000000L, "eighth", null, 90L, "uploads/2022/9/sina2.jpg", "eighthuser" },
                    { new Guid("33586738-999b-40a0-ac8c-fa78315f8511"), null, "09901069557", null, new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(2876), 1000L, 0L, 0, true, "دابویی مشک آبادی", null, true, false, null, null, 0L, "عبدالرحمن", null, 100L, "uploads/2022/9/photo.jpg", "dabooei" },
                    { new Guid("569483bb-6cae-4921-9f4c-dbd2f1fbd7d3"), null, "09100000000", "111111", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(2992), 0L, 0L, 0, false, "user10", null, true, false, null, null, 3000000L, "tenth", null, 90L, "uploads/2022/9/sina2.jpg", "tenthuser" },
                    { new Guid("61dafefb-8d95-40c0-a853-2f3b66eaa75b"), null, "09011000000", "111111", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(2996), 0L, 0L, 0, false, "user11", null, true, false, null, null, 3000000L, "eleventh", null, 90L, "uploads/2022/9/sina2.jpg", "eleventhuser" },
                    { new Guid("6d0c65b1-6d1b-4b1f-b490-ffd77e9fe18e"), null, "09177777777", "111111", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(2976), 0L, 0L, 0, false, "user7", null, true, false, null, null, 3000000L, "seventh", null, 90L, "uploads/2022/9/sina2.jpg", "seventhuser" },
                    { new Guid("986519c7-2148-43c0-8f9f-1d467ba48a89"), null, "09122222222", "111111", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(2950), 0L, 0L, 0, false, "user2", null, true, false, null, null, 3000000L, "second", null, 90L, "uploads/2022/9/sina2.jpg", "seconduser" },
                    { new Guid("a1a86a35-2b91-48c2-b7d8-96b8558a8e4e"), null, "09155555555", "111111", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(2968), 0L, 0L, 0, false, "user5", null, true, false, null, null, 3000000L, "fivth", null, 90L, "uploads/2022/9/sina2.jpg", "fivthuser" },
                    { new Guid("a25da402-a10e-47bb-8871-29baaf111c7a"), null, "09394125130", "111111", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(2924), 0L, 0L, 0, false, "Jouybari", new Guid("33586738-999b-40a0-ac8c-fa78315f8511"), true, false, null, null, 850000L, "Sina", null, 90L, "uploads/2022/9/sina2.jpg", "sinful" },
                    { new Guid("c2099b91-8394-4be5-ad6a-8e10d4d5b067"), null, "09133333333", "111111", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(2955), 0L, 0L, 0, false, "user3", null, true, false, null, null, 3000000L, "third", null, 90L, "uploads/2022/9/sina2.jpg", "thirduser" },
                    { new Guid("c407d2f7-62cc-4d39-926a-8395c46ddcfa"), null, "09144444444", "111111", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(2960), 0L, 0L, 0, false, "user4", null, true, false, null, null, 3000000L, "fourth", null, 90L, "uploads/2022/9/sina2.jpg", "fourthuser" },
                    { new Guid("c4b6ad2c-2ef7-4223-8182-e6a44368d3e0"), null, "09111111111", "111111", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(2929), 0L, 0L, 0, false, "user1", null, true, false, null, null, 3000000L, "first", null, 90L, "uploads/2022/9/sina2.jpg", "firstuser" },
                    { new Guid("c85fbc3b-d84d-4bf8-91be-4d297a2770d2"), null, "09166666666", "111111", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(2972), 0L, 0L, 0, false, "user6", null, true, false, null, null, 3000000L, "sixth", null, 90L, "uploads/2022/9/sina2.jpg", "sixthuser" },
                    { new Guid("f6e0dd87-5f71-44eb-8e98-f6513dbd78d1"), null, "09199999999", "111111", new DateTime(2023, 2, 7, 6, 49, 52, 722, DateTimeKind.Local).AddTicks(2984), 0L, 0L, 0, false, "user9", null, true, false, null, null, 3000000L, "ninth", null, 90L, "uploads/2022/9/sina2.jpg", "ninthuser" }
                });

            migrationBuilder.InsertData(
                table: "UsersRoles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "Role", "User" },
                values: new object[,]
                {
                    { new Guid("1f095723-b77b-40e6-a398-524c84a812c3"), null, new Guid("c407d2f7-62cc-4d39-926a-8395c46ddcfa"), false, null, null, new Guid("9f2b307f-cbff-4ee6-a301-1c4cef8f17be"), new Guid("c407d2f7-62cc-4d39-926a-8395c46ddcfa") },
                    { new Guid("1f6017f3-5861-41d1-807e-5ec666a95b60"), null, new Guid("a1a86a35-2b91-48c2-b7d8-96b8558a8e4e"), false, null, null, new Guid("9f2b307f-cbff-4ee6-a301-1c4cef8f17be"), new Guid("a1a86a35-2b91-48c2-b7d8-96b8558a8e4e") },
                    { new Guid("2b3dc546-f4dc-4a92-909d-1828a95d25f1"), null, new Guid("61dafefb-8d95-40c0-a853-2f3b66eaa75b"), false, null, null, new Guid("9f2b307f-cbff-4ee6-a301-1c4cef8f17be"), new Guid("61dafefb-8d95-40c0-a853-2f3b66eaa75b") },
                    { new Guid("32b6a22f-02ec-41f2-a0fc-48f107f708f5"), null, new Guid("569483bb-6cae-4921-9f4c-dbd2f1fbd7d3"), false, null, null, new Guid("9f2b307f-cbff-4ee6-a301-1c4cef8f17be"), new Guid("569483bb-6cae-4921-9f4c-dbd2f1fbd7d3") },
                    { new Guid("5b9327f2-d922-4a00-bca5-dadd6d20aa83"), null, new Guid("a25da402-a10e-47bb-8871-29baaf111c7a"), false, null, null, new Guid("1f11cd21-7123-4cc7-b8a6-112c36314ae9"), new Guid("a25da402-a10e-47bb-8871-29baaf111c7a") },
                    { new Guid("836f58bb-1664-407a-bcbc-846fe83ba455"), null, new Guid("c2099b91-8394-4be5-ad6a-8e10d4d5b067"), false, null, null, new Guid("9f2b307f-cbff-4ee6-a301-1c4cef8f17be"), new Guid("c2099b91-8394-4be5-ad6a-8e10d4d5b067") },
                    { new Guid("bab63b6d-0cd4-452d-9638-325315727a03"), null, new Guid("986519c7-2148-43c0-8f9f-1d467ba48a89"), false, null, null, new Guid("9f2b307f-cbff-4ee6-a301-1c4cef8f17be"), new Guid("986519c7-2148-43c0-8f9f-1d467ba48a89") },
                    { new Guid("ca43bac1-262f-4886-8727-0039ca4b9865"), null, new Guid("c85fbc3b-d84d-4bf8-91be-4d297a2770d2"), false, null, null, new Guid("9f2b307f-cbff-4ee6-a301-1c4cef8f17be"), new Guid("c85fbc3b-d84d-4bf8-91be-4d297a2770d2") },
                    { new Guid("dcf1da04-9a69-44d9-84c3-f63c188995a3"), null, new Guid("c4b6ad2c-2ef7-4223-8182-e6a44368d3e0"), false, null, null, new Guid("9f2b307f-cbff-4ee6-a301-1c4cef8f17be"), new Guid("c4b6ad2c-2ef7-4223-8182-e6a44368d3e0") },
                    { new Guid("ee622da5-e01c-44a5-862d-6d311053dcc4"), null, new Guid("f6e0dd87-5f71-44eb-8e98-f6513dbd78d1"), false, null, null, new Guid("9f2b307f-cbff-4ee6-a301-1c4cef8f17be"), new Guid("f6e0dd87-5f71-44eb-8e98-f6513dbd78d1") },
                    { new Guid("f400d90d-879b-4476-a098-a3199a0c54ca"), null, new Guid("6d0c65b1-6d1b-4b1f-b490-ffd77e9fe18e"), false, null, null, new Guid("9f2b307f-cbff-4ee6-a301-1c4cef8f17be"), new Guid("6d0c65b1-6d1b-4b1f-b490-ffd77e9fe18e") },
                    { new Guid("f4e8f244-14f1-4c97-afcf-bcf87eb49370"), null, new Guid("33586738-999b-40a0-ac8c-fa78315f8511"), false, null, null, new Guid("c15a0ba9-f835-4c3d-b82c-2c6a5606f6c2"), new Guid("33586738-999b-40a0-ac8c-fa78315f8511") },
                    { new Guid("fce41ead-a1c8-4774-a23d-c2672963bdfb"), null, new Guid("2e64646c-21bd-48a9-8c74-950c2cf8ecb1"), false, null, null, new Guid("9f2b307f-cbff-4ee6-a301-1c4cef8f17be"), new Guid("2e64646c-21bd-48a9-8c74-950c2cf8ecb1") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Advertises");

            migrationBuilder.DropTable(
                name: "ChallengeUserData");

            migrationBuilder.DropTable(
                name: "ChatMessages");

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
                name: "GraphHistory");

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
