using System.Net.Http.Headers;

namespace Builder.RealtimeExample
{
    public class PremiumLaptopBuilder : Builder
    {
        private Laptop laptop = new Laptop();
        public override void AddCPU()
        {
            laptop.AddParts("CPU - Intel");
        }

        public override void AddExtraKeyboard()
        {
            laptop.AddParts("USB Keyboard");
        }

        public override void AddFrame()
        {
            laptop.AddParts("Black Carbon body");
        }

        public override void AddMemory()
        {
            laptop.AddParts("Hard Disk - 1TB");
        }

        public override void AddMotherBoard()
        {
            laptop.AddParts("Motherboard -Intel");
        }

        public override void AddMouse()
        {
            laptop.AddParts("USB Mouse");
        }

        public override void AddRAM()
        {
            laptop.AddParts("RAM - 16 GB");
        }
        public override Laptop GetLaptop()
        {
            return laptop;
        }
    }
}
