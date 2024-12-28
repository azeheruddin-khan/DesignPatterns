using Prototype.ShallowDeepCopyExample.ShallowCopy;
using DeepCopy = Prototype.ShallowDeepCopyExample.DeepCopy;

namespace Prototype.ShallowDeepCopyExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ShallowCopy
                Employee emp = new Employee();
                emp.Id = 1;
                emp.Name = "Albert";
                emp.Address = new Address();
                emp.Address.City = "Agra";
                emp.Address.State = "Uttar Pradesh";

                Console.WriteLine("Employee 1: ");
                Console.WriteLine("Name: " + emp.Name + ", Address: City " + emp.Address.City + ", State: " + emp.Address.State);

                Employee empClone = emp.Clone();

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
            #endregion ShallowCopy

            #region DeepCopy
                Console.WriteLine("Deep Copy Example");
                DeepCopy.Employee emp2 = new DeepCopy.Employee();
                emp2.Id = 3;
                emp2.Name = "Robert";
                emp2.Address = new DeepCopy.Address();
                emp2.Address.City = "Mumbai";
                emp2.Address.State = "Maharashtra";

                Console.WriteLine("Employee:emp2 ");
                Console.WriteLine("Name: " + emp2.Name + ", Address: City " + emp2.Address.City + ", State: " + emp2.Address.State);

                DeepCopy.Employee empDeepClone = emp2.Clone();

                Console.WriteLine("Employee Clone: ");
                Console.WriteLine("Name: " + empDeepClone.Name + ", Address: City: " + empDeepClone.Address.City + ", State: " + empDeepClone.Address.State);


                empDeepClone.Id = 4;
                empDeepClone.Name = "Robert 2";
                empDeepClone.Address.City = "Chandigargh";
                empDeepClone.Address.State = "Punjab";

                Console.WriteLine("Employee emp2:After update ");
                Console.WriteLine("Name: " + emp2.Name + ", Address: City " + emp2.Address.City + ", State: " + emp2.Address.State);

                Console.WriteLine("Employee Clone:After update ");
                Console.WriteLine("Name: " + empDeepClone.Name + ", Address: City: " + empDeepClone.Address.City + ", State: " + empDeepClone.Address.State);

            #endregion ShallowCopy

        }
    }
}
