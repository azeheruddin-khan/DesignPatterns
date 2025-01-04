namespace Interpreter.Structural
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Context context = new Context();
           List<AbstractExpression> expressions = new List<AbstractExpression>();
            expressions.Add(new TerminalExpression());            
            expressions.Add(new NonTerminalExpression ());

            foreach (AbstractExpression expression in expressions)
            {
                expression.Interpret(context);
            }
        }
    }
}
