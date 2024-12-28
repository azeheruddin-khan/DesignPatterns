
namespace Prototype.ShallowDeepCopyExample.ShallowCopy
{
    public class Employee 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }

        public Employee Clone()
        {
            return (Employee)this.MemberwiseClone();
        }
    }
}
