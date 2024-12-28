namespace Builder.RealtimeExample
{
    public abstract class Builder
    {
        public abstract void AddFrame();
        public abstract void AddMotherBoard();
        public abstract void AddCPU();
        public abstract void AddRAM();
        public abstract void AddMemory();
        public abstract void AddMouse();
        public abstract void AddExtraKeyboard();

        public abstract Laptop GetLaptop();
    }
}
