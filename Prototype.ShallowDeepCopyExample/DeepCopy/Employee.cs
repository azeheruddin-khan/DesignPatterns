
namespace Prototype.ShallowDeepCopyExample.DeepCopy
{
    public class Employee 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }

        public Employee Clone()
        {
            Employee emp = (Employee)this.MemberwiseClone();
            emp.Address = Address.Clone();
            return emp;
        }
    }
}
