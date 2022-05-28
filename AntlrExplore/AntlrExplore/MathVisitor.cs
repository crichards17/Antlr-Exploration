using Antlr4.Runtime.Misc;

public class MathVisitor: MathBaseVisitor<decimal> 
{    
    
    public override decimal VisitLine([NotNull] MathParser.LineContext context)
    {
        string expression = context.expression()[0].GetText(); //debugging
        decimal answer = Visit(context.expression()[0]);
        System.Console.WriteLine($"{expression} = {answer}");
        return answer;
    }

    public override decimal VisitParenExpr([NotNull] MathParser.ParenExprContext context)
    {
        return Visit(context.expression());
    }

    public override decimal VisitUnaryExpr([NotNull] MathParser.UnaryExprContext context)
    {
        decimal value = decimal.Parse((context.value().GetText()));
        if (context.sign.Text == "-"){
            return value * -1;
        }
        return value;
    }

    public override decimal VisitValExpr([NotNull] MathParser.ValExprContext context)
    {
        
        return decimal.Parse(context.value().GetText());
    }

    public override decimal VisitOpExpr([NotNull] MathParser.OpExprContext context)
    {
        decimal left = Visit(context.left);
        decimal right = Visit(context.right);
        switch(context.op.Text) {
            case "*":
                decimal answer = left * right;
                return answer;
            case "/":
                return left / right;
            case "+":
                return left + right;
            case "-":
                return left - right;
            case "^":
                return (decimal)Math.Pow((double)left, (double)right);
            default:
                throw new ArgumentException($"Unknown operator: {context.op.Text}");
        }
    }
}

