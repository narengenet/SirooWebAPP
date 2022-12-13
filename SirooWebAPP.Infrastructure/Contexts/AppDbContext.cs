using Microsoft.EntityFrameworkCore;
using SirooWebAPP.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace SirooWebAPP.Infrastructure.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Users> Users { get; set; }
        public DbSet<OnlineUsers> OnlineUsers { get; set; }
        public DbSet<Advertise> Advertises { get; set; }
        public DbSet<Likers> Likers { get; set; }
        public DbSet<Viewers> Viewers { get; set; }

        public DbSet<Roles> Roles { get; set; }
        public DbSet<UsersRoles> UsersRoles { get; set; }
        public DbSet<Draws> Draws { get; set; }
        public DbSet<Prizes> Prizes { get; set; }
        public DbSet<ConstantDictionaries> ConstantDictionaries { get; set; }
        public DbSet<DonnationTickets> DonnationTickets { get; set; }
        public DbSet<PointUsages> PointUsages { get; set; }
        //public DbSet<RoleChangeRequests> RoleChangeRequests{ get; set; }
        public DbSet<PrizesWinners> PrizesWinners { get; set; }
        public DbSet<Transactions> Transactions { get; set; }
        public DbSet<Purchases> Purchases { get; set; }
        public DbSet<TransactionPercents>  TransactionPercents{ get; set; }
        public DbSet<Chips>  Chips{ get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Guid rahmanId = Guid.NewGuid();
            Users dabouei = new Users { Id = rahmanId, Name = "عبدالرحمن", Family = "دابویی مشک آبادی", Cellphone = "09901069557", Username = "dabooei", ProfileMediaURL = "uploads/2022/9/photo.jpg", DonnationActive = true, Credits = 1000, IsActivated = true, Created = DateTime.Now, Points = 100 };
            Guid sinId = Guid.NewGuid();
            Users sina = new Users { Id = sinId, Name = "Sina", Family = "Jouybari", Cellphone = "09394125130", Username = "sinful", ProfileMediaURL = "uploads/2022/9/sina2.jpg", Inviter=rahmanId, IsActivated = true, Created = DateTime.Now, Points = 90, ConfirmationCode="111111", Money=850000 };
            //Users mohsen = new Users { Id = Guid.NewGuid(), Name = "محسن", Family = "پردلان", Cellphone = "09111769591", Username = "vinona", ProfileMediaURL = "uploads/2022/9/99.jpg", Inviter = dabouei.Id, IsActivated = true, Created = DateTime.Now, Points = 80 };
            //Users sepideh = new Users { Id = Guid.NewGuid(), Name = "سامان", Family = "احمدی", Cellphone = "09161234567", Username = "saman", ProfileMediaURL = "uploads/2022/9/photo.jpg", Inviter = dabouei.Id, IsActivated = true, Created = DateTime.Now, Points = 70 };
            //Users abdolah = new Users { Id = Guid.NewGuid(), Name = "عبداله", Family = "سرپرست", Cellphone = "09112281237", Username = "abdolah", ProfileMediaURL = "uploads/2022/9/photo.jpg", IsActivated = true, Created = DateTime.Now, Points = 60 };
            //Users amir = new Users { Id = Guid.NewGuid(), Name = "امیر", Family = "شفایی", Cellphone = "09181650111", Username = "amirsh", ProfileMediaURL = "uploads/2022/9/photo.jpg", IsActivated = true, Created = DateTime.Now, Points = 50 };
            //Users maryam = new Users { Id = Guid.NewGuid(), Name = "مریم", Family = "سرپرست", Cellphone = "09181616111", Username = "pari", ProfileMediaURL = "uploads/2022/9/photo.jpg", IsActivated = true, Created = DateTime.Now, Points = 40 };
            //Users haji = new Users { Id = Guid.NewGuid(), Name = "رجبعلی", Family = "سرپرست", Cellphone = "09111291908", Username = "haji", ProfileMediaURL = "uploads/2022/9/photo.jpg", IsActivated = true, Created = DateTime.Now, Points = 30 };

            modelBuilder.Entity<Users>().HasData(sina);
            //modelBuilder.Entity<Users>().HasData(mohsen);
            //modelBuilder.Entity<Users>().HasData(sepideh);
            //modelBuilder.Entity<Users>().HasData(abdolah);
            modelBuilder.Entity<Users>().HasData(dabouei);
            //modelBuilder.Entity<Users>().HasData(amir);
            //modelBuilder.Entity<Users>().HasData(maryam);
            //modelBuilder.Entity<Users>().HasData(haji);

            Roles role_superadmin = new Roles { Id = Guid.NewGuid(), RoleName = "super", IsActivated = true, RoleDescription = "مدیر کل", Priority = 0 };
            Roles role_admin = new Roles { Id = Guid.NewGuid(), RoleName = "admin", IsActivated = true, RoleDescription = "مدیر سامانه", Priority = 1 };
            Roles role_countryadmin = new Roles { Id = Guid.NewGuid(), RoleName = "countryadmin", IsActivated = true, RoleDescription = "مدیر کل مناطق", Priority = 2 };
            Roles role_zoneadmin = new Roles { Id = Guid.NewGuid(), RoleName = "zoneadmin", IsActivated = true, RoleDescription = "مدیر منطقه", Priority = 3 };
            Roles role_marketer = new Roles { Id = Guid.NewGuid(), RoleName = "marketer", IsActivated = true, RoleDescription = "بازاریاب", Priority = 4 };
            Roles role_store = new Roles { Id = Guid.NewGuid(), RoleName = "store", IsActivated = true, RoleDescription = "فروشگاه", Priority = 5 };
            Roles role_client = new Roles { Id = Guid.NewGuid(), RoleName = "client", IsActivated = true, RoleDescription = "مشتری", Priority = 6 };
            modelBuilder.Entity<Roles>().HasData(role_superadmin);
            modelBuilder.Entity<Roles>().HasData(role_admin);
            modelBuilder.Entity<Roles>().HasData(role_countryadmin);
            modelBuilder.Entity<Roles>().HasData(role_zoneadmin);
            modelBuilder.Entity<Roles>().HasData(role_marketer);
            modelBuilder.Entity<Roles>().HasData(role_store);
            modelBuilder.Entity<Roles>().HasData(role_client);

            UsersRoles superadmin_sina = new UsersRoles { Id = Guid.NewGuid(), Role = role_superadmin.Id, User = sina.Id, CreatedBy = sinId };
            //UsersRoles marketer_sepideh = new UsersRoles { Id = Guid.NewGuid(), Role = role_marketer.Id, User = sepideh.Id, CreatedBy = sina.Id };
            //UsersRoles zoneadmin_mohsen = new UsersRoles { Id = Guid.NewGuid(), Role = role_zoneadmin.Id, User = mohsen.Id, CreatedBy = sina.Id };
            //UsersRoles client_abdolah = new UsersRoles { Id = Guid.NewGuid(), Role = role_client.Id, User = abdolah.Id, CreatedBy = abdolah.Id };
            //UsersRoles client_amir = new UsersRoles { Id = Guid.NewGuid(), Role = role_client.Id, User = amir.Id, CreatedBy = abdolah.Id };
            //UsersRoles client_maryam = new UsersRoles { Id = Guid.NewGuid(), Role = role_client.Id, User = maryam.Id, CreatedBy = abdolah.Id };
            //UsersRoles client_haji = new UsersRoles { Id = Guid.NewGuid(), Role = role_client.Id, User = haji.Id, CreatedBy = abdolah.Id };
            UsersRoles store_dabouei = new UsersRoles { Id = Guid.NewGuid(), Role = role_store.Id, User = dabouei.Id, CreatedBy = dabouei.Id };
            modelBuilder.Entity<UsersRoles>().HasData(superadmin_sina);
            //modelBuilder.Entity<UsersRoles>().HasData(marketer_sepideh);
            //modelBuilder.Entity<UsersRoles>().HasData(zoneadmin_mohsen);
            //modelBuilder.Entity<UsersRoles>().HasData(client_abdolah);
            modelBuilder.Entity<UsersRoles>().HasData(store_dabouei);
            //modelBuilder.Entity<UsersRoles>().HasData(client_maryam);
            //modelBuilder.Entity<UsersRoles>().HasData(client_amir);
            //modelBuilder.Entity<UsersRoles>().HasData(client_haji);



            //modelBuilder.Entity<Advertise>().HasData(new Advertise { Id = Guid.NewGuid(), Owner = sina.Id, Caption = "کیش کدپولو", IsVideo = true, LikeReward = 4, ViewReward = 4, ViewQuota = 100, RemainedViewQuota = 100, MediaSourceURL = "uploads/2022/9/1-56192-4_6008031941360618419.MP4", IsAvtivated = true, CreatedBy = sina.Id, CreationDate = DateTime.Now.AddDays(-1), LastModified = DateTime.Now.AddDays(-1) });
            //modelBuilder.Entity<Advertise>().HasData(new Advertise { Id = Guid.NewGuid(), Owner = mohsen.Id, Caption = "ال جی", IsVideo = false, LikeReward = 2, ViewReward = 4, ViewQuota = 100, RemainedViewQuota = 100, MediaSourceURL = "uploads/2022/9/1-53754-1.mp4_snapshot_01.04_[2022.05.26_09.50.52].jpg", IsAvtivated = true, CreatedBy = sina.Id, CreationDate = DateTime.Now.AddDays(-2), LastModified = DateTime.Now.AddDays(-2) });
            //modelBuilder.Entity<Advertise>().HasData(new Advertise { Id = Guid.NewGuid(), Owner = sepideh.Id, Caption = "سامسونگ", IsVideo = false, LikeReward = 2, ViewReward = 4, ViewQuota = 100, RemainedViewQuota = 100, MediaSourceURL = "uploads/2022/9/1582619178545.jpg", IsAvtivated = true, CreatedBy = sina.Id, CreationDate = DateTime.Now.AddDays(-5), LastModified = DateTime.Now.AddDays(-5) });
            //modelBuilder.Entity<Advertise>().HasData(new Advertise { Id = Guid.NewGuid(), Owner = sina.Id, Caption = "دیجی کالا", IsVideo = false, LikeReward = 2, ViewReward = 4, ViewQuota = 100, RemainedViewQuota = 100, MediaSourceURL = "uploads/2022/9/1-36433-1.jpg", IsAvtivated = true, CreatedBy = sina.Id, CreationDate = DateTime.Now.AddDays(-3), LastModified = DateTime.Now.AddDays(-3) });

            //Draws draw_a = new Draws { Id = Guid.NewGuid(), Name = "آبان 1401", Created = DateTime.Now, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(15), CreatedBy = sina.Id, IsActivated = true, IsFinished = false, IsLottery = false, Owner = sina.Id };
            //Draws draw_b = new Draws { Id = Guid.NewGuid(), Name = "اذر 1401", Created = DateTime.Now, StartDate = DateTime.Now.AddDays(30), EndDate = DateTime.Now.AddDays(60), CreatedBy = sina.Id, IsActivated = true, IsFinished = false, IsLottery = false, Owner = sepideh.Id };
            //Draws draw_c = new Draws { Id = Guid.NewGuid(), Name = "شهریور 1401", Created = DateTime.Now, StartDate = DateTime.Now.AddDays(-30), EndDate = DateTime.Now.AddDays(-10), CreatedBy = sina.Id, IsActivated = true, IsFinished = false, IsLottery = false, Owner = mohsen.Id };
            //modelBuilder.Entity<Draws>().HasData(draw_a);
            //modelBuilder.Entity<Draws>().HasData(draw_b);
            //modelBuilder.Entity<Draws>().HasData(draw_c);

            //Prizes prize_a_one = new Prizes { Id = Guid.NewGuid(), Name = "200 هزار تومان", Draw = draw_a.Id, IsActivated = true, Priority = 0, WinnerCount = 1, Created = DateTime.Now, CreatedBy = sina.Id };
            //Prizes prize_a_two = new Prizes { Id = Guid.NewGuid(), Name = "100 هزار تومان", Draw = draw_a.Id, IsActivated = true, Priority = 1, WinnerCount = 2, Created = DateTime.Now, CreatedBy = sina.Id };
            //Prizes prize_a_three = new Prizes { Id = Guid.NewGuid(), Name = "50 هزار تومان", Draw = draw_a.Id, IsActivated = true, Priority = 2, WinnerCount = 3, Created = DateTime.Now, CreatedBy = sina.Id };
            //modelBuilder.Entity<Prizes>().HasData(prize_a_one);
            //modelBuilder.Entity<Prizes>().HasData(prize_a_two);
            //modelBuilder.Entity<Prizes>().HasData(prize_a_three);

            //Prizes prize_b_one = new Prizes { Id = Guid.NewGuid(), Name = "2 میلیون تومان", Draw = draw_b.Id, IsActivated = true, Priority = 0, WinnerCount = 5, Created = DateTime.Now, CreatedBy = sina.Id };
            //Prizes prize_b_two = new Prizes { Id = Guid.NewGuid(), Name = "1 میلیون تومان", Draw = draw_b.Id, IsActivated = true, Priority = 1, WinnerCount = 10, Created = DateTime.Now, CreatedBy = sina.Id };
            //Prizes prize_b_three = new Prizes { Id = Guid.NewGuid(), Name = "500 هزار تومان", Draw = draw_b.Id, IsActivated = true, Priority = 2, WinnerCount = 15, Created = DateTime.Now, CreatedBy = sina.Id };
            //modelBuilder.Entity<Prizes>().HasData(prize_b_one);
            //modelBuilder.Entity<Prizes>().HasData(prize_b_two);
            //modelBuilder.Entity<Prizes>().HasData(prize_b_three);

            //Prizes prize_c_one = new Prizes { Id = Guid.NewGuid(), Name = "20 میلیون تومان", Draw = draw_c.Id, IsActivated = true, Priority = 0, WinnerCount = 5, Created = DateTime.Now, CreatedBy = sina.Id };
            //Prizes prize_c_two = new Prizes { Id = Guid.NewGuid(), Name = "10 میلیون تومان", Draw = draw_c.Id, IsActivated = true, Priority = 1, WinnerCount = 10, Created = DateTime.Now, CreatedBy = sina.Id };
            //Prizes prize_c_three = new Prizes { Id = Guid.NewGuid(), Name = "500 هزار تومان", Draw = draw_c.Id, IsActivated = true, Priority = 2, WinnerCount = 15, Created = DateTime.Now, CreatedBy = sina.Id };
            //modelBuilder.Entity<Prizes>().HasData(prize_c_one);
            //modelBuilder.Entity<Prizes>().HasData(prize_c_two);
            //modelBuilder.Entity<Prizes>().HasData(prize_c_three);

            ConstantDictionaries store_default_credits_registration = new ConstantDictionaries { Id = Guid.NewGuid(), ConstantKey = "store_def_credit_reg", ConstantValue = "1000", IsActive = true, Description = "اعتبار اولیه فروشگاه برای ثبت نام اولین بار", Created = DateTime.Now, CreatedBy = sina.Id };
            ConstantDictionaries store_point_usage_per_day = new ConstantDictionaries { Id = Guid.NewGuid(), ConstantKey = "store_point_usage_per_day", ConstantValue = "2", IsActive = true, Description = "تعداد دفعات استفاده از کارت تخفیف هر مغازه در روز برای یک مشتری", Created = DateTime.Now, CreatedBy = sina.Id };
            ConstantDictionaries stores_max_donnation_point = new ConstantDictionaries { Id = Guid.NewGuid(), ConstantKey = "stores_max_donnation_point", ConstantValue = "500", IsActive = true, Description = "حداکثر امتیازی که فروشگاه میتواند در هر نوتب هدیه بدهد", Created = DateTime.Now, CreatedBy = sina.Id };
            ConstantDictionaries money_to_credit_ratio = new ConstantDictionaries { Id = Guid.NewGuid(), ConstantKey = "money_to_credit_ratio", ConstantValue = "500", IsActive = true, Description = "نسبت هر اعتبار به تومان", Created = DateTime.Now, CreatedBy = sina.Id };
            ConstantDictionaries credit_for_image_ads = new ConstantDictionaries { Id = Guid.NewGuid(), ConstantKey = "credit_for_image_ads", ConstantValue = "500", IsActive = true, Description = "اعتبار لازم برای ثبت آگهی تصویری", Created = DateTime.Now, CreatedBy = sina.Id };
            ConstantDictionaries credit_for_video_ads = new ConstantDictionaries { Id = Guid.NewGuid(), ConstantKey = "credit_for_video_ads", ConstantValue = "1000", IsActive = true, Description = "اعتبار لازم برای ثبت آگهی ویدئویی", Created = DateTime.Now, CreatedBy = sina.Id };
            ConstantDictionaries credit_for_client_registration_by_store_invitation = new ConstantDictionaries { Id = Guid.NewGuid(), ConstantKey = "credit_for_client_registration_by_store_invitation", ConstantValue = "50", IsActive = true, Description = "اعتبار برای فروشنده ای که باعث ثبت نام مشتری شد", Created = DateTime.Now, CreatedBy = sina.Id };
            ConstantDictionaries def_points_for_client_registration = new ConstantDictionaries { Id = Guid.NewGuid(), ConstantKey = "def_points_for_client_registration", ConstantValue = "100", IsActive = true, Description = "امتیاز اولیه برای کاربری که ثبت نام میکند.", Created = DateTime.Now, CreatedBy = sina.Id };
            ConstantDictionaries def_points_for_client_invitation = new ConstantDictionaries { Id = Guid.NewGuid(), ConstantKey = "def_points_for_client_invitation", ConstantValue = "50", IsActive = true, Description = "امتیاز برای معرف وقتی کاربر ثبت نام کرد.", Created = DateTime.Now, CreatedBy = sina.Id };
            ConstantDictionaries def_points_for_image_like = new ConstantDictionaries { Id = Guid.NewGuid(), ConstantKey = "def_points_for_image_like", ConstantValue = "1", IsActive = true, Description = "امتیاز پیش فرض برای لایک پست تصویری", Created = DateTime.Now, CreatedBy = sina.Id };
            ConstantDictionaries def_points_for_video_like = new ConstantDictionaries { Id = Guid.NewGuid(), ConstantKey = "def_points_for_video_like", ConstantValue = "4", IsActive = true, Description = "امتیاز پیش فرض برای لایک پست ویدئویی", Created = DateTime.Now, CreatedBy = sina.Id };
            ConstantDictionaries def_percent_for_marketer = new ConstantDictionaries { Id = Guid.NewGuid(), ConstantKey = "def_percent_for_marketer", ConstantValue = "10", IsActive = true, Description = "درصد بازاریاب", Created = DateTime.Now, CreatedBy = sina.Id };
            ConstantDictionaries def_percent_for_zoneadmin = new ConstantDictionaries { Id = Guid.NewGuid(), ConstantKey = "def_percent_for_zoneadmin", ConstantValue = "6", IsActive = true, Description = "درصد مدیر منطقه", Created = DateTime.Now, CreatedBy = sina.Id };
            ConstantDictionaries def_percent_for_countryadmin = new ConstantDictionaries { Id = Guid.NewGuid(), ConstantKey = "def_percent_for_countryadmin", ConstantValue = "4", IsActive = true, Description = "درصد مدیر مناطق", Created = DateTime.Now, CreatedBy = sina.Id };
            ConstantDictionaries def_chips_usage_perday = new ConstantDictionaries { Id = Guid.NewGuid(), ConstantKey = "def_chips_usage_perday", ConstantValue = "-1", IsActive = true, Description = "تعداد استفاده از کارت اعتباری هر کاربر در روز", Created = DateTime.Now, CreatedBy = sina.Id };
            ConstantDictionaries def_money_to_premium_video_ads = new ConstantDictionaries { Id = Guid.NewGuid(), ConstantKey = "def_money_to_premium_video_ads", ConstantValue = "200000", IsActive = true, Description = "هزینه درج آگهی تبلیغاتی ویدئویی", Created = DateTime.Now, CreatedBy = sina.Id };
            ConstantDictionaries def_money_to_premium_image_ads = new ConstantDictionaries { Id = Guid.NewGuid(), ConstantKey = "def_money_to_premium_image_ads", ConstantValue = "50000", IsActive = true, Description = "هزینه درج آگهی تبلیغاتی تصویری", Created = DateTime.Now, CreatedBy = sina.Id };
            ConstantDictionaries points_reward_premium_video_ads = new ConstantDictionaries { Id = Guid.NewGuid(), ConstantKey = "points_reward_premium_video_ads", ConstantValue = "200", IsActive = true, Description = "امتیاز ثبت آگهی تبلیغاتی ویدئویی", Created = DateTime.Now, CreatedBy = sina.Id };
            ConstantDictionaries points_reward_premium_image_ads = new ConstantDictionaries { Id = Guid.NewGuid(), ConstantKey = "points_reward_premium_image_ads", ConstantValue = "40", IsActive = true, Description = "امتیاز ثبت آگهی تبلیغاتی تصویری", Created = DateTime.Now, CreatedBy = sina.Id };
            

            modelBuilder.Entity<ConstantDictionaries>().HasData(store_default_credits_registration);
            modelBuilder.Entity<ConstantDictionaries>().HasData(store_point_usage_per_day);
            modelBuilder.Entity<ConstantDictionaries>().HasData(stores_max_donnation_point);
            modelBuilder.Entity<ConstantDictionaries>().HasData(money_to_credit_ratio);
            modelBuilder.Entity<ConstantDictionaries>().HasData(credit_for_image_ads);
            modelBuilder.Entity<ConstantDictionaries>().HasData(credit_for_video_ads);
            modelBuilder.Entity<ConstantDictionaries>().HasData(credit_for_client_registration_by_store_invitation);
            modelBuilder.Entity<ConstantDictionaries>().HasData(def_points_for_client_registration);
            modelBuilder.Entity<ConstantDictionaries>().HasData(def_points_for_client_invitation);
            modelBuilder.Entity<ConstantDictionaries>().HasData(def_points_for_image_like);
            modelBuilder.Entity<ConstantDictionaries>().HasData(def_points_for_video_like);
            modelBuilder.Entity<ConstantDictionaries>().HasData(def_percent_for_marketer);
            modelBuilder.Entity<ConstantDictionaries>().HasData(def_percent_for_zoneadmin);
            modelBuilder.Entity<ConstantDictionaries>().HasData(def_percent_for_countryadmin);
            modelBuilder.Entity<ConstantDictionaries>().HasData(def_chips_usage_perday);
            modelBuilder.Entity<ConstantDictionaries>().HasData(def_money_to_premium_video_ads);
            modelBuilder.Entity<ConstantDictionaries>().HasData(def_money_to_premium_image_ads);
            modelBuilder.Entity<ConstantDictionaries>().HasData(points_reward_premium_video_ads);
            modelBuilder.Entity<ConstantDictionaries>().HasData(points_reward_premium_image_ads);



            //DonnationTickets ticket_A = new DonnationTickets { Id = Guid.NewGuid(), Donner = dabouei.Id, RemainedCapacity = 2, Value = 150 };
            //DonnationTickets ticket_B = new DonnationTickets { Id = Guid.NewGuid(), Donner = dabouei.Id, RemainedCapacity = 5, Value = 100 };
            //modelBuilder.Entity<DonnationTickets>().HasData(ticket_A);
            //modelBuilder.Entity<DonnationTickets>().HasData(ticket_B);


        }


    }
}
