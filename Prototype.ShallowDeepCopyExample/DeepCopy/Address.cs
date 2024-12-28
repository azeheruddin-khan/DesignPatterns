namespace Prototype.ShallowDeepCopyExample.DeepCopy
{
    public class Address
    {
        public string City { get; set; }
        public string State { get; set; }

        public Address Clone()
        {
            return (Address)this.MemberwiseClone();
        }
    }
}
