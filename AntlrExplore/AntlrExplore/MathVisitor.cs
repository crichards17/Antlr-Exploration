using Antlr4.Runtime.Misc;

public class MathVisitor: MathBaseVisitor<int> 
{    
    
    public override int VisitLine([NotNull] MathParser.LineContext context)
    {
        string expression = context.expression()[0].GetText(); //debugging
        int answer = Visit(context.expression()[0]);
        System.Console.WriteLine($"{expression} = {answer}");
        return answer;
    }

    public override int VisitParenExpr([NotNull] MathParser.ParenExprContext context)
    {
        return Visit(context.expression());
    }

    public override int VisitValExpr([NotNull] MathParser.ValExprContext context)
    {
        return int.Parse(context.val.Text);
    }

    public override int VisitOpExpr([NotNull] MathParser.OpExprContext context)
    {
        int left = Visit(context.left);
        int right = Visit(context.right);
        switch(context.op.Text) {
            case "*":
                return left * right;
            case "/":
                return left / right;
            case "+":
                return left + right;
            case "-":
                return left - right;
            case "^":
                return (int)Math.Pow(left, right); //Remove cast when supporting Double
            default:
                throw new ArgumentException($"Unknown operator: {context.op.Text}");
        }
    }
}

