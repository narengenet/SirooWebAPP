﻿using Microsoft.EntityFrameworkCore;
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
        public DbSet<ConstantDictionaries>  ConstantDictionaries { get; set; }
        //public DbSet<RoleChangeRequests> RoleChangeRequests{ get; set; }
        //public DbSet<PrizesWinners> PrizesWinners { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Users sina = new Users { Id = Guid.NewGuid(), Name = "Sina", Family = "Jouybari", Cellphone = "09394125130", Username = "sinful", ProfileMediaURL= "uploads/2022/9/sina2.jpg" };
            Users mohsen = new Users { Id = Guid.NewGuid(), Name = "محسن", Family = "پردلان", Cellphone = "09111769591", Username = "vinona", ProfileMediaURL = "uploads/2022/9/99.jpg" };
            Users sepideh = new Users { Id = Guid.NewGuid(), Name = "سپیده", Family = "یاراحمدی", Cellphone = "09163681249", Username = "sepideh", ProfileMediaURL = "uploads/2022/9/photo.jpg" };
            Users abdolah = new Users { Id = Guid.NewGuid(), Name = "عبداله", Family = "سرپرست", Cellphone = "09112281237", Username = "abdolah", ProfileMediaURL = "uploads/2022/9/photo.jpg" };
            modelBuilder.Entity<Users>().HasData(sina);
            modelBuilder.Entity<Users>().HasData(mohsen);
            modelBuilder.Entity<Users>().HasData(sepideh);
            modelBuilder.Entity<Users>().HasData(abdolah);

            Roles role_superadmin = new Roles { Id = Guid.NewGuid(), RoleName = "super", IsActivated = true, RoleDescription = "مدیر کل", Priority=0 };
            Roles role_admin = new Roles { Id = Guid.NewGuid(), RoleName = "admin", IsActivated = true, RoleDescription = "مدیر سامانه", Priority=1 };
            Roles role_zoneadmin = new Roles { Id = Guid.NewGuid(), RoleName = "zoneadmin", IsActivated = true, RoleDescription = "مدیر منطقه",Priority=2};
            Roles role_marketer = new Roles { Id = Guid.NewGuid(), RoleName = "marketer", IsActivated = true, RoleDescription = "بازاریاب", Priority=3 };
            Roles role_store = new Roles { Id = Guid.NewGuid(), RoleName = "store", IsActivated = true, RoleDescription = "فروشگاه",Priority=4 };
            Roles role_client = new Roles { Id = Guid.NewGuid(), RoleName = "client", IsActivated = true, RoleDescription = "مشتری",Priority=5 };
            modelBuilder.Entity<Roles>().HasData(role_superadmin);
            modelBuilder.Entity<Roles>().HasData(role_admin);
            modelBuilder.Entity<Roles>().HasData(role_zoneadmin);
            modelBuilder.Entity<Roles>().HasData(role_marketer);
            modelBuilder.Entity<Roles>().HasData(role_store);
            modelBuilder.Entity<Roles>().HasData(role_client);

            UsersRoles superadmin_sina = new UsersRoles { Id = Guid.NewGuid(), Role = role_superadmin.Id, User = sina.Id, CreatedBy = sina.Id };
            UsersRoles marketer_sepideh = new UsersRoles { Id = Guid.NewGuid(), Role = role_marketer.Id, User = sepideh.Id, CreatedBy = sina.Id };
            UsersRoles zoneadmin_mohsen = new UsersRoles { Id = Guid.NewGuid(), Role = role_zoneadmin.Id, User = mohsen.Id, CreatedBy = sina.Id };
            UsersRoles client_abdolah = new UsersRoles { Id = Guid.NewGuid(), Role = role_client.Id, User = abdolah.Id, CreatedBy = abdolah.Id };
            modelBuilder.Entity<UsersRoles>().HasData(superadmin_sina);
            modelBuilder.Entity<UsersRoles>().HasData(marketer_sepideh);
            modelBuilder.Entity<UsersRoles>().HasData(zoneadmin_mohsen);
            modelBuilder.Entity<UsersRoles>().HasData(client_abdolah);

            modelBuilder.Entity<Advertise>().HasData(new Advertise { Id=Guid.NewGuid(),Owner=sina.Id, Caption="کیش کدپولو", Name="کیش", IsVideo=true, LikeReward=200, ViewReward=4, ViewQuota=100, RemainedViewQuota=100, MediaSourceURL= "uploads/2022/9/1-56192-4_6008031941360618419.MP4",IsAvtivated=true, CreatedBy=sina.Id, CreationDate=DateTime.Now.AddDays(-1)});
            modelBuilder.Entity<Advertise>().HasData(new Advertise { Id = Guid.NewGuid(), Owner=mohsen.Id, Caption="ال جی", Name="کیش", IsVideo=false, LikeReward=20, ViewReward=4, ViewQuota=100, RemainedViewQuota=100, MediaSourceURL= "uploads/2022/9/1-53754-1.mp4_snapshot_01.04_[2022.05.26_09.50.52].jpg", IsAvtivated = true, CreatedBy = sina.Id, CreationDate = DateTime.Now.AddDays(-2) });
            modelBuilder.Entity<Advertise>().HasData(new Advertise { Id = Guid.NewGuid(), Owner=sepideh.Id, Caption="سامسونگ", Name="کیش", IsVideo=false, LikeReward=50, ViewReward=4, ViewQuota=100, RemainedViewQuota=100, MediaSourceURL= "uploads/2022/9/1582619178545.jpg", IsAvtivated = true, CreatedBy = sina.Id, CreationDate = DateTime.Now.AddDays(-5) });
            modelBuilder.Entity<Advertise>().HasData(new Advertise { Id = Guid.NewGuid(), Owner=sina.Id, Caption="دیجی کالا", Name="کیش", IsVideo=false, LikeReward=40, ViewReward=4, ViewQuota=100, RemainedViewQuota=100, MediaSourceURL= "uploads/2022/9/1-36433-1.jpg", IsAvtivated = true, CreatedBy = sina.Id, CreationDate = DateTime.Now.AddDays(-3) });

            Draws draw_a = new Draws { Id = Guid.NewGuid(), Name = "آبان 1401", Created = DateTime.Now, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(15), CreatedBy = sina.Id, IsActivated = true, IsFinished = false, IsLottery = false, Owner=sina.Id };
            Draws draw_b = new Draws { Id = Guid.NewGuid(), Name = "اذر 1401", Created = DateTime.Now, StartDate = DateTime.Now.AddDays(30), EndDate = DateTime.Now.AddDays(60), CreatedBy = sina.Id, IsActivated = true, IsFinished = false, IsLottery = false, Owner=sepideh.Id };
            Draws draw_c = new Draws { Id = Guid.NewGuid(), Name = "شهریور 1401", Created = DateTime.Now, StartDate = DateTime.Now.AddDays(-30), EndDate = DateTime.Now.AddDays(-10), CreatedBy = sina.Id, IsActivated = true, IsFinished = true, IsLottery = false, Owner=mohsen.Id };
            modelBuilder.Entity<Draws>().HasData(draw_a);
            modelBuilder.Entity<Draws>().HasData(draw_b);
            modelBuilder.Entity<Draws>().HasData(draw_c);

            Prizes prize_a_one = new Prizes { Id = Guid.NewGuid(), Name = "200 هزار تومان", Draw = draw_a.Id, IsActivated = true, Priority = 0, WinnerCount = 5, Created = DateTime.Now, CreatedBy = sina.Id };
            Prizes prize_a_two = new Prizes { Id = Guid.NewGuid(), Name = "100 هزار تومان", Draw = draw_a.Id, IsActivated = true, Priority = 1, WinnerCount = 10, Created = DateTime.Now, CreatedBy = sina.Id };
            Prizes prize_a_three = new Prizes { Id = Guid.NewGuid(), Name = "50 هزار تومان", Draw = draw_a.Id, IsActivated = true, Priority = 2, WinnerCount = 15, Created = DateTime.Now, CreatedBy = sina.Id };
            modelBuilder.Entity<Prizes>().HasData(prize_a_one);
            modelBuilder.Entity<Prizes>().HasData(prize_a_two);
            modelBuilder.Entity<Prizes>().HasData(prize_a_three);

            Prizes prize_b_one = new Prizes { Id = Guid.NewGuid(), Name = "2 میلیون تومان", Draw = draw_b.Id, IsActivated = true, Priority = 0, WinnerCount = 5, Created = DateTime.Now, CreatedBy = sina.Id };
            Prizes prize_b_two = new Prizes { Id = Guid.NewGuid(), Name = "1 میلیون تومان", Draw = draw_b.Id, IsActivated = true, Priority = 1, WinnerCount = 10, Created = DateTime.Now, CreatedBy = sina.Id };
            Prizes prize_b_three = new Prizes { Id = Guid.NewGuid(), Name = "500 هزار تومان", Draw = draw_b.Id, IsActivated = true, Priority = 2, WinnerCount = 15, Created = DateTime.Now, CreatedBy = sina.Id };
            modelBuilder.Entity<Prizes>().HasData(prize_b_one);
            modelBuilder.Entity<Prizes>().HasData(prize_b_two);
            modelBuilder.Entity<Prizes>().HasData(prize_b_three);
            
            Prizes prize_c_one = new Prizes { Id = Guid.NewGuid(), Name = "20 میلیون تومان", Draw = draw_c.Id, IsActivated = true, Priority = 0, WinnerCount = 5, Created = DateTime.Now, CreatedBy = sina.Id };
            Prizes prize_c_two = new Prizes { Id = Guid.NewGuid(), Name = "10 میلیون تومان", Draw = draw_c.Id, IsActivated = true, Priority = 1, WinnerCount = 10, Created = DateTime.Now, CreatedBy = sina.Id };
            Prizes prize_c_three = new Prizes { Id = Guid.NewGuid(), Name = "500 هزار تومان", Draw = draw_c.Id, IsActivated = true, Priority = 2, WinnerCount = 15, Created = DateTime.Now, CreatedBy = sina.Id };
            modelBuilder.Entity<Prizes>().HasData(prize_c_one);
            modelBuilder.Entity<Prizes>().HasData(prize_c_two);
            modelBuilder.Entity<Prizes>().HasData(prize_c_three);

            ConstantDictionaries store_default_credits_registration = new ConstantDictionaries {Id=Guid.NewGuid(), ConstantKey = "store_def_credit_reg", ConstantValue = "1000", IsActive = true, Description = "اعتبار اولیه فروشگاه برای ثبت نام اولین بار", Created = DateTime.Now, CreatedBy=sina.Id };
            ConstantDictionaries store_point_usage_per_day = new ConstantDictionaries {Id=Guid.NewGuid(), ConstantKey = "store_point_usage_per_day", ConstantValue = "2", IsActive = true, Description = "تعداد دفعات استفاده از کارت تخفیف هر مغازه در روز برای یک مشتری", Created = DateTime.Now, CreatedBy=sina.Id };
            ConstantDictionaries stores_max_donnation_point = new ConstantDictionaries {Id=Guid.NewGuid(), ConstantKey = "stores_max_donnation_point", ConstantValue = "500", IsActive = true, Description = "حداکثر امتیازی که فروشگاه میتواند در هر نوتب هدیه بدهد", Created = DateTime.Now, CreatedBy=sina.Id };
            ConstantDictionaries money_to_credit_ratio = new ConstantDictionaries {Id=Guid.NewGuid(), ConstantKey = "money_to_credit_ratio", ConstantValue = "50", IsActive = true, Description = "نسبت هر اعتبار به تومان", Created = DateTime.Now, CreatedBy=sina.Id };
            ConstantDictionaries credit_for_image_ads = new ConstantDictionaries {Id=Guid.NewGuid(), ConstantKey = "credit_for_image_ads", ConstantValue = "500", IsActive = true, Description = "اعتبار لازم برای ثبت آگهی تصویری", Created = DateTime.Now, CreatedBy=sina.Id };
            ConstantDictionaries credit_for_video_ads = new ConstantDictionaries {Id=Guid.NewGuid(), ConstantKey = "credit_for_video_ads", ConstantValue = "1000", IsActive = true, Description = "اعتبار لازم برای ثبت آگهی تصویری", Created = DateTime.Now, CreatedBy=sina.Id };
            
            modelBuilder.Entity<ConstantDictionaries>().HasData(store_default_credits_registration);
            modelBuilder.Entity<ConstantDictionaries>().HasData(store_point_usage_per_day);
            modelBuilder.Entity<ConstantDictionaries>().HasData(stores_max_donnation_point);
            modelBuilder.Entity<ConstantDictionaries>().HasData(money_to_credit_ratio);
            modelBuilder.Entity<ConstantDictionaries>().HasData(credit_for_image_ads);
            modelBuilder.Entity<ConstantDictionaries>().HasData(credit_for_video_ads);


        }


    }
}
