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
                name: "InsuranceFourthUserData",
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
                    table.PrimaryKey("PK_InsuranceFourthUserData", x => x.Id);
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
                name: "InsuranceThirdUserData",
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
                    table.PrimaryKey("PK_InsuranceThirdUserData", x => x.Id);
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
                    { new Guid("04cae77b-19fe-4aa5-a096-606771f36839"), "بیمه", "money_needed_to_attend_in_insurance4", null, "50000000", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3674), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "موجودی ریالی برای خرید پکیج 100 میلیونی", true, false, null, null, 57 },
                    { new Guid("0ed3fa47-894e-45c8-8868-e2361807d1de"), "چالش", "expire_dates_for_ads_3", null, "20", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3626), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "تعداد روزهای آگهی تجاری نوع 3", true, false, null, null, 47 },
                    { new Guid("0fab8140-d5a6-46b6-b10e-76c484ed4c2b"), "چالش", "money_needed_to_attend_in_challenge_1", null, "300000", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3546), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "موجودی ریالی برای شرکت در چالش نوع 1", true, false, null, null, 31 },
                    { new Guid("12119c98-7888-4d21-ad15-b3d34518d087"), "اعتبار", "credit_for_video_ads", null, "1000", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3532), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "اعتبار لازم برای ثبت آگهی ویدئویی", true, false, null, null, 29 },
                    { new Guid("14dc2be1-2590-43d8-a0a6-b772d2f42996"), "گردونه", "diamond_third_priority", "10", "11,20", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3353), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "اولویت سوم تعداد الماس و درصد شانس", true, false, null, null, 2 },
                    { new Guid("183d04d3-a651-4bff-8139-ddc793cb011b"), "فروشگاه", "credit_for_client_registration_by_store_invitation", null, "50", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3502), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "اعتبار برای فروشنده ای که باعث ثبت نام مشتری شد", true, false, null, null, 23 },
                    { new Guid("1a270aef-7c38-4b7d-9ec7-29184a021d61"), "گردونه", "diamond_seventh_priority", "3", "101,200", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3374), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "اولویت هفتم تعداد الماس و درصد شانس", true, false, null, null, 6 },
                    { new Guid("1af21419-31b3-480e-b55b-b681967e1104"), "گردونه", "diamond_eighth_priority", "2", "201,300", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3382), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "اولویت هشتم تعداد الماس و درصد شانس", true, false, null, null, 7 },
                    { new Guid("26f73e82-50ed-448a-a19a-a122373e08af"), "گردونه", "diamond_fourth_priority", "6", "21,30", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3360), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "اولویت چهارم تعداد الماس و درصد شانس", true, false, null, null, 3 },
                    { new Guid("291fb663-adf7-4966-b2a2-4111a976bb97"), "مالی", "money_to_credit_ratio", null, "1000", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3509), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "نسبت هر اعتبار به تومان", true, false, null, null, 24 },
                    { new Guid("29e9981f-3212-416a-ab9f-250b1e332cde"), "گردونه", "diamond_fivth_priority", "5", "31,50", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3365), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "اولویت پنجم تعداد الماس و درصد شانس", true, false, null, null, 4 },
                    { new Guid("29fd1367-3bdb-4c06-8125-c5aeda317bc6"), "ثبت نام", "def_points_for_client_invitation", null, "50", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3444), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "امتیاز برای معرف وقتی کاربر ثبت نام کرد.", true, false, null, null, 19 },
                    { new Guid("2ad6deab-e8a2-4f18-a5ea-c1d98ebaab33"), "درصدها", "def_percent_for_countryadmin", null, "4", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3522), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "درصد مدیر مناطق", true, false, null, null, 27 },
                    { new Guid("2d46af4e-009e-40f4-87dc-832324d5bbfb"), "گردونه", "diamond_sixth_priority", "4", "51,100", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3370), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "اولویت ششم تعداد الماس و درصد شانس", true, false, null, null, 5 },
                    { new Guid("34fecdf8-66c8-41fd-8326-d7970d6de544"), "چالش", "maximum_number_of_prize_payment_1", null, "1000", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3560), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "حداکثر تعداد پرداخت کارمزدها نوع 1", true, false, null, null, 34 },
                    { new Guid("390541c2-151d-4c5e-8ccb-648125dbc0c9"), "چالش", "expire_dates_for_challenge_3", null, "90", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3599), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "تعداد روزهای مجاز برای چالش نوع 3", true, false, null, null, 42 },
                    { new Guid("41ffefae-75dd-441d-941f-ac7c1faa622b"), "لایک ها", "def_points_for_image_like", null, "1", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3424), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "امتیاز پیش فرض برای لایک پست تصویری", true, false, null, null, 15 },
                    { new Guid("4750fb60-ccf9-4896-a0c0-1b951992c3e6"), "چالش", "maximum_number_of_prize_payment_3", null, "1000", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3618), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "حداکثر تعداد پرداخت کارمزدها نوع 3", true, false, null, null, 46 },
                    { new Guid("4812e93e-829e-40ad-bf1b-ae0d769dc64d"), "گردونه", "diamond_nineth_priority", "0", "301,500", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3387), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "امتیاز نهم آگهی تبلیغاتی تصویری", true, false, null, null, 8 },
                    { new Guid("495e4152-80cf-4b9c-845f-003d6333fd2a"), "چالش", "order_of_prize_payment_2", null, "2,3,5", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3586), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "ترتیب پرداخت کارمزدها نوع 2", true, false, null, null, 39 },
                    { new Guid("4c95a862-7d09-4c74-a61b-022d8d4e3e01"), "گردونه", "min_points_to_spin_diamond_wheel", null, "200", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3322), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "حداقل امتیاز برای چرخاندن گردونه شانس الماس بار اول", true, false, null, null, -2 },
                    { new Guid("52d016e6-feb0-480e-a28a-37813d7601b8"), "لایک ها", "def_points_for_audio_like", null, "5", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3434), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "امتیاز پیش فرض برای لایک پست صوتی", true, false, null, null, 17 },
                    { new Guid("59956551-de70-49ff-9cc0-1ddab9249270"), "بیمه", "prize_marketer_to_invite_in_insurance4", null, "4000000", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3678), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "پورسانت بازاریاب", true, false, null, null, 58 },
                    { new Guid("641df135-7735-4ef8-85f8-274cf979e293"), "آگهی تبلیغاتی", "def_money_to_premium_video_ads", null, "1000000", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3396), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "هزینه درج آگهی تبلیغاتی ویدئویی", true, false, null, null, 10 },
                    { new Guid("664d5737-26bc-4b4e-a458-24be2bd55bd0"), "چالش", "money_needed_to_attend_in_challenge_3", null, "30000000", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3604), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "موجودی ریالی برای شرکت در چالش نوع 3", true, false, null, null, 43 },
                    { new Guid("678d23cd-6078-46e4-8dc3-484d9a40674c"), "اعتبار", "credit_for_image_ads", null, "500", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3527), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "اعتبار لازم برای ثبت آگهی تصویری", true, false, null, null, 28 },
                    { new Guid("67fe430e-a290-4df3-b88e-4de1b25bddfb"), "چالش", "order_of_prize_payment_1", null, "2,3,5", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3555), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "ترتیب پرداخت کارمزدها نوع 1", true, false, null, null, 33 },
                    { new Guid("6fba6822-ba13-4a2c-b799-8ca9dcc2973c"), "لایک ها", "def_points_for_video_like", null, "15", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3429), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "امتیاز پیش فرض برای لایک پست ویدئویی", true, false, null, null, 16 },
                    { new Guid("7d7f5790-c52d-4c94-be9d-835cfa30892d"), "چالش", "expire_dates_for_challenge_1", null, "30", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3537), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "تعداد روزهای مجاز برای چالش نوع 1", true, false, null, null, 30 },
                    { new Guid("8019bdd7-9b47-42a0-8862-8c42569b590a"), "گردونه", "diamond_tenth_priority", "0", "999,1000", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3391), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "امتیاز دهم آگهی تبلیغاتی تصویری", true, false, null, null, 9 },
                    { new Guid("890756b2-51f9-47e3-a599-dd94793d353f"), "چالش", "prize_for_invite_to_challenge_3", null, "10000000", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3608), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "کارمزد برای معرفی کاربران به چالش نوع 3", true, false, null, null, 44 },
                    { new Guid("8e48eaf6-f9ea-4369-b392-698002242df5"), "آگهی تبلیغاتی", "points_reward_premium_video_ads", null, "200", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3407), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "امتیاز ثبت آگهی تبلیغاتی ویدئویی", true, false, null, null, 12 },
                    { new Guid("8e574bea-e4d9-4a2b-b673-4a74912770b3"), "گردونه", "diamond_second_priority", "20", "6,10", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3347), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "اولویت دوم تعداد الماس و درصد شانس", true, false, null, null, 1 },
                    { new Guid("8fd8b1f7-837f-4029-8629-b1d247559202"), "فروشگاه", "store_def_credit_reg", null, "0", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3449), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "اعتبار اولیه فروشگاه برای ثبت نام اولین بار", true, false, null, null, 20 },
                    { new Guid("90a5f1f9-5ed7-4beb-9c76-923deef7472e"), "چالش", "expire_dates_for_challenge_2", null, "60", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3570), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "تعداد روزهای مجاز برای چالش نوع 2", true, false, null, null, 36 },
                    { new Guid("97d8d1cf-9cd6-4627-a057-41309097b546"), "گردونه", "diamond_first_priority", "50", "1,5", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3342), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "اولویت اول تعداد الماس و درصد شانس", true, false, null, null, 0 },
                    { new Guid("9d2eb1cd-b6ed-4538-a17c-fb959c15e9f7"), "ثبت نام", "def_points_for_client_registration", null, "100", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3439), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "امتیاز اولیه برای کاربری که ثبت نام میکند.", true, false, null, null, 18 },
                    { new Guid("a1b9e56e-2014-4d6e-b7c1-d3c7bad71a63"), "گردونه", "added_points_to_each_spin_diamond_wheel_after_first_time", null, "100", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3336), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "افزایش تعداد امتیاز به اضای هر بار چرخاندن گردونه شانس در یک روز", true, false, null, null, -1 },
                    { new Guid("a88a5c61-4b35-4711-93e6-1eb01a908ee7"), "آگهی تبلیغاتی", "points_reward_premium_image_ads", null, "1000", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3412), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "امتیاز ثبت آگهی تبلیغاتی تصویری", true, false, null, null, 13 },
                    { new Guid("aa4403d0-3e66-4f23-a75d-2fe174cb2361"), "بیمه", "prize_zoneadmin_to_invite_in_insurance2", null, "4000000", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3653), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "پورسانت مدیر منطقه", true, false, null, null, 53 },
                    { new Guid("ab5e52fb-b8fe-4ddc-b5c3-c1e04696854b"), "بیمه", "prize_zoneadmin_to_invite_in_insurance", null, "2000000", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3639), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "پورسانت مدیر منطقه", true, false, null, null, 50 },
                    { new Guid("ab992e80-37e4-4a4d-a1f4-c9876fd9684c"), "بیمه", "prize_marketer_to_invite_in_insurance", null, "2000000", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3634), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "پورسانت بازاریاب", true, false, null, null, 49 }
                });

            migrationBuilder.InsertData(
                table: "ConstantDictionaries",
                columns: new[] { "Id", "Category", "ConstantKey", "ConstantSecondValue", "ConstantValue", "Created", "CreatedBy", "Description", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy", "PriorityIndex" },
                values: new object[,]
                {
                    { new Guid("acfc3bb4-6c2c-45fa-8a61-60c306d78a7c"), "چالش", "expire_dates_for_ads_2", null, "20", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3595), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "تعداد روزهای آگهی تجاری نوع 2", true, false, null, null, 41 },
                    { new Guid("adbf4b23-fed5-4f3e-b4f5-c4da19e7d321"), "چالش", "expire_dates_for_ads_1", null, "20", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3564), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "تعداد روزهای آگهی تجاری نوع 1", true, false, null, null, 35 },
                    { new Guid("b0383d04-ce7b-4931-87f0-837a0b1f9acf"), "کارت اعتباری", "def_chips_usage_perday", null, "-1", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3416), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "تعداد استفاده از کارت اعتباری هر کاربر در روز", true, false, null, null, 14 },
                    { new Guid("bc5630e5-83f2-429a-99c2-7a0e33dac03c"), "چالش", "money_needed_to_attend_in_challenge_2", null, "3550000", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3575), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "موجودی ریالی برای شرکت در چالش نوع 2", true, false, null, null, 37 },
                    { new Guid("bde6d9d5-4e7b-412c-94aa-e7dc4aa360f9"), "فروشگاه", "store_point_usage_per_day", null, "-1", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3454), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "تعداد دفعات استفاده از کارت تخفیف هر فروشگاه در روز برای یک مشتری", true, false, null, null, 21 },
                    { new Guid("c61c3811-87de-4495-9f5a-5c500da535a1"), "درصدها", "def_percent_for_marketer", null, "10", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3513), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "درصد بازاریاب", true, false, null, null, 25 },
                    { new Guid("d1f31406-c8a6-40a4-8f49-1a2ff1de5524"), "چالش", "order_of_prize_payment_3", null, "2,3,5", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3614), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "ترتیب پرداخت کارمزدها نوع 3", true, false, null, null, 45 },
                    { new Guid("d60a8c76-3499-4665-9a98-4792931d36d2"), "درصدها", "def_percent_for_zoneadmin", null, "6", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3517), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "درصد مدیر منطقه", true, false, null, null, 26 },
                    { new Guid("d791e1ea-3fce-4e05-93ae-e30ad2f71a83"), "بیمه", "money_needed_to_attend_in_insurance2", null, "25000000", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3643), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "موجودی ریالی برای خرید پکیج تخفیف بیمه‌ای و ثبت نام وام مهرامید", true, false, null, null, 51 },
                    { new Guid("d92c57cc-211f-4e57-ba75-d05ecde8b44c"), "چالش", "prize_for_invite_to_challenge_2", null, "1000000", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3579), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "کارمزد برای معرفی کاربران به چالش نوع 2", true, false, null, null, 38 },
                    { new Guid("da051bb8-ad34-4f5e-a19e-afaca31eb7a0"), "بیمه", "prize_marketer_to_invite_in_insurance3", null, "4000000", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3665), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "پورسانت بازاریاب", true, false, null, null, 55 },
                    { new Guid("dcc35aef-5441-49fd-b809-de96247082d4"), "بیمه", "prize_marketer_to_invite_in_insurance2", null, "4000000", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3647), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "پورسانت بازاریاب", true, false, null, null, 52 },
                    { new Guid("dff474d2-8c7c-4016-98d0-c986871517b1"), "چالش", "prize_for_invite_to_challenge_1", null, "100000", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3551), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "کارمزد برای معرفی کاربران به چالش نوع 1", true, false, null, null, 32 },
                    { new Guid("e08f9c18-7456-48f7-a27e-d70eb32ffa65"), "آگهی تبلیغاتی", "def_money_to_premium_image_ads", null, "200000", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3402), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "هزینه درج آگهی تبلیغاتی تصویری", true, false, null, null, 11 },
                    { new Guid("e14eb730-d5b6-48c1-a567-677519291f86"), "بیمه", "prize_zoneadmin_to_invite_in_insurance3", null, "4000000", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3669), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "پورسانت مدیر منطقه", true, false, null, null, 56 },
                    { new Guid("e40238bb-7a1f-41d3-80f6-aa222c3ea903"), "فروشگاه", "stores_max_donnation_point", null, "500", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3459), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "حداکثر امتیازی که فروشگاه میتواند در هر نوتب هدیه بدهد", true, false, null, null, 22 },
                    { new Guid("e6ac9973-004d-4d77-a021-1a75edf97c47"), "بیمه", "money_needed_to_attend_in_insurance3", null, "60000000", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3658), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "موجودی ریالی برای خرید پکیج تخفیف لوازم خانگی", true, false, null, null, 54 },
                    { new Guid("ebbc96e0-b88b-460f-a15c-6f58c8ea82d7"), "چالش", "maximum_number_of_prize_payment_2", null, "1000", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3590), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "حداکثر تعداد پرداخت کارمزدها نوع 2", true, false, null, null, 40 },
                    { new Guid("f59f11c0-a06d-467e-be71-825a42957bab"), "بیمه", "prize_zoneadmin_to_invite_in_insurance4", null, "4000000", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3683), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "پورسانت مدیر منطقه", true, false, null, null, 59 },
                    { new Guid("f5b18abe-c071-46dc-be0c-da920c903a22"), "بیمه", "money_needed_to_attend_in_insurance", null, "12000000", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(3630), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), "موجودی ریالی برای خرید پکیج بیمه حوادث انفرادی", true, false, null, null, 48 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Priority", "RoleDescription", "RoleName" },
                values: new object[,]
                {
                    { new Guid("3f552725-7bd5-455a-8bab-5c3ae6ed8e29"), null, null, true, false, null, null, 4, "بازاریاب", "marketer" },
                    { new Guid("4d69c593-90cd-451f-9153-6d2c14c24b39"), null, null, true, false, null, null, 0, "مدیر کل", "super" },
                    { new Guid("6ba1d644-f5fc-497d-9d54-6a086aa1e766"), null, null, true, false, null, null, 6, "مشتری", "client" },
                    { new Guid("94337b9f-795f-481e-8c09-5370cdfcfc68"), null, null, true, false, null, null, 5, "فروشگاه", "store" },
                    { new Guid("b649b467-1e50-4688-b0ee-03744eba772d"), null, null, true, false, null, null, 3, "مدیر منطقه", "zoneadmin" },
                    { new Guid("bb068be9-9f95-4f6f-b5bd-73a0256855d9"), null, null, true, false, null, null, 2, "مدیر کل مناطق", "countryadmin" },
                    { new Guid("e0ef1624-1b26-47b6-bd4f-d4ae0e500845"), null, null, true, false, null, null, 1, "مدیر سامانه", "admin" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CardNumber", "Cellphone", "ConfirmationCode", "Created", "Credits", "DefaultCredit", "Diamonds", "DonnationActive", "Family", "HasNewMessage", "Inviter", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Money", "Name", "Notes", "Points", "ProfileMediaURL", "ShowMyFullNameInPublic", "Username" },
                values: new object[,]
                {
                    { new Guid("25cbd0dc-85c6-4b1c-a5e2-ef23ac2a0505"), null, "09011000000", "111111", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(2671), 0L, 0L, 0, false, "user11", null, null, true, false, null, null, 3000000L, "eleventh", null, 90L, "uploads/2022/9/sina2.jpg", null, "eleventhuser" },
                    { new Guid("27ec2277-ab55-48e0-b66f-762a9cc2d9c6"), null, "09177777777", "111111", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(2648), 0L, 0L, 0, false, "user7", null, null, true, false, null, null, 3000000L, "seventh", null, 90L, "uploads/2022/9/sina2.jpg", null, "seventhuser" },
                    { new Guid("34627b58-b47a-40af-bab6-bf21facc80c4"), null, "09133333333", "111111", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(2626), 0L, 0L, 0, false, "user3", null, null, true, false, null, null, 3000000L, "third", null, 90L, "uploads/2022/9/sina2.jpg", null, "thirduser" },
                    { new Guid("3eba2d3c-fe1a-422c-bf03-9020d5dbf4b8"), null, "09111111111", "111111", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(2612), 0L, 0L, 0, false, "user1", null, null, true, false, null, null, 3000000L, "first", null, 90L, "uploads/2022/9/sina2.jpg", null, "firstuser" },
                    { new Guid("5f7b2cab-5b64-45d7-b886-f2cd97d9200c"), null, "09188888888", "111111", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(2653), 0L, 0L, 0, false, "user8", null, null, true, false, null, null, 3000000L, "eighth", null, 90L, "uploads/2022/9/sina2.jpg", null, "eighthuser" },
                    { new Guid("9eda3548-8b59-4652-8fb2-1462a4d6e908"), null, "09901069557", null, new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(2490), 1000L, 0L, 0, true, "دابویی مشک آبادی", null, null, true, false, null, null, 0L, "عبدالرحمن", null, 100L, "uploads/2022/9/photo.jpg", null, "dabooei" },
                    { new Guid("b2aa3ea6-6438-4695-8107-6712995cc5c5"), null, "09100000000", "111111", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(2666), 0L, 0L, 0, false, "user10", null, null, true, false, null, null, 3000000L, "tenth", null, 90L, "uploads/2022/9/sina2.jpg", null, "tenthuser" },
                    { new Guid("b2d3a024-78ee-4798-87bc-a4ef2a3cb4e7"), null, "09155555555", "111111", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(2638), 0L, 0L, 0, false, "user5", null, null, true, false, null, null, 3000000L, "fivth", null, 90L, "uploads/2022/9/sina2.jpg", null, "fivthuser" },
                    { new Guid("c115d9e9-1955-4d13-8428-54854cb63ee4"), null, "09144444444", "111111", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(2631), 0L, 0L, 0, false, "user4", null, null, true, false, null, null, 3000000L, "fourth", null, 90L, "uploads/2022/9/sina2.jpg", null, "fourthuser" },
                    { new Guid("c864bb8a-5d72-4f8a-bb42-86b3eb241678"), null, "09122222222", "111111", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(2621), 0L, 0L, 0, false, "user2", null, null, true, false, null, null, 3000000L, "second", null, 90L, "uploads/2022/9/sina2.jpg", null, "seconduser" },
                    { new Guid("d3b587fb-383c-43f7-b026-6b47f2bd3920"), null, "09166666666", "111111", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(2643), 0L, 0L, 0, false, "user6", null, null, true, false, null, null, 3000000L, "sixth", null, 90L, "uploads/2022/9/sina2.jpg", null, "sixthuser" },
                    { new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), null, "09394125130", "111111", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(2540), 0L, 0L, 0, false, "Jouybari", null, new Guid("9eda3548-8b59-4652-8fb2-1462a4d6e908"), true, false, null, null, 850000L, "Sina", null, 90L, "uploads/2022/9/sina2.jpg", null, "sinful" },
                    { new Guid("e9fbe090-38f7-4358-a2b7-a14793675a81"), null, "09199999999", "111111", new DateTime(2023, 10, 30, 23, 33, 40, 617, DateTimeKind.Local).AddTicks(2662), 0L, 0L, 0, false, "user9", null, null, true, false, null, null, 3000000L, "ninth", null, 90L, "uploads/2022/9/sina2.jpg", null, "ninthuser" }
                });

            migrationBuilder.InsertData(
                table: "UsersRoles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "Role", "User" },
                values: new object[,]
                {
                    { new Guid("14df387a-0475-4638-ace4-a6f56c4d1ce0"), null, new Guid("c864bb8a-5d72-4f8a-bb42-86b3eb241678"), false, null, null, new Guid("6ba1d644-f5fc-497d-9d54-6a086aa1e766"), new Guid("c864bb8a-5d72-4f8a-bb42-86b3eb241678") },
                    { new Guid("15f928cc-0b9d-4da7-a6c2-0e1b1872d902"), null, new Guid("b2aa3ea6-6438-4695-8107-6712995cc5c5"), false, null, null, new Guid("6ba1d644-f5fc-497d-9d54-6a086aa1e766"), new Guid("b2aa3ea6-6438-4695-8107-6712995cc5c5") }
                });

            migrationBuilder.InsertData(
                table: "UsersRoles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "Role", "User" },
                values: new object[,]
                {
                    { new Guid("17be6ab8-fb68-486b-97bd-12508c430271"), null, new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415"), false, null, null, new Guid("4d69c593-90cd-451f-9153-6d2c14c24b39"), new Guid("d6aff5fa-9f0e-49fc-8ebf-ea438e201415") },
                    { new Guid("547697d8-bd5e-4d44-9fa9-d1104fc699eb"), null, new Guid("c115d9e9-1955-4d13-8428-54854cb63ee4"), false, null, null, new Guid("6ba1d644-f5fc-497d-9d54-6a086aa1e766"), new Guid("c115d9e9-1955-4d13-8428-54854cb63ee4") },
                    { new Guid("60f8fe3a-113d-44c6-911a-0eb6c24dfaf5"), null, new Guid("e9fbe090-38f7-4358-a2b7-a14793675a81"), false, null, null, new Guid("6ba1d644-f5fc-497d-9d54-6a086aa1e766"), new Guid("e9fbe090-38f7-4358-a2b7-a14793675a81") },
                    { new Guid("6619bcb5-dd34-468d-b677-b2d85438f848"), null, new Guid("34627b58-b47a-40af-bab6-bf21facc80c4"), false, null, null, new Guid("6ba1d644-f5fc-497d-9d54-6a086aa1e766"), new Guid("34627b58-b47a-40af-bab6-bf21facc80c4") },
                    { new Guid("6c0c9b5c-8574-433c-8437-6da89ffba458"), null, new Guid("9eda3548-8b59-4652-8fb2-1462a4d6e908"), false, null, null, new Guid("94337b9f-795f-481e-8c09-5370cdfcfc68"), new Guid("9eda3548-8b59-4652-8fb2-1462a4d6e908") },
                    { new Guid("7a19a940-a7a1-413a-a422-dcb5fcdc06bd"), null, new Guid("5f7b2cab-5b64-45d7-b886-f2cd97d9200c"), false, null, null, new Guid("6ba1d644-f5fc-497d-9d54-6a086aa1e766"), new Guid("5f7b2cab-5b64-45d7-b886-f2cd97d9200c") },
                    { new Guid("87192df3-6cf9-4985-88b3-83b3df8a332b"), null, new Guid("b2d3a024-78ee-4798-87bc-a4ef2a3cb4e7"), false, null, null, new Guid("6ba1d644-f5fc-497d-9d54-6a086aa1e766"), new Guid("b2d3a024-78ee-4798-87bc-a4ef2a3cb4e7") },
                    { new Guid("8dec7602-a500-4a5d-93ae-e27b32ac6c31"), null, new Guid("3eba2d3c-fe1a-422c-bf03-9020d5dbf4b8"), false, null, null, new Guid("6ba1d644-f5fc-497d-9d54-6a086aa1e766"), new Guid("3eba2d3c-fe1a-422c-bf03-9020d5dbf4b8") },
                    { new Guid("d3adf470-c218-4638-8bfa-d480ad9646dc"), null, new Guid("d3b587fb-383c-43f7-b026-6b47f2bd3920"), false, null, null, new Guid("6ba1d644-f5fc-497d-9d54-6a086aa1e766"), new Guid("d3b587fb-383c-43f7-b026-6b47f2bd3920") },
                    { new Guid("eb647970-47aa-4e19-8833-985bf38a79e9"), null, new Guid("27ec2277-ab55-48e0-b66f-762a9cc2d9c6"), false, null, null, new Guid("6ba1d644-f5fc-497d-9d54-6a086aa1e766"), new Guid("27ec2277-ab55-48e0-b66f-762a9cc2d9c6") },
                    { new Guid("f973e7b5-7c2e-42bb-be0b-7119aad6a1a8"), null, new Guid("25cbd0dc-85c6-4b1c-a5e2-ef23ac2a0505"), false, null, null, new Guid("6ba1d644-f5fc-497d-9d54-6a086aa1e766"), new Guid("25cbd0dc-85c6-4b1c-a5e2-ef23ac2a0505") }
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
                name: "InsuranceFourthUserData");

            migrationBuilder.DropTable(
                name: "InsuranceSecondUserData");

            migrationBuilder.DropTable(
                name: "InsuranceThirdUserData");

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
