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
                name: "InsuranceSecondUserData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    User = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Family = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NationalID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdentityID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cellphone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressProvience = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressPostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NationalIDPerson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullNamePerson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThePolicy = table.Column<bool>(type: "bit", nullable: false),
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
                    table.PrimaryKey("PK_InsuranceSecondUserData", x => x.Id);
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
                    { new Guid("00106fe5-60fd-47d5-b65a-dedbfebbe047"), "چالش", "expire_dates_for_ads_2", null, "20", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(2887), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), "تعداد روزهای آگهی تجاری نوع 2", true, false, null, null, 41 },
                    { new Guid("008bf02f-7d50-4fde-b44b-89764ac8ca0a"), "بیمه", "money_needed_to_attend_in_insurance", null, "35000000", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(2908), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), "موجودی ریالی برای خرید پکیج بیمه", true, false, null, null, 48 },
                    { new Guid("026f57ef-53e8-431d-94a2-92b10a8f8194"), "چالش", "order_of_prize_payment_2", null, "2,3,5", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(2879), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), "ترتیب پرداخت کارمزدها نوع 2", true, false, null, null, 39 },
                    { new Guid("05defbaf-d6e5-4946-9756-f9dccc86575a"), "آگهی تبلیغاتی", "points_reward_premium_video_ads", null, "200", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(2751), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), "امتیاز ثبت آگهی تبلیغاتی ویدئویی", true, false, null, null, 12 },
                    { new Guid("06150c90-d60e-44e1-84a1-547bebb67d2f"), "گردونه", "diamond_tenth_priority", "0", "999,1000", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(2743), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), "امتیاز دهم آگهی تبلیغاتی تصویری", true, false, null, null, 9 },
                    { new Guid("1275904a-d95b-4cbc-9fd8-bacabb664bfc"), "لایک ها", "def_points_for_video_like", null, "15", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(2766), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), "امتیاز پیش فرض برای لایک پست ویدئویی", true, false, null, null, 16 },
                    { new Guid("14170b13-6c6c-46c5-a0a1-011d507ffadb"), "چالش", "expire_dates_for_ads_3", null, "20", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(2901), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), "تعداد روزهای آگهی تجاری نوع 3", true, false, null, null, 47 },
                    { new Guid("153d2527-7a95-4488-a3d8-43d5820a2b69"), "چالش", "maximum_number_of_prize_payment_2", null, "1000", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(2884), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), "حداکثر تعداد پرداخت کارمزدها نوع 2", true, false, null, null, 40 },
                    { new Guid("21fe9574-7d03-4c6c-a9d2-40b38d865003"), "گردونه", "diamond_seventh_priority", "3", "101,200", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(2732), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), "اولویت هفتم تعداد الماس و درصد شانس", true, false, null, null, 6 },
                    { new Guid("2293f230-84e8-4670-966e-19f2997063e3"), "لایک ها", "def_points_for_audio_like", null, "5", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(2769), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), "امتیاز پیش فرض برای لایک پست صوتی", true, false, null, null, 17 },
                    { new Guid("24bd6e96-4abb-40b8-8560-ceed9f13a9f7"), "آگهی تبلیغاتی", "def_money_to_premium_image_ads", null, "200000", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(2748), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), "هزینه درج آگهی تبلیغاتی تصویری", true, false, null, null, 11 },
                    { new Guid("2f074890-de04-4186-bced-fbec00722008"), "چالش", "maximum_number_of_prize_payment_3", null, "1000", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(2899), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), "حداکثر تعداد پرداخت کارمزدها نوع 3", true, false, null, null, 46 },
                    { new Guid("2f77e2b6-18e0-407b-ba99-f70b50d4fce1"), "درصدها", "def_percent_for_countryadmin", null, "4", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(2843), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), "درصد مدیر مناطق", true, false, null, null, 27 },
                    { new Guid("2ffb053e-2d8f-4d0f-9403-f76fe5f04738"), "گردونه", "diamond_sixth_priority", "4", "51,100", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(2728), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), "اولویت ششم تعداد الماس و درصد شانس", true, false, null, null, 5 },
                    { new Guid("35ec7584-7820-43ed-821e-74a22241440f"), "چالش", "expire_dates_for_ads_1", null, "20", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(2868), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), "تعداد روزهای آگهی تجاری نوع 1", true, false, null, null, 35 },
                    { new Guid("3e4b32ba-342a-4105-8ac3-756599c290dd"), "فروشگاه", "store_def_credit_reg", null, "0", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(2776), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), "اعتبار اولیه فروشگاه برای ثبت نام اولین بار", true, false, null, null, 20 },
                    { new Guid("40556795-3153-46ea-8a5a-88459c30522e"), "چالش", "prize_for_invite_to_challenge_3", null, "10000000", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(2894), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), "کارمزد برای معرفی کاربران به چالش نوع 3", true, false, null, null, 44 },
                    { new Guid("48e3a784-665e-4553-b560-373e40a0bf26"), "اعتبار", "credit_for_video_ads", null, "1000", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(2848), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), "اعتبار لازم برای ثبت آگهی ویدئویی", true, false, null, null, 29 },
                    { new Guid("4e2c047f-3136-4f00-a728-a8e677393862"), "ثبت نام", "def_points_for_client_invitation", null, "50", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(2774), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), "امتیاز برای معرف وقتی کاربر ثبت نام کرد.", true, false, null, null, 19 },
                    { new Guid("5238ebb0-4b03-45d3-ab7b-b8c06bebc5c1"), "چالش", "prize_for_invite_to_challenge_2", null, "1000000", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(2875), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), "کارمزد برای معرفی کاربران به چالش نوع 2", true, false, null, null, 38 },
                    { new Guid("54d8ea39-6451-47b7-af76-66e092867dcc"), "فروشگاه", "stores_max_donnation_point", null, "500", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(2782), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), "حداکثر امتیازی که فروشگاه میتواند در هر نوتب هدیه بدهد", true, false, null, null, 22 },
                    { new Guid("5f658627-3da0-45d8-853d-d53e15fcf6fb"), "گردونه", "diamond_first_priority", "50", "1,5", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(2712), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), "اولویت اول تعداد الماس و درصد شانس", true, false, null, null, 0 },
                    { new Guid("66d5d1a3-0e58-4949-9ca9-12215c9da5a6"), "چالش", "maximum_number_of_prize_payment_1", null, "1000", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(2866), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), "حداکثر تعداد پرداخت کارمزدها نوع 1", true, false, null, null, 34 },
                    { new Guid("677dfce2-b460-4a0f-8d10-a3725ac21331"), "فروشگاه", "store_point_usage_per_day", null, "-1", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(2779), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), "تعداد دفعات استفاده از کارت تخفیف هر فروشگاه در روز برای یک مشتری", true, false, null, null, 21 },
                    { new Guid("739a2a58-cd85-456f-9ca8-ecf49486ec2e"), "چالش", "order_of_prize_payment_3", null, "2,3,5", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(2897), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), "ترتیب پرداخت کارمزدها نوع 3", true, false, null, null, 45 },
                    { new Guid("73b76b64-b71b-4b6a-bc36-938f3e622771"), "مالی", "money_to_credit_ratio", null, "1000", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(2836), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), "نسبت هر اعتبار به تومان", true, false, null, null, 24 },
                    { new Guid("77bbd4ba-a4ca-4c64-8c31-c49fea9933e4"), "گردونه", "added_points_to_each_spin_diamond_wheel_after_first_time", null, "100", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(2706), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), "افزایش تعداد امتیاز به اضای هر بار چرخاندن گردونه شانس در یک روز", true, false, null, null, -1 },
                    { new Guid("7842f735-0b1b-49d0-88e0-c20a558a4128"), "گردونه", "diamond_nineth_priority", "0", "301,500", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(2740), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), "امتیاز نهم آگهی تبلیغاتی تصویری", true, false, null, null, 8 },
                    { new Guid("7d709281-8604-484f-99cb-e0b5d486c9e7"), "چالش", "prize_for_invite_to_challenge_1", null, "100000", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(2861), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), "کارمزد برای معرفی کاربران به چالش نوع 1", true, false, null, null, 32 },
                    { new Guid("8d52a1c6-856e-477f-8a91-64079ace0b6b"), "آگهی تبلیغاتی", "def_money_to_premium_video_ads", null, "1000000", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(2745), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), "هزینه درج آگهی تبلیغاتی ویدئویی", true, false, null, null, 10 },
                    { new Guid("8f573bdb-68db-41d3-8894-84e2c2c9f91e"), "گردونه", "diamond_second_priority", "20", "6,10", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(2716), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), "اولویت دوم تعداد الماس و درصد شانس", true, false, null, null, 1 },
                    { new Guid("93bc92bb-2445-419c-a3eb-da3a6a4008c2"), "فروشگاه", "credit_for_client_registration_by_store_invitation", null, "50", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(2829), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), "اعتبار برای فروشنده ای که باعث ثبت نام مشتری شد", true, false, null, null, 23 },
                    { new Guid("97fdb73f-c727-4afd-908f-cd367cc70c7b"), "گردونه", "min_points_to_spin_diamond_wheel", null, "200", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(2699), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), "حداقل امتیاز برای چرخاندن گردونه شانس الماس بار اول", true, false, null, null, -2 },
                    { new Guid("9d296705-b3a3-468e-bfcf-63c8d32c5b5a"), "گردونه", "diamond_third_priority", "10", "11,20", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(2719), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), "اولویت سوم تعداد الماس و درصد شانس", true, false, null, null, 2 },
                    { new Guid("a30bb731-e579-4af5-983d-f80d12d5b6b4"), "لایک ها", "def_points_for_image_like", null, "1", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(2761), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), "امتیاز پیش فرض برای لایک پست تصویری", true, false, null, null, 15 },
                    { new Guid("a321d344-f864-439d-bd18-28b828644b1c"), "چالش", "expire_dates_for_challenge_2", null, "60", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(2870), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), "تعداد روزهای مجاز برای چالش نوع 2", true, false, null, null, 36 },
                    { new Guid("a6c79df1-0589-451f-8451-74314c3861c5"), "آگهی تبلیغاتی", "points_reward_premium_image_ads", null, "1000", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(2753), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), "امتیاز ثبت آگهی تبلیغاتی تصویری", true, false, null, null, 13 },
                    { new Guid("a776353a-950c-4d92-baa5-7b31ed1cfa03"), "درصدها", "def_percent_for_zoneadmin", null, "6", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(2841), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), "درصد مدیر منطقه", true, false, null, null, 26 },
                    { new Guid("abdf4dc1-87c3-4ec6-808a-b026c3e7875b"), "چالش", "expire_dates_for_challenge_3", null, "90", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(2889), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), "تعداد روزهای مجاز برای چالش نوع 3", true, false, null, null, 42 },
                    { new Guid("ae02b3d9-5a16-4245-b765-454e8e4140f5"), "ثبت نام", "def_points_for_client_registration", null, "100", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(2772), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), "امتیاز اولیه برای کاربری که ثبت نام میکند.", true, false, null, null, 18 },
                    { new Guid("b3e118df-85f4-4cbf-84d1-4d103f59692c"), "چالش", "money_needed_to_attend_in_challenge_1", null, "300000", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(2855), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), "موجودی ریالی برای شرکت در چالش نوع 1", true, false, null, null, 31 },
                    { new Guid("bfaaa7ba-c3a4-4ae4-a044-d2921eca9ed9"), "درصدها", "def_percent_for_marketer", null, "10", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(2839), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), "درصد بازاریاب", true, false, null, null, 25 }
                });

            migrationBuilder.InsertData(
                table: "ConstantDictionaries",
                columns: new[] { "Id", "Category", "ConstantKey", "ConstantSecondValue", "ConstantValue", "Created", "CreatedBy", "Description", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "PriorityIndex" },
                values: new object[,]
                {
                    { new Guid("c3ba6517-fedf-4926-91cc-024a742332ed"), "گردونه", "diamond_eighth_priority", "2", "201,300", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(2734), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), "اولویت هشتم تعداد الماس و درصد شانس", true, false, null, null, 7 },
                    { new Guid("cac1fc2a-36a8-4c14-8c66-db2449d1ae75"), "گردونه", "diamond_fourth_priority", "6", "21,30", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(2722), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), "اولویت چهارم تعداد الماس و درصد شانس", true, false, null, null, 3 },
                    { new Guid("d783d66d-df62-40bb-b1cb-8c3b6f651bff"), "چالش", "money_needed_to_attend_in_challenge_3", null, "30000000", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(2892), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), "موجودی ریالی برای شرکت در چالش نوع 3", true, false, null, null, 43 },
                    { new Guid("dcdb783c-fe92-46a6-859a-a2c687cec596"), "چالش", "money_needed_to_attend_in_challenge_2", null, "3550000", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(2873), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), "موجودی ریالی برای شرکت در چالش نوع 2", true, false, null, null, 37 },
                    { new Guid("e70d774a-173c-4b7c-9208-7ccd100a0fed"), "گردونه", "diamond_fivth_priority", "5", "31,50", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(2725), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), "اولویت پنجم تعداد الماس و درصد شانس", true, false, null, null, 4 },
                    { new Guid("eec9abca-c1ff-4efc-b3cb-46e8fc905b2d"), "اعتبار", "credit_for_image_ads", null, "500", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(2846), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), "اعتبار لازم برای ثبت آگهی تصویری", true, false, null, null, 28 },
                    { new Guid("f00e332f-3e0d-44e1-8761-9f4e1e650365"), "چالش", "expire_dates_for_challenge_1", null, "30", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(2851), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), "تعداد روزهای مجاز برای چالش نوع 1", true, false, null, null, 30 },
                    { new Guid("f1c16357-3a2c-4f5c-97f2-9db33225b261"), "چالش", "order_of_prize_payment_1", null, "2,3,5", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(2863), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), "ترتیب پرداخت کارمزدها نوع 1", true, false, null, null, 33 },
                    { new Guid("f2e1ff89-ac11-4b8a-bb02-7725576e763d"), "کارت اعتباری", "def_chips_usage_perday", null, "-1", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(2757), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), "تعداد استفاده از کارت اعتباری هر کاربر در روز", true, false, null, null, 14 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Priority", "RoleDescription", "RoleName" },
                values: new object[,]
                {
                    { new Guid("6e1f0bd2-ee67-44c0-bdb8-3a8bbf91b23d"), null, null, true, false, null, null, 5, "فروشگاه", "store" },
                    { new Guid("79efd07c-9b64-46ae-a86f-a1d3f36b89de"), null, null, true, false, null, null, 0, "مدیر کل", "super" },
                    { new Guid("8ca94b1f-4783-45c7-91c7-6f61d26aa6c4"), null, null, true, false, null, null, 6, "مشتری", "client" },
                    { new Guid("8e871218-8e56-4985-b7f3-fcb2ed28e049"), null, null, true, false, null, null, 2, "مدیر کل مناطق", "countryadmin" },
                    { new Guid("a1d46702-faae-4a83-a3ff-3a3381fc67a6"), null, null, true, false, null, null, 1, "مدیر سامانه", "admin" },
                    { new Guid("c6e8d11f-2ea2-4e2e-ab0c-088d201c2568"), null, null, true, false, null, null, 4, "بازاریاب", "marketer" },
                    { new Guid("efa39ad4-6fdf-4998-b8ab-174c871f9fdd"), null, null, true, false, null, null, 3, "مدیر منطقه", "zoneadmin" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CardNumber", "Cellphone", "ConfirmationCode", "Created", "Credits", "DefaultCredit", "Diamonds", "DonnationActive", "Family", "HasNewMessage", "Inviter", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Money", "Name", "Notes", "Points", "ProfileMediaURL", "ShowMyFullNameInPublic", "Username" },
                values: new object[,]
                {
                    { new Guid("01c3dde5-86df-48f1-a0b5-3fa2b0f8e2ad"), null, "09155555555", "111111", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(1681), 0L, 0L, 0, false, "user5", null, null, true, false, null, null, 3000000L, "fivth", null, 90L, "uploads/2022/9/sina2.jpg", null, "fivthuser" },
                    { new Guid("0f060d96-dbde-4ccb-9e98-a5d577f756a1"), null, "09144444444", "111111", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(1678), 0L, 0L, 0, false, "user4", null, null, true, false, null, null, 3000000L, "fourth", null, 90L, "uploads/2022/9/sina2.jpg", null, "fourthuser" },
                    { new Guid("6ad6eae3-c8f0-4792-afa3-8b75c6eba740"), null, "09199999999", "111111", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(1696), 0L, 0L, 0, false, "user9", null, null, true, false, null, null, 3000000L, "ninth", null, 90L, "uploads/2022/9/sina2.jpg", null, "ninthuser" },
                    { new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), null, "09394125130", "111111", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(1588), 0L, 0L, 0, false, "Jouybari", null, new Guid("e142625e-969e-4c56-b6e6-12d94c8da8c5"), true, false, null, null, 850000L, "Sina", null, 90L, "uploads/2022/9/sina2.jpg", null, "sinful" },
                    { new Guid("98f3254e-fa15-4911-bdd7-0906cc118347"), null, "09133333333", "111111", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(1674), 0L, 0L, 0, false, "user3", null, null, true, false, null, null, 3000000L, "third", null, 90L, "uploads/2022/9/sina2.jpg", null, "thirduser" },
                    { new Guid("a3b82555-3980-4f2b-8cd0-8fa0b33a0694"), null, "09166666666", "111111", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(1684), 0L, 0L, 0, false, "user6", null, null, true, false, null, null, 3000000L, "sixth", null, 90L, "uploads/2022/9/sina2.jpg", null, "sixthuser" },
                    { new Guid("b334f9f2-84ec-4ccc-bc8f-11c8184130ad"), null, "09122222222", "111111", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(1671), 0L, 0L, 0, false, "user2", null, null, true, false, null, null, 3000000L, "second", null, 90L, "uploads/2022/9/sina2.jpg", null, "seconduser" },
                    { new Guid("b56ec279-3549-47e6-ac45-d2066d29d467"), null, "09100000000", "111111", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(1708), 0L, 0L, 0, false, "user10", null, null, true, false, null, null, 3000000L, "tenth", null, 90L, "uploads/2022/9/sina2.jpg", null, "tenthuser" },
                    { new Guid("c9ee86b0-5f85-420c-a63b-0829574e0bb8"), null, "09111111111", "111111", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(1647), 0L, 0L, 0, false, "user1", null, null, true, false, null, null, 3000000L, "first", null, 90L, "uploads/2022/9/sina2.jpg", null, "firstuser" },
                    { new Guid("dbd8a505-c2a4-4e4a-a391-fa3b4fc27af6"), null, "09188888888", "111111", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(1691), 0L, 0L, 0, false, "user8", null, null, true, false, null, null, 3000000L, "eighth", null, 90L, "uploads/2022/9/sina2.jpg", null, "eighthuser" },
                    { new Guid("e142625e-969e-4c56-b6e6-12d94c8da8c5"), null, "09901069557", null, new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(1567), 1000L, 0L, 0, true, "دابویی مشک آبادی", null, null, true, false, null, null, 0L, "عبدالرحمن", null, 100L, "uploads/2022/9/photo.jpg", null, "dabooei" },
                    { new Guid("e85e0851-e324-4e3d-a504-98ad71ef268b"), null, "09177777777", "111111", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(1687), 0L, 0L, 0, false, "user7", null, null, true, false, null, null, 3000000L, "seventh", null, 90L, "uploads/2022/9/sina2.jpg", null, "seventhuser" },
                    { new Guid("feb117b0-fb9b-4c45-8db3-f29d0c4e7545"), null, "09011000000", "111111", new DateTime(2023, 6, 18, 10, 43, 25, 525, DateTimeKind.Local).AddTicks(1712), 0L, 0L, 0, false, "user11", null, null, true, false, null, null, 3000000L, "eleventh", null, 90L, "uploads/2022/9/sina2.jpg", null, "eleventhuser" }
                });

            migrationBuilder.InsertData(
                table: "UsersRoles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "Role", "User" },
                values: new object[,]
                {
                    { new Guid("0601ea9e-70b5-4999-9796-ecb2b2995737"), null, new Guid("feb117b0-fb9b-4c45-8db3-f29d0c4e7545"), false, null, null, new Guid("8ca94b1f-4783-45c7-91c7-6f61d26aa6c4"), new Guid("feb117b0-fb9b-4c45-8db3-f29d0c4e7545") },
                    { new Guid("0dd9b36f-fc7f-446b-b2d7-f32e4f271bb7"), null, new Guid("e85e0851-e324-4e3d-a504-98ad71ef268b"), false, null, null, new Guid("8ca94b1f-4783-45c7-91c7-6f61d26aa6c4"), new Guid("e85e0851-e324-4e3d-a504-98ad71ef268b") },
                    { new Guid("23de9ddb-58f1-4181-805c-92e2d9f614b5"), null, new Guid("c9ee86b0-5f85-420c-a63b-0829574e0bb8"), false, null, null, new Guid("8ca94b1f-4783-45c7-91c7-6f61d26aa6c4"), new Guid("c9ee86b0-5f85-420c-a63b-0829574e0bb8") },
                    { new Guid("5139199f-c6a7-43f3-8fbe-34bddac070f1"), null, new Guid("b56ec279-3549-47e6-ac45-d2066d29d467"), false, null, null, new Guid("8ca94b1f-4783-45c7-91c7-6f61d26aa6c4"), new Guid("b56ec279-3549-47e6-ac45-d2066d29d467") },
                    { new Guid("5543d944-35a9-43cb-8dad-b4212db2f6fd"), null, new Guid("6ad6eae3-c8f0-4792-afa3-8b75c6eba740"), false, null, null, new Guid("8ca94b1f-4783-45c7-91c7-6f61d26aa6c4"), new Guid("6ad6eae3-c8f0-4792-afa3-8b75c6eba740") },
                    { new Guid("716e96cb-f796-49dc-b116-52b015848b0c"), null, new Guid("e142625e-969e-4c56-b6e6-12d94c8da8c5"), false, null, null, new Guid("6e1f0bd2-ee67-44c0-bdb8-3a8bbf91b23d"), new Guid("e142625e-969e-4c56-b6e6-12d94c8da8c5") },
                    { new Guid("91096ce9-4dd4-44a4-b3ae-1053cfd55170"), null, new Guid("dbd8a505-c2a4-4e4a-a391-fa3b4fc27af6"), false, null, null, new Guid("8ca94b1f-4783-45c7-91c7-6f61d26aa6c4"), new Guid("dbd8a505-c2a4-4e4a-a391-fa3b4fc27af6") },
                    { new Guid("9824afa4-ffe1-40ea-af4a-abcd7b4c0d66"), null, new Guid("01c3dde5-86df-48f1-a0b5-3fa2b0f8e2ad"), false, null, null, new Guid("8ca94b1f-4783-45c7-91c7-6f61d26aa6c4"), new Guid("01c3dde5-86df-48f1-a0b5-3fa2b0f8e2ad") },
                    { new Guid("ac6bbdea-191f-4bea-a2f4-40002d9ee3e5"), null, new Guid("98f3254e-fa15-4911-bdd7-0906cc118347"), false, null, null, new Guid("8ca94b1f-4783-45c7-91c7-6f61d26aa6c4"), new Guid("98f3254e-fa15-4911-bdd7-0906cc118347") },
                    { new Guid("e44bd926-d01f-4b0b-aa5f-f63181a9a5a8"), null, new Guid("0f060d96-dbde-4ccb-9e98-a5d577f756a1"), false, null, null, new Guid("8ca94b1f-4783-45c7-91c7-6f61d26aa6c4"), new Guid("0f060d96-dbde-4ccb-9e98-a5d577f756a1") },
                    { new Guid("e984ed6c-54fe-4f1b-b633-49f11babe986"), null, new Guid("a3b82555-3980-4f2b-8cd0-8fa0b33a0694"), false, null, null, new Guid("8ca94b1f-4783-45c7-91c7-6f61d26aa6c4"), new Guid("a3b82555-3980-4f2b-8cd0-8fa0b33a0694") },
                    { new Guid("ebdb70df-0511-4e1c-ac30-683c089c359f"), null, new Guid("b334f9f2-84ec-4ccc-bc8f-11c8184130ad"), false, null, null, new Guid("8ca94b1f-4783-45c7-91c7-6f61d26aa6c4"), new Guid("b334f9f2-84ec-4ccc-bc8f-11c8184130ad") },
                    { new Guid("efe1c3f1-7fcb-4a58-914e-ba014a48177c"), null, new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447"), false, null, null, new Guid("79efd07c-9b64-46ae-a86f-a1d3f36b89de"), new Guid("82721aa0-4b8e-4f15-9e83-eac6d5394447") }
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
                name: "InsuranceSecondUserData");

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
