interface IGross
{
    double gross_sal();
}
public class EmployeeSalary
{
    public double DRA, TA, DA, basic;
    public EmployeeSalary(double DRA, double TA, double DA, double basic)
    {
        this.DRA = DRA;
        this.TA = TA;
        this.DA = DA;
        this.basic = basic;
    }

    public double disp_sal()
    {
        return DRA + TA + DA + basic;
    }

}
public class Employee : EmployeeSalary, IGross
{
    public string name;

    public Employee(double DRA, double TA, double DA, double basic) : base(DRA, TA, DA, basic) { }


    public void basic_sal()
    {
        Console.WriteLine(gross_sal());
    }

    public double gross_sal()
    {
        return disp_sal();
    }
}