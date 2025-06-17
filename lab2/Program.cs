
using practical.lab2;

namespace labwork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a program number:\n1]Candidate\n2]Staff \n3]BankAccount\n4]StudentDetail\n5]AreaOfRectangle\n6]Account_Detail\n7]Salary\n8]Distance\n9]Furniture\n10]Gross");
            int n=Convert.ToInt32(Console.ReadLine());
           
            switch(n)
            {
                case 1: 
                       Candidate candidate= new Candidate();
                       candidate.GetCandidateDetails();
                       candidate.DisplayCandidateDetails();
                       break;
                case 2:
                        Staff staff = new Staff();
                        Staff[] s = new Staff[2];
                        for (int i = 0; i < 2; i++)
                        {
                            s[i] = new Staff();
                            s[i].GetStaff();
                        }
                        for (int i = 0; i < 2; i++)
                        {
                            s[i].SetDisplay();
                        }
                        break;

                case 3:
                        Bank_Account bankAccount = new Bank_Account();
                        bankAccount.GetAccountDetails();
                        bankAccount.DisplayAccountDetails();
                        break;

                case 4:
                        Console.Write("Enter Enrollment No: ");
                        string enrollmentNo = Console.ReadLine();

                        Console.Write("Enter Student Name: ");
                        string studentName = Console.ReadLine();

                        Console.Write("Enter Semester: ");
                        int semester = int.Parse(Console.ReadLine());

                        Console.Write("Enter CPI: ");
                        double cpi = double.Parse(Console.ReadLine());

                        Console.Write("Enter SPI: ");
                        double spi = double.Parse(Console.ReadLine());

                        Student student = new Student(enrollmentNo, studentName, semester, cpi, spi);
                        student.DisplayStudentDetails();
                        break;
                case 5:
                        Console.WriteLine("enter a length:");
                        double length = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("enter a width:");
                        double width = Convert.ToDouble(Console.ReadLine());

                        Rectangle ractangle = new Rectangle(length, width);
                        ractangle.DisplayArea();
                       break;
                case 6:
                        Interest interest = new Interest();
                        interest.GetAccountDetails();
                        interest.CalculateInterest();
                        break;
                    
                case 7:
                        Console.WriteLine("enter Basic:");
                        double basic = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("enter TA:");
                        double ta = Convert.ToDouble(Console.ReadLine());
                        Salary salary = new Salary(basic,ta);
                        salary.DispalyTotalDetail();
                        break;
                case 8:
                        Console.WriteLine("enter a first distance:");
                        double d1= Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("enter a sec distance:");
                        double d2= Convert.ToDouble(Console.ReadLine());
                        Distance distance = new Distance(d1,d2);
                        distance.AddDistance();
                        distance.DisplayDistance();
                        break;

                case 9:
                        Console.WriteLine("enter a Material :");
                        string material=Console.ReadLine();
                        Console.WriteLine("enter a Price");
                        double price= Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter a Heigth");
                        double heigth=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter a Surface_area");
                        double surface_area=Convert.ToInt32(Console.ReadLine());
                        Table table = new Table(material,price,heigth,surface_area);
                        table.DisplayTabInfo();
                        break;

                case 10:
                        SalaryCal salaryCal = new SalaryCal();
                         salaryCal.basic_sal();
                         salaryCal.Disp_sal();
                         salaryCal.Gross_sal();
                        break;


            }

        }
    }
}
