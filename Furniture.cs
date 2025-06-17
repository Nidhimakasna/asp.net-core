
//9.Create a class Furniture with material, price as data members.
//Create another class Table with Height, surface_area as data members.
// Write a program to implement single inheritance. 
namespace practical.lab2
{
    internal class Furniture
    {
        public string Material;
        public double Price;

        public Furniture(string material,double price)
        {
            Material = material;
            Price = price;  

        }

    }
    class Table : Furniture{
        public double Heigth;
        public double Surface_area;

        public Table(string material, double price,double heigth,double surface_area):base(material, price) 
        {
            Heigth = heigth;
            Surface_area = surface_area;
        }
        public void DisplayTabInfo()
        {
            
            Console.WriteLine("Material:" + Material);
            Console.WriteLine("Price:" + Price);
            Console.WriteLine("Heigth:" + Heigth);
            Console.WriteLine("Surface_area:"+Surface_area);
        }


    }
}
