//7.Write a program to Define a class Salary which will contain member 
//variable Basic, TA, DA, HRA. Write a program using Constructor with default
//values for DA and HRA and calculate the salary of employee. 

namespace practical.lab2
{
    internal class Salary
    {
        public  double Basic;
        public double TA;
        public double DA;
        public double HRA;

        public Salary(double basic,double ta,double da=0.10,double hra=0.15) {
            Basic = basic;
            TA = ta;
            DA = basic * da;
            HRA=basic * hra;
               
        }
       
        public double CalculateTotalSalary(){
            return Basic+TA+DA+HRA;
        }

        public void DispalyTotalDetail() {
            Console.WriteLine("Basic: " + Basic);
            Console.WriteLine("TA: " + TA);
            Console.WriteLine("DA: " + DA);
            Console.WriteLine("HRA: " + HRA);
            Console.WriteLine("Total Salary: " + CalculateTotalSalary());
        }

    }
}
