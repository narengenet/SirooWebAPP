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
                    { new Guid("012e3701-939a-4d63-a82f-29bb5e71c92c"), "گردونه", "diamond_second_priority", "20", "6,10", new DateTime(2023, 1, 30, 5, 50, 10, 981, DateTimeKind.Local).AddTicks(6210), new Guid("dfa5968c-1e59-41b6-be64-2e3c7a5e20cd"), "اولویت دوم تعداد الماس و درصد شانس", true, false, null, null, 1 },
                    { new Guid("037147cb-d978-4e79-9f95-479c0b1720bc"), "مالی", "money_to_credit_ratio", null, "1000", new DateTime(2023, 1, 30, 5, 50, 10, 981, DateTimeKind.Local).AddTicks(6447), new Guid("dfa5968c-1e59-41b6-be64-2e3c7a5e20cd"), "نسبت هر اعتبار به تومان", true, false, null, null, 23 },
                    { new Guid("173bb8f3-b285-4ec0-bc12-1171182bb397"), "چالش", "expire_dates_for_challenge", null, "60", new DateTime(2023, 1, 30, 5, 50, 10, 981, DateTimeKind.Local).AddTicks(6494), new Guid("dfa5968c-1e59-41b6-be64-2e3c7a5e20cd"), "تعداد روزهای مجاز برای چالش", true, false, null, null, 29 },
                    { new Guid("1ac4b76f-d935-4737-aca7-c4c152247574"), "اعتبار", "credit_for_image_ads", null, "500", new DateTime(2023, 1, 30, 5, 50, 10, 981, DateTimeKind.Local).AddTicks(6476), new Guid("dfa5968c-1e59-41b6-be64-2e3c7a5e20cd"), "اعتبار لازم برای ثبت آگهی تصویری", true, false, null, null, 27 },
                    { new Guid("21cde4fc-733e-42c4-ac4f-b06facad91f2"), "گردونه", "diamond_fivth_priority", "5", "31,50", new DateTime(2023, 1, 30, 5, 50, 10, 981, DateTimeKind.Local).AddTicks(6237), new Guid("dfa5968c-1e59-41b6-be64-2e3c7a5e20cd"), "اولویت پنجم تعداد الماس و درصد شانس", true, false, null, null, 4 },
                    { new Guid("2439fbec-3d05-4ad0-9cea-b7f1c32fb593"), "فروشگاه", "store_def_credit_reg", null, "0", new DateTime(2023, 1, 30, 5, 50, 10, 981, DateTimeKind.Local).AddTicks(6349), new Guid("dfa5968c-1e59-41b6-be64-2e3c7a5e20cd"), "اعتبار اولیه فروشگاه برای ثبت نام اولین بار", true, false, null, null, 19 },
                    { new Guid("29d26d8d-a596-4e5f-ad8e-351c31f2ddf4"), "ثبت نام", "def_points_for_client_registration", null, "100", new DateTime(2023, 1, 30, 5, 50, 10, 981, DateTimeKind.Local).AddTicks(6337), new Guid("dfa5968c-1e59-41b6-be64-2e3c7a5e20cd"), "امتیاز اولیه برای کاربری که ثبت نام میکند.", true, false, null, null, 17 },
                    { new Guid("2d0ba3b4-6044-45ee-b1f0-ec096e1fee09"), "چالش", "money_needed_to_attend_in_challenge", null, "3000000", new DateTime(2023, 1, 30, 5, 50, 10, 981, DateTimeKind.Local).AddTicks(6500), new Guid("dfa5968c-1e59-41b6-be64-2e3c7a5e20cd"), "موجودی ریالی برای شرکت در چالش", true, false, null, null, 30 },
                    { new Guid("3014a52f-97e2-4940-93ca-1703c08f1529"), "گردونه", "min_points_to_spin_diamond_wheel", null, "200", new DateTime(2023, 1, 30, 5, 50, 10, 981, DateTimeKind.Local).AddTicks(6174), new Guid("dfa5968c-1e59-41b6-be64-2e3c7a5e20cd"), "حداقل امتیاز برای چرخاندن گردونه شانس الماس بار اول", true, false, null, null, -2 },
                    { new Guid("451b2d15-6b65-4fbd-8b17-a47ead67838a"), "گردونه", "diamond_nineth_priority", "0", "301,500", new DateTime(2023, 1, 30, 5, 50, 10, 981, DateTimeKind.Local).AddTicks(6266), new Guid("dfa5968c-1e59-41b6-be64-2e3c7a5e20cd"), "امتیاز نهم آگهی تبلیغاتی تصویری", true, false, null, null, 8 },
                    { new Guid("533be143-d7a9-4c08-bb91-406d8859f5d4"), "فروشگاه", "store_point_usage_per_day", null, "-1", new DateTime(2023, 1, 30, 5, 50, 10, 981, DateTimeKind.Local).AddTicks(6362), new Guid("dfa5968c-1e59-41b6-be64-2e3c7a5e20cd"), "تعداد دفعات استفاده از کارت تخفیف هر فروشگاه در روز برای یک مشتری", true, false, null, null, 20 },
                    { new Guid("5e725834-d6f6-4942-91c7-0672b6a0a944"), "کارت اعتباری", "def_chips_usage_perday", null, "-1", new DateTime(2023, 1, 30, 5, 50, 10, 981, DateTimeKind.Local).AddTicks(6313), new Guid("dfa5968c-1e59-41b6-be64-2e3c7a5e20cd"), "تعداد استفاده از کارت اعتباری هر کاربر در روز", true, false, null, null, 14 },
                    { new Guid("6036a663-63c5-461b-80d3-66dd52759a28"), "فروشگاه", "stores_max_donnation_point", null, "500", new DateTime(2023, 1, 30, 5, 50, 10, 981, DateTimeKind.Local).AddTicks(6369), new Guid("dfa5968c-1e59-41b6-be64-2e3c7a5e20cd"), "حداکثر امتیازی که فروشگاه میتواند در هر نوتب هدیه بدهد", true, false, null, null, 21 },
                    { new Guid("6fc9ff49-60aa-4bd2-8da7-fc8e868373c5"), "آگهی تبلیغاتی", "points_reward_premium_video_ads", null, "200", new DateTime(2023, 1, 30, 5, 50, 10, 981, DateTimeKind.Local).AddTicks(6299), new Guid("dfa5968c-1e59-41b6-be64-2e3c7a5e20cd"), "امتیاز ثبت آگهی تبلیغاتی ویدئویی", true, false, null, null, 12 },
                    { new Guid("7bb6d4dc-c58c-4af1-b489-5a054ccb203f"), "گردونه", "diamond_seventh_priority", "3", "101,200", new DateTime(2023, 1, 30, 5, 50, 10, 981, DateTimeKind.Local).AddTicks(6250), new Guid("dfa5968c-1e59-41b6-be64-2e3c7a5e20cd"), "اولویت هفتم تعداد الماس و درصد شانس", true, false, null, null, 6 },
                    { new Guid("8088a450-8879-47b2-bd2a-7d6bb21450fe"), "لایک ها", "def_points_for_video_like", null, "15", new DateTime(2023, 1, 30, 5, 50, 10, 981, DateTimeKind.Local).AddTicks(6328), new Guid("dfa5968c-1e59-41b6-be64-2e3c7a5e20cd"), "امتیاز پیش فرض برای لایک پست ویدئویی", true, false, null, null, 16 },
                    { new Guid("814abe55-2c43-4553-9fdf-3571ebe6fa2b"), "گردونه", "diamond_first_priority", "50", "1,5", new DateTime(2023, 1, 30, 5, 50, 10, 981, DateTimeKind.Local).AddTicks(6201), new Guid("dfa5968c-1e59-41b6-be64-2e3c7a5e20cd"), "اولویت اول تعداد الماس و درصد شانس", true, false, null, null, 0 },
                    { new Guid("8b05e1db-541a-4ac2-ab3c-29354c621922"), "درصدها", "def_percent_for_marketer", null, "10", new DateTime(2023, 1, 30, 5, 50, 10, 981, DateTimeKind.Local).AddTicks(6454), new Guid("dfa5968c-1e59-41b6-be64-2e3c7a5e20cd"), "درصد بازاریاب", true, false, null, null, 24 },
                    { new Guid("93a81b4f-1dc7-4387-91b7-3e6c904421f3"), "اعتبار", "credit_for_video_ads", null, "1000", new DateTime(2023, 1, 30, 5, 50, 10, 981, DateTimeKind.Local).AddTicks(6487), new Guid("dfa5968c-1e59-41b6-be64-2e3c7a5e20cd"), "اعتبار لازم برای ثبت آگهی ویدئویی", true, false, null, null, 28 },
                    { new Guid("965caad3-15bd-48ed-a931-e1d5d8a22a6e"), "فروشگاه", "credit_for_client_registration_by_store_invitation", null, "50", new DateTime(2023, 1, 30, 5, 50, 10, 981, DateTimeKind.Local).AddTicks(6439), new Guid("dfa5968c-1e59-41b6-be64-2e3c7a5e20cd"), "اعتبار برای فروشنده ای که باعث ثبت نام مشتری شد", true, false, null, null, 22 },
                    { new Guid("96f940be-6e69-4edd-97d8-5df1c21ce0a4"), "گردونه", "added_points_to_each_spin_diamond_wheel_after_first_time", null, "100", new DateTime(2023, 1, 30, 5, 50, 10, 981, DateTimeKind.Local).AddTicks(6193), new Guid("dfa5968c-1e59-41b6-be64-2e3c7a5e20cd"), "افزایش تعداد امتیاز به اضای هر بار چرخاندن گردونه شانس در یک روز", true, false, null, null, -1 },
                    { new Guid("98d17a62-7cef-4a02-97d5-058881169232"), "آگهی تبلیغاتی", "def_money_to_premium_image_ads", null, "200000", new DateTime(2023, 1, 30, 5, 50, 10, 981, DateTimeKind.Local).AddTicks(6288), new Guid("dfa5968c-1e59-41b6-be64-2e3c7a5e20cd"), "هزینه درج آگهی تبلیغاتی تصویری", true, false, null, null, 11 },
                    { new Guid("a254a39c-f6b5-4ce0-82b9-b8f209b6cf6e"), "درصدها", "def_percent_for_countryadmin", null, "4", new DateTime(2023, 1, 30, 5, 50, 10, 981, DateTimeKind.Local).AddTicks(6470), new Guid("dfa5968c-1e59-41b6-be64-2e3c7a5e20cd"), "درصد مدیر مناطق", true, false, null, null, 26 },
                    { new Guid("a5d5b584-ac56-43fa-bd18-8f2a5c3d8535"), "چالش", "maximum_number_of_prize_payment", null, "1000", new DateTime(2023, 1, 30, 5, 50, 10, 981, DateTimeKind.Local).AddTicks(6522), new Guid("dfa5968c-1e59-41b6-be64-2e3c7a5e20cd"), "حداکثر تعداد پرداخت کارمزدها", true, false, null, null, 33 },
                    { new Guid("aac87124-bb1d-47e5-872f-5a7de7991d16"), "گردونه", "diamond_sixth_priority", "4", "51,100", new DateTime(2023, 1, 30, 5, 50, 10, 981, DateTimeKind.Local).AddTicks(6244), new Guid("dfa5968c-1e59-41b6-be64-2e3c7a5e20cd"), "اولویت ششم تعداد الماس و درصد شانس", true, false, null, null, 5 },
                    { new Guid("b954912a-649f-4a4a-a20c-826b7354c3b7"), "چالش", "prize_for_invite_to_challenge", null, "1000000", new DateTime(2023, 1, 30, 5, 50, 10, 981, DateTimeKind.Local).AddTicks(6506), new Guid("dfa5968c-1e59-41b6-be64-2e3c7a5e20cd"), "کارمزد برای معرفی کاربران به چالش", true, false, null, null, 31 },
                    { new Guid("c72ac58b-a724-4099-a45b-fb1bdd16db84"), "گردونه", "diamond_third_priority", "10", "11,20", new DateTime(2023, 1, 30, 5, 50, 10, 981, DateTimeKind.Local).AddTicks(6218), new Guid("dfa5968c-1e59-41b6-be64-2e3c7a5e20cd"), "اولویت سوم تعداد الماس و درصد شانس", true, false, null, null, 2 },
                    { new Guid("c79fbbea-9fed-4681-bbea-00b9bfe9c94b"), "گردونه", "diamond_tenth_priority", "0", "999,1000", new DateTime(2023, 1, 30, 5, 50, 10, 981, DateTimeKind.Local).AddTicks(6274), new Guid("dfa5968c-1e59-41b6-be64-2e3c7a5e20cd"), "امتیاز دهم آگهی تبلیغاتی تصویری", true, false, null, null, 9 },
                    { new Guid("c86025ff-1ebc-4d95-9aff-589bf7b60d00"), "گردونه", "diamond_eighth_priority", "2", "201,300", new DateTime(2023, 1, 30, 5, 50, 10, 981, DateTimeKind.Local).AddTicks(6258), new Guid("dfa5968c-1e59-41b6-be64-2e3c7a5e20cd"), "اولویت هشتم تعداد الماس و درصد شانس", true, false, null, null, 7 },
                    { new Guid("d409a1c7-81cc-4e9b-97cd-2dc74b5a0478"), "درصدها", "def_percent_for_zoneadmin", null, "6", new DateTime(2023, 1, 30, 5, 50, 10, 981, DateTimeKind.Local).AddTicks(6462), new Guid("dfa5968c-1e59-41b6-be64-2e3c7a5e20cd"), "درصد مدیر منطقه", true, false, null, null, 25 },
                    { new Guid("da476ee2-32ba-4b2a-b7d6-6e8eb6a7a9de"), "ثبت نام", "def_points_for_client_invitation", null, "50", new DateTime(2023, 1, 30, 5, 50, 10, 981, DateTimeKind.Local).AddTicks(6343), new Guid("dfa5968c-1e59-41b6-be64-2e3c7a5e20cd"), "امتیاز برای معرف وقتی کاربر ثبت نام کرد.", true, false, null, null, 18 },
                    { new Guid("dac6a05d-45ac-4bbd-955e-0c0640b05472"), "آگهی تبلیغاتی", "def_money_to_premium_video_ads", null, "1000000", new DateTime(2023, 1, 30, 5, 50, 10, 981, DateTimeKind.Local).AddTicks(6280), new Guid("dfa5968c-1e59-41b6-be64-2e3c7a5e20cd"), "هزینه درج آگهی تبلیغاتی ویدئویی", true, false, null, null, 10 },
                    { new Guid("e6a769e2-f70a-453b-93f0-11d36a8e0326"), "آگهی تبلیغاتی", "points_reward_premium_image_ads", null, "1000", new DateTime(2023, 1, 30, 5, 50, 10, 981, DateTimeKind.Local).AddTicks(6306), new Guid("dfa5968c-1e59-41b6-be64-2e3c7a5e20cd"), "امتیاز ثبت آگهی تبلیغاتی تصویری", true, false, null, null, 13 },
                    { new Guid("f5a6aacf-d5d1-4b9a-a654-503d51960b58"), "چالش", "order_of_prize_payment", null, "3,5,2,10", new DateTime(2023, 1, 30, 5, 50, 10, 981, DateTimeKind.Local).AddTicks(6513), new Guid("dfa5968c-1e59-41b6-be64-2e3c7a5e20cd"), "ترتیب پرداخت کارمزدها", true, false, null, null, 32 },
                    { new Guid("fb279375-2a1e-49dd-80c3-83d5548b818e"), "لایک ها", "def_points_for_image_like", null, "1", new DateTime(2023, 1, 30, 5, 50, 10, 981, DateTimeKind.Local).AddTicks(6321), new Guid("dfa5968c-1e59-41b6-be64-2e3c7a5e20cd"), "امتیاز پیش فرض برای لایک پست تصویری", true, false, null, null, 15 },
                    { new Guid("fc958529-1dfa-494d-b425-fd1a549e593f"), "گردونه", "diamond_fourth_priority", "6", "21,30", new DateTime(2023, 1, 30, 5, 50, 10, 981, DateTimeKind.Local).AddTicks(6224), new Guid("dfa5968c-1e59-41b6-be64-2e3c7a5e20cd"), "اولویت چهارم تعداد الماس و درصد شانس", true, false, null, null, 3 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Priority", "RoleDescription", "RoleName" },
                values: new object[,]
                {
                    { new Guid("044f2ef6-0e5a-4b0e-88bf-334161b28291"), null, null, true, false, null, null, 6, "مشتری", "client" },
                    { new Guid("0d03fb9a-705a-4e90-adb8-1e108da5de48"), null, null, true, false, null, null, 4, "بازاریاب", "marketer" },
                    { new Guid("1df1ee07-28be-414a-b75b-90a4455d7482"), null, null, true, false, null, null, 5, "فروشگاه", "store" },
                    { new Guid("8561e501-b346-41d0-8a03-ec2b733c13de"), null, null, true, false, null, null, 3, "مدیر منطقه", "zoneadmin" },
                    { new Guid("dd8d8a5a-866c-46d7-9fd6-50a2b36cfc99"), null, null, true, false, null, null, 2, "مدیر کل مناطق", "countryadmin" },
                    { new Guid("f574f15e-ba92-4cca-a9b0-36cc278474c4"), null, null, true, false, null, null, 0, "مدیر کل", "super" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Priority", "RoleDescription", "RoleName" },
                values: new object[] { new Guid("fac7b19c-1d9e-44e9-ae89-f1615a0b8778"), null, null, true, false, null, null, 1, "مدیر سامانه", "admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CardNumber", "Cellphone", "ConfirmationCode", "Created", "Credits", "DefaultCredit", "Diamonds", "DonnationActive", "Family", "Inviter", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Money", "Name", "Notes", "Points", "ProfileMediaURL", "Username" },
                values: new object[,]
                {
                    { new Guid("156a058e-6abc-4b47-b1af-74dc0ceb0252"), null, "09155555555", "111111", new DateTime(2023, 1, 30, 5, 50, 10, 981, DateTimeKind.Local).AddTicks(5033), 0L, 0L, 0, false, "user5", null, true, false, null, null, 3000000L, "fivth", null, 90L, "uploads/2022/9/sina2.jpg", "fivthuser" },
                    { new Guid("1c2e89ac-89e1-4026-a4a8-7de811c520ec"), null, "09111111111", "111111", new DateTime(2023, 1, 30, 5, 50, 10, 981, DateTimeKind.Local).AddTicks(5000), 0L, 0L, 0, false, "user1", null, true, false, null, null, 3000000L, "first", null, 90L, "uploads/2022/9/sina2.jpg", "firstuser" },
                    { new Guid("48c87c91-19eb-48f6-9424-347a06e1de67"), null, "09199999999", "111111", new DateTime(2023, 1, 30, 5, 50, 10, 981, DateTimeKind.Local).AddTicks(5084), 0L, 0L, 0, false, "user9", null, true, false, null, null, 3000000L, "ninth", null, 90L, "uploads/2022/9/sina2.jpg", "ninthuser" },
                    { new Guid("6120a1c7-e6ab-478f-b7bb-d14f4d6e43a8"), null, "09011000000", "111111", new DateTime(2023, 1, 30, 5, 50, 10, 981, DateTimeKind.Local).AddTicks(5099), 0L, 0L, 0, false, "user11", null, true, false, null, null, 3000000L, "eleventh", null, 90L, "uploads/2022/9/sina2.jpg", "eleventhuser" },
                    { new Guid("633bf8cd-4feb-4dcc-9804-ae533b8666dc"), null, "09901069557", null, new DateTime(2023, 1, 30, 5, 50, 10, 981, DateTimeKind.Local).AddTicks(4929), 1000L, 0L, 0, true, "دابویی مشک آبادی", null, true, false, null, null, 0L, "عبدالرحمن", null, 100L, "uploads/2022/9/photo.jpg", "dabooei" },
                    { new Guid("7c51bd83-3002-47d8-96d5-99758950781c"), null, "09177777777", "111111", new DateTime(2023, 1, 30, 5, 50, 10, 981, DateTimeKind.Local).AddTicks(5068), 0L, 0L, 0, false, "user7", null, true, false, null, null, 3000000L, "seventh", null, 90L, "uploads/2022/9/sina2.jpg", "seventhuser" },
                    { new Guid("829df813-efc8-4125-9c03-330723e4a479"), null, "09166666666", "111111", new DateTime(2023, 1, 30, 5, 50, 10, 981, DateTimeKind.Local).AddTicks(5062), 0L, 0L, 0, false, "user6", null, true, false, null, null, 3000000L, "sixth", null, 90L, "uploads/2022/9/sina2.jpg", "sixthuser" },
                    { new Guid("ac3167b9-7dc8-4be9-881b-bc20e00059f2"), null, "09122222222", "111111", new DateTime(2023, 1, 30, 5, 50, 10, 981, DateTimeKind.Local).AddTicks(5009), 0L, 0L, 0, false, "user2", null, true, false, null, null, 3000000L, "second", null, 90L, "uploads/2022/9/sina2.jpg", "seconduser" },
                    { new Guid("bf8e24d4-d758-4e9e-b4c9-84a508314899"), null, "09133333333", "111111", new DateTime(2023, 1, 30, 5, 50, 10, 981, DateTimeKind.Local).AddTicks(5018), 0L, 0L, 0, false, "user3", null, true, false, null, null, 3000000L, "third", null, 90L, "uploads/2022/9/sina2.jpg", "thirduser" },
                    { new Guid("cc486935-cc8a-477a-a735-64b922d20a88"), null, "09144444444", "111111", new DateTime(2023, 1, 30, 5, 50, 10, 981, DateTimeKind.Local).AddTicks(5025), 0L, 0L, 0, false, "user4", null, true, false, null, null, 3000000L, "fourth", null, 90L, "uploads/2022/9/sina2.jpg", "fourthuser" },
                    { new Guid("d764128d-e1ad-4d11-866d-fd112aa2c984"), null, "09188888888", "111111", new DateTime(2023, 1, 30, 5, 50, 10, 981, DateTimeKind.Local).AddTicks(5078), 0L, 0L, 0, false, "user8", null, true, false, null, null, 3000000L, "eighth", null, 90L, "uploads/2022/9/sina2.jpg", "eighthuser" },
                    { new Guid("dfa5968c-1e59-41b6-be64-2e3c7a5e20cd"), null, "09394125130", "111111", new DateTime(2023, 1, 30, 5, 50, 10, 981, DateTimeKind.Local).AddTicks(4989), 0L, 0L, 0, false, "Jouybari", new Guid("633bf8cd-4feb-4dcc-9804-ae533b8666dc"), true, false, null, null, 850000L, "Sina", null, 90L, "uploads/2022/9/sina2.jpg", "sinful" },
                    { new Guid("eeed223d-1c8d-4fb1-baaf-fcb70d24f1ab"), null, "09100000000", "111111", new DateTime(2023, 1, 30, 5, 50, 10, 981, DateTimeKind.Local).AddTicks(5092), 0L, 0L, 0, false, "user10", null, true, false, null, null, 3000000L, "tenth", null, 90L, "uploads/2022/9/sina2.jpg", "tenthuser" }
                });

            migrationBuilder.InsertData(
                table: "UsersRoles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "Role", "User" },
                values: new object[,]
                {
                    { new Guid("140435d3-d7bc-447f-8f48-9997f8c4534e"), null, new Guid("633bf8cd-4feb-4dcc-9804-ae533b8666dc"), false, null, null, new Guid("1df1ee07-28be-414a-b75b-90a4455d7482"), new Guid("633bf8cd-4feb-4dcc-9804-ae533b8666dc") },
                    { new Guid("25d90beb-5b6b-4578-b84d-4858255703a4"), null, new Guid("48c87c91-19eb-48f6-9424-347a06e1de67"), false, null, null, new Guid("044f2ef6-0e5a-4b0e-88bf-334161b28291"), new Guid("48c87c91-19eb-48f6-9424-347a06e1de67") },
                    { new Guid("3ac81182-99ce-46d3-9a49-05421e992574"), null, new Guid("1c2e89ac-89e1-4026-a4a8-7de811c520ec"), false, null, null, new Guid("044f2ef6-0e5a-4b0e-88bf-334161b28291"), new Guid("1c2e89ac-89e1-4026-a4a8-7de811c520ec") },
                    { new Guid("3c732122-a826-4ee3-acbc-c67d1e28e8d5"), null, new Guid("d764128d-e1ad-4d11-866d-fd112aa2c984"), false, null, null, new Guid("044f2ef6-0e5a-4b0e-88bf-334161b28291"), new Guid("d764128d-e1ad-4d11-866d-fd112aa2c984") },
                    { new Guid("5a06c864-ee69-42cc-b3a6-626c491f916e"), null, new Guid("eeed223d-1c8d-4fb1-baaf-fcb70d24f1ab"), false, null, null, new Guid("044f2ef6-0e5a-4b0e-88bf-334161b28291"), new Guid("eeed223d-1c8d-4fb1-baaf-fcb70d24f1ab") },
                    { new Guid("65e33f75-3952-4b76-8a3f-2251568d558f"), null, new Guid("dfa5968c-1e59-41b6-be64-2e3c7a5e20cd"), false, null, null, new Guid("f574f15e-ba92-4cca-a9b0-36cc278474c4"), new Guid("dfa5968c-1e59-41b6-be64-2e3c7a5e20cd") },
                    { new Guid("6e9c3efa-a79b-4a03-8bc2-ae7130332c38"), null, new Guid("156a058e-6abc-4b47-b1af-74dc0ceb0252"), false, null, null, new Guid("044f2ef6-0e5a-4b0e-88bf-334161b28291"), new Guid("156a058e-6abc-4b47-b1af-74dc0ceb0252") },
                    { new Guid("718ff1ed-70fe-4737-b538-4919402c3c0f"), null, new Guid("7c51bd83-3002-47d8-96d5-99758950781c"), false, null, null, new Guid("044f2ef6-0e5a-4b0e-88bf-334161b28291"), new Guid("7c51bd83-3002-47d8-96d5-99758950781c") },
                    { new Guid("8278e00a-3036-4584-a2ad-a8c735cca1ed"), null, new Guid("829df813-efc8-4125-9c03-330723e4a479"), false, null, null, new Guid("044f2ef6-0e5a-4b0e-88bf-334161b28291"), new Guid("829df813-efc8-4125-9c03-330723e4a479") },
                    { new Guid("a80629ec-39c7-48c6-b46d-462964f3a83d"), null, new Guid("cc486935-cc8a-477a-a735-64b922d20a88"), false, null, null, new Guid("044f2ef6-0e5a-4b0e-88bf-334161b28291"), new Guid("cc486935-cc8a-477a-a735-64b922d20a88") },
                    { new Guid("addbba29-c0f8-4e86-99f3-867f96114466"), null, new Guid("ac3167b9-7dc8-4be9-881b-bc20e00059f2"), false, null, null, new Guid("044f2ef6-0e5a-4b0e-88bf-334161b28291"), new Guid("ac3167b9-7dc8-4be9-881b-bc20e00059f2") },
                    { new Guid("c4f1bf9a-80ec-4995-92f0-fcd6575ea843"), null, new Guid("bf8e24d4-d758-4e9e-b4c9-84a508314899"), false, null, null, new Guid("044f2ef6-0e5a-4b0e-88bf-334161b28291"), new Guid("bf8e24d4-d758-4e9e-b4c9-84a508314899") },
                    { new Guid("d31e45cf-f1cf-4380-8f21-1a682297905e"), null, new Guid("6120a1c7-e6ab-478f-b7bb-d14f4d6e43a8"), false, null, null, new Guid("044f2ef6-0e5a-4b0e-88bf-334161b28291"), new Guid("6120a1c7-e6ab-478f-b7bb-d14f4d6e43a8") }
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
