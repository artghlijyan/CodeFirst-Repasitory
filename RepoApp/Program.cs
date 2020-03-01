using DbRepasitory.Models;
using DbRepasitory.Repasitories.Impl;
using System;
using System.Linq;

namespace ReppoApp
{
    class Program
    {
        // TODO - Paramsov AddRange chi anum
        //TODO - chi haskanum vor method@ kanchi, inch anel?
        static void Main(string[] args)
        {
            using (DbRepasitory<User> userRepo = new DbRepasitory<User>(ConnectionStrings.HomeSqlConString))
            {
                User user = new User()
                {
                    Name = "Karen",
                    Age = 19,
                };

                User user1 = new User()
                {
                    Name = "Lilit",
                    Age = 22,
                };

                User[] userisk = { user, user1 };
                userRepo.AddRange(userisk);
                userRepo.SaveChanges();

                var users = userRepo.AsEnumerable().ToList();
                foreach (var us in users)
                {
                    Console.WriteLine(us);
                }
            }
        }
    }
}
