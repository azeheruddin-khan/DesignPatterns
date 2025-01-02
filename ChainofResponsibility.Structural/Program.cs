using System;

namespace ChainofResponsibility.Structural
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Handler handleZeroToTen = new ConcreteHandler1();
            Handler handleElevenToTwenty = new ConcreteHandler2();
            Handler handleTwentyOneToThirtly = new ConcreteHandler3();
            

            handleZeroToTen.SetSuccessor(handleElevenToTwenty);
            handleElevenToTwenty.SetSuccessor(handleTwentyOneToThirtly);

            int[] numbers = { 10, 2, 3, 30, 21, 25, 15 };

            foreach (int number in numbers)
            {
                handleZeroToTen.HandleRequest(number);
            }
        }
    }
}
