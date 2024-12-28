namespace Builder.Structural
{
    public class Director
    {
        public void Construct(Builder builder)
        {
            builder.AddPartA();
            builder.AddPartB();
        }
    }
}
