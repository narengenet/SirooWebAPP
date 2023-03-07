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
                    IsMusic = table.Column<bool>(type: "bit", nullable: true),
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
                    ShowMyFullNameInPublic = table.Column<bool>(type: "bit", nullable: true),
                    HasNewMessage = table.Column<bool>(type: "bit", nullable: true),
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
                    { new Guid("0273d779-1065-431a-8a99-35852215f0e5"), "چالش", "order_of_prize_payment_2", null, "2,3,5", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(7207), new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), "ترتیب پرداخت کارمزدها نوع 2", true, false, null, null, 39 },
                    { new Guid("03545798-321c-4518-8d26-0688b800c260"), "اعتبار", "credit_for_video_ads", null, "1000", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(7133), new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), "اعتبار لازم برای ثبت آگهی ویدئویی", true, false, null, null, 29 },
                    { new Guid("0387b4b3-9171-49c8-82a9-7c815649f314"), "چالش", "expire_dates_for_ads_1", null, "20", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(7179), new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), "تعداد روزهای آگهی تجاری نوع 1", true, false, null, null, 35 },
                    { new Guid("0e82f180-9099-41bb-9be9-5ce148b95022"), "چالش", "expire_dates_for_challenge_1", null, "30", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(7140), new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), "تعداد روزهای مجاز برای چالش نوع 1", true, false, null, null, 30 },
                    { new Guid("10c6e4a8-2b3e-4788-881e-e5fedd0a6ca3"), "چالش", "maximum_number_of_prize_payment_2", null, "1000", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(7215), new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), "حداکثر تعداد پرداخت کارمزدها نوع 2", true, false, null, null, 40 },
                    { new Guid("1228ba6c-e3e4-440c-a78a-446f158e7d63"), "چالش", "expire_dates_for_challenge_3", null, "90", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(7288), new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), "تعداد روزهای مجاز برای چالش نوع 3", true, false, null, null, 42 },
                    { new Guid("25655424-c021-40cd-9dc8-e21215971c7d"), "فروشگاه", "stores_max_donnation_point", null, "500", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(7079), new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), "حداکثر امتیازی که فروشگاه میتواند در هر نوتب هدیه بدهد", true, false, null, null, 22 },
                    { new Guid("257bff3f-4e28-4373-9d60-3257371770b6"), "گردونه", "added_points_to_each_spin_diamond_wheel_after_first_time", null, "100", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(6900), new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), "افزایش تعداد امتیاز به اضای هر بار چرخاندن گردونه شانس در یک روز", true, false, null, null, -1 },
                    { new Guid("262e484e-1e6e-4ec5-8ec6-b7da34a58d19"), "لایک ها", "def_points_for_image_like", null, "1", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(7026), new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), "امتیاز پیش فرض برای لایک پست تصویری", true, false, null, null, 15 },
                    { new Guid("33615bed-cdc7-435a-bd14-bc338c786196"), "گردونه", "diamond_seventh_priority", "3", "101,200", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(6959), new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), "اولویت هفتم تعداد الماس و درصد شانس", true, false, null, null, 6 },
                    { new Guid("37a7ee21-1b9b-4f05-85f5-19beaf223eef"), "چالش", "expire_dates_for_challenge_2", null, "60", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(7186), new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), "تعداد روزهای مجاز برای چالش نوع 2", true, false, null, null, 36 },
                    { new Guid("3fd0259f-8d5d-42d7-aafd-07d9c6b85669"), "چالش", "expire_dates_for_ads_3", null, "20", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(7325), new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), "تعداد روزهای آگهی تجاری نوع 3", true, false, null, null, 47 },
                    { new Guid("4251d087-30b1-4cdf-9735-8dd2f7e60216"), "گردونه", "diamond_second_priority", "20", "6,10", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(6914), new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), "اولویت دوم تعداد الماس و درصد شانس", true, false, null, null, 1 },
                    { new Guid("485148c2-2807-4a8d-bf27-a413528182c1"), "گردونه", "diamond_fourth_priority", "6", "21,30", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(6936), new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), "اولویت چهارم تعداد الماس و درصد شانس", true, false, null, null, 3 },
                    { new Guid("4ab881e7-b239-435b-b2ac-6465668c83f8"), "چالش", "order_of_prize_payment_3", null, "2,3,5", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(7311), new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), "ترتیب پرداخت کارمزدها نوع 3", true, false, null, null, 45 },
                    { new Guid("4abb3488-dfae-4103-b5fb-74bc3962c89e"), "چالش", "maximum_number_of_prize_payment_1", null, "1000", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(7172), new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), "حداکثر تعداد پرداخت کارمزدها نوع 1", true, false, null, null, 34 },
                    { new Guid("4d2565d3-f7fc-4ab8-a15e-3691d69b4053"), "اعتبار", "credit_for_image_ads", null, "500", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(7125), new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), "اعتبار لازم برای ثبت آگهی تصویری", true, false, null, null, 28 },
                    { new Guid("510febdf-ae7c-434e-95ee-e88d7b7c36af"), "لایک ها", "def_points_for_video_like", null, "15", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(7033), new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), "امتیاز پیش فرض برای لایک پست ویدئویی", true, false, null, null, 16 },
                    { new Guid("56c91c15-1c68-4869-a1c6-2d59ea5bb961"), "گردونه", "diamond_tenth_priority", "0", "999,1000", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(6979), new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), "امتیاز دهم آگهی تبلیغاتی تصویری", true, false, null, null, 9 },
                    { new Guid("5d2e25c5-f610-4bd6-bd18-cc955a44bbf5"), "گردونه", "diamond_sixth_priority", "4", "51,100", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(6950), new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), "اولویت ششم تعداد الماس و درصد شانس", true, false, null, null, 5 },
                    { new Guid("61a4b964-105a-4bb6-a8e3-942d3d2ed698"), "چالش", "prize_for_invite_to_challenge_1", null, "100000", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(7155), new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), "کارمزد برای معرفی کاربران به چالش نوع 1", true, false, null, null, 32 },
                    { new Guid("646462c4-ad85-400e-999c-a2b7e944aafb"), "فروشگاه", "store_point_usage_per_day", null, "-1", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(7072), new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), "تعداد دفعات استفاده از کارت تخفیف هر فروشگاه در روز برای یک مشتری", true, false, null, null, 21 },
                    { new Guid("648f0e40-12a9-48fb-8198-8c9d0c807b06"), "فروشگاه", "credit_for_client_registration_by_store_invitation", null, "50", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(7087), new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), "اعتبار برای فروشنده ای که باعث ثبت نام مشتری شد", true, false, null, null, 23 },
                    { new Guid("6ac61331-dd32-424a-906c-82f02a30714f"), "چالش", "prize_for_invite_to_challenge_3", null, "10000000", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(7304), new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), "کارمزد برای معرفی کاربران به چالش نوع 3", true, false, null, null, 44 },
                    { new Guid("7fa3cb26-360b-43fd-b5a7-35290f5ae27e"), "درصدها", "def_percent_for_countryadmin", null, "4", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(7118), new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), "درصد مدیر مناطق", true, false, null, null, 27 },
                    { new Guid("85a870dd-5cb3-49e7-bfa3-0e89bae02a30"), "چالش", "prize_for_invite_to_challenge_2", null, "1000000", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(7200), new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), "کارمزد برای معرفی کاربران به چالش نوع 2", true, false, null, null, 38 },
                    { new Guid("87520c82-5f25-4701-81a0-ae6bb8220639"), "لایک ها", "def_points_for_audio_like", null, "5", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(7040), new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), "امتیاز پیش فرض برای لایک پست صوتی", true, false, null, null, 17 },
                    { new Guid("89701402-0ec0-4ea4-b938-cb6cefe58334"), "آگهی تبلیغاتی", "def_money_to_premium_video_ads", null, "1000000", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(6989), new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), "هزینه درج آگهی تبلیغاتی ویدئویی", true, false, null, null, 10 },
                    { new Guid("8bb9f88d-9c99-471a-af8e-148b924ee194"), "گردونه", "diamond_third_priority", "10", "11,20", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(6929), new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), "اولویت سوم تعداد الماس و درصد شانس", true, false, null, null, 2 },
                    { new Guid("96d29755-9112-4eaa-be25-c81d99791fd1"), "چالش", "maximum_number_of_prize_payment_3", null, "1000", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(7318), new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), "حداکثر تعداد پرداخت کارمزدها نوع 3", true, false, null, null, 46 },
                    { new Guid("9a798192-a542-4cbc-946e-b128f80eb16b"), "آگهی تبلیغاتی", "def_money_to_premium_image_ads", null, "200000", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(6996), new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), "هزینه درج آگهی تبلیغاتی تصویری", true, false, null, null, 11 },
                    { new Guid("9b4b7c5c-c914-4735-87b3-3694cc8ffa0d"), "آگهی تبلیغاتی", "points_reward_premium_image_ads", null, "1000", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(7011), new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), "امتیاز ثبت آگهی تبلیغاتی تصویری", true, false, null, null, 13 },
                    { new Guid("9ed13067-1bd0-4aa8-93b2-0604e3191f13"), "آگهی تبلیغاتی", "points_reward_premium_video_ads", null, "200", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(7004), new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), "امتیاز ثبت آگهی تبلیغاتی ویدئویی", true, false, null, null, 12 },
                    { new Guid("a5f11ee8-70b8-4e7d-89ee-737d249b760e"), "گردونه", "diamond_eighth_priority", "2", "201,300", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(6966), new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), "اولویت هشتم تعداد الماس و درصد شانس", true, false, null, null, 7 },
                    { new Guid("ab63af6b-c7de-4e45-8096-622dc634811a"), "ثبت نام", "def_points_for_client_invitation", null, "50", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(7058), new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), "امتیاز برای معرف وقتی کاربر ثبت نام کرد.", true, false, null, null, 19 },
                    { new Guid("ad122161-f9a0-402a-ba0b-7017fd585fd4"), "مالی", "money_to_credit_ratio", null, "1000", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(7094), new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), "نسبت هر اعتبار به تومان", true, false, null, null, 24 },
                    { new Guid("ae61183b-c7c2-4231-9c30-3b51ff0e32f6"), "درصدها", "def_percent_for_zoneadmin", null, "6", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(7111), new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), "درصد مدیر منطقه", true, false, null, null, 26 },
                    { new Guid("ae79031d-73ad-4223-ad53-1d1526f935d0"), "گردونه", "min_points_to_spin_diamond_wheel", null, "200", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(6887), new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), "حداقل امتیاز برای چرخاندن گردونه شانس الماس بار اول", true, false, null, null, -2 },
                    { new Guid("b7e52ca4-fe08-48e6-92d4-264ff72aa017"), "چالش", "order_of_prize_payment_1", null, "2,3,5", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(7162), new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), "ترتیب پرداخت کارمزدها نوع 1", true, false, null, null, 33 },
                    { new Guid("babe9e8e-cf31-4fd4-b16e-aef799705afe"), "درصدها", "def_percent_for_marketer", null, "10", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(7101), new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), "درصد بازاریاب", true, false, null, null, 25 },
                    { new Guid("bbaf6c6f-0239-459f-bad1-3a7ae875d973"), "چالش", "expire_dates_for_ads_2", null, "20", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(7222), new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), "تعداد روزهای آگهی تجاری نوع 2", true, false, null, null, 41 },
                    { new Guid("ceb1a7bf-4d0d-4e52-8345-dd76f088339b"), "چالش", "money_needed_to_attend_in_challenge_2", null, "3550000", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(7193), new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), "موجودی ریالی برای شرکت در چالش نوع 2", true, false, null, null, 37 }
                });

            migrationBuilder.InsertData(
                table: "ConstantDictionaries",
                columns: new[] { "Id", "Category", "ConstantKey", "ConstantSecondValue", "ConstantValue", "Created", "CreatedBy", "Description", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "PriorityIndex" },
                values: new object[,]
                {
                    { new Guid("daed9a73-8af9-4d0e-ba78-7bfc164a12a6"), "چالش", "money_needed_to_attend_in_challenge_3", null, "30000000", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(7297), new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), "موجودی ریالی برای شرکت در چالش نوع 3", true, false, null, null, 43 },
                    { new Guid("deea65c3-5d11-4e36-96c9-bc334f91d96d"), "چالش", "money_needed_to_attend_in_challenge_1", null, "300000", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(7148), new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), "موجودی ریالی برای شرکت در چالش نوع 1", true, false, null, null, 31 },
                    { new Guid("e789c8db-f63a-4750-9217-b166f58bb52e"), "گردونه", "diamond_nineth_priority", "0", "301,500", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(6972), new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), "امتیاز نهم آگهی تبلیغاتی تصویری", true, false, null, null, 8 },
                    { new Guid("ec8e6919-5706-4382-97a2-c0faa2feefc1"), "گردونه", "diamond_first_priority", "50", "1,5", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(6907), new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), "اولویت اول تعداد الماس و درصد شانس", true, false, null, null, 0 },
                    { new Guid("f1bb14fa-efef-4a1e-9ce8-2d7b9f33b5a4"), "فروشگاه", "store_def_credit_reg", null, "0", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(7065), new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), "اعتبار اولیه فروشگاه برای ثبت نام اولین بار", true, false, null, null, 20 },
                    { new Guid("f36ed145-4f2a-469a-890a-6a59324debf2"), "کارت اعتباری", "def_chips_usage_perday", null, "-1", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(7019), new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), "تعداد استفاده از کارت اعتباری هر کاربر در روز", true, false, null, null, 14 },
                    { new Guid("fae0f2d3-a4a5-4949-b250-86d8631a7d26"), "ثبت نام", "def_points_for_client_registration", null, "100", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(7050), new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), "امتیاز اولیه برای کاربری که ثبت نام میکند.", true, false, null, null, 18 },
                    { new Guid("fcbd17ae-5b93-4a30-bae2-727f35ba4799"), "گردونه", "diamond_fivth_priority", "5", "31,50", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(6943), new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), "اولویت پنجم تعداد الماس و درصد شانس", true, false, null, null, 4 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Priority", "RoleDescription", "RoleName" },
                values: new object[,]
                {
                    { new Guid("0c9adba3-e1b9-485a-82eb-837d8d56c780"), null, null, true, false, null, null, 6, "مشتری", "client" },
                    { new Guid("18eaa04f-3f7d-4422-b1fb-22e0261bb83f"), null, null, true, false, null, null, 0, "مدیر کل", "super" },
                    { new Guid("20c1681f-19a2-4a00-a78a-c03e51e2c778"), null, null, true, false, null, null, 4, "بازاریاب", "marketer" },
                    { new Guid("583c0e60-f0b6-4682-9860-1aec00ec8a79"), null, null, true, false, null, null, 3, "مدیر منطقه", "zoneadmin" },
                    { new Guid("6894dc27-b886-4fb3-a548-8e1345a7df63"), null, null, true, false, null, null, 5, "فروشگاه", "store" },
                    { new Guid("6cf4e6db-0334-4667-8f32-ab93f74c427e"), null, null, true, false, null, null, 1, "مدیر سامانه", "admin" },
                    { new Guid("9fdd0a26-b197-438f-a91a-0402f08496b0"), null, null, true, false, null, null, 2, "مدیر کل مناطق", "countryadmin" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CardNumber", "Cellphone", "ConfirmationCode", "Created", "Credits", "DefaultCredit", "Diamonds", "DonnationActive", "Family", "HasNewMessage", "Inviter", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Money", "Name", "Notes", "Points", "ProfileMediaURL", "ShowMyFullNameInPublic", "Username" },
                values: new object[,]
                {
                    { new Guid("2467174b-713f-4381-b04f-39a01bf3cc4b"), null, "09901069557", null, new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(6035), 1000L, 0L, 0, true, "دابویی مشک آبادی", null, null, true, false, null, null, 0L, "عبدالرحمن", null, 100L, "uploads/2022/9/photo.jpg", null, "dabooei" },
                    { new Guid("2d2a108a-7a14-469e-9702-7704985a3783"), null, "09133333333", "111111", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(6111), 0L, 0L, 0, false, "user3", null, null, true, false, null, null, 3000000L, "third", null, 90L, "uploads/2022/9/sina2.jpg", null, "thirduser" },
                    { new Guid("3564ae75-bef1-45a3-9b4c-e1211da3e9a3"), null, "09155555555", "111111", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(6146), 0L, 0L, 0, false, "user5", null, null, true, false, null, null, 3000000L, "fivth", null, 90L, "uploads/2022/9/sina2.jpg", null, "fivthuser" },
                    { new Guid("51a8ac8e-aafb-4d98-9630-ba7cc28887bc"), null, "09177777777", "111111", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(6160), 0L, 0L, 0, false, "user7", null, null, true, false, null, null, 3000000L, "seventh", null, 90L, "uploads/2022/9/sina2.jpg", null, "seventhuser" },
                    { new Guid("52ea1e48-ecdb-42a5-971d-2569a3f507ba"), null, "09199999999", "111111", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(6175), 0L, 0L, 0, false, "user9", null, null, true, false, null, null, 3000000L, "ninth", null, 90L, "uploads/2022/9/sina2.jpg", null, "ninthuser" },
                    { new Guid("54144e07-47a3-493e-b16e-df23a9a5e752"), null, "09166666666", "111111", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(6153), 0L, 0L, 0, false, "user6", null, null, true, false, null, null, 3000000L, "sixth", null, 90L, "uploads/2022/9/sina2.jpg", null, "sixthuser" },
                    { new Guid("5b6f0c1a-3345-449f-9210-d7f162d55ea3"), null, "09122222222", "111111", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(6104), 0L, 0L, 0, false, "user2", null, null, true, false, null, null, 3000000L, "second", null, 90L, "uploads/2022/9/sina2.jpg", null, "seconduser" },
                    { new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), null, "09394125130", "111111", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(6087), 0L, 0L, 0, false, "Jouybari", null, new Guid("2467174b-713f-4381-b04f-39a01bf3cc4b"), true, false, null, null, 850000L, "Sina", null, 90L, "uploads/2022/9/sina2.jpg", null, "sinful" },
                    { new Guid("692e7bef-9489-43aa-87eb-ba8260ddb972"), null, "09011000000", "111111", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(6189), 0L, 0L, 0, false, "user11", null, null, true, false, null, null, 3000000L, "eleventh", null, 90L, "uploads/2022/9/sina2.jpg", null, "eleventhuser" },
                    { new Guid("718cb269-da6e-4c88-a9d4-9d58b3881259"), null, "09188888888", "111111", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(6168), 0L, 0L, 0, false, "user8", null, null, true, false, null, null, 3000000L, "eighth", null, 90L, "uploads/2022/9/sina2.jpg", null, "eighthuser" },
                    { new Guid("74af259d-6fc3-4b4e-84b1-a1dc65939c3b"), null, "09111111111", "111111", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(6096), 0L, 0L, 0, false, "user1", null, null, true, false, null, null, 3000000L, "first", null, 90L, "uploads/2022/9/sina2.jpg", null, "firstuser" },
                    { new Guid("ced1d211-1990-4936-a756-7663664f121c"), null, "09100000000", "111111", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(6182), 0L, 0L, 0, false, "user10", null, null, true, false, null, null, 3000000L, "tenth", null, 90L, "uploads/2022/9/sina2.jpg", null, "tenthuser" },
                    { new Guid("e714a4af-7227-465e-8d3a-de409c9efde4"), null, "09144444444", "111111", new DateTime(2023, 3, 7, 3, 51, 8, 456, DateTimeKind.Local).AddTicks(6138), 0L, 0L, 0, false, "user4", null, null, true, false, null, null, 3000000L, "fourth", null, 90L, "uploads/2022/9/sina2.jpg", null, "fourthuser" }
                });

            migrationBuilder.InsertData(
                table: "UsersRoles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "Role", "User" },
                values: new object[,]
                {
                    { new Guid("114915fa-b705-4f49-9406-1efb08b88402"), null, new Guid("e714a4af-7227-465e-8d3a-de409c9efde4"), false, null, null, new Guid("0c9adba3-e1b9-485a-82eb-837d8d56c780"), new Guid("e714a4af-7227-465e-8d3a-de409c9efde4") },
                    { new Guid("22a73b85-33dd-4a13-946d-0f7959441e4f"), null, new Guid("5b6f0c1a-3345-449f-9210-d7f162d55ea3"), false, null, null, new Guid("0c9adba3-e1b9-485a-82eb-837d8d56c780"), new Guid("5b6f0c1a-3345-449f-9210-d7f162d55ea3") },
                    { new Guid("2476bf12-68fe-4ebd-92fc-2fdc8847d658"), null, new Guid("52ea1e48-ecdb-42a5-971d-2569a3f507ba"), false, null, null, new Guid("0c9adba3-e1b9-485a-82eb-837d8d56c780"), new Guid("52ea1e48-ecdb-42a5-971d-2569a3f507ba") },
                    { new Guid("3ad20435-6703-4a63-a8dc-22e954294fa6"), null, new Guid("2d2a108a-7a14-469e-9702-7704985a3783"), false, null, null, new Guid("0c9adba3-e1b9-485a-82eb-837d8d56c780"), new Guid("2d2a108a-7a14-469e-9702-7704985a3783") },
                    { new Guid("492bf3ae-e96a-4422-a893-c7f8b9c3d8fc"), null, new Guid("692e7bef-9489-43aa-87eb-ba8260ddb972"), false, null, null, new Guid("0c9adba3-e1b9-485a-82eb-837d8d56c780"), new Guid("692e7bef-9489-43aa-87eb-ba8260ddb972") },
                    { new Guid("62c6ecd9-9202-4cd6-bca8-8aecdacafe8b"), null, new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078"), false, null, null, new Guid("18eaa04f-3f7d-4422-b1fb-22e0261bb83f"), new Guid("6748d1fa-d49f-4f13-8ef5-5baebba93078") },
                    { new Guid("70bcc3dc-1a8a-4871-9485-4f52f859a06e"), null, new Guid("51a8ac8e-aafb-4d98-9630-ba7cc28887bc"), false, null, null, new Guid("0c9adba3-e1b9-485a-82eb-837d8d56c780"), new Guid("51a8ac8e-aafb-4d98-9630-ba7cc28887bc") },
                    { new Guid("7b2fdc7e-6729-4c14-a39c-adca788b7f91"), null, new Guid("3564ae75-bef1-45a3-9b4c-e1211da3e9a3"), false, null, null, new Guid("0c9adba3-e1b9-485a-82eb-837d8d56c780"), new Guid("3564ae75-bef1-45a3-9b4c-e1211da3e9a3") },
                    { new Guid("80070ee2-2612-4575-b730-0827db7c603a"), null, new Guid("54144e07-47a3-493e-b16e-df23a9a5e752"), false, null, null, new Guid("0c9adba3-e1b9-485a-82eb-837d8d56c780"), new Guid("54144e07-47a3-493e-b16e-df23a9a5e752") },
                    { new Guid("9557b6b7-dde5-4be2-844c-69c9324b3912"), null, new Guid("718cb269-da6e-4c88-a9d4-9d58b3881259"), false, null, null, new Guid("0c9adba3-e1b9-485a-82eb-837d8d56c780"), new Guid("718cb269-da6e-4c88-a9d4-9d58b3881259") },
                    { new Guid("cb0b4517-20f0-4e1a-bbb9-d6359b7b3b12"), null, new Guid("74af259d-6fc3-4b4e-84b1-a1dc65939c3b"), false, null, null, new Guid("0c9adba3-e1b9-485a-82eb-837d8d56c780"), new Guid("74af259d-6fc3-4b4e-84b1-a1dc65939c3b") },
                    { new Guid("eee93b1f-e8ac-44f5-b7ef-e6388c3e3eac"), null, new Guid("ced1d211-1990-4936-a756-7663664f121c"), false, null, null, new Guid("0c9adba3-e1b9-485a-82eb-837d8d56c780"), new Guid("ced1d211-1990-4936-a756-7663664f121c") },
                    { new Guid("fd8971b4-6b97-44d6-bd33-d044a722adfc"), null, new Guid("2467174b-713f-4381-b04f-39a01bf3cc4b"), false, null, null, new Guid("6894dc27-b886-4fb3-a548-8e1345a7df63"), new Guid("2467174b-713f-4381-b04f-39a01bf3cc4b") }
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
