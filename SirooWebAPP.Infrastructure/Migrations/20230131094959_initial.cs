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
                    { new Guid("0469b98e-32c4-46e6-b100-edc08f8182aa"), "لایک ها", "def_points_for_image_like", null, "1", new DateTime(2023, 1, 31, 13, 19, 58, 903, DateTimeKind.Local).AddTicks(9516), new Guid("32bfdb16-387e-4087-b323-ab649fb49d77"), "امتیاز پیش فرض برای لایک پست تصویری", true, false, null, null, 15 },
                    { new Guid("086fcb17-e59a-45f6-8e1c-0d2df54120d2"), "گردونه", "diamond_nineth_priority", "0", "301,500", new DateTime(2023, 1, 31, 13, 19, 58, 903, DateTimeKind.Local).AddTicks(9495), new Guid("32bfdb16-387e-4087-b323-ab649fb49d77"), "امتیاز نهم آگهی تبلیغاتی تصویری", true, false, null, null, 8 },
                    { new Guid("0deb1230-b5ee-4af5-9dde-bc84e9d5735d"), "گردونه", "diamond_eighth_priority", "2", "201,300", new DateTime(2023, 1, 31, 13, 19, 58, 903, DateTimeKind.Local).AddTicks(9492), new Guid("32bfdb16-387e-4087-b323-ab649fb49d77"), "اولویت هشتم تعداد الماس و درصد شانس", true, false, null, null, 7 },
                    { new Guid("11a4e63f-b361-4f28-85a0-43d8951d8134"), "درصدها", "def_percent_for_marketer", null, "10", new DateTime(2023, 1, 31, 13, 19, 58, 903, DateTimeKind.Local).AddTicks(9542), new Guid("32bfdb16-387e-4087-b323-ab649fb49d77"), "درصد بازاریاب", true, false, null, null, 24 },
                    { new Guid("17d88d82-afd3-4a91-a4e1-21abb5dcb91e"), "ثبت نام", "def_points_for_client_registration", null, "100", new DateTime(2023, 1, 31, 13, 19, 58, 903, DateTimeKind.Local).AddTicks(9522), new Guid("32bfdb16-387e-4087-b323-ab649fb49d77"), "امتیاز اولیه برای کاربری که ثبت نام میکند.", true, false, null, null, 17 },
                    { new Guid("1c571614-bc78-40ea-828b-b94fe00351ca"), "کارت اعتباری", "def_chips_usage_perday", null, "-1", new DateTime(2023, 1, 31, 13, 19, 58, 903, DateTimeKind.Local).AddTicks(9513), new Guid("32bfdb16-387e-4087-b323-ab649fb49d77"), "تعداد استفاده از کارت اعتباری هر کاربر در روز", true, false, null, null, 14 },
                    { new Guid("21c3804d-baa2-40ad-a8ef-42b39492cf29"), "آگهی تبلیغاتی", "def_money_to_premium_image_ads", null, "200000", new DateTime(2023, 1, 31, 13, 19, 58, 903, DateTimeKind.Local).AddTicks(9503), new Guid("32bfdb16-387e-4087-b323-ab649fb49d77"), "هزینه درج آگهی تبلیغاتی تصویری", true, false, null, null, 11 },
                    { new Guid("2d10f0df-017f-4bcd-a342-39c75f668fba"), "درصدها", "def_percent_for_countryadmin", null, "4", new DateTime(2023, 1, 31, 13, 19, 58, 903, DateTimeKind.Local).AddTicks(9548), new Guid("32bfdb16-387e-4087-b323-ab649fb49d77"), "درصد مدیر مناطق", true, false, null, null, 26 },
                    { new Guid("4bc4a97c-404a-48b4-9c7e-50be8c3c27be"), "لایک ها", "def_points_for_video_like", null, "15", new DateTime(2023, 1, 31, 13, 19, 58, 903, DateTimeKind.Local).AddTicks(9519), new Guid("32bfdb16-387e-4087-b323-ab649fb49d77"), "امتیاز پیش فرض برای لایک پست ویدئویی", true, false, null, null, 16 },
                    { new Guid("59c825f8-32f4-45c2-8dec-706cede88357"), "چالش", "expire_dates_for_challenge", null, "60", new DateTime(2023, 1, 31, 13, 19, 58, 903, DateTimeKind.Local).AddTicks(9557), new Guid("32bfdb16-387e-4087-b323-ab649fb49d77"), "تعداد روزهای مجاز برای چالش", true, false, null, null, 29 },
                    { new Guid("5be693bf-f4fb-45f5-8ff3-a6d86244c6f5"), "اعتبار", "credit_for_video_ads", null, "1000", new DateTime(2023, 1, 31, 13, 19, 58, 903, DateTimeKind.Local).AddTicks(9553), new Guid("32bfdb16-387e-4087-b323-ab649fb49d77"), "اعتبار لازم برای ثبت آگهی ویدئویی", true, false, null, null, 28 },
                    { new Guid("5d234561-88cd-4cfd-9f87-316103dc00b6"), "گردونه", "diamond_fourth_priority", "6", "21,30", new DateTime(2023, 1, 31, 13, 19, 58, 903, DateTimeKind.Local).AddTicks(9479), new Guid("32bfdb16-387e-4087-b323-ab649fb49d77"), "اولویت چهارم تعداد الماس و درصد شانس", true, false, null, null, 3 },
                    { new Guid("63347c5f-e87f-4bb8-8110-ffa3cefe77cf"), "درصدها", "def_percent_for_zoneadmin", null, "6", new DateTime(2023, 1, 31, 13, 19, 58, 903, DateTimeKind.Local).AddTicks(9545), new Guid("32bfdb16-387e-4087-b323-ab649fb49d77"), "درصد مدیر منطقه", true, false, null, null, 25 },
                    { new Guid("6a448fac-aa02-4bef-8760-445fad40de14"), "آگهی تبلیغاتی", "def_money_to_premium_video_ads", null, "1000000", new DateTime(2023, 1, 31, 13, 19, 58, 903, DateTimeKind.Local).AddTicks(9500), new Guid("32bfdb16-387e-4087-b323-ab649fb49d77"), "هزینه درج آگهی تبلیغاتی ویدئویی", true, false, null, null, 10 },
                    { new Guid("6cb75452-b686-4a83-baf6-ea3e17533cd3"), "مالی", "money_to_credit_ratio", null, "1000", new DateTime(2023, 1, 31, 13, 19, 58, 903, DateTimeKind.Local).AddTicks(9539), new Guid("32bfdb16-387e-4087-b323-ab649fb49d77"), "نسبت هر اعتبار به تومان", true, false, null, null, 23 },
                    { new Guid("712042da-a5f1-4435-ac13-365a14827951"), "گردونه", "min_points_to_spin_diamond_wheel", null, "200", new DateTime(2023, 1, 31, 13, 19, 58, 903, DateTimeKind.Local).AddTicks(9459), new Guid("32bfdb16-387e-4087-b323-ab649fb49d77"), "حداقل امتیاز برای چرخاندن گردونه شانس الماس بار اول", true, false, null, null, -2 },
                    { new Guid("7710fdba-ee70-4fa2-9e3f-651ce50e6d9d"), "فروشگاه", "stores_max_donnation_point", null, "500", new DateTime(2023, 1, 31, 13, 19, 58, 903, DateTimeKind.Local).AddTicks(9533), new Guid("32bfdb16-387e-4087-b323-ab649fb49d77"), "حداکثر امتیازی که فروشگاه میتواند در هر نوتب هدیه بدهد", true, false, null, null, 21 },
                    { new Guid("788bd10d-b22c-4cc3-8329-964537842de0"), "آگهی تبلیغاتی", "points_reward_premium_image_ads", null, "1000", new DateTime(2023, 1, 31, 13, 19, 58, 903, DateTimeKind.Local).AddTicks(9511), new Guid("32bfdb16-387e-4087-b323-ab649fb49d77"), "امتیاز ثبت آگهی تبلیغاتی تصویری", true, false, null, null, 13 },
                    { new Guid("789aeb3a-f1e1-434a-bd39-fb43d7593301"), "فروشگاه", "credit_for_client_registration_by_store_invitation", null, "50", new DateTime(2023, 1, 31, 13, 19, 58, 903, DateTimeKind.Local).AddTicks(9536), new Guid("32bfdb16-387e-4087-b323-ab649fb49d77"), "اعتبار برای فروشنده ای که باعث ثبت نام مشتری شد", true, false, null, null, 22 },
                    { new Guid("87710444-38bb-40bb-acaa-dce419484f48"), "گردونه", "diamond_sixth_priority", "4", "51,100", new DateTime(2023, 1, 31, 13, 19, 58, 903, DateTimeKind.Local).AddTicks(9486), new Guid("32bfdb16-387e-4087-b323-ab649fb49d77"), "اولویت ششم تعداد الماس و درصد شانس", true, false, null, null, 5 },
                    { new Guid("95eff3c3-ab22-4f43-9305-1dccd261c225"), "فروشگاه", "store_point_usage_per_day", null, "-1", new DateTime(2023, 1, 31, 13, 19, 58, 903, DateTimeKind.Local).AddTicks(9529), new Guid("32bfdb16-387e-4087-b323-ab649fb49d77"), "تعداد دفعات استفاده از کارت تخفیف هر فروشگاه در روز برای یک مشتری", true, false, null, null, 20 },
                    { new Guid("9721389d-e6c2-4f0d-9974-4228c832c708"), "اعتبار", "credit_for_image_ads", null, "500", new DateTime(2023, 1, 31, 13, 19, 58, 903, DateTimeKind.Local).AddTicks(9550), new Guid("32bfdb16-387e-4087-b323-ab649fb49d77"), "اعتبار لازم برای ثبت آگهی تصویری", true, false, null, null, 27 },
                    { new Guid("a0cff7ff-9053-47e4-b23d-f2dc8cbfca78"), "چالش", "prize_for_invite_to_challenge", null, "1000000", new DateTime(2023, 1, 31, 13, 19, 58, 903, DateTimeKind.Local).AddTicks(9562), new Guid("32bfdb16-387e-4087-b323-ab649fb49d77"), "کارمزد برای معرفی کاربران به چالش", true, false, null, null, 31 },
                    { new Guid("a6451aef-d07f-458c-935f-6461ba64e5e0"), "آگهی تبلیغاتی", "points_reward_premium_video_ads", null, "200", new DateTime(2023, 1, 31, 13, 19, 58, 903, DateTimeKind.Local).AddTicks(9506), new Guid("32bfdb16-387e-4087-b323-ab649fb49d77"), "امتیاز ثبت آگهی تبلیغاتی ویدئویی", true, false, null, null, 12 },
                    { new Guid("a6bd4a70-aa5f-4c46-9056-f2d9fd204c4c"), "گردونه", "diamond_seventh_priority", "3", "101,200", new DateTime(2023, 1, 31, 13, 19, 58, 903, DateTimeKind.Local).AddTicks(9489), new Guid("32bfdb16-387e-4087-b323-ab649fb49d77"), "اولویت هفتم تعداد الماس و درصد شانس", true, false, null, null, 6 },
                    { new Guid("b1449474-5425-4e26-b437-1aef809fca01"), "فروشگاه", "store_def_credit_reg", null, "0", new DateTime(2023, 1, 31, 13, 19, 58, 903, DateTimeKind.Local).AddTicks(9527), new Guid("32bfdb16-387e-4087-b323-ab649fb49d77"), "اعتبار اولیه فروشگاه برای ثبت نام اولین بار", true, false, null, null, 19 },
                    { new Guid("b641ed8b-983e-4cc7-9c58-83d3ace8a575"), "چالش", "maximum_number_of_prize_payment", null, "1000", new DateTime(2023, 1, 31, 13, 19, 58, 903, DateTimeKind.Local).AddTicks(9568), new Guid("32bfdb16-387e-4087-b323-ab649fb49d77"), "حداکثر تعداد پرداخت کارمزدها", true, false, null, null, 33 },
                    { new Guid("e421496c-3459-49d5-a7ee-9c7c91fd5d2b"), "گردونه", "diamond_first_priority", "50", "1,5", new DateTime(2023, 1, 31, 13, 19, 58, 903, DateTimeKind.Local).AddTicks(9466), new Guid("32bfdb16-387e-4087-b323-ab649fb49d77"), "اولویت اول تعداد الماس و درصد شانس", true, false, null, null, 0 },
                    { new Guid("e7ce587c-27e2-4a68-b1b1-36aca2649228"), "گردونه", "diamond_tenth_priority", "0", "999,1000", new DateTime(2023, 1, 31, 13, 19, 58, 903, DateTimeKind.Local).AddTicks(9498), new Guid("32bfdb16-387e-4087-b323-ab649fb49d77"), "امتیاز دهم آگهی تبلیغاتی تصویری", true, false, null, null, 9 },
                    { new Guid("ee39a592-fe68-4e16-bdee-ac6340b3de68"), "چالش", "money_needed_to_attend_in_challenge", null, "3000000", new DateTime(2023, 1, 31, 13, 19, 58, 903, DateTimeKind.Local).AddTicks(9560), new Guid("32bfdb16-387e-4087-b323-ab649fb49d77"), "موجودی ریالی برای شرکت در چالش", true, false, null, null, 30 },
                    { new Guid("f237b5a0-0e4a-482d-a900-1852cf01f6e9"), "چالش", "order_of_prize_payment", null, "3,5,2,10", new DateTime(2023, 1, 31, 13, 19, 58, 903, DateTimeKind.Local).AddTicks(9565), new Guid("32bfdb16-387e-4087-b323-ab649fb49d77"), "ترتیب پرداخت کارمزدها", true, false, null, null, 32 },
                    { new Guid("f8d4ae88-d93c-4254-9e2e-37641b76c2b7"), "گردونه", "diamond_third_priority", "10", "11,20", new DateTime(2023, 1, 31, 13, 19, 58, 903, DateTimeKind.Local).AddTicks(9472), new Guid("32bfdb16-387e-4087-b323-ab649fb49d77"), "اولویت سوم تعداد الماس و درصد شانس", true, false, null, null, 2 },
                    { new Guid("f9b0a32b-7fa1-4206-8d60-84e36274014e"), "ثبت نام", "def_points_for_client_invitation", null, "50", new DateTime(2023, 1, 31, 13, 19, 58, 903, DateTimeKind.Local).AddTicks(9524), new Guid("32bfdb16-387e-4087-b323-ab649fb49d77"), "امتیاز برای معرف وقتی کاربر ثبت نام کرد.", true, false, null, null, 18 },
                    { new Guid("fa205819-6a8e-4bf8-9b84-0b976040f452"), "گردونه", "diamond_second_priority", "20", "6,10", new DateTime(2023, 1, 31, 13, 19, 58, 903, DateTimeKind.Local).AddTicks(9469), new Guid("32bfdb16-387e-4087-b323-ab649fb49d77"), "اولویت دوم تعداد الماس و درصد شانس", true, false, null, null, 1 },
                    { new Guid("fee4f32a-8eec-4198-92fd-186bc7ec7e06"), "گردونه", "added_points_to_each_spin_diamond_wheel_after_first_time", null, "100", new DateTime(2023, 1, 31, 13, 19, 58, 903, DateTimeKind.Local).AddTicks(9463), new Guid("32bfdb16-387e-4087-b323-ab649fb49d77"), "افزایش تعداد امتیاز به اضای هر بار چرخاندن گردونه شانس در یک روز", true, false, null, null, -1 },
                    { new Guid("fef61edb-f679-455f-a79c-3d8991c7640f"), "گردونه", "diamond_fivth_priority", "5", "31,50", new DateTime(2023, 1, 31, 13, 19, 58, 903, DateTimeKind.Local).AddTicks(9482), new Guid("32bfdb16-387e-4087-b323-ab649fb49d77"), "اولویت پنجم تعداد الماس و درصد شانس", true, false, null, null, 4 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Priority", "RoleDescription", "RoleName" },
                values: new object[,]
                {
                    { new Guid("1400e495-1d13-4662-900a-2930c1540286"), null, null, true, false, null, null, 4, "بازاریاب", "marketer" },
                    { new Guid("4a3df27f-9bf1-49eb-a53b-275e3479b496"), null, null, true, false, null, null, 3, "مدیر منطقه", "zoneadmin" },
                    { new Guid("8c1506d5-7e75-49d0-b5b3-0d909fea8481"), null, null, true, false, null, null, 6, "مشتری", "client" },
                    { new Guid("8da24f6e-352b-41cf-bc35-a9197cd04c2f"), null, null, true, false, null, null, 0, "مدیر کل", "super" },
                    { new Guid("d8e11e47-6dec-46ea-ba88-1b064283e398"), null, null, true, false, null, null, 5, "فروشگاه", "store" },
                    { new Guid("e867824d-b637-477e-861f-0bae61aa8d07"), null, null, true, false, null, null, 2, "مدیر کل مناطق", "countryadmin" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Priority", "RoleDescription", "RoleName" },
                values: new object[] { new Guid("f36dba5f-4ab1-413c-80b6-d7fddd3aaf87"), null, null, true, false, null, null, 1, "مدیر سامانه", "admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CardNumber", "Cellphone", "ConfirmationCode", "Created", "Credits", "DefaultCredit", "Diamonds", "DonnationActive", "Family", "Inviter", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Money", "Name", "Notes", "Points", "ProfileMediaURL", "Username" },
                values: new object[,]
                {
                    { new Guid("2d95a046-1ea5-4edd-aa67-74e98fd38b93"), null, "09100000000", "111111", new DateTime(2023, 1, 31, 13, 19, 58, 903, DateTimeKind.Local).AddTicks(9158), 0L, 0L, 0, false, "user10", null, true, false, null, null, 3000000L, "tenth", null, 90L, "uploads/2022/9/sina2.jpg", "tenthuser" },
                    { new Guid("32bfdb16-387e-4087-b323-ab649fb49d77"), null, "09394125130", "111111", new DateTime(2023, 1, 31, 13, 19, 58, 903, DateTimeKind.Local).AddTicks(9126), 0L, 0L, 0, false, "Jouybari", new Guid("33231dd2-9b1f-4341-b620-be37bf96d094"), true, false, null, null, 850000L, "Sina", null, 90L, "uploads/2022/9/sina2.jpg", "sinful" },
                    { new Guid("331854c6-87e8-42f3-9eb8-0d6890b642ae"), null, "09166666666", "111111", new DateTime(2023, 1, 31, 13, 19, 58, 903, DateTimeKind.Local).AddTicks(9143), 0L, 0L, 0, false, "user6", null, true, false, null, null, 3000000L, "sixth", null, 90L, "uploads/2022/9/sina2.jpg", "sixthuser" },
                    { new Guid("331fd2ce-6fd6-449b-95d3-d2a4f7d93d89"), null, "09133333333", "111111", new DateTime(2023, 1, 31, 13, 19, 58, 903, DateTimeKind.Local).AddTicks(9136), 0L, 0L, 0, false, "user3", null, true, false, null, null, 3000000L, "third", null, 90L, "uploads/2022/9/sina2.jpg", "thirduser" },
                    { new Guid("33231dd2-9b1f-4341-b620-be37bf96d094"), null, "09901069557", null, new DateTime(2023, 1, 31, 13, 19, 58, 903, DateTimeKind.Local).AddTicks(9088), 1000L, 0L, 0, true, "دابویی مشک آبادی", null, true, false, null, null, 0L, "عبدالرحمن", null, 100L, "uploads/2022/9/photo.jpg", "dabooei" },
                    { new Guid("37baf46c-ad2e-4ff0-873f-8e6137c169ab"), null, "09122222222", "111111", new DateTime(2023, 1, 31, 13, 19, 58, 903, DateTimeKind.Local).AddTicks(9133), 0L, 0L, 0, false, "user2", null, true, false, null, null, 3000000L, "second", null, 90L, "uploads/2022/9/sina2.jpg", "seconduser" },
                    { new Guid("38d44e2c-d0e1-4b43-9e6d-f93d27a57071"), null, "09177777777", "111111", new DateTime(2023, 1, 31, 13, 19, 58, 903, DateTimeKind.Local).AddTicks(9148), 0L, 0L, 0, false, "user7", null, true, false, null, null, 3000000L, "seventh", null, 90L, "uploads/2022/9/sina2.jpg", "seventhuser" },
                    { new Guid("444a35b3-cdbe-42c2-ac68-ad8d8716d117"), null, "09188888888", "111111", new DateTime(2023, 1, 31, 13, 19, 58, 903, DateTimeKind.Local).AddTicks(9151), 0L, 0L, 0, false, "user8", null, true, false, null, null, 3000000L, "eighth", null, 90L, "uploads/2022/9/sina2.jpg", "eighthuser" },
                    { new Guid("8179445e-6711-42bb-9ab0-0c422ed52379"), null, "09011000000", "111111", new DateTime(2023, 1, 31, 13, 19, 58, 903, DateTimeKind.Local).AddTicks(9162), 0L, 0L, 0, false, "user11", null, true, false, null, null, 3000000L, "eleventh", null, 90L, "uploads/2022/9/sina2.jpg", "eleventhuser" },
                    { new Guid("841bba9b-9fd4-41c6-a634-681c0d3e5f3e"), null, "09155555555", "111111", new DateTime(2023, 1, 31, 13, 19, 58, 903, DateTimeKind.Local).AddTicks(9141), 0L, 0L, 0, false, "user5", null, true, false, null, null, 3000000L, "fivth", null, 90L, "uploads/2022/9/sina2.jpg", "fivthuser" },
                    { new Guid("bd00783a-a55e-4d06-be80-1079c071324d"), null, "09111111111", "111111", new DateTime(2023, 1, 31, 13, 19, 58, 903, DateTimeKind.Local).AddTicks(9130), 0L, 0L, 0, false, "user1", null, true, false, null, null, 3000000L, "first", null, 90L, "uploads/2022/9/sina2.jpg", "firstuser" },
                    { new Guid("cd3d8c9c-fffd-4055-b122-37497383b15c"), null, "09199999999", "111111", new DateTime(2023, 1, 31, 13, 19, 58, 903, DateTimeKind.Local).AddTicks(9156), 0L, 0L, 0, false, "user9", null, true, false, null, null, 3000000L, "ninth", null, 90L, "uploads/2022/9/sina2.jpg", "ninthuser" },
                    { new Guid("e1ae45d1-dac3-47ae-9520-b763ab141231"), null, "09144444444", "111111", new DateTime(2023, 1, 31, 13, 19, 58, 903, DateTimeKind.Local).AddTicks(9138), 0L, 0L, 0, false, "user4", null, true, false, null, null, 3000000L, "fourth", null, 90L, "uploads/2022/9/sina2.jpg", "fourthuser" }
                });

            migrationBuilder.InsertData(
                table: "UsersRoles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "Role", "User" },
                values: new object[,]
                {
                    { new Guid("1086aff7-242b-4f83-9042-2305d1bc98b0"), null, new Guid("bd00783a-a55e-4d06-be80-1079c071324d"), false, null, null, new Guid("8c1506d5-7e75-49d0-b5b3-0d909fea8481"), new Guid("bd00783a-a55e-4d06-be80-1079c071324d") },
                    { new Guid("183a489a-fc9c-4e26-abc2-c941c17c0852"), null, new Guid("331854c6-87e8-42f3-9eb8-0d6890b642ae"), false, null, null, new Guid("8c1506d5-7e75-49d0-b5b3-0d909fea8481"), new Guid("331854c6-87e8-42f3-9eb8-0d6890b642ae") },
                    { new Guid("2599a818-ff9d-4476-97ba-7077952c0891"), null, new Guid("32bfdb16-387e-4087-b323-ab649fb49d77"), false, null, null, new Guid("8da24f6e-352b-41cf-bc35-a9197cd04c2f"), new Guid("32bfdb16-387e-4087-b323-ab649fb49d77") },
                    { new Guid("3afec9d1-9a6e-4c25-a156-d8c549dfc3ed"), null, new Guid("33231dd2-9b1f-4341-b620-be37bf96d094"), false, null, null, new Guid("d8e11e47-6dec-46ea-ba88-1b064283e398"), new Guid("33231dd2-9b1f-4341-b620-be37bf96d094") },
                    { new Guid("3b2a7ee2-22a0-4351-8c29-cc361c153068"), null, new Guid("37baf46c-ad2e-4ff0-873f-8e6137c169ab"), false, null, null, new Guid("8c1506d5-7e75-49d0-b5b3-0d909fea8481"), new Guid("37baf46c-ad2e-4ff0-873f-8e6137c169ab") },
                    { new Guid("4095e8e6-085e-40a7-927b-ec75b288af35"), null, new Guid("cd3d8c9c-fffd-4055-b122-37497383b15c"), false, null, null, new Guid("8c1506d5-7e75-49d0-b5b3-0d909fea8481"), new Guid("cd3d8c9c-fffd-4055-b122-37497383b15c") },
                    { new Guid("49cd46f5-9207-4aa9-93f3-71844cd85420"), null, new Guid("444a35b3-cdbe-42c2-ac68-ad8d8716d117"), false, null, null, new Guid("8c1506d5-7e75-49d0-b5b3-0d909fea8481"), new Guid("444a35b3-cdbe-42c2-ac68-ad8d8716d117") },
                    { new Guid("4afca1b5-8708-4511-8da3-d55a3b4b85dd"), null, new Guid("331fd2ce-6fd6-449b-95d3-d2a4f7d93d89"), false, null, null, new Guid("8c1506d5-7e75-49d0-b5b3-0d909fea8481"), new Guid("331fd2ce-6fd6-449b-95d3-d2a4f7d93d89") },
                    { new Guid("5a6f18bf-a2f6-4588-b22c-69c589e522e6"), null, new Guid("38d44e2c-d0e1-4b43-9e6d-f93d27a57071"), false, null, null, new Guid("8c1506d5-7e75-49d0-b5b3-0d909fea8481"), new Guid("38d44e2c-d0e1-4b43-9e6d-f93d27a57071") },
                    { new Guid("8730bced-f07b-4999-a56a-7ef2b0c8b318"), null, new Guid("2d95a046-1ea5-4edd-aa67-74e98fd38b93"), false, null, null, new Guid("8c1506d5-7e75-49d0-b5b3-0d909fea8481"), new Guid("2d95a046-1ea5-4edd-aa67-74e98fd38b93") },
                    { new Guid("c1606870-f44d-4a42-b578-02a91fbdbcea"), null, new Guid("8179445e-6711-42bb-9ab0-0c422ed52379"), false, null, null, new Guid("8c1506d5-7e75-49d0-b5b3-0d909fea8481"), new Guid("8179445e-6711-42bb-9ab0-0c422ed52379") },
                    { new Guid("c8011e20-fd42-4145-a442-3685a286632e"), null, new Guid("e1ae45d1-dac3-47ae-9520-b763ab141231"), false, null, null, new Guid("8c1506d5-7e75-49d0-b5b3-0d909fea8481"), new Guid("e1ae45d1-dac3-47ae-9520-b763ab141231") },
                    { new Guid("e0e7bfd4-330a-45b0-96f0-e9af04a08238"), null, new Guid("841bba9b-9fd4-41c6-a634-681c0d3e5f3e"), false, null, null, new Guid("8c1506d5-7e75-49d0-b5b3-0d909fea8481"), new Guid("841bba9b-9fd4-41c6-a634-681c0d3e5f3e") }
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
