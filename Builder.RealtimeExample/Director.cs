namespace Builder.RealtimeExample
{
    public class Director
    {
        public void Construct(Builder builder)
        {
            builder.AddFrame();
            builder.AddMotherBoard();
            builder.AddCPU();
            builder.AddRAM();
            builder.AddMemory();
            builder.AddMouse();
            builder.AddExtraKeyboard();
        }
    }
}
