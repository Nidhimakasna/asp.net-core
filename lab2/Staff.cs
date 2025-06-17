//2.Write a program to create a class Staff having data members as Name,
//Department, Designation, Experience & Salary. Accept this data for 5 
//different staffs and display only names & salary of those staff who are      
//HOD. 
namespace practical.lab2
{
    internal class Staff
    {
        
        public string name;
        public string Department;
        public string Designation;
        public int Experience;
        public double Salary;
       
        public void GetStaff()
        {
            
            Console.WriteLine("enter a name:");
            name = Console.ReadLine();
            Console.WriteLine("enter a Department:");
            Department = Console.ReadLine();
            Console.WriteLine("enter a Designation :");
            Designation =Console.ReadLine();
            Console.WriteLine("enter a Experience:");
            Experience = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a  Salary:");
            Salary = Convert.ToDouble(Console.ReadLine());
          

        }

        public void SetDisplay()
        {
            if(Department=="HOD" || Department == "hod")
            {
                Console.WriteLine($" name is{name}");
                Console.WriteLine($" Experience is{Salary}"); 
            }
        }

    }
}

