namespace Builder.Structural
{
    public class ConcreteBuilder2:Builder
    {
        private Product product = new Product();
        public override void AddPartA()
        {
            product.AddPart("Part A");
        }

        public override void AddPartB()
        {
            product.AddPart("Part B");
        }


        public override Product GetProduct()
        {
            return product;
        }
    }
}
