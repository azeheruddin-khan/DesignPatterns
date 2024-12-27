namespace Prototype.Structural
{
    public class ConcretePrototype : Prototype
    {
        public ConcretePrototype(string id):base(id) 
        { 
        }
        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();       
        }
    }
}
