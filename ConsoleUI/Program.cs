using Business.Concrete;
using Entity.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManager userManager = new UserManager();

            foreach (var user in userManager.GetAll())
            {
                Console.WriteLine(user.FirstName);
            }
        }
    }
}
