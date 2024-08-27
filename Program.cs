using System;
namespace LOPVADOITUONG
{
    public class Student
    {
        int rollno;
        string name;
        static string college = "ABC";
        public Student(int r, string n)
        {
            name = n;
            rollno = r;
        }
        public static void Change()
        {
            college = "CODEGYM";
        }
        public void Display()
        {
            Console.WriteLine($"{rollno} {name} {college}");
        }
    }
    public class TestStaticMethod
    {
        public static void Main(string[] args)
        {
            Student.Change();
            Console.WriteLine("Enter rollno and name:");
            int rn = Convert.ToInt32(Console.ReadLine());
            string n = Console.ReadLine();
            Student student = new Student(rn, n);
            student.Display();
        }
    }
}