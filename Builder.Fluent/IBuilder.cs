namespace Builder.Fluent
{
    public interface IBuilder
    {
        IBuilder AddMotherBoard();
        IBuilder AddRAM();
        IBuilder AddHardDisk();
        IBuilder AddCPU();
        IBuilder AddMonitor();
        Laptop Build();

    }
}
