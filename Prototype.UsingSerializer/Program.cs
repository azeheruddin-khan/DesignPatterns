using System.Text.Json;

namespace Prototype.UsingSerializer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Id = 1;
            emp.Name = "Albert";
            emp.Address = new Address();
            emp.Address.City = "Agra";
            emp.Address.State = "Uttar Pradesh";
           

            Console.WriteLine("Employee 1: ");
            Console.WriteLine("Name: " + emp.Name + ", Address: City " + emp.Address.City + ", State: " + emp.Address.State);

            Employee? empClone = emp.Clone();

            if (empClone != null)
            {

                Console.WriteLine("Employee Clone: ");
                Console.WriteLine("Name: " + empClone.Name + ", Address: City: " + empClone.Address.City + ", State: " + empClone.Address.State);


                empClone.Id = 2;
                empClone.Name = "Albert 2";
                empClone.Address.City = "Hyderabad";
                empClone.Address.State = "Telangana";

                Console.WriteLine("Employee 1:After update ");
                Console.WriteLine("Name: " + emp.Name + ", Address: City " + emp.Address.City + ", State: " + emp.Address.State);

                Console.WriteLine("Employee Clone:After update ");
                Console.WriteLine("Name: " + empClone.Name + ", Address: City: " + empClone.Address.City + ", State: " + empClone.Address.State);

            }
        }


    }

    public static class ExtensionMethod
    {
        public static Employee? Clone(this Employee emp)
        {
            var serialized = JsonSerializer.Serialize(emp);
            var empClone = JsonSerializer.Deserialize<Employee>(serialized);
            return empClone;
        }
    }
}
