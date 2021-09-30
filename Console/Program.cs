using Business.Concrete;
using System;

namespace Presentation
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
