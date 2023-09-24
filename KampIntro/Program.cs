using System;

namespace KampIntro
{

    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Yazılım Geliştirici Yetiştirme Kampı.");
            //kod yazarken kendini tekrarlama

            //type safety

            //string categoryTag = "";
            //int numberOfStudents = 32145;
            //double interstRates = 1.456;
            bool loggedIn = true;
            double usdPre = 21.48;
            double usdNow = 25.24;

            if (usdPre > usdNow)
            {
                Console.WriteLine("Decrementation button");
            }
            else if (usdPre < usdNow)
            {
                Console.WriteLine("Incrementation button");
            }
            else
            {
                Console.WriteLine("No changes button");
            }


            if (loggedIn == true)
            {
                Console.WriteLine("User's settings button");
            }
            else
            {
                Console.WriteLine("Login button");
            }

        }
    }
}