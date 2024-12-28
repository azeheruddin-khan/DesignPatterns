namespace Builder.RealtimeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Builder builder = new BasicLaptopBuilder();
            Director director = new Director();
            director.Construct(builder);
            Laptop laptop = builder.GetLaptop();
            laptop.Show();

            Builder premiumLaptopBuilder = new PremiumLaptopBuilder();           
            director.Construct(premiumLaptopBuilder);
            Laptop premiumLaptop = premiumLaptopBuilder.GetLaptop();
            premiumLaptop.Show();



        }
    }
}
