using System;

namespace Practical
{
    class Student
    {
        private int admissionNo;
        public string studentName;
        public int enrollmentNo;
        public string course;

        public void StudentDetails()
        {
            Console.WriteLine("\n--------- Enter Student Admission Details ---------");
            Console.Write("Enter Student Admission No: ");
            admissionNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Name: ");
            studentName = Console.ReadLine();

            Console.Write("Enter Student Enrollment No: ");
            enrollmentNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Course: ");
            course = Console.ReadLine();
        }

        public void DisplayDetails()
        {
            Console.WriteLine("\n========= Student Admission Details =========");
            Console.WriteLine("Admission No          : " + admissionNo);
            Console.WriteLine("Student Name          : " + studentName);
            Console.WriteLine("Student Enrollment No :" + enrollmentNo);
            Console.WriteLine("Course                : " + course);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.StudentDetails();
            s1.DisplayDetails();

            Console.WriteLine("\nAdmission Successful!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
