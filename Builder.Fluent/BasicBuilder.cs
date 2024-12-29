namespace Builder.Fluent
{
    public class BasicBuilder : IBuilder
    {
        private Laptop laptop = new Laptop();
        public IBuilder AddCPU()
        {
            laptop.AddPart("Added CPU");
            return this;
        }

        public IBuilder AddHardDisk()
        {
            laptop.AddPart("Added HardDisk ");
            return this;
        }

        public IBuilder AddMonitor()
        {
            laptop.AddPart("Added Monitor ");
            return this;
        }

        public IBuilder AddMotherBoard()
        {
            laptop.AddPart("Added MotherBoard ");
            return this;
        }

        public IBuilder AddRAM()
        {
            laptop.AddPart("Added RAM");
            return this;
        }

        public Laptop Build()
        {
            return laptop;
        }
    }
}
