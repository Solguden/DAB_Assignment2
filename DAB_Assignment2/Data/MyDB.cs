using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Model;

namespace WebApplication1.Data
{
    public class MyDB : DbContext
    {
        public DbSet<Restaurant> restaurants { get; set; }
        public DbSet<Waiter> waiters { get; set; }
        public DbSet<Table> tables { get; set; }
        public DbSet<Dish> dishes { get; set; }
        public DbSet<Guest> guests { get; set; }
        public DbSet<Review> reviews { get; set; }
        public DbSet<Person> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=MyDB.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        //public MyDB(DbContextOptions<MyDB> options) : base(options)
        //{
        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //Restaurant
        //    //Primary key definition
        //    modelBuilder.Entity<Restaurant>()
        //        .HasKey(s => s.Address);
        //    //Specifying required properties
        //    modelBuilder.Entity<Restaurant>()
        //        .Property(s => s.Name).IsRequired();
        //    modelBuilder.Entity<Restaurant>()
        //        .Property(s => s.Type).IsRequired();


        //    //Data seeding Restaurant
        //    modelBuilder.Entity<Restaurant>()
        //        .HasData(new Restaurant()
        //        {
        //            Address = "Ronald McDonald Street 6969",
        //            Name = "McDonalds",
        //            Type = "Hurtig-Mad",
        //        });
        //    modelBuilder.Entity<Restaurant>()
        //        .HasData(new Restaurant()
        //        {
        //            Address = "Sunset Boulevard 420",
        //            Name = "Burger King",
        //            Type = "Sund Hurtig-Mad",
        //        });

        //    //Table
        //    //Specifying required properties
        //    modelBuilder.Entity<Table>()
        //        .Property(s => s.Number).IsRequired();


        //    //Data seeding Table
        //    modelBuilder.Entity<Table>()
        //       .HasData(new Table()
        //       {
        //           Number = 10,
        //       });
        //    modelBuilder.Entity<Table>()
        //        .HasData(new Table()
        //        {
        //            Number = 20,
        //        });
        //    modelBuilder.Entity<Table>()
        //        .HasData(new Table()
        //        {
        //            Number = 30,
        //        });
        //    modelBuilder.Entity<Table>()
        //       .HasData(new Table()
        //       {
        //           Number = 40,
        //       });

        //    //Table
        //    //Specifying required properties
        //    modelBuilder.Entity<Review>()
        //        .Property(s => s.Stars).IsRequired();
        //    modelBuilder.Entity<Review>()
        //        .Property(s => s.Text).IsRequired();

        //    //Data seeding Review
        //    modelBuilder.Entity<Review>()
        //       .HasData(new Review()
        //       {
        //           Stars = 1,
        //           Text = "Jeg hader Hurtig-mad. Det var ikke hurtigt nok",
        //       });
        //    modelBuilder.Entity<Review>()
        //       .HasData(new Review()
        //       {
        //           Stars = 3,
        //           Text = "Jeg kan godt lide Hurtig-mad. Det kunne dog have været hurtigere",
        //       });
        //    modelBuilder.Entity<Review>()
        //       .HasData(new Review()
        //       {
        //           Stars = 5,
        //           Text = "Jeg elsker Hurtig-mad. Det var bare lyn-hurtigt! :)",
        //       });

        //    //Dish
        //    //Specifying required properties
        //    modelBuilder.Entity<Dish>()
        //        .Property(s => s.Price).IsRequired();
        //    modelBuilder.Entity<Dish>()
        //        .Property(s => s.Type).IsRequired();
        //    modelBuilder.Entity<Dish>()
        //        .Property(s => s.DishName).IsRequired();

        //    //Data seeding Review
        //    modelBuilder.Entity<Dish>()
        //      .HasData(new Dish()
        //      {
        //          Price = 9.95,
        //          DishName = "Cheese Burger",
        //          Type = "Coin Offer",
        //      });
        //    modelBuilder.Entity<Dish>()
        //      .HasData(new Dish()
        //      {
        //          Price = 36.95,
        //          DishName = "Happy Meal",
        //          Type = "Børne Menu",
        //      });

        //    modelBuilder.Entity<Dish>()
        //     .HasData(new Dish()
        //     {
        //         Price = 14.95,
        //         DishName = "Whopper",
        //         Type = "Langsom burger",
        //     });
        //    modelBuilder.Entity<Dish>()
        //    .HasData(new Dish()
        //    {
        //        Price = 29.95,
        //        DishName = "Double-Whopper",
        //        Type = "Lidt hurtigere burger",
        //    });

        //    //Waiter
        //    //Specifying required properties
        //    modelBuilder.Entity<Waiter>()
        //        .Property(s => s.Salary).IsRequired();

        //    //Data seeding Review
        //    modelBuilder.Entity<Waiter>()
        //      .HasData(new Waiter()
        //      {
        //          Salary = 2500,
        //      });
        //    modelBuilder.Entity<Waiter>()
        //     .HasData(new Waiter()
        //     {
        //         Salary = 2600,
        //     });
        //    modelBuilder.Entity<Waiter>()
        //     .HasData(new Waiter()
        //     {
        //         Salary = 2700,
        //     });
        //    modelBuilder.Entity<Waiter>()
        //     .HasData(new Waiter()
        //     {
        //         Salary = 2800,
        //     });

        //    //Waiter
        //    //Specifying required properties
        //    modelBuilder.Entity<Guest>()
        //        .Property(s => s.Time).IsRequired();

        //    //Data seeding Review
        //    modelBuilder.Entity<Guest>()
        //      .HasData(new Guest()
        //      {
        //          Time = new DateTime(2019,6,10),
        //      });
        //    modelBuilder.Entity<Guest>()
        //      .HasData(new Guest()
        //      {
        //          Time = new DateTime(2019, 7, 10),
        //      });
        //    modelBuilder.Entity<Guest>()
        //      .HasData(new Guest()
        //      {
        //          Time = new DateTime(2019, 8, 10),
        //      });
        //    modelBuilder.Entity<Guest>()
        //      .HasData(new Guest()
        //      {
        //          Time = new DateTime(2019, 9, 10),
        //      });

        //    //Person
        //    //Specifying required properties
        //    modelBuilder.Entity<Person>()
        //        .Property(s => s.Name).IsRequired();

        //    //Data seeding Review
        //    modelBuilder.Entity<Person>()
        //      .HasData(new Person()
        //      {
        //          Name = "Jeps Jepsemand",
        //      });
        //    modelBuilder.Entity<Person>()
        //      .HasData(new Person()
        //      {
        //          Name = "Jobs Jobsemand",
        //      });
        //    modelBuilder.Entity<Person>()
        //      .HasData(new Person()
        //      {
        //          Name = "Flobs Flobsemand",
        //      });
        //    modelBuilder.Entity<Person>()
        //      .HasData(new Person()
        //      {
        //          Name = "Muubs Megetsyg",
        //      });
        //    modelBuilder.Entity<Person>()
        //      .HasData(new Person()
        //      {
        //          Name = "Blobs Blobbermand",
        //      });
        //    modelBuilder.Entity<Person>()
        //      .HasData(new Person()
        //      {
        //          Name = "Djebs Djakketyv",
        //      });
        //    modelBuilder.Entity<Person>()
        //      .HasData(new Person()
        //      {
        //          Name = "Henrik DABsemand",
        //      });
        //    modelBuilder.Entity<Person>()
        //      .HasData(new Person()
        //      {
        //          Name = "Jørgen Ingenarm",
        //      });


        //}

    }
}
