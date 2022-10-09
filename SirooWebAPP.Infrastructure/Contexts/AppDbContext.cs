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
        //public DbSet<PrizesWinners> PrizesWinners { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Users sina = new Users { Id = Guid.NewGuid(), Name = "Sina", Family = "Jouybari", Cellphone = "09394125130", Username = "sinful", ProfileMediaURL= "uploads/2022/9/sina2.jpg" };
            Users mohsen = new Users { Id = Guid.NewGuid(), Name = "محسن", Family = "پردلان", Cellphone = "09111769591", Username = "vinona", ProfileMediaURL = "uploads/2022/9/99.jpg" };
            Users sepideh = new Users { Id = Guid.NewGuid(), Name = "سپیده", Family = "یاراحمدی", Cellphone = "09163681249", Username = "sepideh", ProfileMediaURL = "uploads/2022/9/photo.jpg" };
            modelBuilder.Entity<Users>().HasData(sina);
            modelBuilder.Entity<Users>().HasData(mohsen);
            modelBuilder.Entity<Users>().HasData(sepideh);

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
            UsersRoles admin_sina = new UsersRoles { Id = Guid.NewGuid(), Role = role_admin.Id, User = sina.Id, CreatedBy = sina.Id };
            UsersRoles marketer_sina = new UsersRoles { Id = Guid.NewGuid(), Role = role_marketer.Id, User = sina.Id, CreatedBy = sina.Id };
            UsersRoles marketer_sepideh = new UsersRoles { Id = Guid.NewGuid(), Role = role_marketer.Id, User = sepideh.Id, CreatedBy = sina.Id };
            UsersRoles zoneadmin_mohsen = new UsersRoles { Id = Guid.NewGuid(), Role = role_zoneadmin.Id, User = mohsen.Id, CreatedBy = sina.Id };
            modelBuilder.Entity<UsersRoles>().HasData(superadmin_sina);
            modelBuilder.Entity<UsersRoles>().HasData(admin_sina);
            modelBuilder.Entity<UsersRoles>().HasData(marketer_sina);
            modelBuilder.Entity<UsersRoles>().HasData(marketer_sepideh);
            modelBuilder.Entity<UsersRoles>().HasData(zoneadmin_mohsen);

            modelBuilder.Entity<Advertise>().HasData(new Advertise { Id=Guid.NewGuid(),Owner=sina.Id, Caption="کیش کدپولو", Name="کیش", IsVideo=true, LikeReward=200, ViewReward=4, ViewQuota=100, RemainedViewQuota=100, MediaSourceURL= "uploads/2022/9/1-56192-4_6008031941360618419.MP4",IsAvtivated=true, CreatedBy=sina.Id, CreationDate=DateTime.Now.AddDays(-1)});
            modelBuilder.Entity<Advertise>().HasData(new Advertise { Id = Guid.NewGuid(), Owner=mohsen.Id, Caption="ال جی", Name="کیش", IsVideo=false, LikeReward=20, ViewReward=4, ViewQuota=100, RemainedViewQuota=100, MediaSourceURL= "uploads/2022/9/1-53754-1.mp4_snapshot_01.04_[2022.05.26_09.50.52].jpg", IsAvtivated = true, CreatedBy = sina.Id, CreationDate = DateTime.Now.AddDays(-2) });
            modelBuilder.Entity<Advertise>().HasData(new Advertise { Id = Guid.NewGuid(), Owner=sepideh.Id, Caption="سامسونگ", Name="کیش", IsVideo=false, LikeReward=50, ViewReward=4, ViewQuota=100, RemainedViewQuota=100, MediaSourceURL= "uploads/2022/9/1582619178545.jpg", IsAvtivated = true, CreatedBy = sina.Id, CreationDate = DateTime.Now.AddDays(-5) });
            modelBuilder.Entity<Advertise>().HasData(new Advertise { Id = Guid.NewGuid(), Owner=sina.Id, Caption="دیجی کالا", Name="کیش", IsVideo=false, LikeReward=40, ViewReward=4, ViewQuota=100, RemainedViewQuota=100, MediaSourceURL= "uploads/2022/9/1-36433-1.jpg", IsAvtivated = true, CreatedBy = sina.Id, CreationDate = DateTime.Now.AddDays(-3) });


        }


    }
}
