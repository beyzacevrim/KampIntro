namespace ClassIntro
{
    class Program
    {
        public static void Main(string[] args)
        {
            string name = "engin"; 
            int age = 36;


            Course course1 = new Course();   
            course1.CourseName = "A";
            course1.CourseTeacher = "Engin demiroğ";
            course1.CourseScore = 8;

            Course course2 = new("B", "Engin demiroğ", 7);
            Course course3 = new("C", "Engin demiroğ", 9);

            Course[] courses = new Course[] { course1, course2, course3 };

            foreach (Course course in courses) 
            { 
                Console.WriteLine(course.CourseName);
                Console.WriteLine(course.CourseTeacher);
                Console.WriteLine(course.CourseScore);
                Console.WriteLine();  

            }
        }
    }

    class Course
    {
        //properties
        public string? CourseName { get; set; }
        public string? CourseTeacher { get; set; }
        public int CourseScore { get; set; }

        //constructer
        public Course() { }
        public Course(string CourseName, string CourseTeacher, int CourseScore) 
        {
            this.CourseName = CourseName;
            this.CourseTeacher = CourseTeacher;
            this.CourseScore = CourseScore;
        }
    }

}