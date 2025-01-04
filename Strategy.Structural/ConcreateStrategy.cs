namespace Strategy.Structural
{
    public class ConcreateStrategy : Strategy
    {
        public override void Sort(List<string> list)
        {
            Console.WriteLine(this.GetType().Name +" Apply Sort");
        }
    }
}
