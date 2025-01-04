namespace Interpreter.Structural
{

    public class NonTerminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine(this.GetType().Name);
        }
    }

}
