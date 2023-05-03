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
                name: "InsuranceUserData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    User = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Family = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NationalID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdentityID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IssuePlace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    IsMarried = table.Column<bool>(type: "bit", nullable: false),
                    Height = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MilitaryServiceStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResidentialPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cellphone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressProvience = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressPostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatherIsAlive = table.Column<bool>(type: "bit", nullable: false),
                    MotherIsAlive = table.Column<bool>(type: "bit", nullable: false),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsExported = table.Column<bool>(type: "bit", nullable: true),
                    TheParent = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsuranceUserData", x => x.Id);
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
                    { new Guid("020cce39-f246-4d9e-8bfb-37dec1c93b62"), "لایک ها", "def_points_for_image_like", null, "1", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(2345), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), "امتیاز پیش فرض برای لایک پست تصویری", true, false, null, null, 15 },
                    { new Guid("0936debe-738d-4d01-9b54-5d643e678dc3"), "گردونه", "diamond_third_priority", "10", "11,20", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(2268), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), "اولویت سوم تعداد الماس و درصد شانس", true, false, null, null, 2 },
                    { new Guid("0c6b5c8f-4ed1-462c-9947-f09acb5c710e"), "چالش", "prize_for_invite_to_challenge_2", null, "1000000", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(2499), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), "کارمزد برای معرفی کاربران به چالش نوع 2", true, false, null, null, 38 },
                    { new Guid("0ff54104-89eb-467a-b8df-ac8fb21e87c8"), "درصدها", "def_percent_for_zoneadmin", null, "6", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(2401), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), "درصد مدیر منطقه", true, false, null, null, 26 },
                    { new Guid("102bf1b5-acfd-4ab2-986c-a1c12743a461"), "چالش", "expire_dates_for_challenge_3", null, "90", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(2517), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), "تعداد روزهای مجاز برای چالش نوع 3", true, false, null, null, 42 },
                    { new Guid("11525e0c-908c-4f69-8dff-f43324868e65"), "مالی", "money_to_credit_ratio", null, "1000", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(2392), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), "نسبت هر اعتبار به تومان", true, false, null, null, 24 },
                    { new Guid("14da51b6-72e2-47fe-92d0-3f9becad18b3"), "گردونه", "diamond_fivth_priority", "5", "31,50", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(2283), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), "اولویت پنجم تعداد الماس و درصد شانس", true, false, null, null, 4 },
                    { new Guid("1524a05d-2e77-4592-9d22-2fe81bc13786"), "فروشگاه", "stores_max_donnation_point", null, "500", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(2384), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), "حداکثر امتیازی که فروشگاه میتواند در هر نوتب هدیه بدهد", true, false, null, null, 22 },
                    { new Guid("19f7b0d9-baa3-434d-a1e4-509bc030e3ed"), "گردونه", "diamond_nineth_priority", "0", "301,500", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(2308), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), "امتیاز نهم آگهی تبلیغاتی تصویری", true, false, null, null, 8 },
                    { new Guid("304b6ff2-769b-451c-b218-22760fbd86cf"), "چالش", "expire_dates_for_challenge_1", null, "30", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(2421), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), "تعداد روزهای مجاز برای چالش نوع 1", true, false, null, null, 30 },
                    { new Guid("31b73a21-19c0-4dcd-9dd0-17ba7ab2877b"), "گردونه", "added_points_to_each_spin_diamond_wheel_after_first_time", null, "100", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(2242), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), "افزایش تعداد امتیاز به اضای هر بار چرخاندن گردونه شانس در یک روز", true, false, null, null, -1 },
                    { new Guid("37e3af81-fabe-42dc-bc90-0c68e2e9a35f"), "چالش", "money_needed_to_attend_in_challenge_2", null, "3550000", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(2453), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), "موجودی ریالی برای شرکت در چالش نوع 2", true, false, null, null, 37 },
                    { new Guid("3b80d721-14d1-4bf5-bc50-45d19fc522ff"), "گردونه", "diamond_tenth_priority", "0", "999,1000", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(2312), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), "امتیاز دهم آگهی تبلیغاتی تصویری", true, false, null, null, 9 },
                    { new Guid("3d8b9486-60d0-4501-84bc-07d84fba72b4"), "چالش", "maximum_number_of_prize_payment_2", null, "1000", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(2509), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), "حداکثر تعداد پرداخت کارمزدها نوع 2", true, false, null, null, 40 },
                    { new Guid("458cc996-f8d3-47b4-bfac-aba359403fba"), "فروشگاه", "store_point_usage_per_day", null, "-1", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(2376), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), "تعداد دفعات استفاده از کارت تخفیف هر فروشگاه در روز برای یک مشتری", true, false, null, null, 21 },
                    { new Guid("48979d65-d561-4edd-a1c7-428c7b9f7e29"), "چالش", "expire_dates_for_ads_1", null, "20", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(2442), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), "تعداد روزهای آگهی تجاری نوع 1", true, false, null, null, 35 },
                    { new Guid("50ac2859-5b64-4ef9-aea1-9d03f220a338"), "گردونه", "min_points_to_spin_diamond_wheel", null, "200", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(2230), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), "حداقل امتیاز برای چرخاندن گردونه شانس الماس بار اول", true, false, null, null, -2 },
                    { new Guid("574b4c26-41db-4630-ba9d-da88f142fbf7"), "آگهی تبلیغاتی", "def_money_to_premium_video_ads", null, "1000000", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(2316), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), "هزینه درج آگهی تبلیغاتی ویدئویی", true, false, null, null, 10 },
                    { new Guid("5c3a5569-3ade-4b32-98fb-1774d2055a85"), "چالش", "prize_for_invite_to_challenge_1", null, "100000", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(2429), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), "کارمزد برای معرفی کاربران به چالش نوع 1", true, false, null, null, 32 },
                    { new Guid("74d5dcaa-df67-4f47-b01b-1c7d4a09f37e"), "گردونه", "diamond_seventh_priority", "3", "101,200", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(2295), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), "اولویت هفتم تعداد الماس و درصد شانس", true, false, null, null, 6 },
                    { new Guid("7707942c-daa9-4854-99ee-ba910a209be8"), "چالش", "expire_dates_for_ads_3", null, "20", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(2542), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), "تعداد روزهای آگهی تجاری نوع 3", true, false, null, null, 47 },
                    { new Guid("7a88f42f-954c-4c51-a46d-3f7e05deaf7c"), "درصدها", "def_percent_for_marketer", null, "10", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(2397), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), "درصد بازاریاب", true, false, null, null, 25 },
                    { new Guid("7ab04f74-2b8a-4a87-9fc1-faaa63ccd9a8"), "آگهی تبلیغاتی", "points_reward_premium_video_ads", null, "200", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(2328), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), "امتیاز ثبت آگهی تبلیغاتی ویدئویی", true, false, null, null, 12 },
                    { new Guid("7c74a9a4-865f-4d36-9b99-61844caedc59"), "لایک ها", "def_points_for_audio_like", null, "5", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(2354), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), "امتیاز پیش فرض برای لایک پست صوتی", true, false, null, null, 17 },
                    { new Guid("7fe9b03b-c1fd-4ce7-9803-9a311b340545"), "چالش", "order_of_prize_payment_3", null, "2,3,5", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(2533), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), "ترتیب پرداخت کارمزدها نوع 3", true, false, null, null, 45 },
                    { new Guid("8be23bf3-b9f5-450f-a303-5e0fff26d283"), "چالش", "maximum_number_of_prize_payment_1", null, "1000", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(2438), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), "حداکثر تعداد پرداخت کارمزدها نوع 1", true, false, null, null, 34 },
                    { new Guid("8ebe2153-01e1-4d8b-96f4-a267dfbf5a44"), "گردونه", "diamond_second_priority", "20", "6,10", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(2251), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), "اولویت دوم تعداد الماس و درصد شانس", true, false, null, null, 1 },
                    { new Guid("95a03104-fc84-4d5b-b4ad-87b96d7d96b7"), "لایک ها", "def_points_for_video_like", null, "15", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(2349), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), "امتیاز پیش فرض برای لایک پست ویدئویی", true, false, null, null, 16 },
                    { new Guid("97fc6613-2e62-4328-bd2d-c85803e7a4f9"), "چالش", "expire_dates_for_challenge_2", null, "60", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(2449), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), "تعداد روزهای مجاز برای چالش نوع 2", true, false, null, null, 36 },
                    { new Guid("985a00e9-f7dc-4ee4-ac8f-c41b19dcf6ab"), "ثبت نام", "def_points_for_client_registration", null, "100", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(2358), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), "امتیاز اولیه برای کاربری که ثبت نام میکند.", true, false, null, null, 18 },
                    { new Guid("9a72dfef-25ca-4dbd-b109-9954fce04968"), "گردونه", "diamond_fourth_priority", "6", "21,30", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(2274), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), "اولویت چهارم تعداد الماس و درصد شانس", true, false, null, null, 3 },
                    { new Guid("9ab3db3c-5742-43ff-8f24-4adef607f71f"), "آگهی تبلیغاتی", "points_reward_premium_image_ads", null, "1000", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(2335), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), "امتیاز ثبت آگهی تبلیغاتی تصویری", true, false, null, null, 13 },
                    { new Guid("9cbfd7dc-6dd1-4a2c-8b95-274d1e3fae20"), "چالش", "prize_for_invite_to_challenge_3", null, "10000000", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(2528), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), "کارمزد برای معرفی کاربران به چالش نوع 3", true, false, null, null, 44 },
                    { new Guid("a534129d-2680-4874-9a2a-2b997e037651"), "درصدها", "def_percent_for_countryadmin", null, "4", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(2405), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), "درصد مدیر مناطق", true, false, null, null, 27 },
                    { new Guid("ac9c8b8a-6ca5-44b6-955e-1636057500aa"), "فروشگاه", "credit_for_client_registration_by_store_invitation", null, "50", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(2388), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), "اعتبار برای فروشنده ای که باعث ثبت نام مشتری شد", true, false, null, null, 23 },
                    { new Guid("ad438134-9e75-4ab8-8392-85530e680ffd"), "چالش", "order_of_prize_payment_2", null, "2,3,5", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(2505), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), "ترتیب پرداخت کارمزدها نوع 2", true, false, null, null, 39 },
                    { new Guid("ae8d38f1-88bd-466d-87de-43bef25a8efc"), "فروشگاه", "store_def_credit_reg", null, "0", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(2369), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), "اعتبار اولیه فروشگاه برای ثبت نام اولین بار", true, false, null, null, 20 },
                    { new Guid("b58e5f78-d398-4e85-968b-799f50c1f323"), "اعتبار", "credit_for_video_ads", null, "1000", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(2415), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), "اعتبار لازم برای ثبت آگهی ویدئویی", true, false, null, null, 29 },
                    { new Guid("b7263f1a-2776-4823-a5d5-118ffffb70c2"), "چالش", "money_needed_to_attend_in_challenge_1", null, "300000", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(2425), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), "موجودی ریالی برای شرکت در چالش نوع 1", true, false, null, null, 31 },
                    { new Guid("b9a5e3c7-cb1f-453c-b135-1921f98e874c"), "چالش", "maximum_number_of_prize_payment_3", null, "1000", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(2537), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), "حداکثر تعداد پرداخت کارمزدها نوع 3", true, false, null, null, 46 },
                    { new Guid("c08df044-0215-4e5d-93da-63e0083c1904"), "اعتبار", "credit_for_image_ads", null, "500", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(2411), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), "اعتبار لازم برای ثبت آگهی تصویری", true, false, null, null, 28 },
                    { new Guid("d7ee7a34-3f2b-4c1f-8e5b-4692298decb1"), "گردونه", "diamond_first_priority", "50", "1,5", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(2247), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), "اولویت اول تعداد الماس و درصد شانس", true, false, null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "ConstantDictionaries",
                columns: new[] { "Id", "Category", "ConstantKey", "ConstantSecondValue", "ConstantValue", "Created", "CreatedBy", "Description", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "PriorityIndex" },
                values: new object[,]
                {
                    { new Guid("d8f0f00a-7ac2-4065-8880-a6597578f77a"), "چالش", "expire_dates_for_ads_2", null, "20", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(2513), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), "تعداد روزهای آگهی تجاری نوع 2", true, false, null, null, 41 },
                    { new Guid("dc0ef891-eac2-44ff-85f7-641d4ea96584"), "گردونه", "diamond_sixth_priority", "4", "51,100", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(2291), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), "اولویت ششم تعداد الماس و درصد شانس", true, false, null, null, 5 },
                    { new Guid("e5c9d24f-3b55-4278-bc24-12828a67038a"), "ثبت نام", "def_points_for_client_invitation", null, "50", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(2362), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), "امتیاز برای معرف وقتی کاربر ثبت نام کرد.", true, false, null, null, 19 },
                    { new Guid("e7859737-428c-478c-b23f-496e97db46d2"), "آگهی تبلیغاتی", "def_money_to_premium_image_ads", null, "200000", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(2320), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), "هزینه درج آگهی تبلیغاتی تصویری", true, false, null, null, 11 },
                    { new Guid("ecee10d8-f4ff-4dd1-8b98-da90724b73d1"), "چالش", "order_of_prize_payment_1", null, "2,3,5", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(2434), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), "ترتیب پرداخت کارمزدها نوع 1", true, false, null, null, 33 },
                    { new Guid("eef3ae4d-2eb4-4d50-b507-f4806a7470b5"), "کارت اعتباری", "def_chips_usage_perday", null, "-1", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(2339), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), "تعداد استفاده از کارت اعتباری هر کاربر در روز", true, false, null, null, 14 },
                    { new Guid("f0977cda-022d-479f-8103-ebf651bb1ed2"), "گردونه", "diamond_eighth_priority", "2", "201,300", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(2301), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), "اولویت هشتم تعداد الماس و درصد شانس", true, false, null, null, 7 },
                    { new Guid("f2f05381-26d4-4820-a923-4678c5c16652"), "بیمه", "money_needed_to_attend_in_insurance", null, "35000000", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(2546), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), "موجودی ریالی برای خرید پکیج بیمه", true, false, null, null, 48 },
                    { new Guid("f7e740a0-bae5-40a7-b6b5-15d51edf6cc9"), "چالش", "money_needed_to_attend_in_challenge_3", null, "30000000", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(2521), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), "موجودی ریالی برای شرکت در چالش نوع 3", true, false, null, null, 43 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Priority", "RoleDescription", "RoleName" },
                values: new object[,]
                {
                    { new Guid("31b5dee3-f15a-4c8d-9154-1020c91b9a20"), null, null, true, false, null, null, 2, "مدیر کل مناطق", "countryadmin" },
                    { new Guid("6a3531d8-498e-438f-8167-bf95076946c9"), null, null, true, false, null, null, 3, "مدیر منطقه", "zoneadmin" },
                    { new Guid("7026b207-5dac-4ed9-a805-01e11ccd06c5"), null, null, true, false, null, null, 4, "بازاریاب", "marketer" },
                    { new Guid("743587ae-f5bc-46f0-9bef-4d1babb657b8"), null, null, true, false, null, null, 6, "مشتری", "client" },
                    { new Guid("b75e38bd-7dc9-4bab-864b-c28cc4ef7c98"), null, null, true, false, null, null, 1, "مدیر سامانه", "admin" },
                    { new Guid("badc40d6-95b9-4bc1-a054-31c50799fcb9"), null, null, true, false, null, null, 5, "فروشگاه", "store" },
                    { new Guid("e846edd8-2e15-4812-9e06-493e3e1eade3"), null, null, true, false, null, null, 0, "مدیر کل", "super" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CardNumber", "Cellphone", "ConfirmationCode", "Created", "Credits", "DefaultCredit", "Diamonds", "DonnationActive", "Family", "HasNewMessage", "Inviter", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Money", "Name", "Notes", "Points", "ProfileMediaURL", "ShowMyFullNameInPublic", "Username" },
                values: new object[,]
                {
                    { new Guid("00512c2f-ce1b-422d-8d90-886225576ba7"), null, "09122222222", "111111", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(1412), 0L, 0L, 0, false, "user2", null, null, true, false, null, null, 3000000L, "second", null, 90L, "uploads/2022/9/sina2.jpg", null, "seconduser" },
                    { new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), null, "09394125130", "111111", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(1398), 0L, 0L, 0, false, "Jouybari", null, new Guid("1c0e3c92-86ac-4aea-972b-ac812e44ff1c"), true, false, null, null, 850000L, "Sina", null, 90L, "uploads/2022/9/sina2.jpg", null, "sinful" },
                    { new Guid("1c0e3c92-86ac-4aea-972b-ac812e44ff1c"), null, "09901069557", null, new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(1318), 1000L, 0L, 0, true, "دابویی مشک آبادی", null, null, true, false, null, null, 0L, "عبدالرحمن", null, 100L, "uploads/2022/9/photo.jpg", null, "dabooei" },
                    { new Guid("360b35c1-f205-467e-bfd8-3f57bda626d7"), null, "09100000000", "111111", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(1488), 0L, 0L, 0, false, "user10", null, null, true, false, null, null, 3000000L, "tenth", null, 90L, "uploads/2022/9/sina2.jpg", null, "tenthuser" },
                    { new Guid("4cb4f556-9660-4e51-9e1d-9a47dfc7ca1e"), null, "09111111111", "111111", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(1407), 0L, 0L, 0, false, "user1", null, null, true, false, null, null, 3000000L, "first", null, 90L, "uploads/2022/9/sina2.jpg", null, "firstuser" },
                    { new Guid("6cfae818-b833-45ac-ad42-4984a9135cd3"), null, "09155555555", "111111", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(1427), 0L, 0L, 0, false, "user5", null, null, true, false, null, null, 3000000L, "fivth", null, 90L, "uploads/2022/9/sina2.jpg", null, "fivthuser" },
                    { new Guid("78150ba5-73fb-4a80-905b-da4dcd223fd8"), null, "09199999999", "111111", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(1484), 0L, 0L, 0, false, "user9", null, null, true, false, null, null, 3000000L, "ninth", null, 90L, "uploads/2022/9/sina2.jpg", null, "ninthuser" },
                    { new Guid("87e90fd4-3497-4c53-841a-5246be8825b4"), null, "09011000000", "111111", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(1545), 0L, 0L, 0, false, "user11", null, null, true, false, null, null, 3000000L, "eleventh", null, 90L, "uploads/2022/9/sina2.jpg", null, "eleventhuser" },
                    { new Guid("9dda00b1-46dd-48af-93a6-f40c29d50091"), null, "09144444444", "111111", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(1422), 0L, 0L, 0, false, "user4", null, null, true, false, null, null, 3000000L, "fourth", null, 90L, "uploads/2022/9/sina2.jpg", null, "fourthuser" },
                    { new Guid("a103c7c8-e2fd-4892-a5b9-9a42c6b09426"), null, "09177777777", "111111", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(1472), 0L, 0L, 0, false, "user7", null, null, true, false, null, null, 3000000L, "seventh", null, 90L, "uploads/2022/9/sina2.jpg", null, "seventhuser" },
                    { new Guid("a5e6e61d-6c21-4f7d-a2fa-0b3c86b1b427"), null, "09133333333", "111111", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(1418), 0L, 0L, 0, false, "user3", null, null, true, false, null, null, 3000000L, "third", null, 90L, "uploads/2022/9/sina2.jpg", null, "thirduser" },
                    { new Guid("b0ae55cc-3a1c-4d59-ae8a-fb402c30b5f4"), null, "09166666666", "111111", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(1462), 0L, 0L, 0, false, "user6", null, null, true, false, null, null, 3000000L, "sixth", null, 90L, "uploads/2022/9/sina2.jpg", null, "sixthuser" },
                    { new Guid("f6a5dd48-3779-498a-8ef3-5b583a11f544"), null, "09188888888", "111111", new DateTime(2023, 5, 1, 4, 1, 21, 695, DateTimeKind.Local).AddTicks(1477), 0L, 0L, 0, false, "user8", null, null, true, false, null, null, 3000000L, "eighth", null, 90L, "uploads/2022/9/sina2.jpg", null, "eighthuser" }
                });

            migrationBuilder.InsertData(
                table: "UsersRoles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "Role", "User" },
                values: new object[,]
                {
                    { new Guid("09744107-bc74-4f3f-b643-48b0de74114a"), null, new Guid("a5e6e61d-6c21-4f7d-a2fa-0b3c86b1b427"), false, null, null, new Guid("743587ae-f5bc-46f0-9bef-4d1babb657b8"), new Guid("a5e6e61d-6c21-4f7d-a2fa-0b3c86b1b427") },
                    { new Guid("0b7e7fc7-322c-40cd-a0ec-4c77792e38ed"), null, new Guid("6cfae818-b833-45ac-ad42-4984a9135cd3"), false, null, null, new Guid("743587ae-f5bc-46f0-9bef-4d1babb657b8"), new Guid("6cfae818-b833-45ac-ad42-4984a9135cd3") },
                    { new Guid("2500b291-688e-43d7-aec8-d9a7e001ff45"), null, new Guid("4cb4f556-9660-4e51-9e1d-9a47dfc7ca1e"), false, null, null, new Guid("743587ae-f5bc-46f0-9bef-4d1babb657b8"), new Guid("4cb4f556-9660-4e51-9e1d-9a47dfc7ca1e") },
                    { new Guid("26dd360d-5e51-494b-b51e-b251cb1a16d0"), null, new Guid("1c0e3c92-86ac-4aea-972b-ac812e44ff1c"), false, null, null, new Guid("badc40d6-95b9-4bc1-a054-31c50799fcb9"), new Guid("1c0e3c92-86ac-4aea-972b-ac812e44ff1c") },
                    { new Guid("2da45df7-40ec-4053-ae4b-1e494395ff70"), null, new Guid("360b35c1-f205-467e-bfd8-3f57bda626d7"), false, null, null, new Guid("743587ae-f5bc-46f0-9bef-4d1babb657b8"), new Guid("360b35c1-f205-467e-bfd8-3f57bda626d7") },
                    { new Guid("30b11911-f4c8-4111-8c42-aa4fc090cd46"), null, new Guid("9dda00b1-46dd-48af-93a6-f40c29d50091"), false, null, null, new Guid("743587ae-f5bc-46f0-9bef-4d1babb657b8"), new Guid("9dda00b1-46dd-48af-93a6-f40c29d50091") },
                    { new Guid("4c2b6d61-1e9b-4bda-b7a3-5fd4443757ac"), null, new Guid("87e90fd4-3497-4c53-841a-5246be8825b4"), false, null, null, new Guid("743587ae-f5bc-46f0-9bef-4d1babb657b8"), new Guid("87e90fd4-3497-4c53-841a-5246be8825b4") },
                    { new Guid("7f714418-ad7f-4dd0-a4b8-0117394a7634"), null, new Guid("15f24ccf-6c07-4d75-af21-22256a46e651"), false, null, null, new Guid("e846edd8-2e15-4812-9e06-493e3e1eade3"), new Guid("15f24ccf-6c07-4d75-af21-22256a46e651") },
                    { new Guid("9b337f3a-eb25-46ce-98aa-ce9dcb43f457"), null, new Guid("a103c7c8-e2fd-4892-a5b9-9a42c6b09426"), false, null, null, new Guid("743587ae-f5bc-46f0-9bef-4d1babb657b8"), new Guid("a103c7c8-e2fd-4892-a5b9-9a42c6b09426") },
                    { new Guid("a35ca985-f316-4f33-a471-6b25de6a1673"), null, new Guid("b0ae55cc-3a1c-4d59-ae8a-fb402c30b5f4"), false, null, null, new Guid("743587ae-f5bc-46f0-9bef-4d1babb657b8"), new Guid("b0ae55cc-3a1c-4d59-ae8a-fb402c30b5f4") },
                    { new Guid("c0c1b740-cc77-4016-8add-683850b08010"), null, new Guid("f6a5dd48-3779-498a-8ef3-5b583a11f544"), false, null, null, new Guid("743587ae-f5bc-46f0-9bef-4d1babb657b8"), new Guid("f6a5dd48-3779-498a-8ef3-5b583a11f544") },
                    { new Guid("c28d5980-7cd9-4915-960b-e6d41142a333"), null, new Guid("78150ba5-73fb-4a80-905b-da4dcd223fd8"), false, null, null, new Guid("743587ae-f5bc-46f0-9bef-4d1babb657b8"), new Guid("78150ba5-73fb-4a80-905b-da4dcd223fd8") },
                    { new Guid("e4c440c0-fbb0-4848-861b-c267ad3c6578"), null, new Guid("00512c2f-ce1b-422d-8d90-886225576ba7"), false, null, null, new Guid("743587ae-f5bc-46f0-9bef-4d1babb657b8"), new Guid("00512c2f-ce1b-422d-8d90-886225576ba7") }
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
                name: "InsuranceUserData");

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
