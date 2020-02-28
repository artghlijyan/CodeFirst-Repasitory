using DbRepasitory.Models;
using DbRepasitory.Repasitories.Impl;
using System;
using System.Collections;
using System.Linq;

// AddRange(), RemoveRange(), UpdateRange(),
namespace ReppoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (DbRepasitory<User> userRepo = new DbRepasitory<User>(ConnectionStrings.HomeSqlConString))
            {
                User user = new User()
                {
                    Name = "Ashot",
                    Age = 38,
                };

                var user1 = userRepo.AsEnumerable().First();
                Console.WriteLine(user1);

                userRepo.Remove(user);
                userRepo.SaveChanges();


                var users = userRepo.AsEnumerable().ToList();
                foreach (var us in users)
                {
                    Console.WriteLine(us);
                }
            }

            //Console.WriteLine("Adding");
            //
            //using (SqlDbContext db = new SqlDbContext())
            //{
            //    User user1 = new User { Name = "Hakob", Age = 24 };
            //    User user2 = new User { Name = "Norik", Age = 45 };

            //    db.Users.Add(user1);
            //    db.Users.Add(user2);
            //    db.SaveChanges();
            //}

            //Console.WriteLine("ToScreen");
            //using (AppContext db = new AppContext())
            //{
            //    var users = db.Users.ToList();
            //    foreach (User u in users)
            //    {
            //        Console.WriteLine($"{u.UserId}.{u.Name} - {u.Age}");
            //    }
            //}

            //Console.WriteLine("Editing");
            //using (AppContext db = new AppContext())
            //{
            //    User user = db.Users.FirstOrDefault();

            //    if (user != null)
            //    {
            //        user.Name = "Lilit";
            //        user.Age = 29;
            //db.Users.Update(user);
            //    }
            //        db.SaveChanges();

            //    Console.WriteLine("ToScreen");
            //    var users = db.Users.ToList();
            //    foreach (User u in users)
            //    {
            //        Console.WriteLine($"{u.UserId}.{u.Name} - {u.Age}");
            //    }
            //}

            //Console.WriteLine("Deleting");
            //using (AppContext db = new AppContext())
            //{
            //    User user = db.Users.FirstOrDefault();

            //    if (user != null)
            //    {
            //        db.Users.Remove(user);
            //        db.SaveChanges();
            //    }

            //    Console.WriteLine("ToScreen");
            //    var users = db.Users.ToList();
            //    foreach (User u in users)
            //    {
            //        Console.WriteLine($"{u.UserId}.{u.Name} - {u.Age}");
            //    }
            //}

            Console.Read();
        }
    }
}
