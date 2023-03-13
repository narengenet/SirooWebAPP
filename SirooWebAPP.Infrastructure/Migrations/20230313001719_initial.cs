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
                    IsPublic = table.Column<bool>(type: "bit", nullable: true),
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
                name: "Followers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FollowPerson = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FollowedPerson = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Followers", x => x.Id);
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
                    { new Guid("03e22a15-b740-413b-b505-1f445a7675ce"), "گردونه", "diamond_third_priority", "10", "11,20", new DateTime(2023, 3, 13, 3, 47, 18, 815, DateTimeKind.Local).AddTicks(30), new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), "اولویت سوم تعداد الماس و درصد شانس", true, false, null, null, 2 },
                    { new Guid("1283c8af-2998-4b38-b743-397be7717b58"), "مالی", "money_to_credit_ratio", null, "1000", new DateTime(2023, 3, 13, 3, 47, 18, 815, DateTimeKind.Local).AddTicks(170), new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), "نسبت هر اعتبار به تومان", true, false, null, null, 24 },
                    { new Guid("18933927-7ee8-4b46-9dfd-45319600fe77"), "لایک ها", "def_points_for_audio_like", null, "5", new DateTime(2023, 3, 13, 3, 47, 18, 815, DateTimeKind.Local).AddTicks(138), new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), "امتیاز پیش فرض برای لایک پست صوتی", true, false, null, null, 17 },
                    { new Guid("1911a3d2-b0f7-40ca-807a-56101780690e"), "چالش", "expire_dates_for_ads_2", null, "20", new DateTime(2023, 3, 13, 3, 47, 18, 815, DateTimeKind.Local).AddTicks(247), new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), "تعداد روزهای آگهی تجاری نوع 2", true, false, null, null, 41 },
                    { new Guid("1bcf3c09-f386-4044-8dc5-5cc9175a3c1b"), "چالش", "money_needed_to_attend_in_challenge_1", null, "300000", new DateTime(2023, 3, 13, 3, 47, 18, 815, DateTimeKind.Local).AddTicks(202), new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), "موجودی ریالی برای شرکت در چالش نوع 1", true, false, null, null, 31 },
                    { new Guid("1ef159fc-9f5c-4a9c-bd3d-0b6f4cf30f3a"), "چالش", "money_needed_to_attend_in_challenge_3", null, "30000000", new DateTime(2023, 3, 13, 3, 47, 18, 815, DateTimeKind.Local).AddTicks(254), new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), "موجودی ریالی برای شرکت در چالش نوع 3", true, false, null, null, 43 },
                    { new Guid("21f72f09-b4d2-4fc3-9128-0cf829b84ddc"), "چالش", "maximum_number_of_prize_payment_2", null, "1000", new DateTime(2023, 3, 13, 3, 47, 18, 815, DateTimeKind.Local).AddTicks(243), new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), "حداکثر تعداد پرداخت کارمزدها نوع 2", true, false, null, null, 40 },
                    { new Guid("22b8ee56-eed9-4f90-bf7c-e23841c6b171"), "گردونه", "diamond_first_priority", "50", "1,5", new DateTime(2023, 3, 13, 3, 47, 18, 815, DateTimeKind.Local).AddTicks(22), new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), "اولویت اول تعداد الماس و درصد شانس", true, false, null, null, 0 },
                    { new Guid("29fe261c-f05b-4b7e-bbf8-e678b468f811"), "چالش", "expire_dates_for_ads_1", null, "20", new DateTime(2023, 3, 13, 3, 47, 18, 815, DateTimeKind.Local).AddTicks(217), new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), "تعداد روزهای آگهی تجاری نوع 1", true, false, null, null, 35 },
                    { new Guid("30685463-66e4-4e67-85d6-f7387a3027c4"), "چالش", "expire_dates_for_challenge_2", null, "60", new DateTime(2023, 3, 13, 3, 47, 18, 815, DateTimeKind.Local).AddTicks(223), new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), "تعداد روزهای مجاز برای چالش نوع 2", true, false, null, null, 36 },
                    { new Guid("313a4088-7cb9-41bf-9736-8d8ae8f843d4"), "چالش", "order_of_prize_payment_3", null, "2,3,5", new DateTime(2023, 3, 13, 3, 47, 18, 815, DateTimeKind.Local).AddTicks(270), new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), "ترتیب پرداخت کارمزدها نوع 3", true, false, null, null, 45 },
                    { new Guid("345d39e1-e974-4fcf-8f5b-0b5a8543051e"), "لایک ها", "def_points_for_image_like", null, "1", new DateTime(2023, 3, 13, 3, 47, 18, 815, DateTimeKind.Local).AddTicks(130), new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), "امتیاز پیش فرض برای لایک پست تصویری", true, false, null, null, 15 },
                    { new Guid("386822f8-0e34-407b-b722-909a1dcf694b"), "اعتبار", "credit_for_video_ads", null, "1000", new DateTime(2023, 3, 13, 3, 47, 18, 815, DateTimeKind.Local).AddTicks(195), new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), "اعتبار لازم برای ثبت آگهی ویدئویی", true, false, null, null, 29 },
                    { new Guid("461bce33-71d2-4fbc-a3f8-577976e83e87"), "گردونه", "diamond_sixth_priority", "4", "51,100", new DateTime(2023, 3, 13, 3, 47, 18, 815, DateTimeKind.Local).AddTicks(47), new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), "اولویت ششم تعداد الماس و درصد شانس", true, false, null, null, 5 },
                    { new Guid("4c94c289-b56e-4be7-9011-0bc5752fd377"), "چالش", "maximum_number_of_prize_payment_3", null, "1000", new DateTime(2023, 3, 13, 3, 47, 18, 815, DateTimeKind.Local).AddTicks(274), new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), "حداکثر تعداد پرداخت کارمزدها نوع 3", true, false, null, null, 46 },
                    { new Guid("4df7864f-f625-4046-94c5-e6e7336ff2b8"), "درصدها", "def_percent_for_zoneadmin", null, "6", new DateTime(2023, 3, 13, 3, 47, 18, 815, DateTimeKind.Local).AddTicks(178), new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), "درصد مدیر منطقه", true, false, null, null, 26 },
                    { new Guid("4f85ea5f-0883-4e32-bc23-b73263254199"), "چالش", "order_of_prize_payment_2", null, "2,3,5", new DateTime(2023, 3, 13, 3, 47, 18, 815, DateTimeKind.Local).AddTicks(239), new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), "ترتیب پرداخت کارمزدها نوع 2", true, false, null, null, 39 },
                    { new Guid("523390ac-4848-4d89-95d2-0f060f2a8e19"), "آگهی تبلیغاتی", "def_money_to_premium_video_ads", null, "1000000", new DateTime(2023, 3, 13, 3, 47, 18, 815, DateTimeKind.Local).AddTicks(106), new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), "هزینه درج آگهی تبلیغاتی ویدئویی", true, false, null, null, 10 },
                    { new Guid("562f1b8f-c6ca-4833-9591-cc557e9eb34f"), "گردونه", "min_points_to_spin_diamond_wheel", null, "200", new DateTime(2023, 3, 13, 3, 47, 18, 815, DateTimeKind.Local).AddTicks(6), new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), "حداقل امتیاز برای چرخاندن گردونه شانس الماس بار اول", true, false, null, null, -2 },
                    { new Guid("56ad4abe-2dc2-4930-9180-b729ebd713c5"), "آگهی تبلیغاتی", "def_money_to_premium_image_ads", null, "200000", new DateTime(2023, 3, 13, 3, 47, 18, 815, DateTimeKind.Local).AddTicks(111), new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), "هزینه درج آگهی تبلیغاتی تصویری", true, false, null, null, 11 },
                    { new Guid("592f9c04-4bfe-4a42-851b-818f3fca2e0d"), "گردونه", "diamond_seventh_priority", "3", "101,200", new DateTime(2023, 3, 13, 3, 47, 18, 815, DateTimeKind.Local).AddTicks(51), new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), "اولویت هفتم تعداد الماس و درصد شانس", true, false, null, null, 6 },
                    { new Guid("6cab05f9-285f-41e3-bd44-1bae7329bb18"), "گردونه", "diamond_second_priority", "20", "6,10", new DateTime(2023, 3, 13, 3, 47, 18, 815, DateTimeKind.Local).AddTicks(26), new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), "اولویت دوم تعداد الماس و درصد شانس", true, false, null, null, 1 },
                    { new Guid("6d385685-b66c-4b00-b4b9-67a9cde5634f"), "چالش", "expire_dates_for_challenge_1", null, "30", new DateTime(2023, 3, 13, 3, 47, 18, 815, DateTimeKind.Local).AddTicks(199), new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), "تعداد روزهای مجاز برای چالش نوع 1", true, false, null, null, 30 },
                    { new Guid("6d686b82-8b6b-4915-9bfa-6e54acc28c2e"), "چالش", "order_of_prize_payment_1", null, "2,3,5", new DateTime(2023, 3, 13, 3, 47, 18, 815, DateTimeKind.Local).AddTicks(210), new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), "ترتیب پرداخت کارمزدها نوع 1", true, false, null, null, 33 },
                    { new Guid("6e1c41b5-c5a7-43ce-9905-a4f0bb14c6eb"), "گردونه", "diamond_fivth_priority", "5", "31,50", new DateTime(2023, 3, 13, 3, 47, 18, 815, DateTimeKind.Local).AddTicks(40), new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), "اولویت پنجم تعداد الماس و درصد شانس", true, false, null, null, 4 },
                    { new Guid("7a9c3401-3ce1-472c-a55c-15589cc0a0e4"), "درصدها", "def_percent_for_countryadmin", null, "4", new DateTime(2023, 3, 13, 3, 47, 18, 815, DateTimeKind.Local).AddTicks(183), new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), "درصد مدیر مناطق", true, false, null, null, 27 },
                    { new Guid("7bdd39fa-2e6a-4dfd-85d6-175e323272d8"), "گردونه", "added_points_to_each_spin_diamond_wheel_after_first_time", null, "100", new DateTime(2023, 3, 13, 3, 47, 18, 815, DateTimeKind.Local).AddTicks(17), new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), "افزایش تعداد امتیاز به اضای هر بار چرخاندن گردونه شانس در یک روز", true, false, null, null, -1 },
                    { new Guid("7d9f1c0c-f513-4940-9bf3-5e051ee6ca5a"), "چالش", "maximum_number_of_prize_payment_1", null, "1000", new DateTime(2023, 3, 13, 3, 47, 18, 815, DateTimeKind.Local).AddTicks(214), new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), "حداکثر تعداد پرداخت کارمزدها نوع 1", true, false, null, null, 34 },
                    { new Guid("84ecf5f2-ce0b-4425-9cce-d536beda3e75"), "چالش", "prize_for_invite_to_challenge_3", null, "10000000", new DateTime(2023, 3, 13, 3, 47, 18, 815, DateTimeKind.Local).AddTicks(261), new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), "کارمزد برای معرفی کاربران به چالش نوع 3", true, false, null, null, 44 },
                    { new Guid("8a589c09-8984-4e8a-9f8b-3c682c72a7ba"), "گردونه", "diamond_nineth_priority", "0", "301,500", new DateTime(2023, 3, 13, 3, 47, 18, 815, DateTimeKind.Local).AddTicks(60), new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), "امتیاز نهم آگهی تبلیغاتی تصویری", true, false, null, null, 8 },
                    { new Guid("932fa1a2-db99-4a4a-ba2b-825a65b1100b"), "چالش", "money_needed_to_attend_in_challenge_2", null, "3550000", new DateTime(2023, 3, 13, 3, 47, 18, 815, DateTimeKind.Local).AddTicks(231), new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), "موجودی ریالی برای شرکت در چالش نوع 2", true, false, null, null, 37 },
                    { new Guid("96ccb82f-8028-4fe4-8bb7-fc47c70a571f"), "چالش", "prize_for_invite_to_challenge_2", null, "1000000", new DateTime(2023, 3, 13, 3, 47, 18, 815, DateTimeKind.Local).AddTicks(235), new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), "کارمزد برای معرفی کاربران به چالش نوع 2", true, false, null, null, 38 },
                    { new Guid("97be6a97-1ab9-4c9d-97ae-05c96b76dae0"), "درصدها", "def_percent_for_marketer", null, "10", new DateTime(2023, 3, 13, 3, 47, 18, 815, DateTimeKind.Local).AddTicks(174), new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), "درصد بازاریاب", true, false, null, null, 25 },
                    { new Guid("a8dffc0b-b5e2-4ea3-9d9b-6bd351d6ea01"), "فروشگاه", "store_def_credit_reg", null, "0", new DateTime(2023, 3, 13, 3, 47, 18, 815, DateTimeKind.Local).AddTicks(152), new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), "اعتبار اولیه فروشگاه برای ثبت نام اولین بار", true, false, null, null, 20 },
                    { new Guid("b12b5837-011a-480d-b7d4-c3389a4e78f2"), "فروشگاه", "stores_max_donnation_point", null, "500", new DateTime(2023, 3, 13, 3, 47, 18, 815, DateTimeKind.Local).AddTicks(163), new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), "حداکثر امتیازی که فروشگاه میتواند در هر نوتب هدیه بدهد", true, false, null, null, 22 },
                    { new Guid("b1c7412c-f34b-4d8d-bc5d-0d2823041c7d"), "کارت اعتباری", "def_chips_usage_perday", null, "-1", new DateTime(2023, 3, 13, 3, 47, 18, 815, DateTimeKind.Local).AddTicks(125), new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), "تعداد استفاده از کارت اعتباری هر کاربر در روز", true, false, null, null, 14 },
                    { new Guid("b3a7421e-5acf-42ce-8d47-2024ea7121f0"), "فروشگاه", "credit_for_client_registration_by_store_invitation", null, "50", new DateTime(2023, 3, 13, 3, 47, 18, 815, DateTimeKind.Local).AddTicks(167), new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), "اعتبار برای فروشنده ای که باعث ثبت نام مشتری شد", true, false, null, null, 23 },
                    { new Guid("b507e813-87d1-4813-9d12-608a13e13f9a"), "آگهی تبلیغاتی", "points_reward_premium_video_ads", null, "200", new DateTime(2023, 3, 13, 3, 47, 18, 815, DateTimeKind.Local).AddTicks(115), new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), "امتیاز ثبت آگهی تبلیغاتی ویدئویی", true, false, null, null, 12 },
                    { new Guid("bed73f2b-92ac-4b22-8f95-67ade6313195"), "فروشگاه", "store_point_usage_per_day", null, "-1", new DateTime(2023, 3, 13, 3, 47, 18, 815, DateTimeKind.Local).AddTicks(159), new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), "تعداد دفعات استفاده از کارت تخفیف هر فروشگاه در روز برای یک مشتری", true, false, null, null, 21 },
                    { new Guid("cbf85263-df74-4618-a175-bffb698221b6"), "چالش", "expire_dates_for_challenge_3", null, "90", new DateTime(2023, 3, 13, 3, 47, 18, 815, DateTimeKind.Local).AddTicks(250), new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), "تعداد روزهای مجاز برای چالش نوع 3", true, false, null, null, 42 },
                    { new Guid("cbfb78de-f724-487e-8121-b75a6be6994a"), "چالش", "prize_for_invite_to_challenge_1", null, "100000", new DateTime(2023, 3, 13, 3, 47, 18, 815, DateTimeKind.Local).AddTicks(206), new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), "کارمزد برای معرفی کاربران به چالش نوع 1", true, false, null, null, 32 },
                    { new Guid("d53a04aa-45ca-4371-86b0-adcc50f365eb"), "ثبت نام", "def_points_for_client_registration", null, "100", new DateTime(2023, 3, 13, 3, 47, 18, 815, DateTimeKind.Local).AddTicks(142), new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), "امتیاز اولیه برای کاربری که ثبت نام میکند.", true, false, null, null, 18 }
                });

            migrationBuilder.InsertData(
                table: "ConstantDictionaries",
                columns: new[] { "Id", "Category", "ConstantKey", "ConstantSecondValue", "ConstantValue", "Created", "CreatedBy", "Description", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "PriorityIndex" },
                values: new object[,]
                {
                    { new Guid("d6b575b3-75aa-4e46-bff3-4ddcad0f2ab7"), "آگهی تبلیغاتی", "points_reward_premium_image_ads", null, "1000", new DateTime(2023, 3, 13, 3, 47, 18, 815, DateTimeKind.Local).AddTicks(122), new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), "امتیاز ثبت آگهی تبلیغاتی تصویری", true, false, null, null, 13 },
                    { new Guid("d7389455-6796-408f-b107-d09e981e9f84"), "گردونه", "diamond_eighth_priority", "2", "201,300", new DateTime(2023, 3, 13, 3, 47, 18, 815, DateTimeKind.Local).AddTicks(56), new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), "اولویت هشتم تعداد الماس و درصد شانس", true, false, null, null, 7 },
                    { new Guid("d778bd1b-4da6-472f-919e-388819720750"), "لایک ها", "def_points_for_video_like", null, "15", new DateTime(2023, 3, 13, 3, 47, 18, 815, DateTimeKind.Local).AddTicks(134), new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), "امتیاز پیش فرض برای لایک پست ویدئویی", true, false, null, null, 16 },
                    { new Guid("e33e01fb-2ce9-4990-a652-5b3eac120154"), "گردونه", "diamond_tenth_priority", "0", "999,1000", new DateTime(2023, 3, 13, 3, 47, 18, 815, DateTimeKind.Local).AddTicks(100), new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), "امتیاز دهم آگهی تبلیغاتی تصویری", true, false, null, null, 9 },
                    { new Guid("f3173027-3fd8-4f6a-850f-9a066b834738"), "گردونه", "diamond_fourth_priority", "6", "21,30", new DateTime(2023, 3, 13, 3, 47, 18, 815, DateTimeKind.Local).AddTicks(35), new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), "اولویت چهارم تعداد الماس و درصد شانس", true, false, null, null, 3 },
                    { new Guid("f3743b4a-3d9a-49cd-bfc8-29b0e740c169"), "چالش", "expire_dates_for_ads_3", null, "20", new DateTime(2023, 3, 13, 3, 47, 18, 815, DateTimeKind.Local).AddTicks(277), new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), "تعداد روزهای آگهی تجاری نوع 3", true, false, null, null, 47 },
                    { new Guid("f3a34088-1138-4a13-b681-040581dce66a"), "اعتبار", "credit_for_image_ads", null, "500", new DateTime(2023, 3, 13, 3, 47, 18, 815, DateTimeKind.Local).AddTicks(188), new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), "اعتبار لازم برای ثبت آگهی تصویری", true, false, null, null, 28 },
                    { new Guid("fe8ac958-10ed-4a88-a035-23fbc771b8ac"), "ثبت نام", "def_points_for_client_invitation", null, "50", new DateTime(2023, 3, 13, 3, 47, 18, 815, DateTimeKind.Local).AddTicks(147), new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), "امتیاز برای معرف وقتی کاربر ثبت نام کرد.", true, false, null, null, 19 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Priority", "RoleDescription", "RoleName" },
                values: new object[,]
                {
                    { new Guid("58b8a632-ef9f-4b86-87d5-bfd4f514f684"), null, null, true, false, null, null, 1, "مدیر سامانه", "admin" },
                    { new Guid("7567f8e5-b2fc-4dba-9afe-2893bfc930ba"), null, null, true, false, null, null, 4, "بازاریاب", "marketer" },
                    { new Guid("7d4165ac-67dd-468b-84cb-f10d78d9fd98"), null, null, true, false, null, null, 0, "مدیر کل", "super" },
                    { new Guid("91bc3716-a57a-4de7-8e1a-f982fea242b9"), null, null, true, false, null, null, 3, "مدیر منطقه", "zoneadmin" },
                    { new Guid("b7403080-9d6d-4bdb-9244-e3fa5e49cfc9"), null, null, true, false, null, null, 2, "مدیر کل مناطق", "countryadmin" },
                    { new Guid("ccbc9815-e43e-4485-a21e-9d7bf0577b66"), null, null, true, false, null, null, 5, "فروشگاه", "store" },
                    { new Guid("e12f4427-b0f1-4ca2-910d-0880e6eafda1"), null, null, true, false, null, null, 6, "مشتری", "client" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CardNumber", "Cellphone", "ConfirmationCode", "Created", "Credits", "DefaultCredit", "Diamonds", "DonnationActive", "Family", "HasNewMessage", "Inviter", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Money", "Name", "Notes", "Points", "ProfileMediaURL", "ShowMyFullNameInPublic", "Username" },
                values: new object[,]
                {
                    { new Guid("09ca6dac-610e-41a8-b0ea-99c81222f323"), null, "09166666666", "111111", new DateTime(2023, 3, 13, 3, 47, 18, 814, DateTimeKind.Local).AddTicks(9409), 0L, 0L, 0, false, "user6", null, null, true, false, null, null, 3000000L, "sixth", null, 90L, "uploads/2022/9/sina2.jpg", null, "sixthuser" },
                    { new Guid("5273fd3c-f916-486d-a235-7ff9e010c521"), null, "09011000000", "111111", new DateTime(2023, 3, 13, 3, 47, 18, 814, DateTimeKind.Local).AddTicks(9435), 0L, 0L, 0, false, "user11", null, null, true, false, null, null, 3000000L, "eleventh", null, 90L, "uploads/2022/9/sina2.jpg", null, "eleventhuser" },
                    { new Guid("5dcd5c2b-97a1-4176-bfed-a050985eac66"), null, "09111111111", "111111", new DateTime(2023, 3, 13, 3, 47, 18, 814, DateTimeKind.Local).AddTicks(9388), 0L, 0L, 0, false, "user1", null, null, true, false, null, null, 3000000L, "first", null, 90L, "uploads/2022/9/sina2.jpg", null, "firstuser" },
                    { new Guid("79f7b058-1826-41fc-8f33-d1e20df4d077"), null, "09901069557", null, new DateTime(2023, 3, 13, 3, 47, 18, 814, DateTimeKind.Local).AddTicks(9330), 1000L, 0L, 0, true, "دابویی مشک آبادی", null, null, true, false, null, null, 0L, "عبدالرحمن", null, 100L, "uploads/2022/9/photo.jpg", null, "dabooei" },
                    { new Guid("7d396286-99d0-4279-8b28-8c3c8390bde2"), null, "09155555555", "111111", new DateTime(2023, 3, 13, 3, 47, 18, 814, DateTimeKind.Local).AddTicks(9405), 0L, 0L, 0, false, "user5", null, null, true, false, null, null, 3000000L, "fivth", null, 90L, "uploads/2022/9/sina2.jpg", null, "fivthuser" },
                    { new Guid("928a83f6-7c46-4afa-b3cc-21db99473550"), null, "09100000000", "111111", new DateTime(2023, 3, 13, 3, 47, 18, 814, DateTimeKind.Local).AddTicks(9431), 0L, 0L, 0, false, "user10", null, null, true, false, null, null, 3000000L, "tenth", null, 90L, "uploads/2022/9/sina2.jpg", null, "tenthuser" },
                    { new Guid("a6d1e427-fd1d-45ff-917b-e8f6c3137583"), null, "09133333333", "111111", new DateTime(2023, 3, 13, 3, 47, 18, 814, DateTimeKind.Local).AddTicks(9395), 0L, 0L, 0, false, "user3", null, null, true, false, null, null, 3000000L, "third", null, 90L, "uploads/2022/9/sina2.jpg", null, "thirduser" },
                    { new Guid("b04365fe-c567-45df-8b0c-a45b81404b16"), null, "09144444444", "111111", new DateTime(2023, 3, 13, 3, 47, 18, 814, DateTimeKind.Local).AddTicks(9399), 0L, 0L, 0, false, "user4", null, null, true, false, null, null, 3000000L, "fourth", null, 90L, "uploads/2022/9/sina2.jpg", null, "fourthuser" },
                    { new Guid("b70f7f53-6885-48ac-8f83-ddf997d9c60e"), null, "09199999999", "111111", new DateTime(2023, 3, 13, 3, 47, 18, 814, DateTimeKind.Local).AddTicks(9427), 0L, 0L, 0, false, "user9", null, null, true, false, null, null, 3000000L, "ninth", null, 90L, "uploads/2022/9/sina2.jpg", null, "ninthuser" },
                    { new Guid("c069339b-6be9-4322-bf4e-47e498dab864"), null, "09122222222", "111111", new DateTime(2023, 3, 13, 3, 47, 18, 814, DateTimeKind.Local).AddTicks(9392), 0L, 0L, 0, false, "user2", null, null, true, false, null, null, 3000000L, "second", null, 90L, "uploads/2022/9/sina2.jpg", null, "seconduser" },
                    { new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), null, "09394125130", "111111", new DateTime(2023, 3, 13, 3, 47, 18, 814, DateTimeKind.Local).AddTicks(9383), 0L, 0L, 0, false, "Jouybari", null, new Guid("79f7b058-1826-41fc-8f33-d1e20df4d077"), true, false, null, null, 850000L, "Sina", null, 90L, "uploads/2022/9/sina2.jpg", null, "sinful" },
                    { new Guid("ed673e26-c5eb-447d-a6f3-c7b0e88f1bf3"), null, "09177777777", "111111", new DateTime(2023, 3, 13, 3, 47, 18, 814, DateTimeKind.Local).AddTicks(9417), 0L, 0L, 0, false, "user7", null, null, true, false, null, null, 3000000L, "seventh", null, 90L, "uploads/2022/9/sina2.jpg", null, "seventhuser" },
                    { new Guid("ffc06b55-623d-43e0-a604-2c020f430504"), null, "09188888888", "111111", new DateTime(2023, 3, 13, 3, 47, 18, 814, DateTimeKind.Local).AddTicks(9422), 0L, 0L, 0, false, "user8", null, null, true, false, null, null, 3000000L, "eighth", null, 90L, "uploads/2022/9/sina2.jpg", null, "eighthuser" }
                });

            migrationBuilder.InsertData(
                table: "UsersRoles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "Role", "User" },
                values: new object[,]
                {
                    { new Guid("093d631b-03ec-400f-ba56-32b6a0dd434f"), null, new Guid("5273fd3c-f916-486d-a235-7ff9e010c521"), false, null, null, new Guid("e12f4427-b0f1-4ca2-910d-0880e6eafda1"), new Guid("5273fd3c-f916-486d-a235-7ff9e010c521") },
                    { new Guid("0ec14921-fada-4fa0-ac73-acef5993d22d"), null, new Guid("928a83f6-7c46-4afa-b3cc-21db99473550"), false, null, null, new Guid("e12f4427-b0f1-4ca2-910d-0880e6eafda1"), new Guid("928a83f6-7c46-4afa-b3cc-21db99473550") },
                    { new Guid("18ae83ef-1fed-43c0-a5b0-487bfdf88207"), null, new Guid("7d396286-99d0-4279-8b28-8c3c8390bde2"), false, null, null, new Guid("e12f4427-b0f1-4ca2-910d-0880e6eafda1"), new Guid("7d396286-99d0-4279-8b28-8c3c8390bde2") },
                    { new Guid("212816ba-e9ae-419e-bd37-16a2373f184a"), null, new Guid("5dcd5c2b-97a1-4176-bfed-a050985eac66"), false, null, null, new Guid("e12f4427-b0f1-4ca2-910d-0880e6eafda1"), new Guid("5dcd5c2b-97a1-4176-bfed-a050985eac66") },
                    { new Guid("50200f6f-df1f-4d43-9813-bb40466478be"), null, new Guid("b04365fe-c567-45df-8b0c-a45b81404b16"), false, null, null, new Guid("e12f4427-b0f1-4ca2-910d-0880e6eafda1"), new Guid("b04365fe-c567-45df-8b0c-a45b81404b16") },
                    { new Guid("58711ca9-c620-418c-9a62-6c131350aa36"), null, new Guid("ed673e26-c5eb-447d-a6f3-c7b0e88f1bf3"), false, null, null, new Guid("e12f4427-b0f1-4ca2-910d-0880e6eafda1"), new Guid("ed673e26-c5eb-447d-a6f3-c7b0e88f1bf3") },
                    { new Guid("5fb63100-5ea7-49db-8ea1-fe80dc71bd3c"), null, new Guid("ffc06b55-623d-43e0-a604-2c020f430504"), false, null, null, new Guid("e12f4427-b0f1-4ca2-910d-0880e6eafda1"), new Guid("ffc06b55-623d-43e0-a604-2c020f430504") },
                    { new Guid("6738abbe-5308-4a2b-b879-2ad440e3ee1c"), null, new Guid("c069339b-6be9-4322-bf4e-47e498dab864"), false, null, null, new Guid("e12f4427-b0f1-4ca2-910d-0880e6eafda1"), new Guid("c069339b-6be9-4322-bf4e-47e498dab864") },
                    { new Guid("7a2f31c2-2fe3-4b88-9b3e-0c7a6d0fd96d"), null, new Guid("a6d1e427-fd1d-45ff-917b-e8f6c3137583"), false, null, null, new Guid("e12f4427-b0f1-4ca2-910d-0880e6eafda1"), new Guid("a6d1e427-fd1d-45ff-917b-e8f6c3137583") },
                    { new Guid("aa151aaf-9343-47ce-8888-5d26256d0c2a"), null, new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442"), false, null, null, new Guid("7d4165ac-67dd-468b-84cb-f10d78d9fd98"), new Guid("c8a22863-11f3-41bf-bec8-7cdbcb90d442") },
                    { new Guid("be6ed49e-3041-4a9d-ac62-c88cf203f57b"), null, new Guid("b70f7f53-6885-48ac-8f83-ddf997d9c60e"), false, null, null, new Guid("e12f4427-b0f1-4ca2-910d-0880e6eafda1"), new Guid("b70f7f53-6885-48ac-8f83-ddf997d9c60e") },
                    { new Guid("cede9313-e55a-44f3-9adf-03943ba32126"), null, new Guid("79f7b058-1826-41fc-8f33-d1e20df4d077"), false, null, null, new Guid("ccbc9815-e43e-4485-a21e-9d7bf0577b66"), new Guid("79f7b058-1826-41fc-8f33-d1e20df4d077") },
                    { new Guid("f0f3cf95-4e4b-4500-9da0-003c4848068a"), null, new Guid("09ca6dac-610e-41a8-b0ea-99c81222f323"), false, null, null, new Guid("e12f4427-b0f1-4ca2-910d-0880e6eafda1"), new Guid("09ca6dac-610e-41a8-b0ea-99c81222f323") }
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
                name: "Followers");

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
