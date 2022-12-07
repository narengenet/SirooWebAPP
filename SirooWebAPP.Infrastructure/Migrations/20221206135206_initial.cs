using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SirooWebAPP.Infrastructure.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ConstantDictionaries",
                keyColumn: "Id",
                keyValue: new Guid("03b07fb8-ffb3-4a95-827f-9eb1cb05bb6a"));

            migrationBuilder.DeleteData(
                table: "ConstantDictionaries",
                keyColumn: "Id",
                keyValue: new Guid("1160188d-db87-479c-b5c3-baca91f8efe9"));

            migrationBuilder.DeleteData(
                table: "ConstantDictionaries",
                keyColumn: "Id",
                keyValue: new Guid("180f3717-3b9a-4491-96b3-c6d73fd01ffe"));

            migrationBuilder.DeleteData(
                table: "ConstantDictionaries",
                keyColumn: "Id",
                keyValue: new Guid("1a850b70-dd71-4130-9cf5-11c4dd2b9947"));

            migrationBuilder.DeleteData(
                table: "ConstantDictionaries",
                keyColumn: "Id",
                keyValue: new Guid("1bf636fd-ac80-487e-b2ac-6dae23258bc0"));

            migrationBuilder.DeleteData(
                table: "ConstantDictionaries",
                keyColumn: "Id",
                keyValue: new Guid("356c5298-b247-438c-81de-71b60e863c46"));

            migrationBuilder.DeleteData(
                table: "ConstantDictionaries",
                keyColumn: "Id",
                keyValue: new Guid("3900fb29-f114-47e9-adde-2e537d832abd"));

            migrationBuilder.DeleteData(
                table: "ConstantDictionaries",
                keyColumn: "Id",
                keyValue: new Guid("39abcffb-38f4-43d6-8e97-68cc44dc92a3"));

            migrationBuilder.DeleteData(
                table: "ConstantDictionaries",
                keyColumn: "Id",
                keyValue: new Guid("50906e18-0c7d-4409-b2b2-51f3a0b6432d"));

            migrationBuilder.DeleteData(
                table: "ConstantDictionaries",
                keyColumn: "Id",
                keyValue: new Guid("5aa588da-1062-4006-b168-4a72896860ff"));

            migrationBuilder.DeleteData(
                table: "ConstantDictionaries",
                keyColumn: "Id",
                keyValue: new Guid("5dcc9645-5919-4e95-b775-c4ed196c0c68"));

            migrationBuilder.DeleteData(
                table: "ConstantDictionaries",
                keyColumn: "Id",
                keyValue: new Guid("64900d4b-02fe-42bf-a60a-78633e2efead"));

            migrationBuilder.DeleteData(
                table: "ConstantDictionaries",
                keyColumn: "Id",
                keyValue: new Guid("861e5d1b-5f80-4ba6-95bb-cab427a7a9cf"));

            migrationBuilder.DeleteData(
                table: "ConstantDictionaries",
                keyColumn: "Id",
                keyValue: new Guid("a0c84e1d-5f97-4284-8cf0-e1975a41ae3a"));

            migrationBuilder.DeleteData(
                table: "ConstantDictionaries",
                keyColumn: "Id",
                keyValue: new Guid("bd87276b-8a98-4070-a2ab-147e6d71c730"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0ca16820-0246-4a5b-87c7-b10d8f3ac6ec"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1a8a0a4d-11fb-4536-a5fa-76fc80aa11f6"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("3ce7ed8d-7ecf-47a0-ad5a-33b46e1e166b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("7e2db2b6-6bdc-4710-ad6f-64959241b31b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b833d83c-31c1-4565-a533-96c386ff659e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d9cac0a3-1b67-424e-aae1-df0888219b69"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("eef85588-6b22-4753-93ba-b349cc30553e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("23da1a4a-0c8e-4f4c-9ca9-2af386d22473"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ed3142cd-7b43-47b8-95a2-b709fa521910"));

            migrationBuilder.DeleteData(
                table: "UsersRoles",
                keyColumn: "Id",
                keyValue: new Guid("6da88238-fe0f-4ca0-b0b2-87fc2585037b"));

            migrationBuilder.DeleteData(
                table: "UsersRoles",
                keyColumn: "Id",
                keyValue: new Guid("f5473c24-1d64-4120-bbef-6603aefda664"));

            migrationBuilder.InsertData(
                table: "ConstantDictionaries",
                columns: new[] { "Id", "ConstantKey", "ConstantValue", "Created", "CreatedBy", "Description", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[,]
                {
                    { new Guid("1de7447d-db65-4c0d-b4b8-51c8ea637ffb"), "def_chips_usage_perday", "-1", new DateTime(2022, 12, 6, 17, 22, 6, 70, DateTimeKind.Local).AddTicks(6207), new Guid("2cf6568d-feb8-4646-aafe-452ee7d2601e"), "تعداد استفاده از کارت اعتباری هر کاربر در روز", true, false, null, null },
                    { new Guid("384a26e3-08e3-4fdb-a74d-3e8f0228bf4b"), "stores_max_donnation_point", "500", new DateTime(2022, 12, 6, 17, 22, 6, 70, DateTimeKind.Local).AddTicks(6130), new Guid("2cf6568d-feb8-4646-aafe-452ee7d2601e"), "حداکثر امتیازی که فروشگاه میتواند در هر نوتب هدیه بدهد", true, false, null, null },
                    { new Guid("478e204c-8bcd-4eb2-9a3f-0f414bb6dcb6"), "def_percent_for_marketer", "10", new DateTime(2022, 12, 6, 17, 22, 6, 70, DateTimeKind.Local).AddTicks(6177), new Guid("2cf6568d-feb8-4646-aafe-452ee7d2601e"), "درصد بازاریاب", true, false, null, null },
                    { new Guid("63a109f7-68e2-4cf1-b3c1-a588bc8f6e61"), "def_percent_for_zoneadmin", "6", new DateTime(2022, 12, 6, 17, 22, 6, 70, DateTimeKind.Local).AddTicks(6194), new Guid("2cf6568d-feb8-4646-aafe-452ee7d2601e"), "درصد مدیر منطقه", true, false, null, null },
                    { new Guid("660d931a-48d8-4b02-ab04-e0728d789adb"), "credit_for_image_ads", "500", new DateTime(2022, 12, 6, 17, 22, 6, 70, DateTimeKind.Local).AddTicks(6138), new Guid("2cf6568d-feb8-4646-aafe-452ee7d2601e"), "اعتبار لازم برای ثبت آگهی تصویری", true, false, null, null },
                    { new Guid("7316285e-0423-46f4-9bc4-a4c5b78543ba"), "store_point_usage_per_day", "2", new DateTime(2022, 12, 6, 17, 22, 6, 70, DateTimeKind.Local).AddTicks(6125), new Guid("2cf6568d-feb8-4646-aafe-452ee7d2601e"), "تعداد دفعات استفاده از کارت تخفیف هر مغازه در روز برای یک مشتری", true, false, null, null },
                    { new Guid("772998b8-b371-4170-a3cc-2464b5630816"), "credit_for_video_ads", "1000", new DateTime(2022, 12, 6, 17, 22, 6, 70, DateTimeKind.Local).AddTicks(6146), new Guid("2cf6568d-feb8-4646-aafe-452ee7d2601e"), "اعتبار لازم برای ثبت آگهی ویدئویی", true, false, null, null },
                    { new Guid("78592b60-273b-4bbf-8264-f876a7b8ccbe"), "def_points_for_client_invitation", "50", new DateTime(2022, 12, 6, 17, 22, 6, 70, DateTimeKind.Local).AddTicks(6164), new Guid("2cf6568d-feb8-4646-aafe-452ee7d2601e"), "امتیاز برای معرف وقتی کاربر ثبت نام کرد.", true, false, null, null },
                    { new Guid("8c6fb367-8393-4deb-b6a5-3e5fab606479"), "store_def_credit_reg", "1000", new DateTime(2022, 12, 6, 17, 22, 6, 70, DateTimeKind.Local).AddTicks(6118), new Guid("2cf6568d-feb8-4646-aafe-452ee7d2601e"), "اعتبار اولیه فروشگاه برای ثبت نام اولین بار", true, false, null, null },
                    { new Guid("8de738c2-3cbd-4434-8c64-853c263e0521"), "def_points_for_video_like", "4", new DateTime(2022, 12, 6, 17, 22, 6, 70, DateTimeKind.Local).AddTicks(6173), new Guid("2cf6568d-feb8-4646-aafe-452ee7d2601e"), "امتیاز پیش فرض برای لایک پست ویدئویی", true, false, null, null },
                    { new Guid("9a137332-2362-431d-bf38-0d1ff22e7e5d"), "def_points_for_client_registration", "100", new DateTime(2022, 12, 6, 17, 22, 6, 70, DateTimeKind.Local).AddTicks(6160), new Guid("2cf6568d-feb8-4646-aafe-452ee7d2601e"), "امتیاز اولیه برای کاربری که ثبت نام میکند.", true, false, null, null },
                    { new Guid("b0c20773-5d62-4feb-a770-df8971488d46"), "def_percent_for_countryadmin", "4", new DateTime(2022, 12, 6, 17, 22, 6, 70, DateTimeKind.Local).AddTicks(6202), new Guid("2cf6568d-feb8-4646-aafe-452ee7d2601e"), "درصد مدیر مناطق", true, false, null, null },
                    { new Guid("be0209d9-3292-45a8-a262-2848da2d6f21"), "credit_for_client_registration_by_store_invitation", "50", new DateTime(2022, 12, 6, 17, 22, 6, 70, DateTimeKind.Local).AddTicks(6152), new Guid("2cf6568d-feb8-4646-aafe-452ee7d2601e"), "اعتبار برای فروشنده ای که باعث ثبت نام مشتری شد", true, false, null, null },
                    { new Guid("c95173ae-b8bf-40ce-bb12-9943ca5a13be"), "money_to_credit_ratio", "500", new DateTime(2022, 12, 6, 17, 22, 6, 70, DateTimeKind.Local).AddTicks(6134), new Guid("2cf6568d-feb8-4646-aafe-452ee7d2601e"), "نسبت هر اعتبار به تومان", true, false, null, null },
                    { new Guid("f4ebef60-d0f1-41fd-88e5-ee811f7bb569"), "def_points_for_image_like", "1", new DateTime(2022, 12, 6, 17, 22, 6, 70, DateTimeKind.Local).AddTicks(6169), new Guid("2cf6568d-feb8-4646-aafe-452ee7d2601e"), "امتیاز پیش فرض برای لایک پست تصویری", true, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Priority", "RoleDescription", "RoleName" },
                values: new object[,]
                {
                    { new Guid("1d5180ec-1b3d-438f-a38b-9107d4191139"), null, null, true, false, null, null, 3, "مدیر منطقه", "zoneadmin" },
                    { new Guid("2047915a-459d-4e99-95da-b26b1c9e4883"), null, null, true, false, null, null, 6, "مشتری", "client" },
                    { new Guid("2498f31f-9da5-4052-a63f-eb07cc8a492c"), null, null, true, false, null, null, 1, "مدیر سامانه", "admin" },
                    { new Guid("3dcf5977-b628-4087-ad27-34afe20f8780"), null, null, true, false, null, null, 5, "فروشگاه", "store" },
                    { new Guid("7c3bc731-4390-4aa0-9eb0-946231b39f71"), null, null, true, false, null, null, 0, "مدیر کل", "super" },
                    { new Guid("c7d437ff-929b-489e-8dc2-33186a53a3a0"), null, null, true, false, null, null, 4, "بازاریاب", "marketer" },
                    { new Guid("cbdc72b8-60f2-40d0-b4c7-ff7aa885d319"), null, null, true, false, null, null, 2, "مدیر کل مناطق", "countryadmin" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CardNumber", "Cellphone", "ConfirmationCode", "Created", "Credits", "DefaultCredit", "DonnationActive", "Family", "Inviter", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Money", "Name", "Notes", "Points", "ProfileMediaURL", "Username" },
                values: new object[,]
                {
                    { new Guid("2cf6568d-feb8-4646-aafe-452ee7d2601e"), null, "09394125130", "111111", new DateTime(2022, 12, 6, 17, 22, 6, 70, DateTimeKind.Local).AddTicks(5870), 0L, 0L, false, "Jouybari", new Guid("3e776f97-d677-4c91-8676-4f6de299195a"), true, false, null, null, 850000L, "Sina", null, 90L, "uploads/2022/9/sina2.jpg", "sinful" },
                    { new Guid("3e776f97-d677-4c91-8676-4f6de299195a"), null, "09901069557", null, new DateTime(2022, 12, 6, 17, 22, 6, 70, DateTimeKind.Local).AddTicks(5823), 1000L, 0L, true, "دابویی مشک آبادی", null, true, false, null, null, 0L, "عبدالرحمن", null, 100L, "uploads/2022/9/photo.jpg", "dabooei" }
                });

            migrationBuilder.InsertData(
                table: "UsersRoles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "Role", "User" },
                values: new object[,]
                {
                    { new Guid("8a1dcbe9-734f-4bd0-bf82-493d426c245e"), null, new Guid("3e776f97-d677-4c91-8676-4f6de299195a"), false, null, null, new Guid("3dcf5977-b628-4087-ad27-34afe20f8780"), new Guid("3e776f97-d677-4c91-8676-4f6de299195a") },
                    { new Guid("a7e14ac6-635a-4a54-bb24-08c5c6b7bb57"), null, new Guid("2cf6568d-feb8-4646-aafe-452ee7d2601e"), false, null, null, new Guid("7c3bc731-4390-4aa0-9eb0-946231b39f71"), new Guid("2cf6568d-feb8-4646-aafe-452ee7d2601e") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ConstantDictionaries",
                keyColumn: "Id",
                keyValue: new Guid("1de7447d-db65-4c0d-b4b8-51c8ea637ffb"));

            migrationBuilder.DeleteData(
                table: "ConstantDictionaries",
                keyColumn: "Id",
                keyValue: new Guid("384a26e3-08e3-4fdb-a74d-3e8f0228bf4b"));

            migrationBuilder.DeleteData(
                table: "ConstantDictionaries",
                keyColumn: "Id",
                keyValue: new Guid("478e204c-8bcd-4eb2-9a3f-0f414bb6dcb6"));

            migrationBuilder.DeleteData(
                table: "ConstantDictionaries",
                keyColumn: "Id",
                keyValue: new Guid("63a109f7-68e2-4cf1-b3c1-a588bc8f6e61"));

            migrationBuilder.DeleteData(
                table: "ConstantDictionaries",
                keyColumn: "Id",
                keyValue: new Guid("660d931a-48d8-4b02-ab04-e0728d789adb"));

            migrationBuilder.DeleteData(
                table: "ConstantDictionaries",
                keyColumn: "Id",
                keyValue: new Guid("7316285e-0423-46f4-9bc4-a4c5b78543ba"));

            migrationBuilder.DeleteData(
                table: "ConstantDictionaries",
                keyColumn: "Id",
                keyValue: new Guid("772998b8-b371-4170-a3cc-2464b5630816"));

            migrationBuilder.DeleteData(
                table: "ConstantDictionaries",
                keyColumn: "Id",
                keyValue: new Guid("78592b60-273b-4bbf-8264-f876a7b8ccbe"));

            migrationBuilder.DeleteData(
                table: "ConstantDictionaries",
                keyColumn: "Id",
                keyValue: new Guid("8c6fb367-8393-4deb-b6a5-3e5fab606479"));

            migrationBuilder.DeleteData(
                table: "ConstantDictionaries",
                keyColumn: "Id",
                keyValue: new Guid("8de738c2-3cbd-4434-8c64-853c263e0521"));

            migrationBuilder.DeleteData(
                table: "ConstantDictionaries",
                keyColumn: "Id",
                keyValue: new Guid("9a137332-2362-431d-bf38-0d1ff22e7e5d"));

            migrationBuilder.DeleteData(
                table: "ConstantDictionaries",
                keyColumn: "Id",
                keyValue: new Guid("b0c20773-5d62-4feb-a770-df8971488d46"));

            migrationBuilder.DeleteData(
                table: "ConstantDictionaries",
                keyColumn: "Id",
                keyValue: new Guid("be0209d9-3292-45a8-a262-2848da2d6f21"));

            migrationBuilder.DeleteData(
                table: "ConstantDictionaries",
                keyColumn: "Id",
                keyValue: new Guid("c95173ae-b8bf-40ce-bb12-9943ca5a13be"));

            migrationBuilder.DeleteData(
                table: "ConstantDictionaries",
                keyColumn: "Id",
                keyValue: new Guid("f4ebef60-d0f1-41fd-88e5-ee811f7bb569"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1d5180ec-1b3d-438f-a38b-9107d4191139"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("2047915a-459d-4e99-95da-b26b1c9e4883"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("2498f31f-9da5-4052-a63f-eb07cc8a492c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("3dcf5977-b628-4087-ad27-34afe20f8780"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("7c3bc731-4390-4aa0-9eb0-946231b39f71"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c7d437ff-929b-489e-8dc2-33186a53a3a0"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("cbdc72b8-60f2-40d0-b4c7-ff7aa885d319"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2cf6568d-feb8-4646-aafe-452ee7d2601e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3e776f97-d677-4c91-8676-4f6de299195a"));

            migrationBuilder.DeleteData(
                table: "UsersRoles",
                keyColumn: "Id",
                keyValue: new Guid("8a1dcbe9-734f-4bd0-bf82-493d426c245e"));

            migrationBuilder.DeleteData(
                table: "UsersRoles",
                keyColumn: "Id",
                keyValue: new Guid("a7e14ac6-635a-4a54-bb24-08c5c6b7bb57"));

            migrationBuilder.InsertData(
                table: "ConstantDictionaries",
                columns: new[] { "Id", "ConstantKey", "ConstantValue", "Created", "CreatedBy", "Description", "IsActive", "IsDeleted", "LastModified", "LastModifiedBy" },
                values: new object[,]
                {
                    { new Guid("03b07fb8-ffb3-4a95-827f-9eb1cb05bb6a"), "stores_max_donnation_point", "500", new DateTime(2022, 12, 6, 16, 1, 47, 49, DateTimeKind.Local).AddTicks(5536), new Guid("23da1a4a-0c8e-4f4c-9ca9-2af386d22473"), "حداکثر امتیازی که فروشگاه میتواند در هر نوتب هدیه بدهد", true, false, null, null },
                    { new Guid("1160188d-db87-479c-b5c3-baca91f8efe9"), "credit_for_video_ads", "1000", new DateTime(2022, 12, 6, 16, 1, 47, 49, DateTimeKind.Local).AddTicks(5565), new Guid("23da1a4a-0c8e-4f4c-9ca9-2af386d22473"), "اعتبار لازم برای ثبت آگهی ویدئویی", true, false, null, null },
                    { new Guid("180f3717-3b9a-4491-96b3-c6d73fd01ffe"), "def_points_for_image_like", "1", new DateTime(2022, 12, 6, 16, 1, 47, 49, DateTimeKind.Local).AddTicks(5595), new Guid("23da1a4a-0c8e-4f4c-9ca9-2af386d22473"), "امتیاز پیش فرض برای لایک پست تصویری", true, false, null, null },
                    { new Guid("1a850b70-dd71-4130-9cf5-11c4dd2b9947"), "def_points_for_client_invitation", "50", new DateTime(2022, 12, 6, 16, 1, 47, 49, DateTimeKind.Local).AddTicks(5588), new Guid("23da1a4a-0c8e-4f4c-9ca9-2af386d22473"), "امتیاز برای معرف وقتی کاربر ثبت نام کرد.", true, false, null, null },
                    { new Guid("1bf636fd-ac80-487e-b2ac-6dae23258bc0"), "money_to_credit_ratio", "500", new DateTime(2022, 12, 6, 16, 1, 47, 49, DateTimeKind.Local).AddTicks(5543), new Guid("23da1a4a-0c8e-4f4c-9ca9-2af386d22473"), "نسبت هر اعتبار به تومان", true, false, null, null },
                    { new Guid("356c5298-b247-438c-81de-71b60e863c46"), "def_percent_for_countryadmin", "4", new DateTime(2022, 12, 6, 16, 1, 47, 49, DateTimeKind.Local).AddTicks(5630), new Guid("23da1a4a-0c8e-4f4c-9ca9-2af386d22473"), "درصد مدیر مناطق", true, false, null, null },
                    { new Guid("3900fb29-f114-47e9-adde-2e537d832abd"), "credit_for_client_registration_by_store_invitation", "50", new DateTime(2022, 12, 6, 16, 1, 47, 49, DateTimeKind.Local).AddTicks(5573), new Guid("23da1a4a-0c8e-4f4c-9ca9-2af386d22473"), "اعتبار برای فروشنده ای که باعث ثبت نام مشتری شد", true, false, null, null },
                    { new Guid("39abcffb-38f4-43d6-8e97-68cc44dc92a3"), "def_chips_usage_perday", "-1", new DateTime(2022, 12, 6, 16, 1, 47, 49, DateTimeKind.Local).AddTicks(5638), new Guid("23da1a4a-0c8e-4f4c-9ca9-2af386d22473"), "تعداد استفاده از کارت اعتباری هر کاربر در روز", true, false, null, null },
                    { new Guid("50906e18-0c7d-4409-b2b2-51f3a0b6432d"), "credit_for_image_ads", "500", new DateTime(2022, 12, 6, 16, 1, 47, 49, DateTimeKind.Local).AddTicks(5551), new Guid("23da1a4a-0c8e-4f4c-9ca9-2af386d22473"), "اعتبار لازم برای ثبت آگهی تصویری", true, false, null, null },
                    { new Guid("5aa588da-1062-4006-b168-4a72896860ff"), "def_percent_for_zoneadmin", "6", new DateTime(2022, 12, 6, 16, 1, 47, 49, DateTimeKind.Local).AddTicks(5618), new Guid("23da1a4a-0c8e-4f4c-9ca9-2af386d22473"), "درصد مدیر منطقه", true, false, null, null },
                    { new Guid("5dcc9645-5919-4e95-b775-c4ed196c0c68"), "def_percent_for_marketer", "10", new DateTime(2022, 12, 6, 16, 1, 47, 49, DateTimeKind.Local).AddTicks(5610), new Guid("23da1a4a-0c8e-4f4c-9ca9-2af386d22473"), "درصد بازاریاب", true, false, null, null },
                    { new Guid("64900d4b-02fe-42bf-a60a-78633e2efead"), "def_points_for_video_like", "4", new DateTime(2022, 12, 6, 16, 1, 47, 49, DateTimeKind.Local).AddTicks(5602), new Guid("23da1a4a-0c8e-4f4c-9ca9-2af386d22473"), "امتیاز پیش فرض برای لایک پست ویدئویی", true, false, null, null },
                    { new Guid("861e5d1b-5f80-4ba6-95bb-cab427a7a9cf"), "store_point_usage_per_day", "2", new DateTime(2022, 12, 6, 16, 1, 47, 49, DateTimeKind.Local).AddTicks(5529), new Guid("23da1a4a-0c8e-4f4c-9ca9-2af386d22473"), "تعداد دفعات استفاده از کارت تخفیف هر مغازه در روز برای یک مشتری", true, false, null, null },
                    { new Guid("a0c84e1d-5f97-4284-8cf0-e1975a41ae3a"), "store_def_credit_reg", "1000", new DateTime(2022, 12, 6, 16, 1, 47, 49, DateTimeKind.Local).AddTicks(5516), new Guid("23da1a4a-0c8e-4f4c-9ca9-2af386d22473"), "اعتبار اولیه فروشگاه برای ثبت نام اولین بار", true, false, null, null },
                    { new Guid("bd87276b-8a98-4070-a2ab-147e6d71c730"), "def_points_for_client_registration", "100", new DateTime(2022, 12, 6, 16, 1, 47, 49, DateTimeKind.Local).AddTicks(5581), new Guid("23da1a4a-0c8e-4f4c-9ca9-2af386d22473"), "امتیاز اولیه برای کاربری که ثبت نام میکند.", true, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Priority", "RoleDescription", "RoleName" },
                values: new object[,]
                {
                    { new Guid("0ca16820-0246-4a5b-87c7-b10d8f3ac6ec"), null, null, true, false, null, null, 5, "فروشگاه", "store" },
                    { new Guid("1a8a0a4d-11fb-4536-a5fa-76fc80aa11f6"), null, null, true, false, null, null, 6, "مشتری", "client" },
                    { new Guid("3ce7ed8d-7ecf-47a0-ad5a-33b46e1e166b"), null, null, true, false, null, null, 1, "مدیر سامانه", "admin" },
                    { new Guid("7e2db2b6-6bdc-4710-ad6f-64959241b31b"), null, null, true, false, null, null, 2, "مدیر کل مناطق", "countryadmin" },
                    { new Guid("b833d83c-31c1-4565-a533-96c386ff659e"), null, null, true, false, null, null, 0, "مدیر کل", "super" },
                    { new Guid("d9cac0a3-1b67-424e-aae1-df0888219b69"), null, null, true, false, null, null, 4, "بازاریاب", "marketer" },
                    { new Guid("eef85588-6b22-4753-93ba-b349cc30553e"), null, null, true, false, null, null, 3, "مدیر منطقه", "zoneadmin" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CardNumber", "Cellphone", "ConfirmationCode", "Created", "Credits", "DefaultCredit", "DonnationActive", "Family", "Inviter", "IsActivated", "IsDeleted", "LastModified", "LastModifiedBy", "Money", "Name", "Notes", "Points", "ProfileMediaURL", "Username" },
                values: new object[,]
                {
                    { new Guid("23da1a4a-0c8e-4f4c-9ca9-2af386d22473"), null, "09394125130", "111111", new DateTime(2022, 12, 6, 16, 1, 47, 49, DateTimeKind.Local).AddTicks(5131), 0L, 0L, false, "Jouybari", new Guid("ed3142cd-7b43-47b8-95a2-b709fa521910"), true, false, null, null, 850000L, "Sina", null, 90L, "uploads/2022/9/sina2.jpg", "sinful" },
                    { new Guid("ed3142cd-7b43-47b8-95a2-b709fa521910"), null, "09901069557", null, new DateTime(2022, 12, 6, 16, 1, 47, 49, DateTimeKind.Local).AddTicks(5084), 1000L, 0L, true, "دابویی مشک آبادی", null, true, false, null, null, 0L, "عبدالرحمن", null, 100L, "uploads/2022/9/photo.jpg", "dabooei" }
                });

            migrationBuilder.InsertData(
                table: "UsersRoles",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDeleted", "LastModified", "LastModifiedBy", "Role", "User" },
                values: new object[,]
                {
                    { new Guid("6da88238-fe0f-4ca0-b0b2-87fc2585037b"), null, new Guid("23da1a4a-0c8e-4f4c-9ca9-2af386d22473"), false, null, null, new Guid("b833d83c-31c1-4565-a533-96c386ff659e"), new Guid("23da1a4a-0c8e-4f4c-9ca9-2af386d22473") },
                    { new Guid("f5473c24-1d64-4120-bbef-6603aefda664"), null, new Guid("ed3142cd-7b43-47b8-95a2-b709fa521910"), false, null, null, new Guid("0ca16820-0246-4a5b-87c7-b10d8f3ac6ec"), new Guid("ed3142cd-7b43-47b8-95a2-b709fa521910") }
                });
        }
    }
}
