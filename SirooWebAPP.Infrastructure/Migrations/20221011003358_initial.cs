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
                    { new Guid("13b8a316-6373-4650-9c50-100722c17f83"), "کیش کدپولو", null, new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea"), new DateTime(2022, 10, 10, 4, 3, 58, 332, DateTimeKind.Local).AddTicks(7352), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, null, true, null, null, 200, "uploads/2022/9/1-56192-4_6008031941360618419.MP4", "کیش", new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea"), 100, 100, 4 },
                    { new Guid("2c6ea6de-53a8-444c-ad01-1a28597e0821"), "دیجی کالا", null, new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea"), new DateTime(2022, 10, 8, 4, 3, 58, 332, DateTimeKind.Local).AddTicks(7553), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, null, false, null, null, 40, "uploads/2022/9/1-36433-1.jpg", "کیش", new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea"), 100, 100, 4 },
                    { new Guid("5bd5619d-9bab-42f5-817b-19f8e0bb4f31"), "ال جی", null, new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea"), new DateTime(2022, 10, 9, 4, 3, 58, 332, DateTimeKind.Local).AddTicks(7460), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, null, false, null, null, 20, "uploads/2022/9/1-53754-1.mp4_snapshot_01.04_[2022.05.26_09.50.52].jpg", "کیش", new Guid("4f487c6b-61db-40ac-8db1-8bbc8e548b1c"), 100, 100, 4 },
                    { new Guid("eb503092-dca1-4125-b2d6-b80a5e80d03e"), "سامسونگ", null, new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea"), new DateTime(2022, 10, 6, 4, 3, 58, 332, DateTimeKind.Local).AddTicks(7508), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, null, false, null, null, 50, "uploads/2022/9/1582619178545.jpg", "کیش", new Guid("bd057cb4-c437-46d1-ad25-bc6056528452"), 100, 100, 4 }
                });

            migrationBuilder.InsertData(
                table: "Draws",
                columns: new[] { "Id", "Created", "CreatedBy", "EndDate", "IsActivated", "IsDeleted", "IsFinished", "IsLottery", "LastModified", "LastModifiedBy", "Name", "Owner", "StartDate" },
                values: new object[,]
                {
                    { new Guid("aa902125-a9e6-448b-ab26-28f44c203572"), new DateTime(2022, 10, 11, 4, 3, 58, 332, DateTimeKind.Local).AddTicks(7596), new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea"), new DateTime(2022, 10, 26, 4, 3, 58, 332, DateTimeKind.Local).AddTicks(7613), true, false, false, false, null, null, "آبان 1401", new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea"), new DateTime(2022, 10, 11, 4, 3, 58, 332, DateTimeKind.Local).AddTicks(7610) },
                    { new Guid("bf6a378b-ae94-45b1-b7a5-ba70ac78ea20"), new DateTime(2022, 10, 11, 4, 3, 58, 332, DateTimeKind.Local).AddTicks(7708), new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea"), new DateTime(2022, 12, 10, 4, 3, 58, 332, DateTimeKind.Local).AddTicks(7719), true, false, false, false, null, null, "اذر 1401", new Guid("bd057cb4-c437-46d1-ad25-bc6056528452"), new DateTime(2022, 11, 10, 4, 3, 58, 332, DateTimeKind.Local).AddTicks(7716) },
                    { new Guid("d3df2349-565d-4624-9182-b94188ba20cd"), new DateTime(2022, 10, 11, 4, 3, 58, 332, DateTimeKind.Local).AddTicks(7727), new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea"), new DateTime(2022, 10, 1, 4, 3, 58, 332, DateTimeKind.Local).AddTicks(7734), true, false, true, false, null, null, "شهریور 1401", new Guid("4f487c6b-61db-40ac-8db1-8bbc8e548b1c"), new DateTime(2022, 9, 11, 4, 3, 58, 332, DateTimeKind.Local).AddTicks(7731) }
                });

            migrationBuilder.InsertData(
                table: "Prizes",
                columns: new[] { "Id", "Created", "CreatedBy", "Draw", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Name", "Priority", "WinnerCount" },
                values: new object[,]
                {
                    { new Guid("0ca8eb85-1d63-44c0-9b98-968323a62ea5"), new DateTime(2022, 10, 11, 4, 3, 58, 332, DateTimeKind.Local).AddTicks(8191), new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea"), new Guid("d3df2349-565d-4624-9182-b94188ba20cd"), true, false, null, null, "10 میلیون تومان", 1, 10 },
                    { new Guid("1531085a-adb7-4cd5-92c5-7a237194c503"), new DateTime(2022, 10, 11, 4, 3, 58, 332, DateTimeKind.Local).AddTicks(7936), new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea"), new Guid("aa902125-a9e6-448b-ab26-28f44c203572"), true, false, null, null, "100 هزار تومان", 1, 10 },
                    { new Guid("5d78ae89-c228-467b-82fa-ee5844e400ce"), new DateTime(2022, 10, 11, 4, 3, 58, 332, DateTimeKind.Local).AddTicks(7947), new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea"), new Guid("aa902125-a9e6-448b-ab26-28f44c203572"), true, false, null, null, "50 هزار تومان", 2, 15 },
                    { new Guid("670a25b2-e261-497a-a56a-29d2c1ae63ce"), new DateTime(2022, 10, 11, 4, 3, 58, 332, DateTimeKind.Local).AddTicks(8079), new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea"), new Guid("bf6a378b-ae94-45b1-b7a5-ba70ac78ea20"), true, false, null, null, "1 میلیون تومان", 1, 10 },
                    { new Guid("6caee7d2-ba38-4509-9047-429532650230"), new DateTime(2022, 10, 11, 4, 3, 58, 332, DateTimeKind.Local).AddTicks(8179), new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea"), new Guid("d3df2349-565d-4624-9182-b94188ba20cd"), true, false, null, null, "20 میلیون تومان", 0, 5 },
                    { new Guid("7ff39343-9ab3-4836-8bb9-73710a18ed51"), new DateTime(2022, 10, 11, 4, 3, 58, 332, DateTimeKind.Local).AddTicks(8064), new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea"), new Guid("bf6a378b-ae94-45b1-b7a5-ba70ac78ea20"), true, false, null, null, "2 میلیون تومان", 0, 5 },
                    { new Guid("9cc1cc33-71bb-4417-a455-0066055abf14"), new DateTime(2022, 10, 11, 4, 3, 58, 332, DateTimeKind.Local).AddTicks(8086), new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea"), new Guid("bf6a378b-ae94-45b1-b7a5-ba70ac78ea20"), true, false, null, null, "500 هزار تومان", 2, 15 },
                    { new Guid("b889e207-4365-44a4-8524-aac02baa47f1"), new DateTime(2022, 10, 11, 4, 3, 58, 332, DateTimeKind.Local).AddTicks(7906), new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea"), new Guid("aa902125-a9e6-448b-ab26-28f44c203572"), true, false, null, null, "200 هزار تومان", 0, 5 },
                    { new Guid("ce34069f-885d-4733-b5a8-6a5bbe2662f3"), new DateTime(2022, 10, 11, 4, 3, 58, 332, DateTimeKind.Local).AddTicks(8199), new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea"), new Guid("d3df2349-565d-4624-9182-b94188ba20cd"), true, false, null, null, "500 هزار تومان", 2, 15 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Priority", "RoleDescription", "RoleName" },
                values: new object[,]
                {
                    { new Guid("07bc46d1-e0e9-4614-b72f-498179e3300b"), null, null, true, false, null, null, 1, "مدیر سامانه", "admin" },
                    { new Guid("14d576a8-91f1-46de-9b46-2053fb040a1f"), null, null, true, false, null, null, 2, "مدیر منطقه", "zoneadmin" },
                    { new Guid("256ac4bb-a4b6-40f8-a222-a01f46826141"), null, null, true, false, null, null, 3, "بازاریاب", "marketer" },
                    { new Guid("367cf5eb-75bd-49ef-81b5-4172e81f8b53"), null, null, true, false, null, null, 5, "مشتری", "client" },
                    { new Guid("8a0df3cc-2c1c-4519-b374-69d5679eabac"), null, null, true, false, null, null, 4, "فروشگاه", "store" },
                    { new Guid("8a4a26a9-2982-4e69-816f-1b195ecaeaf7"), null, null, true, false, null, null, 0, "مدیر کل", "super" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Cellphone", "ConfirmationCode", "Created", "Credits", "Family", "InviterId", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Name", "Points", "ProfileMediaURL", "Username" },
                values: new object[,]
                {
                    { new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea"), "09394125130", null, null, 0L, "Jouybari", null, false, false, null, null, "Sina", 0L, "uploads/2022/9/sina2.jpg", "sinful" },
                    { new Guid("4f487c6b-61db-40ac-8db1-8bbc8e548b1c"), "09111769591", null, null, 0L, "پردلان", null, false, false, null, null, "محسن", 0L, "uploads/2022/9/99.jpg", "vinona" },
                    { new Guid("bd057cb4-c437-46d1-ad25-bc6056528452"), "09163681249", null, null, 0L, "یاراحمدی", null, false, false, null, null, "سپیده", 0L, "uploads/2022/9/photo.jpg", "sepideh" }
                });

            migrationBuilder.InsertData(
                table: "UsersRoles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "Role", "User" },
                values: new object[,]
                {
                    { new Guid("2b07cc4c-2bc5-4e04-a0ff-80502e78d912"), null, new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea"), false, null, null, new Guid("14d576a8-91f1-46de-9b46-2053fb040a1f"), new Guid("4f487c6b-61db-40ac-8db1-8bbc8e548b1c") },
                    { new Guid("41ef6138-5272-4012-8bce-071a0077ea73"), null, new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea"), false, null, null, new Guid("256ac4bb-a4b6-40f8-a222-a01f46826141"), new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea") },
                    { new Guid("805b876e-7a40-4cde-8b0a-1eca9b3e0f12"), null, new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea"), false, null, null, new Guid("8a4a26a9-2982-4e69-816f-1b195ecaeaf7"), new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea") },
                    { new Guid("b46e4f33-a7b4-4b26-bd40-7d6320dfd136"), null, new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea"), false, null, null, new Guid("256ac4bb-a4b6-40f8-a222-a01f46826141"), new Guid("bd057cb4-c437-46d1-ad25-bc6056528452") },
                    { new Guid("f8d1f73d-7ea8-46fd-a156-291892a87945"), null, new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea"), false, null, null, new Guid("07bc46d1-e0e9-4614-b72f-498179e3300b"), new Guid("1aba8d19-3c44-429f-bf27-40d8bb5d61ea") }
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
