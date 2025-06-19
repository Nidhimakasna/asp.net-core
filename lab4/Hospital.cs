//4.Create a class Hospital with HospitalDetails() method.Create another     
//classes Apollo, Wockhardt, Gokul_Superspeciality which overrides     
//HospitalDetails() method. 

namespace lab4.lab4
{
    internal class Hospital
    {
        public virtual void HospitalDetails()
        {
            Console.WriteLine("Hospital Inforamation");
        }
    }
    class Apollo : Hospital
    {
        public override void HospitalDetails()
        {
             Console.WriteLine("Apollo Hospital:");
        }
    }
    class Wockhardt : Hospital
    {
        public override void HospitalDetails()
        {
        Console.WriteLine("Wockhardt Hospital: ");
        }
    }
    class Gokul_Superspeciality : Hospital
    {
        public override void HospitalDetails()
        {
            Console.WriteLine("Gokul_Superspeciality:");
        }
    }
}

