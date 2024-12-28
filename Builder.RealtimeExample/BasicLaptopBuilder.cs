using System.Net.Http.Headers;

namespace Builder.RealtimeExample
{
    public class BasicLaptopBuilder : Builder
    {
        private Laptop laptop = new Laptop();
        public override void AddCPU()
        {
            laptop.AddParts("CPU - Intel");
        }

        public override void AddExtraKeyboard()
        {
            
        }

        public override void AddFrame()
        {
            laptop.AddParts("Black Carbon body");
        }

        public override void AddMemory()
        {
            laptop.AddParts("Hard Disk - 500GB");
        }

        public override void AddMotherBoard()
        {
            laptop.AddParts("Motherboard -Intel");
        }

        public override void AddMouse()
        {
           
        }

        public override void AddRAM()
        {
            laptop.AddParts("RAM - 4 GB");
        }
        public override Laptop GetLaptop()
        {
            return laptop;
        }
    }
}
