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
                    { new Guid("09c40a4b-c84f-44b5-8638-99f45e2e8378"), "گردونه", "diamond_sixth_priority", "4", "51,100", new DateTime(2023, 1, 26, 2, 33, 5, 280, DateTimeKind.Local).AddTicks(2142), new Guid("2371c100-1fb8-415f-ac2e-e40b3d199286"), "اولویت ششم تعداد الماس و درصد شانس", true, false, null, null, 5 },
                    { new Guid("0aaa266c-7387-43c8-a014-dcc8ea968230"), "ثبت نام", "def_points_for_client_invitation", null, "50", new DateTime(2023, 1, 26, 2, 33, 5, 280, DateTimeKind.Local).AddTicks(2210), new Guid("2371c100-1fb8-415f-ac2e-e40b3d199286"), "امتیاز برای معرف وقتی کاربر ثبت نام کرد.", true, false, null, null, 18 },
                    { new Guid("1e734356-5b0e-4010-8ad6-0c4d0117f1ae"), "چالش", "maximum_number_of_prize_payment", null, "1000", new DateTime(2023, 1, 26, 2, 33, 5, 280, DateTimeKind.Local).AddTicks(2280), new Guid("2371c100-1fb8-415f-ac2e-e40b3d199286"), "حداکثر تعداد پرداخت کارمزدها", true, false, null, null, 33 },
                    { new Guid("2272bcab-19c4-485b-b76a-809d656aab77"), "گردونه", "diamond_fivth_priority", "5", "31,50", new DateTime(2023, 1, 26, 2, 33, 5, 280, DateTimeKind.Local).AddTicks(2096), new Guid("2371c100-1fb8-415f-ac2e-e40b3d199286"), "اولویت پنجم تعداد الماس و درصد شانس", true, false, null, null, 4 },
                    { new Guid("237e461f-e62e-4d96-85c3-6c88b370a9fe"), "چالش", "order_of_prize_payment", null, "3,5,2,10", new DateTime(2023, 1, 26, 2, 33, 5, 280, DateTimeKind.Local).AddTicks(2273), new Guid("2371c100-1fb8-415f-ac2e-e40b3d199286"), "ترتیب پرداخت کارمزدها", true, false, null, null, 32 },
                    { new Guid("2ee800f9-27be-42cb-92ef-2fbf3660909a"), "آگهی تبلیغاتی", "def_money_to_premium_video_ads", null, "1000000", new DateTime(2023, 1, 26, 2, 33, 5, 280, DateTimeKind.Local).AddTicks(2172), new Guid("2371c100-1fb8-415f-ac2e-e40b3d199286"), "هزینه درج آگهی تبلیغاتی ویدئویی", true, false, null, null, 10 },
                    { new Guid("3514cef3-5486-48b2-b3d1-fc04642f587c"), "آگهی تبلیغاتی", "def_money_to_premium_image_ads", null, "200000", new DateTime(2023, 1, 26, 2, 33, 5, 280, DateTimeKind.Local).AddTicks(2176), new Guid("2371c100-1fb8-415f-ac2e-e40b3d199286"), "هزینه درج آگهی تبلیغاتی تصویری", true, false, null, null, 11 },
                    { new Guid("36154437-f028-4a42-9d14-56f6e475d810"), "فروشگاه", "store_def_credit_reg", null, "0", new DateTime(2023, 1, 26, 2, 33, 5, 280, DateTimeKind.Local).AddTicks(2214), new Guid("2371c100-1fb8-415f-ac2e-e40b3d199286"), "اعتبار اولیه فروشگاه برای ثبت نام اولین بار", true, false, null, null, 19 },
                    { new Guid("3a20a416-5d7e-46f2-a392-3a4ac91c65e0"), "گردونه", "added_points_to_each_spin_diamond_wheel_after_first_time", null, "100", new DateTime(2023, 1, 26, 2, 33, 5, 280, DateTimeKind.Local).AddTicks(2071), new Guid("2371c100-1fb8-415f-ac2e-e40b3d199286"), "افزایش تعداد امتیاز به اضای هر بار چرخاندن گردونه شانس در یک روز", true, false, null, null, -1 },
                    { new Guid("3f5c3fab-2064-421a-a7be-391750b6074d"), "درصدها", "def_percent_for_marketer", null, "10", new DateTime(2023, 1, 26, 2, 33, 5, 280, DateTimeKind.Local).AddTicks(2237), new Guid("2371c100-1fb8-415f-ac2e-e40b3d199286"), "درصد بازاریاب", true, false, null, null, 24 },
                    { new Guid("3f7fb980-5737-4dad-b8f5-0bae33fa7758"), "گردونه", "diamond_third_priority", "10", "11,20", new DateTime(2023, 1, 26, 2, 33, 5, 280, DateTimeKind.Local).AddTicks(2087), new Guid("2371c100-1fb8-415f-ac2e-e40b3d199286"), "اولویت سوم تعداد الماس و درصد شانس", true, false, null, null, 2 },
                    { new Guid("46abb50e-ffa8-4047-ac33-d1231f951170"), "آگهی تبلیغاتی", "points_reward_premium_image_ads", null, "1000", new DateTime(2023, 1, 26, 2, 33, 5, 280, DateTimeKind.Local).AddTicks(2185), new Guid("2371c100-1fb8-415f-ac2e-e40b3d199286"), "امتیاز ثبت آگهی تبلیغاتی تصویری", true, false, null, null, 13 },
                    { new Guid("5b1bb5d5-23e6-490a-b14d-353934662aac"), "چالش", "expire_dates_for_challenge", null, "60", new DateTime(2023, 1, 26, 2, 33, 5, 280, DateTimeKind.Local).AddTicks(2260), new Guid("2371c100-1fb8-415f-ac2e-e40b3d199286"), "تعداد روزهای مجاز برای چالش", true, false, null, null, 29 },
                    { new Guid("5c5b0820-74bd-4acc-bfbd-4c5dae3086a9"), "گردونه", "diamond_fourth_priority", "6", "21,30", new DateTime(2023, 1, 26, 2, 33, 5, 280, DateTimeKind.Local).AddTicks(2092), new Guid("2371c100-1fb8-415f-ac2e-e40b3d199286"), "اولویت چهارم تعداد الماس و درصد شانس", true, false, null, null, 3 },
                    { new Guid("65e079df-aeb5-424d-a9bb-0124f1c32ec0"), "گردونه", "diamond_first_priority", "50", "1,5", new DateTime(2023, 1, 26, 2, 33, 5, 280, DateTimeKind.Local).AddTicks(2075), new Guid("2371c100-1fb8-415f-ac2e-e40b3d199286"), "اولویت اول تعداد الماس و درصد شانس", true, false, null, null, 0 },
                    { new Guid("7d366647-94ad-415e-8980-b4d043bb9454"), "فروشگاه", "store_point_usage_per_day", null, "-1", new DateTime(2023, 1, 26, 2, 33, 5, 280, DateTimeKind.Local).AddTicks(2217), new Guid("2371c100-1fb8-415f-ac2e-e40b3d199286"), "تعداد دفعات استفاده از کارت تخفیف هر فروشگاه در روز برای یک مشتری", true, false, null, null, 20 },
                    { new Guid("8a3eeb9f-3d96-48f3-9f05-65367dcfe412"), "گردونه", "diamond_second_priority", "20", "6,10", new DateTime(2023, 1, 26, 2, 33, 5, 280, DateTimeKind.Local).AddTicks(2083), new Guid("2371c100-1fb8-415f-ac2e-e40b3d199286"), "اولویت دوم تعداد الماس و درصد شانس", true, false, null, null, 1 },
                    { new Guid("923e2264-bf0f-499e-b8bd-e2ccc41b1b20"), "فروشگاه", "credit_for_client_registration_by_store_invitation", null, "50", new DateTime(2023, 1, 26, 2, 33, 5, 280, DateTimeKind.Local).AddTicks(2229), new Guid("2371c100-1fb8-415f-ac2e-e40b3d199286"), "اعتبار برای فروشنده ای که باعث ثبت نام مشتری شد", true, false, null, null, 22 },
                    { new Guid("955a8f51-67fc-438c-a8f9-940785d2ed0a"), "لایک ها", "def_points_for_video_like", null, "15", new DateTime(2023, 1, 26, 2, 33, 5, 280, DateTimeKind.Local).AddTicks(2199), new Guid("2371c100-1fb8-415f-ac2e-e40b3d199286"), "امتیاز پیش فرض برای لایک پست ویدئویی", true, false, null, null, 16 },
                    { new Guid("9c56d4ed-9b05-4abe-8d3a-abc7b248bbf3"), "گردونه", "diamond_tenth_priority", "0", "999,1000", new DateTime(2023, 1, 26, 2, 33, 5, 280, DateTimeKind.Local).AddTicks(2167), new Guid("2371c100-1fb8-415f-ac2e-e40b3d199286"), "امتیاز دهم آگهی تبلیغاتی تصویری", true, false, null, null, 9 },
                    { new Guid("9da21f3f-0d8a-4692-9ed5-5690bb8b7d6d"), "لایک ها", "def_points_for_image_like", null, "1", new DateTime(2023, 1, 26, 2, 33, 5, 280, DateTimeKind.Local).AddTicks(2195), new Guid("2371c100-1fb8-415f-ac2e-e40b3d199286"), "امتیاز پیش فرض برای لایک پست تصویری", true, false, null, null, 15 },
                    { new Guid("9f2b2368-f068-49c1-bcf3-9717a497f2ca"), "مالی", "money_to_credit_ratio", null, "1000", new DateTime(2023, 1, 26, 2, 33, 5, 280, DateTimeKind.Local).AddTicks(2233), new Guid("2371c100-1fb8-415f-ac2e-e40b3d199286"), "نسبت هر اعتبار به تومان", true, false, null, null, 23 },
                    { new Guid("a6c6367b-2d34-4aa2-b4e8-1f71cb25479a"), "درصدها", "def_percent_for_countryadmin", null, "4", new DateTime(2023, 1, 26, 2, 33, 5, 280, DateTimeKind.Local).AddTicks(2248), new Guid("2371c100-1fb8-415f-ac2e-e40b3d199286"), "درصد مدیر مناطق", true, false, null, null, 26 },
                    { new Guid("b0492cd8-e3dd-4ece-8cda-c0f709cdc6eb"), "کارت اعتباری", "def_chips_usage_perday", null, "-1", new DateTime(2023, 1, 26, 2, 33, 5, 280, DateTimeKind.Local).AddTicks(2190), new Guid("2371c100-1fb8-415f-ac2e-e40b3d199286"), "تعداد استفاده از کارت اعتباری هر کاربر در روز", true, false, null, null, 14 },
                    { new Guid("b7eccfb4-2e96-4e7d-8dc9-09f2b4121028"), "درصدها", "def_percent_for_zoneadmin", null, "6", new DateTime(2023, 1, 26, 2, 33, 5, 280, DateTimeKind.Local).AddTicks(2243), new Guid("2371c100-1fb8-415f-ac2e-e40b3d199286"), "درصد مدیر منطقه", true, false, null, null, 25 },
                    { new Guid("bdf21b42-645c-466d-8588-d9c2763b1df7"), "گردونه", "diamond_nineth_priority", "0", "301,500", new DateTime(2023, 1, 26, 2, 33, 5, 280, DateTimeKind.Local).AddTicks(2160), new Guid("2371c100-1fb8-415f-ac2e-e40b3d199286"), "امتیاز نهم آگهی تبلیغاتی تصویری", true, false, null, null, 8 },
                    { new Guid("becdaaff-d470-4d13-83d9-91b4a021b2c6"), "گردونه", "min_points_to_spin_diamond_wheel", null, "200", new DateTime(2023, 1, 26, 2, 33, 5, 280, DateTimeKind.Local).AddTicks(2062), new Guid("2371c100-1fb8-415f-ac2e-e40b3d199286"), "حداقل امتیاز برای چرخاندن گردونه شانس الماس بار اول", true, false, null, null, -2 },
                    { new Guid("c434356b-425a-4d98-916e-8700f234ff84"), "ثبت نام", "def_points_for_client_registration", null, "100", new DateTime(2023, 1, 26, 2, 33, 5, 280, DateTimeKind.Local).AddTicks(2206), new Guid("2371c100-1fb8-415f-ac2e-e40b3d199286"), "امتیاز اولیه برای کاربری که ثبت نام میکند.", true, false, null, null, 17 },
                    { new Guid("ca7ae0be-4c11-4297-964c-0b118bf465a2"), "گردونه", "diamond_seventh_priority", "3", "101,200", new DateTime(2023, 1, 26, 2, 33, 5, 280, DateTimeKind.Local).AddTicks(2151), new Guid("2371c100-1fb8-415f-ac2e-e40b3d199286"), "اولویت هفتم تعداد الماس و درصد شانس", true, false, null, null, 6 },
                    { new Guid("da8f10d3-c0ae-400f-9875-e29b37871c12"), "گردونه", "diamond_eighth_priority", "2", "201,300", new DateTime(2023, 1, 26, 2, 33, 5, 280, DateTimeKind.Local).AddTicks(2155), new Guid("2371c100-1fb8-415f-ac2e-e40b3d199286"), "اولویت هشتم تعداد الماس و درصد شانس", true, false, null, null, 7 },
                    { new Guid("dd412621-3ad3-4fa2-8f83-fd0247d8d1c4"), "اعتبار", "credit_for_video_ads", null, "1000", new DateTime(2023, 1, 26, 2, 33, 5, 280, DateTimeKind.Local).AddTicks(2256), new Guid("2371c100-1fb8-415f-ac2e-e40b3d199286"), "اعتبار لازم برای ثبت آگهی ویدئویی", true, false, null, null, 28 },
                    { new Guid("ddbc009a-c7ed-4347-bcc6-60628986f048"), "چالش", "prize_for_invite_to_challenge", null, "1000000", new DateTime(2023, 1, 26, 2, 33, 5, 280, DateTimeKind.Local).AddTicks(2269), new Guid("2371c100-1fb8-415f-ac2e-e40b3d199286"), "کارمزد برای معرفی کاربران به چالش", true, false, null, null, 31 },
                    { new Guid("e435eaca-ee98-44b7-98a0-26a7effce92c"), "چالش", "money_needed_to_attend_in_challenge", null, "3000000", new DateTime(2023, 1, 26, 2, 33, 5, 280, DateTimeKind.Local).AddTicks(2265), new Guid("2371c100-1fb8-415f-ac2e-e40b3d199286"), "موجودی ریالی برای شرکت در چالش", true, false, null, null, 30 },
                    { new Guid("e4981c4b-907f-40d9-b58a-a4a37f9d44a7"), "اعتبار", "credit_for_image_ads", null, "500", new DateTime(2023, 1, 26, 2, 33, 5, 280, DateTimeKind.Local).AddTicks(2252), new Guid("2371c100-1fb8-415f-ac2e-e40b3d199286"), "اعتبار لازم برای ثبت آگهی تصویری", true, false, null, null, 27 },
                    { new Guid("f4d7f866-1df3-4438-86e5-63d717b80545"), "فروشگاه", "stores_max_donnation_point", null, "500", new DateTime(2023, 1, 26, 2, 33, 5, 280, DateTimeKind.Local).AddTicks(2222), new Guid("2371c100-1fb8-415f-ac2e-e40b3d199286"), "حداکثر امتیازی که فروشگاه میتواند در هر نوتب هدیه بدهد", true, false, null, null, 21 },
                    { new Guid("febc9620-6904-41eb-a01a-cd0376e2c700"), "آگهی تبلیغاتی", "points_reward_premium_video_ads", null, "200", new DateTime(2023, 1, 26, 2, 33, 5, 280, DateTimeKind.Local).AddTicks(2179), new Guid("2371c100-1fb8-415f-ac2e-e40b3d199286"), "امتیاز ثبت آگهی تبلیغاتی ویدئویی", true, false, null, null, 12 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Priority", "RoleDescription", "RoleName" },
                values: new object[,]
                {
                    { new Guid("1c0737f5-b44c-4118-bedd-84a64f96c04d"), null, null, true, false, null, null, 5, "فروشگاه", "store" },
                    { new Guid("3b09cb90-28ad-4f32-b156-28d5ebdb953e"), null, null, true, false, null, null, 6, "مشتری", "client" },
                    { new Guid("55754f76-6f63-4ec4-8c58-5d196762fd34"), null, null, true, false, null, null, 1, "مدیر سامانه", "admin" },
                    { new Guid("587c360a-ea9d-4ca9-9dc9-ff173b0942cd"), null, null, true, false, null, null, 2, "مدیر کل مناطق", "countryadmin" },
                    { new Guid("8154bad7-ddf9-4941-b5f3-fa54f4ed6fb0"), null, null, true, false, null, null, 0, "مدیر کل", "super" },
                    { new Guid("d355e666-6400-4dc2-8c67-be71a107574c"), null, null, true, false, null, null, 3, "مدیر منطقه", "zoneadmin" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Priority", "RoleDescription", "RoleName" },
                values: new object[] { new Guid("dea9ce0d-15ae-4c21-9011-052cf54526c9"), null, null, true, false, null, null, 4, "بازاریاب", "marketer" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CardNumber", "Cellphone", "ConfirmationCode", "Created", "Credits", "DefaultCredit", "Diamonds", "DonnationActive", "Family", "Inviter", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Money", "Name", "Notes", "Points", "ProfileMediaURL", "Username" },
                values: new object[,]
                {
                    { new Guid("17174fd0-7a01-47e0-b841-258ab8e4990e"), null, "09177777777", "111111", new DateTime(2023, 1, 26, 2, 33, 5, 280, DateTimeKind.Local).AddTicks(1477), 0L, 0L, 0, false, "user7", null, true, false, null, null, 3000000L, "seventh", null, 90L, "uploads/2022/9/sina2.jpg", "seventhuser" },
                    { new Guid("2371c100-1fb8-415f-ac2e-e40b3d199286"), null, "09394125130", "111111", new DateTime(2023, 1, 26, 2, 33, 5, 280, DateTimeKind.Local).AddTicks(1424), 0L, 0L, 0, false, "Jouybari", new Guid("3173abe4-d31a-461c-9a57-42dfc0a64c92"), true, false, null, null, 850000L, "Sina", null, 90L, "uploads/2022/9/sina2.jpg", "sinful" },
                    { new Guid("3173abe4-d31a-461c-9a57-42dfc0a64c92"), null, "09901069557", null, new DateTime(2023, 1, 26, 2, 33, 5, 280, DateTimeKind.Local).AddTicks(1379), 1000L, 0L, 0, true, "دابویی مشک آبادی", null, true, false, null, null, 0L, "عبدالرحمن", null, 100L, "uploads/2022/9/photo.jpg", "dabooei" },
                    { new Guid("49af233b-660e-4c7c-8302-bff6b4bbc451"), null, "09166666666", "111111", new DateTime(2023, 1, 26, 2, 33, 5, 280, DateTimeKind.Local).AddTicks(1471), 0L, 0L, 0, false, "user6", null, true, false, null, null, 3000000L, "sixth", null, 90L, "uploads/2022/9/sina2.jpg", "sixthuser" },
                    { new Guid("5143e229-05bf-4338-8ee1-8b1078f639b7"), null, "09144444444", "111111", new DateTime(2023, 1, 26, 2, 33, 5, 280, DateTimeKind.Local).AddTicks(1463), 0L, 0L, 0, false, "user4", null, true, false, null, null, 3000000L, "fourth", null, 90L, "uploads/2022/9/sina2.jpg", "fourthuser" },
                    { new Guid("5aad5783-079a-4e1d-9818-92aba266a03c"), null, "09011000000", "111111", new DateTime(2023, 1, 26, 2, 33, 5, 280, DateTimeKind.Local).AddTicks(1497), 0L, 0L, 0, false, "user11", null, true, false, null, null, 3000000L, "eleventh", null, 90L, "uploads/2022/9/sina2.jpg", "eleventhuser" },
                    { new Guid("86f279ac-3ad3-4168-b1dc-a25f32874552"), null, "09199999999", "111111", new DateTime(2023, 1, 26, 2, 33, 5, 280, DateTimeKind.Local).AddTicks(1485), 0L, 0L, 0, false, "user9", null, true, false, null, null, 3000000L, "ninth", null, 90L, "uploads/2022/9/sina2.jpg", "ninthuser" },
                    { new Guid("b1d814fe-4d22-46d0-b056-bff329fa56d0"), null, "09100000000", "111111", new DateTime(2023, 1, 26, 2, 33, 5, 280, DateTimeKind.Local).AddTicks(1490), 0L, 0L, 0, false, "user10", null, true, false, null, null, 3000000L, "tenth", null, 90L, "uploads/2022/9/sina2.jpg", "tenthuser" },
                    { new Guid("c151c0a5-9dee-4ed5-99c9-f1c9cc55184d"), null, "09133333333", "111111", new DateTime(2023, 1, 26, 2, 33, 5, 280, DateTimeKind.Local).AddTicks(1459), 0L, 0L, 0, false, "user3", null, true, false, null, null, 3000000L, "third", null, 90L, "uploads/2022/9/sina2.jpg", "thirduser" },
                    { new Guid("c9f4522a-bfa7-452b-98f4-f9df487643c4"), null, "09122222222", "111111", new DateTime(2023, 1, 26, 2, 33, 5, 280, DateTimeKind.Local).AddTicks(1434), 0L, 0L, 0, false, "user2", null, true, false, null, null, 3000000L, "second", null, 90L, "uploads/2022/9/sina2.jpg", "seconduser" },
                    { new Guid("dae516cb-1726-4a17-a58a-9c5e1ceb4e20"), null, "09188888888", "111111", new DateTime(2023, 1, 26, 2, 33, 5, 280, DateTimeKind.Local).AddTicks(1482), 0L, 0L, 0, false, "user8", null, true, false, null, null, 3000000L, "eighth", null, 90L, "uploads/2022/9/sina2.jpg", "eighthuser" },
                    { new Guid("e3484c5d-ded6-406a-830e-a581e319299a"), null, "09155555555", "111111", new DateTime(2023, 1, 26, 2, 33, 5, 280, DateTimeKind.Local).AddTicks(1468), 0L, 0L, 0, false, "user5", null, true, false, null, null, 3000000L, "fivth", null, 90L, "uploads/2022/9/sina2.jpg", "fivthuser" },
                    { new Guid("f1e79443-3518-46d6-86b9-d19557a1281c"), null, "09111111111", "111111", new DateTime(2023, 1, 26, 2, 33, 5, 280, DateTimeKind.Local).AddTicks(1430), 0L, 0L, 0, false, "user1", null, true, false, null, null, 3000000L, "first", null, 90L, "uploads/2022/9/sina2.jpg", "firstuser" }
                });

            migrationBuilder.InsertData(
                table: "UsersRoles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "Role", "User" },
                values: new object[,]
                {
                    { new Guid("039d32be-f6b3-463d-9cb2-96c4ce3814ae"), null, new Guid("17174fd0-7a01-47e0-b841-258ab8e4990e"), false, null, null, new Guid("3b09cb90-28ad-4f32-b156-28d5ebdb953e"), new Guid("17174fd0-7a01-47e0-b841-258ab8e4990e") },
                    { new Guid("05590925-bc45-4333-8830-859286ffedd6"), null, new Guid("e3484c5d-ded6-406a-830e-a581e319299a"), false, null, null, new Guid("3b09cb90-28ad-4f32-b156-28d5ebdb953e"), new Guid("e3484c5d-ded6-406a-830e-a581e319299a") },
                    { new Guid("343f1633-2872-4b96-84e5-632d06e0e933"), null, new Guid("c151c0a5-9dee-4ed5-99c9-f1c9cc55184d"), false, null, null, new Guid("3b09cb90-28ad-4f32-b156-28d5ebdb953e"), new Guid("c151c0a5-9dee-4ed5-99c9-f1c9cc55184d") },
                    { new Guid("35775f36-486d-4650-b3a2-cf1463adfb38"), null, new Guid("c9f4522a-bfa7-452b-98f4-f9df487643c4"), false, null, null, new Guid("3b09cb90-28ad-4f32-b156-28d5ebdb953e"), new Guid("c9f4522a-bfa7-452b-98f4-f9df487643c4") },
                    { new Guid("47c33ead-7617-42ec-8ed1-27f6208101c9"), null, new Guid("49af233b-660e-4c7c-8302-bff6b4bbc451"), false, null, null, new Guid("3b09cb90-28ad-4f32-b156-28d5ebdb953e"), new Guid("49af233b-660e-4c7c-8302-bff6b4bbc451") },
                    { new Guid("5ed91afe-f9e5-4696-a8d7-2b0942a9c632"), null, new Guid("5aad5783-079a-4e1d-9818-92aba266a03c"), false, null, null, new Guid("3b09cb90-28ad-4f32-b156-28d5ebdb953e"), new Guid("5aad5783-079a-4e1d-9818-92aba266a03c") },
                    { new Guid("62e40298-a3ce-4bb2-ae82-0454e0aaf028"), null, new Guid("3173abe4-d31a-461c-9a57-42dfc0a64c92"), false, null, null, new Guid("1c0737f5-b44c-4118-bedd-84a64f96c04d"), new Guid("3173abe4-d31a-461c-9a57-42dfc0a64c92") },
                    { new Guid("7c7f43e0-52ef-4314-8180-2bbcc983db48"), null, new Guid("5143e229-05bf-4338-8ee1-8b1078f639b7"), false, null, null, new Guid("3b09cb90-28ad-4f32-b156-28d5ebdb953e"), new Guid("5143e229-05bf-4338-8ee1-8b1078f639b7") },
                    { new Guid("9ebe83f5-cae8-485c-ad40-a7a8517783da"), null, new Guid("86f279ac-3ad3-4168-b1dc-a25f32874552"), false, null, null, new Guid("3b09cb90-28ad-4f32-b156-28d5ebdb953e"), new Guid("86f279ac-3ad3-4168-b1dc-a25f32874552") },
                    { new Guid("a623e6bb-e024-4089-8f97-d83de52ff016"), null, new Guid("dae516cb-1726-4a17-a58a-9c5e1ceb4e20"), false, null, null, new Guid("3b09cb90-28ad-4f32-b156-28d5ebdb953e"), new Guid("dae516cb-1726-4a17-a58a-9c5e1ceb4e20") },
                    { new Guid("af6bd798-205c-4fba-9634-d95eca953359"), null, new Guid("f1e79443-3518-46d6-86b9-d19557a1281c"), false, null, null, new Guid("3b09cb90-28ad-4f32-b156-28d5ebdb953e"), new Guid("f1e79443-3518-46d6-86b9-d19557a1281c") },
                    { new Guid("ce0ca752-7438-45a7-9c01-9f36e7ed86f2"), null, new Guid("2371c100-1fb8-415f-ac2e-e40b3d199286"), false, null, null, new Guid("8154bad7-ddf9-4941-b5f3-fa54f4ed6fb0"), new Guid("2371c100-1fb8-415f-ac2e-e40b3d199286") },
                    { new Guid("eda90b01-d95b-4a62-ad2a-71c7df058e6c"), null, new Guid("b1d814fe-4d22-46d0-b056-bff329fa56d0"), false, null, null, new Guid("3b09cb90-28ad-4f32-b156-28d5ebdb953e"), new Guid("b1d814fe-4d22-46d0-b056-bff329fa56d0") }
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
