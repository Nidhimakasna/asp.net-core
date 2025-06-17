//3. Write program to prompt a user to input his/her name and country name  and then output will be shown as given: Hello<yourname> from country <countryname> 

Console.WriteLine("enter Your Name");
String Name = Convert.ToString(Console.ReadLine());
Console.WriteLine("enter Country Name");
String Country = Convert.ToString(Console.ReadLine());
Console.WriteLine($" Hello {Name} From Country {Country}");
