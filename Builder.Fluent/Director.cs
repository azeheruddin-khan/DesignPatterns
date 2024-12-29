namespace Builder.Fluent
{
    public class Director
    {
        public Laptop Construct(IBuilder builder)
        {
            return builder.AddMotherBoard()
                 .AddRAM()
                 .AddCPU()
                 .AddHardDisk()
                 .AddMonitor()
                 .Build();

        }
    }
}
