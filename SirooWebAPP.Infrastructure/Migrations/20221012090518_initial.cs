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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ViewQuota = table.Column<int>(type: "int", nullable: false),
                    RemainedViewQuota = table.Column<int>(type: "int", nullable: false),
                    IsSpecial = table.Column<bool>(type: "bit", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MediaSourceURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAvtivated = table.Column<bool>(type: "bit", nullable: false),
                    Owner = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                name: "ConstantDictionaries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConstantKey = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConstantValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                name: "Prizes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Draw = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WinnerCount = table.Column<int>(type: "int", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    DefaultCredit = table.Column<long>(type: "bigint", nullable: false),
                    DonnationActive = table.Column<bool>(type: "bit", nullable: false),
                    ProfileMediaURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InviterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Users_InviterId",
                        column: x => x.InviterId,
                        principalTable: "Users",
                        principalColumn: "Id");
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
                table: "Advertises",
                columns: new[] { "Id", "Caption", "Created", "CreatedBy", "CreationDate", "Expiracy", "IsAvtivated", "IsDeleted", "IsSpecial", "IsVideo", "LastModified", "LastModifiedBy", "LikeReward", "MediaSourceURL", "Name", "Owner", "RemainedViewQuota", "ViewQuota", "ViewReward" },
                values: new object[,]
                {
                    { new Guid("083d0b52-dc1b-4fd6-a423-a9b226e4b241"), "کیش کدپولو", null, new Guid("4a79bd4d-5273-4bc1-9af1-6bcb423bd3b9"), new DateTime(2022, 10, 11, 12, 35, 18, 541, DateTimeKind.Local).AddTicks(5423), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, null, true, null, null, 200, "uploads/2022/9/1-56192-4_6008031941360618419.MP4", "کیش", new Guid("4a79bd4d-5273-4bc1-9af1-6bcb423bd3b9"), 100, 100, 4 },
                    { new Guid("d3f98e7c-7d3c-4989-9035-4aa05338e2c3"), "ال جی", null, new Guid("4a79bd4d-5273-4bc1-9af1-6bcb423bd3b9"), new DateTime(2022, 10, 10, 12, 35, 18, 541, DateTimeKind.Local).AddTicks(5485), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, null, false, null, null, 20, "uploads/2022/9/1-53754-1.mp4_snapshot_01.04_[2022.05.26_09.50.52].jpg", "کیش", new Guid("099cb08d-13b6-4522-b6de-7effe6c96617"), 100, 100, 4 },
                    { new Guid("ed3ae744-cae9-4bbd-9abc-68c8f9257d63"), "دیجی کالا", null, new Guid("4a79bd4d-5273-4bc1-9af1-6bcb423bd3b9"), new DateTime(2022, 10, 9, 12, 35, 18, 541, DateTimeKind.Local).AddTicks(5537), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, null, false, null, null, 40, "uploads/2022/9/1-36433-1.jpg", "کیش", new Guid("4a79bd4d-5273-4bc1-9af1-6bcb423bd3b9"), 100, 100, 4 },
                    { new Guid("f189d64e-f921-4112-98ae-a1a41b26417e"), "سامسونگ", null, new Guid("4a79bd4d-5273-4bc1-9af1-6bcb423bd3b9"), new DateTime(2022, 10, 7, 12, 35, 18, 541, DateTimeKind.Local).AddTicks(5507), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, null, false, null, null, 50, "uploads/2022/9/1582619178545.jpg", "کیش", new Guid("1ccf4855-2d9d-4cd4-b230-99f72162cc10"), 100, 100, 4 }
                });

            migrationBuilder.InsertData(
                table: "ConstantDictionaries",
                columns: new[] { "Id", "ConstantKey", "ConstantValue", "Created", "CreatedBy", "Description", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[,]
                {
                    { new Guid("3614cfa7-8d41-4c06-991e-1763f932cad9"), "credit_for_video_ads", "1000", new DateTime(2022, 10, 12, 12, 35, 18, 541, DateTimeKind.Local).AddTicks(5788), new Guid("4a79bd4d-5273-4bc1-9af1-6bcb423bd3b9"), "اعتبار لازم برای ثبت آگهی تصویری", true, false, null, null },
                    { new Guid("6539004f-ad06-4273-8e39-7c9e409b27ee"), "store_point_usage_per_day", "2", new DateTime(2022, 10, 12, 12, 35, 18, 541, DateTimeKind.Local).AddTicks(5775), new Guid("4a79bd4d-5273-4bc1-9af1-6bcb423bd3b9"), "تعداد دفعات استفاده از کارت تخفیف هر مغازه در روز برای یک مشتری", true, false, null, null },
                    { new Guid("84cf672c-51b8-4153-8f3b-2e0fe507b56c"), "store_def_credit_reg", "1000", new DateTime(2022, 10, 12, 12, 35, 18, 541, DateTimeKind.Local).AddTicks(5768), new Guid("4a79bd4d-5273-4bc1-9af1-6bcb423bd3b9"), "اعتبار اولیه فروشگاه برای ثبت نام اولین بار", true, false, null, null },
                    { new Guid("b1523cb0-cc77-417e-b454-e870b028c496"), "stores_max_donnation_point", "500", new DateTime(2022, 10, 12, 12, 35, 18, 541, DateTimeKind.Local).AddTicks(5778), new Guid("4a79bd4d-5273-4bc1-9af1-6bcb423bd3b9"), "حداکثر امتیازی که فروشگاه میتواند در هر نوتب هدیه بدهد", true, false, null, null },
                    { new Guid("b349ad6d-5089-479b-858a-2ff43d63d71a"), "money_to_credit_ratio", "50", new DateTime(2022, 10, 12, 12, 35, 18, 541, DateTimeKind.Local).AddTicks(5782), new Guid("4a79bd4d-5273-4bc1-9af1-6bcb423bd3b9"), "نسبت هر اعتبار به تومان", true, false, null, null },
                    { new Guid("b97d2cca-86ea-4314-bb63-e8e4f8e8b1f2"), "credit_for_image_ads", "500", new DateTime(2022, 10, 12, 12, 35, 18, 541, DateTimeKind.Local).AddTicks(5785), new Guid("4a79bd4d-5273-4bc1-9af1-6bcb423bd3b9"), "اعتبار لازم برای ثبت آگهی تصویری", true, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Draws",
                columns: new[] { "Id", "Created", "CreatedBy", "EndDate", "IsActivated", "IsDeleted", "IsFinished", "IsLottery", "LastModified", "LastModifiedBy", "Name", "Owner", "StartDate" },
                values: new object[,]
                {
                    { new Guid("3e084aef-5351-4e6f-b647-69770cc51563"), new DateTime(2022, 10, 12, 12, 35, 18, 541, DateTimeKind.Local).AddTicks(5556), new Guid("4a79bd4d-5273-4bc1-9af1-6bcb423bd3b9"), new DateTime(2022, 12, 11, 12, 35, 18, 541, DateTimeKind.Local).AddTicks(5560), true, false, false, false, null, null, "اذر 1401", new Guid("1ccf4855-2d9d-4cd4-b230-99f72162cc10"), new DateTime(2022, 11, 11, 12, 35, 18, 541, DateTimeKind.Local).AddTicks(5558) },
                    { new Guid("b970c88d-bf62-4bf1-afbb-6a5dccfd1e1b"), new DateTime(2022, 10, 12, 12, 35, 18, 541, DateTimeKind.Local).AddTicks(5546), new Guid("4a79bd4d-5273-4bc1-9af1-6bcb423bd3b9"), new DateTime(2022, 10, 27, 12, 35, 18, 541, DateTimeKind.Local).AddTicks(5551), true, false, false, false, null, null, "آبان 1401", new Guid("4a79bd4d-5273-4bc1-9af1-6bcb423bd3b9"), new DateTime(2022, 10, 12, 12, 35, 18, 541, DateTimeKind.Local).AddTicks(5549) },
                    { new Guid("c48ea58e-f22d-4f23-9214-7c2bc7b73642"), new DateTime(2022, 10, 12, 12, 35, 18, 541, DateTimeKind.Local).AddTicks(5563), new Guid("4a79bd4d-5273-4bc1-9af1-6bcb423bd3b9"), new DateTime(2022, 10, 2, 12, 35, 18, 541, DateTimeKind.Local).AddTicks(5567), true, false, true, false, null, null, "شهریور 1401", new Guid("099cb08d-13b6-4522-b6de-7effe6c96617"), new DateTime(2022, 9, 12, 12, 35, 18, 541, DateTimeKind.Local).AddTicks(5565) }
                });

            migrationBuilder.InsertData(
                table: "Prizes",
                columns: new[] { "Id", "Created", "CreatedBy", "Draw", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Name", "Priority", "WinnerCount" },
                values: new object[,]
                {
                    { new Guid("0a345281-9cd3-48f7-82aa-4634ef874448"), new DateTime(2022, 10, 12, 12, 35, 18, 541, DateTimeKind.Local).AddTicks(5625), new Guid("4a79bd4d-5273-4bc1-9af1-6bcb423bd3b9"), new Guid("b970c88d-bf62-4bf1-afbb-6a5dccfd1e1b"), true, false, null, null, "100 هزار تومان", 1, 10 },
                    { new Guid("6161cecb-cfc5-4b43-b9d2-227cea2186d4"), new DateTime(2022, 10, 12, 12, 35, 18, 541, DateTimeKind.Local).AddTicks(5681), new Guid("4a79bd4d-5273-4bc1-9af1-6bcb423bd3b9"), new Guid("3e084aef-5351-4e6f-b647-69770cc51563"), true, false, null, null, "500 هزار تومان", 2, 15 },
                    { new Guid("6a256db4-f2e7-4a62-a2e9-0e3e05450b87"), new DateTime(2022, 10, 12, 12, 35, 18, 541, DateTimeKind.Local).AddTicks(5728), new Guid("4a79bd4d-5273-4bc1-9af1-6bcb423bd3b9"), new Guid("c48ea58e-f22d-4f23-9214-7c2bc7b73642"), true, false, null, null, "500 هزار تومان", 2, 15 },
                    { new Guid("6b385c21-c1e9-4417-8e87-c15f8b36e823"), new DateTime(2022, 10, 12, 12, 35, 18, 541, DateTimeKind.Local).AddTicks(5724), new Guid("4a79bd4d-5273-4bc1-9af1-6bcb423bd3b9"), new Guid("c48ea58e-f22d-4f23-9214-7c2bc7b73642"), true, false, null, null, "10 میلیون تومان", 1, 10 },
                    { new Guid("790a3dc4-0a4a-44e5-bbb0-c6a9430e7883"), new DateTime(2022, 10, 12, 12, 35, 18, 541, DateTimeKind.Local).AddTicks(5615), new Guid("4a79bd4d-5273-4bc1-9af1-6bcb423bd3b9"), new Guid("b970c88d-bf62-4bf1-afbb-6a5dccfd1e1b"), true, false, null, null, "200 هزار تومان", 0, 5 },
                    { new Guid("af1db7ad-17e6-4387-9ea8-c80d9be5267e"), new DateTime(2022, 10, 12, 12, 35, 18, 541, DateTimeKind.Local).AddTicks(5719), new Guid("4a79bd4d-5273-4bc1-9af1-6bcb423bd3b9"), new Guid("c48ea58e-f22d-4f23-9214-7c2bc7b73642"), true, false, null, null, "20 میلیون تومان", 0, 5 },
                    { new Guid("c06f8599-454f-4f0b-b091-26e85d89cb4a"), new DateTime(2022, 10, 12, 12, 35, 18, 541, DateTimeKind.Local).AddTicks(5677), new Guid("4a79bd4d-5273-4bc1-9af1-6bcb423bd3b9"), new Guid("3e084aef-5351-4e6f-b647-69770cc51563"), true, false, null, null, "1 میلیون تومان", 1, 10 },
                    { new Guid("c0c8b31b-3fb5-4261-a3e8-12a0e39663be"), new DateTime(2022, 10, 12, 12, 35, 18, 541, DateTimeKind.Local).AddTicks(5672), new Guid("4a79bd4d-5273-4bc1-9af1-6bcb423bd3b9"), new Guid("3e084aef-5351-4e6f-b647-69770cc51563"), true, false, null, null, "2 میلیون تومان", 0, 5 },
                    { new Guid("d882e1e8-7178-43ec-8964-0e1a77c8fc0c"), new DateTime(2022, 10, 12, 12, 35, 18, 541, DateTimeKind.Local).AddTicks(5628), new Guid("4a79bd4d-5273-4bc1-9af1-6bcb423bd3b9"), new Guid("b970c88d-bf62-4bf1-afbb-6a5dccfd1e1b"), true, false, null, null, "50 هزار تومان", 2, 15 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Priority", "RoleDescription", "RoleName" },
                values: new object[,]
                {
                    { new Guid("299684ef-678e-4e1c-944c-624981466b30"), null, null, true, false, null, null, 1, "مدیر سامانه", "admin" },
                    { new Guid("5700d00d-f578-491a-877a-cd8fa2fd0f6d"), null, null, true, false, null, null, 2, "مدیر منطقه", "zoneadmin" },
                    { new Guid("c34a643e-d3a5-4812-a76c-3ff7473ed347"), null, null, true, false, null, null, 4, "فروشگاه", "store" },
                    { new Guid("c61e6a26-a2df-4ed4-bfbb-6ca74642d191"), null, null, true, false, null, null, 0, "مدیر کل", "super" },
                    { new Guid("e3b5eb26-8c06-43e1-9439-db8c85924da9"), null, null, true, false, null, null, 3, "بازاریاب", "marketer" },
                    { new Guid("e9193645-2591-4480-b332-f6fe31a0224c"), null, null, true, false, null, null, 5, "مشتری", "client" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Cellphone", "ConfirmationCode", "Created", "Credits", "DefaultCredit", "DonnationActive", "Family", "InviterId", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Name", "Points", "ProfileMediaURL", "Username" },
                values: new object[,]
                {
                    { new Guid("099cb08d-13b6-4522-b6de-7effe6c96617"), "09111769591", null, null, 0L, 0L, false, "پردلان", null, false, false, null, null, "محسن", 0L, "uploads/2022/9/99.jpg", "vinona" },
                    { new Guid("1ccf4855-2d9d-4cd4-b230-99f72162cc10"), "09163681249", null, null, 0L, 0L, false, "یاراحمدی", null, false, false, null, null, "سپیده", 0L, "uploads/2022/9/photo.jpg", "sepideh" },
                    { new Guid("2547b929-0060-452e-8b77-5fab09425083"), "09112281237", null, null, 0L, 0L, false, "سرپرست", null, false, false, null, null, "عبداله", 0L, "uploads/2022/9/photo.jpg", "abdolah" },
                    { new Guid("4a79bd4d-5273-4bc1-9af1-6bcb423bd3b9"), "09394125130", null, null, 0L, 0L, false, "Jouybari", null, false, false, null, null, "Sina", 0L, "uploads/2022/9/sina2.jpg", "sinful" }
                });

            migrationBuilder.InsertData(
                table: "UsersRoles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "Role", "User" },
                values: new object[,]
                {
                    { new Guid("0e643754-cb67-40dc-9fde-052d403da125"), null, new Guid("4a79bd4d-5273-4bc1-9af1-6bcb423bd3b9"), false, null, null, new Guid("c61e6a26-a2df-4ed4-bfbb-6ca74642d191"), new Guid("4a79bd4d-5273-4bc1-9af1-6bcb423bd3b9") },
                    { new Guid("7f5f1b17-6a61-4ba1-a9c2-f865658c7a5c"), null, new Guid("4a79bd4d-5273-4bc1-9af1-6bcb423bd3b9"), false, null, null, new Guid("5700d00d-f578-491a-877a-cd8fa2fd0f6d"), new Guid("099cb08d-13b6-4522-b6de-7effe6c96617") },
                    { new Guid("cc601ab5-3689-4e7d-9922-fc5a776fb6af"), null, new Guid("2547b929-0060-452e-8b77-5fab09425083"), false, null, null, new Guid("e9193645-2591-4480-b332-f6fe31a0224c"), new Guid("2547b929-0060-452e-8b77-5fab09425083") },
                    { new Guid("d91ee693-4d7d-4071-9935-34a821d7257c"), null, new Guid("4a79bd4d-5273-4bc1-9af1-6bcb423bd3b9"), false, null, null, new Guid("e3b5eb26-8c06-43e1-9439-db8c85924da9"), new Guid("1ccf4855-2d9d-4cd4-b230-99f72162cc10") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_InviterId",
                table: "Users",
                column: "InviterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Advertises");

            migrationBuilder.DropTable(
                name: "ConstantDictionaries");

            migrationBuilder.DropTable(
                name: "Draws");

            migrationBuilder.DropTable(
                name: "Likers");

            migrationBuilder.DropTable(
                name: "OnlineUsers");

            migrationBuilder.DropTable(
                name: "Prizes");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "UsersRoles");

            migrationBuilder.DropTable(
                name: "Viewers");
        }
    }
}
