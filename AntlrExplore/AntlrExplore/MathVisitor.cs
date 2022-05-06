using Antlr4.Runtime.Misc;

public class MathVisitor: MathBaseVisitor<int> 
{
    public override int VisitExpression([NotNull] MathParser.ExpressionContext context)
    {
        int leftVal = int.Parse(context.INTEGER()[0].GetText());
        int rightVal = int.Parse(context.INTEGER()[1].GetText());
        string op = context.OPERATOR().GetText();

        if (op == "+") {
            System.Console.WriteLine($"{leftVal} + {rightVal} = {leftVal + rightVal}");
            return leftVal + rightVal;
        } else if (op == "-") {
            System.Console.WriteLine($"{leftVal} - {rightVal} = {leftVal - rightVal}");
            return leftVal - rightVal;
        } else if (op == "*") {
            System.Console.WriteLine($"{leftVal} * {rightVal} = {leftVal * rightVal}");
            return leftVal * rightVal;
        } else if (op == "/") {
            System.Console.WriteLine($"{leftVal} / {rightVal} = {leftVal / rightVal}");
            return leftVal / rightVal;
        } else {
            return 0;
        }
    }
}

