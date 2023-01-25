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
                    { new Guid("00150ca1-ff2b-46a1-bfa1-9c6bf3006362"), "لایک ها", "def_points_for_video_like", null, "15", new DateTime(2023, 1, 25, 1, 19, 41, 641, DateTimeKind.Local).AddTicks(4943), new Guid("910e199c-0fcf-41fa-b312-359791c6465e"), "امتیاز پیش فرض برای لایک پست ویدئویی", true, false, null, null, 16 },
                    { new Guid("06de7ae6-29bc-402f-920b-eb60299b5381"), "گردونه", "min_points_to_spin_diamond_wheel", null, "200", new DateTime(2023, 1, 25, 1, 19, 41, 641, DateTimeKind.Local).AddTicks(4853), new Guid("910e199c-0fcf-41fa-b312-359791c6465e"), "حداقل امتیاز برای چرخاندن گردونه شانس الماس بار اول", true, false, null, null, -2 },
                    { new Guid("0745d6d6-cb67-469c-b4e6-3da440c89928"), "گردونه", "diamond_tenth_priority", "0", "999,1000", new DateTime(2023, 1, 25, 1, 19, 41, 641, DateTimeKind.Local).AddTicks(4911), new Guid("910e199c-0fcf-41fa-b312-359791c6465e"), "امتیاز دهم آگهی تبلیغاتی تصویری", true, false, null, null, 9 },
                    { new Guid("0a4b4be6-ea46-467b-a577-60853dea980d"), "اعتبار", "credit_for_image_ads", null, "500", new DateTime(2023, 1, 25, 1, 19, 41, 641, DateTimeKind.Local).AddTicks(4991), new Guid("910e199c-0fcf-41fa-b312-359791c6465e"), "اعتبار لازم برای ثبت آگهی تصویری", true, false, null, null, 27 },
                    { new Guid("1814e336-287a-4076-8cbc-d745508eca92"), "گردونه", "diamond_nineth_priority", "0", "301,500", new DateTime(2023, 1, 25, 1, 19, 41, 641, DateTimeKind.Local).AddTicks(4907), new Guid("910e199c-0fcf-41fa-b312-359791c6465e"), "امتیاز نهم آگهی تبلیغاتی تصویری", true, false, null, null, 8 },
                    { new Guid("1c48d4a7-ea4a-4e02-8c15-915fd8549d31"), "گردونه", "diamond_third_priority", "10", "11,20", new DateTime(2023, 1, 25, 1, 19, 41, 641, DateTimeKind.Local).AddTicks(4879), new Guid("910e199c-0fcf-41fa-b312-359791c6465e"), "اولویت سوم تعداد الماس و درصد شانس", true, false, null, null, 2 },
                    { new Guid("1e5f8db3-5cbb-4115-949b-437cebaafc5d"), "ثبت نام", "def_points_for_client_registration", null, "100", new DateTime(2023, 1, 25, 1, 19, 41, 641, DateTimeKind.Local).AddTicks(4947), new Guid("910e199c-0fcf-41fa-b312-359791c6465e"), "امتیاز اولیه برای کاربری که ثبت نام میکند.", true, false, null, null, 17 },
                    { new Guid("23029da2-741f-4aa2-a6f5-d1554327f660"), "آگهی تبلیغاتی", "points_reward_premium_video_ads", null, "200", new DateTime(2023, 1, 25, 1, 19, 41, 641, DateTimeKind.Local).AddTicks(4924), new Guid("910e199c-0fcf-41fa-b312-359791c6465e"), "امتیاز ثبت آگهی تبلیغاتی ویدئویی", true, false, null, null, 12 },
                    { new Guid("235a5b89-a635-4343-b53a-cc5f83bfb58d"), "فروشگاه", "credit_for_client_registration_by_store_invitation", null, "50", new DateTime(2023, 1, 25, 1, 19, 41, 641, DateTimeKind.Local).AddTicks(4969), new Guid("910e199c-0fcf-41fa-b312-359791c6465e"), "اعتبار برای فروشنده ای که باعث ثبت نام مشتری شد", true, false, null, null, 22 },
                    { new Guid("2572fa62-1fd5-4c80-92d8-8163bb79f6de"), "آگهی تبلیغاتی", "def_money_to_premium_video_ads", null, "1000000", new DateTime(2023, 1, 25, 1, 19, 41, 641, DateTimeKind.Local).AddTicks(4915), new Guid("910e199c-0fcf-41fa-b312-359791c6465e"), "هزینه درج آگهی تبلیغاتی ویدئویی", true, false, null, null, 10 },
                    { new Guid("2f5011fc-6597-48a0-8070-288946db8bc7"), "درصدها", "def_percent_for_marketer", null, "10", new DateTime(2023, 1, 25, 1, 19, 41, 641, DateTimeKind.Local).AddTicks(4979), new Guid("910e199c-0fcf-41fa-b312-359791c6465e"), "درصد بازاریاب", true, false, null, null, 24 },
                    { new Guid("3c43e4fa-9ca4-4fc8-b126-d8b9456c5597"), "آگهی تبلیغاتی", "def_money_to_premium_image_ads", null, "200000", new DateTime(2023, 1, 25, 1, 19, 41, 641, DateTimeKind.Local).AddTicks(4919), new Guid("910e199c-0fcf-41fa-b312-359791c6465e"), "هزینه درج آگهی تبلیغاتی تصویری", true, false, null, null, 11 },
                    { new Guid("55238907-95a7-44b0-84d4-d4feb5a01dec"), "فروشگاه", "stores_max_donnation_point", null, "500", new DateTime(2023, 1, 25, 1, 19, 41, 641, DateTimeKind.Local).AddTicks(4965), new Guid("910e199c-0fcf-41fa-b312-359791c6465e"), "حداکثر امتیازی که فروشگاه میتواند در هر نوتب هدیه بدهد", true, false, null, null, 21 },
                    { new Guid("5b7895dd-d343-48b7-b5d2-bad0e742ebc2"), "کارت اعتباری", "def_chips_usage_perday", null, "-1", new DateTime(2023, 1, 25, 1, 19, 41, 641, DateTimeKind.Local).AddTicks(4931), new Guid("910e199c-0fcf-41fa-b312-359791c6465e"), "تعداد استفاده از کارت اعتباری هر کاربر در روز", true, false, null, null, 14 },
                    { new Guid("5bb74fa3-6777-4136-b978-eda17ad4adee"), "فروشگاه", "store_def_credit_reg", null, "0", new DateTime(2023, 1, 25, 1, 19, 41, 641, DateTimeKind.Local).AddTicks(4955), new Guid("910e199c-0fcf-41fa-b312-359791c6465e"), "اعتبار اولیه فروشگاه برای ثبت نام اولین بار", true, false, null, null, 19 },
                    { new Guid("62dd3f6d-1ae7-41b6-a367-ee1ebac77c83"), "چالش", "expire_dates_for_challenge", null, "60", new DateTime(2023, 1, 25, 1, 19, 41, 641, DateTimeKind.Local).AddTicks(5000), new Guid("910e199c-0fcf-41fa-b312-359791c6465e"), "تعداد روزهای مجاز برای چالش", true, false, null, null, 29 },
                    { new Guid("749492f0-3a87-4979-bb11-016ae146b127"), "اعتبار", "credit_for_video_ads", null, "1000", new DateTime(2023, 1, 25, 1, 19, 41, 641, DateTimeKind.Local).AddTicks(4996), new Guid("910e199c-0fcf-41fa-b312-359791c6465e"), "اعتبار لازم برای ثبت آگهی ویدئویی", true, false, null, null, 28 },
                    { new Guid("78791b54-ec46-4ec2-8300-c4e75bd919ef"), "لایک ها", "def_points_for_image_like", null, "1", new DateTime(2023, 1, 25, 1, 19, 41, 641, DateTimeKind.Local).AddTicks(4939), new Guid("910e199c-0fcf-41fa-b312-359791c6465e"), "امتیاز پیش فرض برای لایک پست تصویری", true, false, null, null, 15 },
                    { new Guid("93c48cc2-1fb6-45c0-95d4-58352cdc322c"), "آگهی تبلیغاتی", "points_reward_premium_image_ads", null, "1000", new DateTime(2023, 1, 25, 1, 19, 41, 641, DateTimeKind.Local).AddTicks(4928), new Guid("910e199c-0fcf-41fa-b312-359791c6465e"), "امتیاز ثبت آگهی تبلیغاتی تصویری", true, false, null, null, 13 },
                    { new Guid("99202849-15ab-4a62-a45d-b4ce11ab4864"), "ثبت نام", "def_points_for_client_invitation", null, "50", new DateTime(2023, 1, 25, 1, 19, 41, 641, DateTimeKind.Local).AddTicks(4951), new Guid("910e199c-0fcf-41fa-b312-359791c6465e"), "امتیاز برای معرف وقتی کاربر ثبت نام کرد.", true, false, null, null, 18 },
                    { new Guid("a1e6d0fd-1401-45a2-9bce-c1eeced6db65"), "گردونه", "added_points_to_each_spin_diamond_wheel_after_first_time", null, "100", new DateTime(2023, 1, 25, 1, 19, 41, 641, DateTimeKind.Local).AddTicks(4866), new Guid("910e199c-0fcf-41fa-b312-359791c6465e"), "افزایش تعداد امتیاز به اضای هر بار چرخاندن گردونه شانس در یک روز", true, false, null, null, -1 },
                    { new Guid("a79ffb6b-d42b-47b4-b2ac-c9ee3c3f91c2"), "گردونه", "diamond_eighth_priority", "2", "201,300", new DateTime(2023, 1, 25, 1, 19, 41, 641, DateTimeKind.Local).AddTicks(4903), new Guid("910e199c-0fcf-41fa-b312-359791c6465e"), "اولویت هشتم تعداد الماس و درصد شانس", true, false, null, null, 7 },
                    { new Guid("aa240ad1-fbc6-40ed-bd7d-9bb402d621bb"), "مالی", "money_to_credit_ratio", null, "1000", new DateTime(2023, 1, 25, 1, 19, 41, 641, DateTimeKind.Local).AddTicks(4975), new Guid("910e199c-0fcf-41fa-b312-359791c6465e"), "نسبت هر اعتبار به تومان", true, false, null, null, 23 },
                    { new Guid("b83b0b5b-ae00-4275-b577-3d1255aa4575"), "فروشگاه", "store_point_usage_per_day", null, "-1", new DateTime(2023, 1, 25, 1, 19, 41, 641, DateTimeKind.Local).AddTicks(4961), new Guid("910e199c-0fcf-41fa-b312-359791c6465e"), "تعداد دفعات استفاده از کارت تخفیف هر فروشگاه در روز برای یک مشتری", true, false, null, null, 20 },
                    { new Guid("bcc8a984-61c4-42a8-963c-b4c8a477c6bd"), "گردونه", "diamond_seventh_priority", "3", "101,200", new DateTime(2023, 1, 25, 1, 19, 41, 641, DateTimeKind.Local).AddTicks(4896), new Guid("910e199c-0fcf-41fa-b312-359791c6465e"), "اولویت هفتم تعداد الماس و درصد شانس", true, false, null, null, 6 },
                    { new Guid("d50039f4-8a96-4426-ad5a-743e97a18383"), "درصدها", "def_percent_for_countryadmin", null, "4", new DateTime(2023, 1, 25, 1, 19, 41, 641, DateTimeKind.Local).AddTicks(4987), new Guid("910e199c-0fcf-41fa-b312-359791c6465e"), "درصد مدیر مناطق", true, false, null, null, 26 },
                    { new Guid("eeb02aaa-a0de-416e-a20d-c5abaafe7151"), "گردونه", "diamond_second_priority", "20", "6,10", new DateTime(2023, 1, 25, 1, 19, 41, 641, DateTimeKind.Local).AddTicks(4875), new Guid("910e199c-0fcf-41fa-b312-359791c6465e"), "اولویت دوم تعداد الماس و درصد شانس", true, false, null, null, 1 },
                    { new Guid("f0b2947e-17d3-43d7-babc-5b9a296ae425"), "چالش", "money_needed_to_attend_in_challenge", null, "3000000", new DateTime(2023, 1, 25, 1, 19, 41, 641, DateTimeKind.Local).AddTicks(5004), new Guid("910e199c-0fcf-41fa-b312-359791c6465e"), "موجودی ریالی برای شرکت در چالش", true, false, null, null, 30 },
                    { new Guid("f2f78ef5-0ff7-4864-96c4-838dbf56e5a6"), "گردونه", "diamond_fivth_priority", "5", "31,50", new DateTime(2023, 1, 25, 1, 19, 41, 641, DateTimeKind.Local).AddTicks(4889), new Guid("910e199c-0fcf-41fa-b312-359791c6465e"), "اولویت پنجم تعداد الماس و درصد شانس", true, false, null, null, 4 },
                    { new Guid("f41addef-fd14-40d2-b045-21276fd6fc10"), "درصدها", "def_percent_for_zoneadmin", null, "6", new DateTime(2023, 1, 25, 1, 19, 41, 641, DateTimeKind.Local).AddTicks(4983), new Guid("910e199c-0fcf-41fa-b312-359791c6465e"), "درصد مدیر منطقه", true, false, null, null, 25 },
                    { new Guid("f4f40d0a-f9aa-45ef-8bf8-2769010a3116"), "چالش", "prize_for_invite_to_challenge", null, "1000000", new DateTime(2023, 1, 25, 1, 19, 41, 641, DateTimeKind.Local).AddTicks(5011), new Guid("910e199c-0fcf-41fa-b312-359791c6465e"), "کارمزد برای معرفی کاربران به چالش", true, false, null, null, 31 },
                    { new Guid("f5bd28e6-81e6-4ca4-b851-9f7d04fb7b04"), "گردونه", "diamond_first_priority", "50", "1,5", new DateTime(2023, 1, 25, 1, 19, 41, 641, DateTimeKind.Local).AddTicks(4871), new Guid("910e199c-0fcf-41fa-b312-359791c6465e"), "اولویت اول تعداد الماس و درصد شانس", true, false, null, null, 0 },
                    { new Guid("f6364673-bd1f-43b5-8e7c-38cf9fdf0bf8"), "گردونه", "diamond_sixth_priority", "4", "51,100", new DateTime(2023, 1, 25, 1, 19, 41, 641, DateTimeKind.Local).AddTicks(4892), new Guid("910e199c-0fcf-41fa-b312-359791c6465e"), "اولویت ششم تعداد الماس و درصد شانس", true, false, null, null, 5 },
                    { new Guid("fd376dd6-8578-4013-b246-8e0c5f771d44"), "گردونه", "diamond_fourth_priority", "6", "21,30", new DateTime(2023, 1, 25, 1, 19, 41, 641, DateTimeKind.Local).AddTicks(4884), new Guid("910e199c-0fcf-41fa-b312-359791c6465e"), "اولویت چهارم تعداد الماس و درصد شانس", true, false, null, null, 3 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Priority", "RoleDescription", "RoleName" },
                values: new object[,]
                {
                    { new Guid("39bd0665-7e4f-42d2-834a-bcc240e2b2f0"), null, null, true, false, null, null, 4, "بازاریاب", "marketer" },
                    { new Guid("4291f9d3-5913-4cf5-8e02-26b87c67c5e3"), null, null, true, false, null, null, 0, "مدیر کل", "super" },
                    { new Guid("48cc195a-56b1-4ae2-a475-62ecf0e39a2b"), null, null, true, false, null, null, 3, "مدیر منطقه", "zoneadmin" },
                    { new Guid("5e3b432a-6c42-40a3-96b2-0ccb382f90e7"), null, null, true, false, null, null, 1, "مدیر سامانه", "admin" },
                    { new Guid("6f0f80d0-6561-4bff-92bc-877ef39e1754"), null, null, true, false, null, null, 6, "مشتری", "client" },
                    { new Guid("7be13644-6f1e-484c-b4e8-136be4383fe5"), null, null, true, false, null, null, 5, "فروشگاه", "store" },
                    { new Guid("7cc6a60d-0609-4666-beaa-92906e7cccee"), null, null, true, false, null, null, 2, "مدیر کل مناطق", "countryadmin" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CardNumber", "Cellphone", "ConfirmationCode", "Created", "Credits", "DefaultCredit", "Diamonds", "DonnationActive", "Family", "Inviter", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Money", "Name", "Notes", "Points", "ProfileMediaURL", "Username" },
                values: new object[] { new Guid("39716961-f090-4b8c-ba20-399263be51ae"), null, "09144444444", "111111", new DateTime(2023, 1, 25, 1, 19, 41, 641, DateTimeKind.Local).AddTicks(4232), 0L, 0L, 0, false, "user4", null, true, false, null, null, 3000000L, "fourth", null, 90L, "uploads/2022/9/sina2.jpg", "fourthuser" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CardNumber", "Cellphone", "ConfirmationCode", "Created", "Credits", "DefaultCredit", "Diamonds", "DonnationActive", "Family", "Inviter", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Money", "Name", "Notes", "Points", "ProfileMediaURL", "Username" },
                values: new object[,]
                {
                    { new Guid("3e6a839c-7f29-4772-a80b-b3116c9bf3aa"), null, "09177777777", "111111", new DateTime(2023, 1, 25, 1, 19, 41, 641, DateTimeKind.Local).AddTicks(4247), 0L, 0L, 0, false, "user7", null, true, false, null, null, 3000000L, "seventh", null, 90L, "uploads/2022/9/sina2.jpg", "seventhuser" },
                    { new Guid("51cc972c-4530-41dc-89ac-0ca06fce6e55"), null, "09188888888", "111111", new DateTime(2023, 1, 25, 1, 19, 41, 641, DateTimeKind.Local).AddTicks(4252), 0L, 0L, 0, false, "user8", null, true, false, null, null, 3000000L, "eighth", null, 90L, "uploads/2022/9/sina2.jpg", "eighthuser" },
                    { new Guid("7e7ff426-9f70-44b3-80de-d8582b0ee2d1"), null, "09133333333", "111111", new DateTime(2023, 1, 25, 1, 19, 41, 641, DateTimeKind.Local).AddTicks(4227), 0L, 0L, 0, false, "user3", null, true, false, null, null, 3000000L, "third", null, 90L, "uploads/2022/9/sina2.jpg", "thirduser" },
                    { new Guid("8921f715-2371-4e71-81a3-277e991c9248"), null, "09901069557", null, new DateTime(2023, 1, 25, 1, 19, 41, 641, DateTimeKind.Local).AddTicks(4165), 1000L, 0L, 0, true, "دابویی مشک آبادی", null, true, false, null, null, 0L, "عبدالرحمن", null, 100L, "uploads/2022/9/photo.jpg", "dabooei" },
                    { new Guid("910e199c-0fcf-41fa-b312-359791c6465e"), null, "09394125130", "111111", new DateTime(2023, 1, 25, 1, 19, 41, 641, DateTimeKind.Local).AddTicks(4211), 0L, 0L, 0, false, "Jouybari", new Guid("8921f715-2371-4e71-81a3-277e991c9248"), true, false, null, null, 850000L, "Sina", null, 90L, "uploads/2022/9/sina2.jpg", "sinful" },
                    { new Guid("b0d9835d-3abd-4e57-8e38-12037a01552b"), null, "09122222222", "111111", new DateTime(2023, 1, 25, 1, 19, 41, 641, DateTimeKind.Local).AddTicks(4221), 0L, 0L, 0, false, "user2", null, true, false, null, null, 3000000L, "second", null, 90L, "uploads/2022/9/sina2.jpg", "seconduser" },
                    { new Guid("b1e3248b-6991-4b2e-8066-7347def49379"), null, "09166666666", "111111", new DateTime(2023, 1, 25, 1, 19, 41, 641, DateTimeKind.Local).AddTicks(4240), 0L, 0L, 0, false, "user6", null, true, false, null, null, 3000000L, "sixth", null, 90L, "uploads/2022/9/sina2.jpg", "sixthuser" },
                    { new Guid("b6bdec28-db74-41e0-bc1e-679a286d9fd0"), null, "09111111111", "111111", new DateTime(2023, 1, 25, 1, 19, 41, 641, DateTimeKind.Local).AddTicks(4217), 0L, 0L, 0, false, "user1", null, true, false, null, null, 3000000L, "first", null, 90L, "uploads/2022/9/sina2.jpg", "firstuser" },
                    { new Guid("c71dcf26-909e-46e1-a1c6-7778659d8017"), null, "09155555555", "111111", new DateTime(2023, 1, 25, 1, 19, 41, 641, DateTimeKind.Local).AddTicks(4236), 0L, 0L, 0, false, "user5", null, true, false, null, null, 3000000L, "fivth", null, 90L, "uploads/2022/9/sina2.jpg", "fivthuser" },
                    { new Guid("d15df198-3765-4760-ae6f-cf3db29a7801"), null, "09199999999", "111111", new DateTime(2023, 1, 25, 1, 19, 41, 641, DateTimeKind.Local).AddTicks(4255), 0L, 0L, 0, false, "user9", null, true, false, null, null, 3000000L, "ninth", null, 90L, "uploads/2022/9/sina2.jpg", "ninthuser" },
                    { new Guid("f739df4b-7fd5-4760-a96e-9647cb6fb028"), null, "09100000000", "111111", new DateTime(2023, 1, 25, 1, 19, 41, 641, DateTimeKind.Local).AddTicks(4260), 0L, 0L, 0, false, "user10", null, true, false, null, null, 3000000L, "tenth", null, 90L, "uploads/2022/9/sina2.jpg", "tenthuser" }
                });

            migrationBuilder.InsertData(
                table: "UsersRoles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "Role", "User" },
                values: new object[,]
                {
                    { new Guid("183c67d0-5cb3-4ead-b7a7-918e54db0ee7"), null, new Guid("b0d9835d-3abd-4e57-8e38-12037a01552b"), false, null, null, new Guid("6f0f80d0-6561-4bff-92bc-877ef39e1754"), new Guid("b0d9835d-3abd-4e57-8e38-12037a01552b") },
                    { new Guid("2f935020-c8e4-4e33-839c-d15183e3c403"), null, new Guid("b1e3248b-6991-4b2e-8066-7347def49379"), false, null, null, new Guid("6f0f80d0-6561-4bff-92bc-877ef39e1754"), new Guid("b1e3248b-6991-4b2e-8066-7347def49379") },
                    { new Guid("34ce1817-472d-4e59-9011-93e39d33cfe5"), null, new Guid("f739df4b-7fd5-4760-a96e-9647cb6fb028"), false, null, null, new Guid("6f0f80d0-6561-4bff-92bc-877ef39e1754"), new Guid("f739df4b-7fd5-4760-a96e-9647cb6fb028") },
                    { new Guid("4c47484d-3513-4298-8c3d-b45f73456bc7"), null, new Guid("3e6a839c-7f29-4772-a80b-b3116c9bf3aa"), false, null, null, new Guid("6f0f80d0-6561-4bff-92bc-877ef39e1754"), new Guid("3e6a839c-7f29-4772-a80b-b3116c9bf3aa") },
                    { new Guid("550fb3fd-bcbf-4f0e-a0b6-681890dc0545"), null, new Guid("8921f715-2371-4e71-81a3-277e991c9248"), false, null, null, new Guid("7be13644-6f1e-484c-b4e8-136be4383fe5"), new Guid("8921f715-2371-4e71-81a3-277e991c9248") },
                    { new Guid("682bbb5e-ee54-422e-bad1-9a4cfc160d6d"), null, new Guid("c71dcf26-909e-46e1-a1c6-7778659d8017"), false, null, null, new Guid("6f0f80d0-6561-4bff-92bc-877ef39e1754"), new Guid("c71dcf26-909e-46e1-a1c6-7778659d8017") },
                    { new Guid("6f5ac3fe-e08b-41ba-a24c-26f6de255044"), null, new Guid("b6bdec28-db74-41e0-bc1e-679a286d9fd0"), false, null, null, new Guid("6f0f80d0-6561-4bff-92bc-877ef39e1754"), new Guid("b6bdec28-db74-41e0-bc1e-679a286d9fd0") },
                    { new Guid("979ddde5-c063-4848-af82-2c0817798bf4"), null, new Guid("910e199c-0fcf-41fa-b312-359791c6465e"), false, null, null, new Guid("4291f9d3-5913-4cf5-8e02-26b87c67c5e3"), new Guid("910e199c-0fcf-41fa-b312-359791c6465e") },
                    { new Guid("a02de0c0-3851-4cc8-b690-0c4a32a52bfd"), null, new Guid("d15df198-3765-4760-ae6f-cf3db29a7801"), false, null, null, new Guid("6f0f80d0-6561-4bff-92bc-877ef39e1754"), new Guid("d15df198-3765-4760-ae6f-cf3db29a7801") },
                    { new Guid("ad034e1b-81ec-4ba8-ac38-e2261d996c8a"), null, new Guid("39716961-f090-4b8c-ba20-399263be51ae"), false, null, null, new Guid("6f0f80d0-6561-4bff-92bc-877ef39e1754"), new Guid("39716961-f090-4b8c-ba20-399263be51ae") },
                    { new Guid("df20e8bc-e251-4c90-8700-a330f1820bb0"), null, new Guid("51cc972c-4530-41dc-89ac-0ca06fce6e55"), false, null, null, new Guid("6f0f80d0-6561-4bff-92bc-877ef39e1754"), new Guid("51cc972c-4530-41dc-89ac-0ca06fce6e55") },
                    { new Guid("f6f5901f-135c-4aa9-b0f8-3c3d385ffb5e"), null, new Guid("7e7ff426-9f70-44b3-80de-d8582b0ee2d1"), false, null, null, new Guid("6f0f80d0-6561-4bff-92bc-877ef39e1754"), new Guid("7e7ff426-9f70-44b3-80de-d8582b0ee2d1") }
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
