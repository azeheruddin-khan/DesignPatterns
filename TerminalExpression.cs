namespace Interpreter.Structural
{
    public class TerminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
}
