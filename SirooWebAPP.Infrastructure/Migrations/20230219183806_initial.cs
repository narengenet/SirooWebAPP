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
                name: "ChatBlocks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fromUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    toUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatBlocks", x => x.Id);
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
                    { new Guid("1242ac82-11d9-451a-847d-e8e3c280f4dc"), "کارت اعتباری", "def_chips_usage_perday", null, "-1", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(2022), new Guid("59a09c77-c905-461d-b676-454d000a47f5"), "تعداد استفاده از کارت اعتباری هر کاربر در روز", true, false, null, null, 14 },
                    { new Guid("12f2057e-3b0b-4d86-a1a1-808ab06a514f"), "گردونه", "diamond_eighth_priority", "2", "201,300", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(1992), new Guid("59a09c77-c905-461d-b676-454d000a47f5"), "اولویت هشتم تعداد الماس و درصد شانس", true, false, null, null, 7 },
                    { new Guid("151c3fb1-c82c-4f73-a1af-00c558f9f6a6"), "چالش", "maximum_number_of_prize_payment_1", null, "1000", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(2185), new Guid("59a09c77-c905-461d-b676-454d000a47f5"), "حداکثر تعداد پرداخت کارمزدها نوع 1", true, false, null, null, 33 },
                    { new Guid("1aa6580d-0d9d-44b0-b32f-bef249ee6ba9"), "درصدها", "def_percent_for_countryadmin", null, "4", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(2074), new Guid("59a09c77-c905-461d-b676-454d000a47f5"), "درصد مدیر مناطق", true, false, null, null, 26 },
                    { new Guid("1bb2c154-58e4-46a2-90e7-4d029bfc1158"), "آگهی تبلیغاتی", "def_money_to_premium_image_ads", null, "200000", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(2008), new Guid("59a09c77-c905-461d-b676-454d000a47f5"), "هزینه درج آگهی تبلیغاتی تصویری", true, false, null, null, 11 },
                    { new Guid("23b94526-e7eb-4e82-aa54-9fc25f91ceca"), "چالش", "order_of_prize_payment_2", null, "2,3,5", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(2208), new Guid("59a09c77-c905-461d-b676-454d000a47f5"), "ترتیب پرداخت کارمزدها نوع 2", true, false, null, null, 38 },
                    { new Guid("31eb2862-03fb-4c18-93e3-c0d8713ecbfd"), "ثبت نام", "def_points_for_client_invitation", null, "50", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(2039), new Guid("59a09c77-c905-461d-b676-454d000a47f5"), "امتیاز برای معرف وقتی کاربر ثبت نام کرد.", true, false, null, null, 18 },
                    { new Guid("3252755d-4f8f-4e56-aea5-69e2c36f19cb"), "گردونه", "diamond_first_priority", "50", "1,5", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(1960), new Guid("59a09c77-c905-461d-b676-454d000a47f5"), "اولویت اول تعداد الماس و درصد شانس", true, false, null, null, 0 },
                    { new Guid("35e984cd-adda-47ae-bc9c-bd9e9c95cfe5"), "گردونه", "diamond_tenth_priority", "0", "999,1000", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(2001), new Guid("59a09c77-c905-461d-b676-454d000a47f5"), "امتیاز دهم آگهی تبلیغاتی تصویری", true, false, null, null, 9 },
                    { new Guid("3da943b8-2794-4de7-b5ee-7f6b25fe3661"), "چالش", "money_needed_to_attend_in_challenge_2", null, "3550000", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(2198), new Guid("59a09c77-c905-461d-b676-454d000a47f5"), "موجودی ریالی برای شرکت در چالش نوع 2", true, false, null, null, 36 },
                    { new Guid("463f4106-c184-4a90-a44b-f0b2fc89002a"), "لایک ها", "def_points_for_image_like", null, "1", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(2026), new Guid("59a09c77-c905-461d-b676-454d000a47f5"), "امتیاز پیش فرض برای لایک پست تصویری", true, false, null, null, 15 },
                    { new Guid("48283576-7762-469d-b232-3e308ac2eefd"), "گردونه", "min_points_to_spin_diamond_wheel", null, "200", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(1947), new Guid("59a09c77-c905-461d-b676-454d000a47f5"), "حداقل امتیاز برای چرخاندن گردونه شانس الماس بار اول", true, false, null, null, -2 },
                    { new Guid("49aff7df-ebe6-4ec0-a826-8402f4999c4a"), "چالش", "order_of_prize_payment_3", null, "2,3,5", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(2232), new Guid("59a09c77-c905-461d-b676-454d000a47f5"), "ترتیب پرداخت کارمزدها نوع 3", true, false, null, null, 44 },
                    { new Guid("4b5f6460-e6b9-4592-b3f0-98fc8f706e77"), "آگهی تبلیغاتی", "points_reward_premium_image_ads", null, "1000", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(2019), new Guid("59a09c77-c905-461d-b676-454d000a47f5"), "امتیاز ثبت آگهی تبلیغاتی تصویری", true, false, null, null, 13 },
                    { new Guid("52be4a40-a98d-466b-b0db-753e28aa78b8"), "چالش", "expire_dates_for_challenge_3", null, "90", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(2219), new Guid("59a09c77-c905-461d-b676-454d000a47f5"), "تعداد روزهای مجاز برای چالش نوع 3", true, false, null, null, 41 },
                    { new Guid("5a868004-c58d-460d-8b81-86fae215b842"), "اعتبار", "credit_for_video_ads", null, "1000", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(2160), new Guid("59a09c77-c905-461d-b676-454d000a47f5"), "اعتبار لازم برای ثبت آگهی ویدئویی", true, false, null, null, 28 },
                    { new Guid("5e853c12-4868-4263-9d7e-3067517323af"), "چالش", "maximum_number_of_prize_payment_3", null, "1000", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(2239), new Guid("59a09c77-c905-461d-b676-454d000a47f5"), "حداکثر تعداد پرداخت کارمزدها نوع 3", true, false, null, null, 45 },
                    { new Guid("6b15b835-c8bb-4202-95be-7571df6b1479"), "گردونه", "added_points_to_each_spin_diamond_wheel_after_first_time", null, "100", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(1956), new Guid("59a09c77-c905-461d-b676-454d000a47f5"), "افزایش تعداد امتیاز به اضای هر بار چرخاندن گردونه شانس در یک روز", true, false, null, null, -1 },
                    { new Guid("6c6735d5-9a67-44e5-a897-8e30d601c9ed"), "گردونه", "diamond_seventh_priority", "3", "101,200", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(1988), new Guid("59a09c77-c905-461d-b676-454d000a47f5"), "اولویت هفتم تعداد الماس و درصد شانس", true, false, null, null, 6 },
                    { new Guid("71e87644-a63a-49fa-8fa7-174a5555c1bf"), "چالش", "expire_dates_for_ads_1", null, "20", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(2190), new Guid("59a09c77-c905-461d-b676-454d000a47f5"), "تعداد روزهای آگهی تجاری نوع 1", true, false, null, null, 34 },
                    { new Guid("73149548-e9e4-48e5-96dd-7b5373ac069a"), "گردونه", "diamond_second_priority", "20", "6,10", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(1965), new Guid("59a09c77-c905-461d-b676-454d000a47f5"), "اولویت دوم تعداد الماس و درصد شانس", true, false, null, null, 1 },
                    { new Guid("7d41e2a1-ee7b-4585-a26f-b4d217b1d860"), "گردونه", "diamond_third_priority", "10", "11,20", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(1969), new Guid("59a09c77-c905-461d-b676-454d000a47f5"), "اولویت سوم تعداد الماس و درصد شانس", true, false, null, null, 2 },
                    { new Guid("7eac0613-f25e-4c75-8167-c288d8e89b54"), "آگهی تبلیغاتی", "def_money_to_premium_video_ads", null, "1000000", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(2004), new Guid("59a09c77-c905-461d-b676-454d000a47f5"), "هزینه درج آگهی تبلیغاتی ویدئویی", true, false, null, null, 10 },
                    { new Guid("81c93a50-7a5a-4617-a27d-4669ebc2d07a"), "چالش", "expire_dates_for_ads_3", null, "20", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(2243), new Guid("59a09c77-c905-461d-b676-454d000a47f5"), "تعداد روزهای آگهی تجاری نوع 3", true, false, null, null, 46 },
                    { new Guid("8a3987f8-fc65-47aa-86e5-802fa4ba95c9"), "چالش", "prize_for_invite_to_challenge_1", null, "100000", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(2177), new Guid("59a09c77-c905-461d-b676-454d000a47f5"), "کارمزد برای معرفی کاربران به چالش نوع 1", true, false, null, null, 31 },
                    { new Guid("8a6ce723-3492-443e-abe7-b87b095dcb28"), "چالش", "expire_dates_for_challenge_1", null, "30", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(2168), new Guid("59a09c77-c905-461d-b676-454d000a47f5"), "تعداد روزهای مجاز برای چالش نوع 1", true, false, null, null, 29 },
                    { new Guid("9299aa6d-7bc4-4a99-b949-26c86b099784"), "فروشگاه", "store_def_credit_reg", null, "0", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(2043), new Guid("59a09c77-c905-461d-b676-454d000a47f5"), "اعتبار اولیه فروشگاه برای ثبت نام اولین بار", true, false, null, null, 19 },
                    { new Guid("93f96589-ebd9-4d8b-8c1e-a92552b3cdaa"), "چالش", "order_of_prize_payment_1", null, "2,3,5", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(2181), new Guid("59a09c77-c905-461d-b676-454d000a47f5"), "ترتیب پرداخت کارمزدها نوع 1", true, false, null, null, 32 },
                    { new Guid("985e4845-9ebb-438e-aaa7-2b272e17096b"), "فروشگاه", "stores_max_donnation_point", null, "500", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(2053), new Guid("59a09c77-c905-461d-b676-454d000a47f5"), "حداکثر امتیازی که فروشگاه میتواند در هر نوتب هدیه بدهد", true, false, null, null, 21 },
                    { new Guid("a13e89bd-1fb3-40e9-82a5-3dad0070ce41"), "درصدها", "def_percent_for_marketer", null, "10", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(2065), new Guid("59a09c77-c905-461d-b676-454d000a47f5"), "درصد بازاریاب", true, false, null, null, 24 },
                    { new Guid("a185c101-8af1-4cf5-bb72-644b8e67b2e2"), "گردونه", "diamond_nineth_priority", "0", "301,500", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(1995), new Guid("59a09c77-c905-461d-b676-454d000a47f5"), "امتیاز نهم آگهی تبلیغاتی تصویری", true, false, null, null, 8 },
                    { new Guid("a36dd23e-2ad8-4531-b7e3-a2688dc9b380"), "چالش", "maximum_number_of_prize_payment_2", null, "1000", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(2212), new Guid("59a09c77-c905-461d-b676-454d000a47f5"), "حداکثر تعداد پرداخت کارمزدها نوع 2", true, false, null, null, 39 },
                    { new Guid("a82caf00-4099-4b0d-8aab-8a5bd3f754f1"), "گردونه", "diamond_sixth_priority", "4", "51,100", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(1984), new Guid("59a09c77-c905-461d-b676-454d000a47f5"), "اولویت ششم تعداد الماس و درصد شانس", true, false, null, null, 5 },
                    { new Guid("aa418eeb-608f-4f33-9fb5-069110ec941b"), "گردونه", "diamond_fourth_priority", "6", "21,30", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(1973), new Guid("59a09c77-c905-461d-b676-454d000a47f5"), "اولویت چهارم تعداد الماس و درصد شانس", true, false, null, null, 3 },
                    { new Guid("b06bfbb6-2113-45f9-b832-caa199fdb99d"), "فروشگاه", "store_point_usage_per_day", null, "-1", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(2047), new Guid("59a09c77-c905-461d-b676-454d000a47f5"), "تعداد دفعات استفاده از کارت تخفیف هر فروشگاه در روز برای یک مشتری", true, false, null, null, 20 },
                    { new Guid("ba36b348-a9e1-4364-a03f-890fb38b04ae"), "گردونه", "diamond_fivth_priority", "5", "31,50", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(1977), new Guid("59a09c77-c905-461d-b676-454d000a47f5"), "اولویت پنجم تعداد الماس و درصد شانس", true, false, null, null, 4 },
                    { new Guid("c0e3e571-9f1d-4752-afd2-d556865cd13f"), "چالش", "prize_for_invite_to_challenge_2", null, "1000000", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(2204), new Guid("59a09c77-c905-461d-b676-454d000a47f5"), "کارمزد برای معرفی کاربران به چالش نوع 2", true, false, null, null, 37 },
                    { new Guid("c106e13b-07c3-487e-87d0-4729e8a309f7"), "چالش", "money_needed_to_attend_in_challenge_3", null, "30000000", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(2224), new Guid("59a09c77-c905-461d-b676-454d000a47f5"), "موجودی ریالی برای شرکت در چالش نوع 3", true, false, null, null, 42 },
                    { new Guid("c3736f23-3e24-4244-bb3e-8201d953c8b3"), "آگهی تبلیغاتی", "points_reward_premium_video_ads", null, "200", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(2012), new Guid("59a09c77-c905-461d-b676-454d000a47f5"), "امتیاز ثبت آگهی تبلیغاتی ویدئویی", true, false, null, null, 12 },
                    { new Guid("c488bb42-eb9a-4558-85c1-8ffe22fa427f"), "مالی", "money_to_credit_ratio", null, "1000", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(2061), new Guid("59a09c77-c905-461d-b676-454d000a47f5"), "نسبت هر اعتبار به تومان", true, false, null, null, 23 },
                    { new Guid("c728cf8c-869a-4e62-8621-37c2d8425f97"), "چالش", "money_needed_to_attend_in_challenge_1", null, "300000", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(2173), new Guid("59a09c77-c905-461d-b676-454d000a47f5"), "موجودی ریالی برای شرکت در چالش نوع 1", true, false, null, null, 30 },
                    { new Guid("cb9edea5-13d0-4f7b-b70d-5e156a3e617a"), "ثبت نام", "def_points_for_client_registration", null, "100", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(2035), new Guid("59a09c77-c905-461d-b676-454d000a47f5"), "امتیاز اولیه برای کاربری که ثبت نام میکند.", true, false, null, null, 17 }
                });

            migrationBuilder.InsertData(
                table: "ConstantDictionaries",
                columns: new[] { "Id", "Category", "ConstantKey", "ConstantSecondValue", "ConstantValue", "Created", "CreatedBy", "Description", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "PriorityIndex" },
                values: new object[,]
                {
                    { new Guid("d94589b7-f813-4fb6-9b38-91eac838de3c"), "چالش", "expire_dates_for_ads_2", null, "20", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(2216), new Guid("59a09c77-c905-461d-b676-454d000a47f5"), "تعداد روزهای آگهی تجاری نوع 2", true, false, null, null, 40 },
                    { new Guid("dc38b858-c660-45ba-8eb8-ab619a64b1d2"), "چالش", "prize_for_invite_to_challenge_3", null, "10000000", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(2228), new Guid("59a09c77-c905-461d-b676-454d000a47f5"), "کارمزد برای معرفی کاربران به چالش نوع 3", true, false, null, null, 43 },
                    { new Guid("e3010dbf-4a4f-449d-bb4d-c46d24057d5e"), "درصدها", "def_percent_for_zoneadmin", null, "6", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(2069), new Guid("59a09c77-c905-461d-b676-454d000a47f5"), "درصد مدیر منطقه", true, false, null, null, 25 },
                    { new Guid("f96ede20-17c8-4924-bd11-e670702370dd"), "چالش", "expire_dates_for_challenge_2", null, "60", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(2194), new Guid("59a09c77-c905-461d-b676-454d000a47f5"), "تعداد روزهای مجاز برای چالش نوع 2", true, false, null, null, 35 },
                    { new Guid("fc8e6dc6-f726-4771-a91c-ebf8ff6f7f2f"), "لایک ها", "def_points_for_video_like", null, "15", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(2030), new Guid("59a09c77-c905-461d-b676-454d000a47f5"), "امتیاز پیش فرض برای لایک پست ویدئویی", true, false, null, null, 16 },
                    { new Guid("ff5523c7-bded-4538-ae2f-40fd18ce8773"), "اعتبار", "credit_for_image_ads", null, "500", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(2154), new Guid("59a09c77-c905-461d-b676-454d000a47f5"), "اعتبار لازم برای ثبت آگهی تصویری", true, false, null, null, 27 },
                    { new Guid("ff6dbf6f-6efc-4060-934c-5c9c93c6fc16"), "فروشگاه", "credit_for_client_registration_by_store_invitation", null, "50", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(2057), new Guid("59a09c77-c905-461d-b676-454d000a47f5"), "اعتبار برای فروشنده ای که باعث ثبت نام مشتری شد", true, false, null, null, 22 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Priority", "RoleDescription", "RoleName" },
                values: new object[,]
                {
                    { new Guid("0dcbda12-20c6-43a5-8d9f-5ba192e433c1"), null, null, true, false, null, null, 5, "فروشگاه", "store" },
                    { new Guid("109066df-110a-483c-a9e3-c8e4a5d64312"), null, null, true, false, null, null, 0, "مدیر کل", "super" },
                    { new Guid("156377d3-c2a3-4647-9313-b98670659255"), null, null, true, false, null, null, 6, "مشتری", "client" },
                    { new Guid("38ea3fa1-bee6-4d03-88b0-d83e9bceeee8"), null, null, true, false, null, null, 2, "مدیر کل مناطق", "countryadmin" },
                    { new Guid("4818df4f-60b3-4689-9667-3184ccd4a310"), null, null, true, false, null, null, 4, "بازاریاب", "marketer" },
                    { new Guid("65b7b1d0-1c24-4bf0-9b66-07b5b5fb8a11"), null, null, true, false, null, null, 1, "مدیر سامانه", "admin" },
                    { new Guid("9d8ea448-a1c5-45f7-b677-cfdef214e861"), null, null, true, false, null, null, 3, "مدیر منطقه", "zoneadmin" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CardNumber", "Cellphone", "ConfirmationCode", "Created", "Credits", "DefaultCredit", "Diamonds", "DonnationActive", "Family", "Inviter", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Money", "Name", "Notes", "Points", "ProfileMediaURL", "Username" },
                values: new object[,]
                {
                    { new Guid("2b240d7f-a10a-4781-80e0-d9108166411b"), null, "09177777777", "111111", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(1345), 0L, 0L, 0, false, "user7", null, true, false, null, null, 3000000L, "seventh", null, 90L, "uploads/2022/9/sina2.jpg", "seventhuser" },
                    { new Guid("31721d22-1f90-41cf-b481-060871647e5a"), null, "09100000000", "111111", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(1357), 0L, 0L, 0, false, "user10", null, true, false, null, null, 3000000L, "tenth", null, 90L, "uploads/2022/9/sina2.jpg", "tenthuser" },
                    { new Guid("3271722a-137e-4bb5-b299-fd2138dcab24"), null, "09155555555", "111111", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(1334), 0L, 0L, 0, false, "user5", null, true, false, null, null, 3000000L, "fivth", null, 90L, "uploads/2022/9/sina2.jpg", "fivthuser" },
                    { new Guid("3a607ec4-1c44-4827-bfb6-7593dec0bf6e"), null, "09188888888", "111111", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(1350), 0L, 0L, 0, false, "user8", null, true, false, null, null, 3000000L, "eighth", null, 90L, "uploads/2022/9/sina2.jpg", "eighthuser" },
                    { new Guid("3c2c54ea-1367-4bad-8a83-e5f70fa8f301"), null, "09122222222", "111111", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(1258), 0L, 0L, 0, false, "user2", null, true, false, null, null, 3000000L, "second", null, 90L, "uploads/2022/9/sina2.jpg", "seconduser" },
                    { new Guid("59a09c77-c905-461d-b676-454d000a47f5"), null, "09394125130", "111111", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(1249), 0L, 0L, 0, false, "Jouybari", new Guid("5b8882a9-9120-4df0-b6db-d44647b880bb"), true, false, null, null, 850000L, "Sina", null, 90L, "uploads/2022/9/sina2.jpg", "sinful" },
                    { new Guid("5b8882a9-9120-4df0-b6db-d44647b880bb"), null, "09901069557", null, new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(1200), 1000L, 0L, 0, true, "دابویی مشک آبادی", null, true, false, null, null, 0L, "عبدالرحمن", null, 100L, "uploads/2022/9/photo.jpg", "dabooei" },
                    { new Guid("688f5412-7056-4f84-b828-79b1c817f28b"), null, "09199999999", "111111", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(1354), 0L, 0L, 0, false, "user9", null, true, false, null, null, 3000000L, "ninth", null, 90L, "uploads/2022/9/sina2.jpg", "ninthuser" },
                    { new Guid("68c25328-1f8a-40b9-beb8-5943d12ec642"), null, "09111111111", "111111", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(1254), 0L, 0L, 0, false, "user1", null, true, false, null, null, 3000000L, "first", null, 90L, "uploads/2022/9/sina2.jpg", "firstuser" },
                    { new Guid("9ad1164d-bab3-434e-b142-10a7a9b2295a"), null, "09133333333", "111111", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(1324), 0L, 0L, 0, false, "user3", null, true, false, null, null, 3000000L, "third", null, 90L, "uploads/2022/9/sina2.jpg", "thirduser" },
                    { new Guid("d0ee26ae-deae-4b8e-9aba-958ae73d169e"), null, "09011000000", "111111", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(1366), 0L, 0L, 0, false, "user11", null, true, false, null, null, 3000000L, "eleventh", null, 90L, "uploads/2022/9/sina2.jpg", "eleventhuser" },
                    { new Guid("d7721ae0-4c62-4d9b-b9bd-d8368005341b"), null, "09144444444", "111111", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(1331), 0L, 0L, 0, false, "user4", null, true, false, null, null, 3000000L, "fourth", null, 90L, "uploads/2022/9/sina2.jpg", "fourthuser" },
                    { new Guid("f3d4fb34-6496-4132-9c33-667fab590fe7"), null, "09166666666", "111111", new DateTime(2023, 2, 19, 22, 8, 6, 52, DateTimeKind.Local).AddTicks(1338), 0L, 0L, 0, false, "user6", null, true, false, null, null, 3000000L, "sixth", null, 90L, "uploads/2022/9/sina2.jpg", "sixthuser" }
                });

            migrationBuilder.InsertData(
                table: "UsersRoles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "Role", "User" },
                values: new object[,]
                {
                    { new Guid("05987bdc-8287-4197-9e2e-942f882aea38"), null, new Guid("5b8882a9-9120-4df0-b6db-d44647b880bb"), false, null, null, new Guid("0dcbda12-20c6-43a5-8d9f-5ba192e433c1"), new Guid("5b8882a9-9120-4df0-b6db-d44647b880bb") },
                    { new Guid("0d0e60fd-6286-4b42-ab0c-b55f194a0403"), null, new Guid("3271722a-137e-4bb5-b299-fd2138dcab24"), false, null, null, new Guid("156377d3-c2a3-4647-9313-b98670659255"), new Guid("3271722a-137e-4bb5-b299-fd2138dcab24") },
                    { new Guid("140e9e8a-e84e-4432-a9c3-db55720b30d8"), null, new Guid("9ad1164d-bab3-434e-b142-10a7a9b2295a"), false, null, null, new Guid("156377d3-c2a3-4647-9313-b98670659255"), new Guid("9ad1164d-bab3-434e-b142-10a7a9b2295a") },
                    { new Guid("1a179297-2dac-4c11-a492-540ee4e786da"), null, new Guid("3a607ec4-1c44-4827-bfb6-7593dec0bf6e"), false, null, null, new Guid("156377d3-c2a3-4647-9313-b98670659255"), new Guid("3a607ec4-1c44-4827-bfb6-7593dec0bf6e") },
                    { new Guid("2a6e1583-bae1-43d7-9bab-62071465e980"), null, new Guid("31721d22-1f90-41cf-b481-060871647e5a"), false, null, null, new Guid("156377d3-c2a3-4647-9313-b98670659255"), new Guid("31721d22-1f90-41cf-b481-060871647e5a") },
                    { new Guid("2ac17cc1-0d58-470c-b98e-c13d49bf1c4c"), null, new Guid("2b240d7f-a10a-4781-80e0-d9108166411b"), false, null, null, new Guid("156377d3-c2a3-4647-9313-b98670659255"), new Guid("2b240d7f-a10a-4781-80e0-d9108166411b") },
                    { new Guid("2e14d5b0-6482-4477-8bb6-3e472ef495c3"), null, new Guid("d7721ae0-4c62-4d9b-b9bd-d8368005341b"), false, null, null, new Guid("156377d3-c2a3-4647-9313-b98670659255"), new Guid("d7721ae0-4c62-4d9b-b9bd-d8368005341b") },
                    { new Guid("71f4b3fb-f49d-4b73-a6e9-fda360ea57b9"), null, new Guid("d0ee26ae-deae-4b8e-9aba-958ae73d169e"), false, null, null, new Guid("156377d3-c2a3-4647-9313-b98670659255"), new Guid("d0ee26ae-deae-4b8e-9aba-958ae73d169e") },
                    { new Guid("8fb27b37-096a-4f4c-8b26-60179851fd9e"), null, new Guid("688f5412-7056-4f84-b828-79b1c817f28b"), false, null, null, new Guid("156377d3-c2a3-4647-9313-b98670659255"), new Guid("688f5412-7056-4f84-b828-79b1c817f28b") },
                    { new Guid("9d74658a-d8c1-4bf9-b963-e3b6733e57c6"), null, new Guid("59a09c77-c905-461d-b676-454d000a47f5"), false, null, null, new Guid("109066df-110a-483c-a9e3-c8e4a5d64312"), new Guid("59a09c77-c905-461d-b676-454d000a47f5") },
                    { new Guid("dcf92ee7-b5d5-4544-be15-465d8a1985f4"), null, new Guid("f3d4fb34-6496-4132-9c33-667fab590fe7"), false, null, null, new Guid("156377d3-c2a3-4647-9313-b98670659255"), new Guid("f3d4fb34-6496-4132-9c33-667fab590fe7") },
                    { new Guid("ddc2718e-db6a-4147-a9b9-25d9fa730aad"), null, new Guid("68c25328-1f8a-40b9-beb8-5943d12ec642"), false, null, null, new Guid("156377d3-c2a3-4647-9313-b98670659255"), new Guid("68c25328-1f8a-40b9-beb8-5943d12ec642") },
                    { new Guid("ebe0068f-4226-403e-8a49-101680987d84"), null, new Guid("3c2c54ea-1367-4bad-8a83-e5f70fa8f301"), false, null, null, new Guid("156377d3-c2a3-4647-9313-b98670659255"), new Guid("3c2c54ea-1367-4bad-8a83-e5f70fa8f301") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Advertises");

            migrationBuilder.DropTable(
                name: "ChallengeUserData");

            migrationBuilder.DropTable(
                name: "ChatBlocks");

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
