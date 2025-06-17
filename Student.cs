
//4.Write a program with following specifications:  
//Class Name: Student
//Data Members: Enrollment_No,Student_Name, Semester, CPI and SPI  
//Get Students Details using constructor and DisplayStudentDetails() using
//member function. 
namespace practical.lab2
{
    internal class Student
    {
        public string Enrollment_No;
        public string Student_Name;
        public int Semester;
        public double CPI;
        public double SPI;

        public Student(string enrollment_No, string student_Name, int semester, double cPI, double sPI)
        {
            Enrollment_No = enrollment_No;
            Student_Name = student_Name;
            Semester = semester;
            CPI = cPI;
            SPI = sPI;
        }

       
        public void DisplayStudentDetails()
        {
            Console.WriteLine("Student Details:");
            Console.WriteLine("Enrollment No: " + Enrollment_No);
            Console.WriteLine("Student Name: " + Student_Name);
            Console.WriteLine("Semester: " + Semester);
            Console.WriteLine("CPI: " + CPI);
            Console.WriteLine("SPI: " + SPI);
        }
    }
}
