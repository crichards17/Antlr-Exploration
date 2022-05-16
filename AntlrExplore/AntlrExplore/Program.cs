using Antlr4.Runtime;

string fileName = "Content\\test.txt";

string fileContents = File.ReadAllText(fileName);

AntlrInputStream inputStream = new AntlrInputStream(fileContents);

MathLexer mathLexer = new MathLexer(inputStream);
CommonTokenStream commonTokenStream = new CommonTokenStream(mathLexer);
MathParser mathParser = new MathParser(commonTokenStream);
MathParser.FileContext fileContext = mathParser.file();
MathVisitor visitor = new MathVisitor();

visitor.Visit(fileContext);