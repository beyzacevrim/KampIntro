using System;

namespace Loops
{

    class Program
    {
        public static void Main(string[] args)
        {
            string[] courses = new string[] {"OOP", "JAVA", "C#"};


            for (int i = 0; i < courses.Length; i++) 
            {
                Console.WriteLine(courses[i]);
            }

            foreach (string course in courses) 
            { 
                Console.WriteLine(course);
            }   

        }
    }
}