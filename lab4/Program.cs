

using lab4.lab4;
namespace lab4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter a program number:\n1]Areas\n2].Addition\n3].BankRBI\n4].Hospital\n5].FindArea\n6].BankAccount");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("enter a value of side:");
                    int side = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter valu of length:");
                    int l = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter value of breadth:");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Area area = new Area();
                    int squarearea = area.area(side);
                    int reacarea = area.area(l, b);
                    Console.WriteLine("area of square:" + squarearea);
                    Console.WriteLine("area of rectangle:"+reacarea);
                    break;
                case 2:
                    Console.WriteLine("enter a value of int:");
                    int no1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter valu of int:");
                    int no2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter a value of float:");
                    float f1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("enter valu of float:");
                    float f2 = float.Parse(Console.ReadLine());
                    Addition addition = new Addition();
                    int add1 = addition.Add(no1, no2);
                    float add2 = addition.Add(f1, f2);
                    Console.WriteLine("Addition of int number:" + add1);
                    Console.WriteLine("Addition of float number:" + add2);
                    break;
                 case 3:

                    Console.WriteLine("Enter principal : ");
                    double principal = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter rate : ");
                    double rate = Convert.ToDouble(Console.ReadLine());


                    RBI bank;
                    bank = new RBI();
                    bank.CalculateInterest(principal, rate);
                    bank = new HDFC();
                    bank.CalculateInterest(principal, rate);  

                    bank = new SBI();
                    bank.CalculateInterest(principal, rate);  

                    bank = new ICICI();
                    bank.CalculateInterest(principal, rate);

                    break;
                 case 4:
                    Hospital hospital;
                    hospital = new Hospital();
                    hospital.HospitalDetails();
                    hospital = new Apollo();
                    hospital.HospitalDetails();
                    hospital = new Wockhardt();
                    hospital.HospitalDetails();
                    hospital=new Gokul_Superspeciality();
                    hospital.HospitalDetails();
                   
                    break;
                 case 5:
                    Console.WriteLine("enter a value of side:");
                    int s = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter valu of length:");
                    int l1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter value of breadth:");
                    int b1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter a radius");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    FindArea findArea = new FindArea();
                    int squarearea1 = findArea.Farea(s);
                    int reacarea1 = findArea.Farea(l1, b1);
                    double circlearea=findArea.Farea(radius);
                    Console.WriteLine("area of square:" + squarearea1);
                    Console.WriteLine("area of rectangle:" + reacarea1);
                    Console.WriteLine("area of circle:" + circlearea);
                    break;
                case 6:
                    
            
                    BankAccount account = new BankAccount(5000, "Nidhi Patel");

                    account.ShowDetails();

                    account.Deposit(1000);

                    account.Deposit("CHK12345", 2000);

                    account.Withdraw(1500);

                    account.Withdraw("CHK54321", 3000);

                    account.Withdraw(10000);

                    account.ShowDetails();
                    break;
            }
        }


    }
}
 
