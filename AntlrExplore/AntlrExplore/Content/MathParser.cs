//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:\Users\crich\Documents\Coding\Fractals\Antlr-Exploration\AntlrExplore\AntlrExplore\Content\Math.g4 by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public partial class MathParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		INTEGER=1, DOUBLE=2, LPAREN=3, RPAREN=4, POW=5, MUL=6, DIV=7, SUM=8, SUB=9, 
		NEWLINE=10, WS=11;
	public const int
		RULE_file = 0, RULE_line = 1, RULE_expression = 2, RULE_value = 3;
	public static readonly string[] ruleNames = {
		"file", "line", "expression", "value"
	};

	private static readonly string[] _LiteralNames = {
		null, null, null, "'('", "')'", "'^'", "'*'", "'/'", "'+'", "'-'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "INTEGER", "DOUBLE", "LPAREN", "RPAREN", "POW", "MUL", "DIV", "SUM", 
		"SUB", "NEWLINE", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Math.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static MathParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public MathParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public MathParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class FileContext : ParserRuleContext {
		public LineContext[] line() {
			return GetRuleContexts<LineContext>();
		}
		public LineContext line(int i) {
			return GetRuleContext<LineContext>(i);
		}
		public FileContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_file; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMathVisitor<TResult> typedVisitor = visitor as IMathVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitFile(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public FileContext file() {
		FileContext _localctx = new FileContext(Context, State);
		EnterRule(_localctx, 0, RULE_file);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 11;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << INTEGER) | (1L << DOUBLE) | (1L << LPAREN) | (1L << SUM) | (1L << SUB))) != 0)) {
				{
				{
				State = 8; line();
				}
				}
				State = 13;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class LineContext : ParserRuleContext {
		public ITerminalNode NEWLINE() { return GetToken(MathParser.NEWLINE, 0); }
		public ITerminalNode Eof() { return GetToken(MathParser.Eof, 0); }
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public LineContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_line; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMathVisitor<TResult> typedVisitor = visitor as IMathVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitLine(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public LineContext line() {
		LineContext _localctx = new LineContext(Context, State);
		EnterRule(_localctx, 2, RULE_line);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 15;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				{
				State = 14; expression(0);
				}
				}
				State = 17;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( (((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << INTEGER) | (1L << DOUBLE) | (1L << LPAREN) | (1L << SUM) | (1L << SUB))) != 0) );
			State = 19;
			_la = TokenStream.LA(1);
			if ( !(_la==Eof || _la==NEWLINE) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExpressionContext : ParserRuleContext {
		public ExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expression; } }
	 
		public ExpressionContext() { }
		public virtual void CopyFrom(ExpressionContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class UnaryExprContext : ExpressionContext {
		public IToken sign;
		public ValueContext value() {
			return GetRuleContext<ValueContext>(0);
		}
		public ITerminalNode SUM() { return GetToken(MathParser.SUM, 0); }
		public ITerminalNode SUB() { return GetToken(MathParser.SUB, 0); }
		public UnaryExprContext(ExpressionContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMathVisitor<TResult> typedVisitor = visitor as IMathVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitUnaryExpr(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class OpExprContext : ExpressionContext {
		public ExpressionContext left;
		public IToken op;
		public ExpressionContext right;
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public ITerminalNode POW() { return GetToken(MathParser.POW, 0); }
		public ITerminalNode MUL() { return GetToken(MathParser.MUL, 0); }
		public ITerminalNode DIV() { return GetToken(MathParser.DIV, 0); }
		public ITerminalNode SUM() { return GetToken(MathParser.SUM, 0); }
		public ITerminalNode SUB() { return GetToken(MathParser.SUB, 0); }
		public OpExprContext(ExpressionContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMathVisitor<TResult> typedVisitor = visitor as IMathVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitOpExpr(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ParenExprContext : ExpressionContext {
		public ITerminalNode LPAREN() { return GetToken(MathParser.LPAREN, 0); }
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public ITerminalNode RPAREN() { return GetToken(MathParser.RPAREN, 0); }
		public ParenExprContext(ExpressionContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMathVisitor<TResult> typedVisitor = visitor as IMathVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitParenExpr(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ValExprContext : ExpressionContext {
		public ValueContext value() {
			return GetRuleContext<ValueContext>(0);
		}
		public ValExprContext(ExpressionContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMathVisitor<TResult> typedVisitor = visitor as IMathVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitValExpr(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExpressionContext expression() {
		return expression(0);
	}

	private ExpressionContext expression(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		ExpressionContext _localctx = new ExpressionContext(Context, _parentState);
		ExpressionContext _prevctx = _localctx;
		int _startState = 4;
		EnterRecursionRule(_localctx, 4, RULE_expression, _p);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 29;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case LPAREN:
				{
				_localctx = new ParenExprContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;

				State = 22; Match(LPAREN);
				State = 23; expression(0);
				State = 24; Match(RPAREN);
				}
				break;
			case SUM:
			case SUB:
				{
				_localctx = new UnaryExprContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 26;
				((UnaryExprContext)_localctx).sign = TokenStream.LT(1);
				_la = TokenStream.LA(1);
				if ( !(_la==SUM || _la==SUB) ) {
					((UnaryExprContext)_localctx).sign = ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				State = 27; value();
				}
				break;
			case INTEGER:
			case DOUBLE:
				{
				_localctx = new ValExprContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 28; value();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			Context.Stop = TokenStream.LT(-1);
			State = 42;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,4,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 40;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,3,Context) ) {
					case 1:
						{
						_localctx = new OpExprContext(new ExpressionContext(_parentctx, _parentState));
						((OpExprContext)_localctx).left = _prevctx;
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 31;
						if (!(Precpred(Context, 5))) throw new FailedPredicateException(this, "Precpred(Context, 5)");
						State = 32; ((OpExprContext)_localctx).op = Match(POW);
						State = 33; ((OpExprContext)_localctx).right = expression(6);
						}
						break;
					case 2:
						{
						_localctx = new OpExprContext(new ExpressionContext(_parentctx, _parentState));
						((OpExprContext)_localctx).left = _prevctx;
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 34;
						if (!(Precpred(Context, 4))) throw new FailedPredicateException(this, "Precpred(Context, 4)");
						State = 35;
						((OpExprContext)_localctx).op = TokenStream.LT(1);
						_la = TokenStream.LA(1);
						if ( !(_la==MUL || _la==DIV) ) {
							((OpExprContext)_localctx).op = ErrorHandler.RecoverInline(this);
						}
						else {
							ErrorHandler.ReportMatch(this);
						    Consume();
						}
						State = 36; ((OpExprContext)_localctx).right = expression(5);
						}
						break;
					case 3:
						{
						_localctx = new OpExprContext(new ExpressionContext(_parentctx, _parentState));
						((OpExprContext)_localctx).left = _prevctx;
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 37;
						if (!(Precpred(Context, 3))) throw new FailedPredicateException(this, "Precpred(Context, 3)");
						State = 38;
						((OpExprContext)_localctx).op = TokenStream.LT(1);
						_la = TokenStream.LA(1);
						if ( !(_la==SUM || _la==SUB) ) {
							((OpExprContext)_localctx).op = ErrorHandler.RecoverInline(this);
						}
						else {
							ErrorHandler.ReportMatch(this);
						    Consume();
						}
						State = 39; ((OpExprContext)_localctx).right = expression(4);
						}
						break;
					}
					} 
				}
				State = 44;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,4,Context);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public partial class ValueContext : ParserRuleContext {
		public ITerminalNode INTEGER() { return GetToken(MathParser.INTEGER, 0); }
		public ITerminalNode DOUBLE() { return GetToken(MathParser.DOUBLE, 0); }
		public ValueContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_value; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMathVisitor<TResult> typedVisitor = visitor as IMathVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitValue(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ValueContext value() {
		ValueContext _localctx = new ValueContext(Context, State);
		EnterRule(_localctx, 6, RULE_value);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 45;
			_la = TokenStream.LA(1);
			if ( !(_la==INTEGER || _la==DOUBLE) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 2: return expression_sempred((ExpressionContext)_localctx, predIndex);
		}
		return true;
	}
	private bool expression_sempred(ExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(Context, 5);
		case 1: return Precpred(Context, 4);
		case 2: return Precpred(Context, 3);
		}
		return true;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\r', '\x32', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', 
		'\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x3', 
		'\x2', '\a', '\x2', '\f', '\n', '\x2', '\f', '\x2', '\xE', '\x2', '\xF', 
		'\v', '\x2', '\x3', '\x3', '\x6', '\x3', '\x12', '\n', '\x3', '\r', '\x3', 
		'\xE', '\x3', '\x13', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x5', '\x4', ' ', '\n', '\x4', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\a', '\x4', '+', '\n', '\x4', '\f', 
		'\x4', '\xE', '\x4', '.', '\v', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x5', '\x2', '\x3', '\x6', '\x6', '\x2', '\x4', '\x6', '\b', '\x2', '\x6', 
		'\x3', '\x3', '\f', '\f', '\x3', '\x2', '\n', '\v', '\x3', '\x2', '\b', 
		'\t', '\x3', '\x2', '\x3', '\x4', '\x2', '\x34', '\x2', '\r', '\x3', '\x2', 
		'\x2', '\x2', '\x4', '\x11', '\x3', '\x2', '\x2', '\x2', '\x6', '\x1F', 
		'\x3', '\x2', '\x2', '\x2', '\b', '/', '\x3', '\x2', '\x2', '\x2', '\n', 
		'\f', '\x5', '\x4', '\x3', '\x2', '\v', '\n', '\x3', '\x2', '\x2', '\x2', 
		'\f', '\xF', '\x3', '\x2', '\x2', '\x2', '\r', '\v', '\x3', '\x2', '\x2', 
		'\x2', '\r', '\xE', '\x3', '\x2', '\x2', '\x2', '\xE', '\x3', '\x3', '\x2', 
		'\x2', '\x2', '\xF', '\r', '\x3', '\x2', '\x2', '\x2', '\x10', '\x12', 
		'\x5', '\x6', '\x4', '\x2', '\x11', '\x10', '\x3', '\x2', '\x2', '\x2', 
		'\x12', '\x13', '\x3', '\x2', '\x2', '\x2', '\x13', '\x11', '\x3', '\x2', 
		'\x2', '\x2', '\x13', '\x14', '\x3', '\x2', '\x2', '\x2', '\x14', '\x15', 
		'\x3', '\x2', '\x2', '\x2', '\x15', '\x16', '\t', '\x2', '\x2', '\x2', 
		'\x16', '\x5', '\x3', '\x2', '\x2', '\x2', '\x17', '\x18', '\b', '\x4', 
		'\x1', '\x2', '\x18', '\x19', '\a', '\x5', '\x2', '\x2', '\x19', '\x1A', 
		'\x5', '\x6', '\x4', '\x2', '\x1A', '\x1B', '\a', '\x6', '\x2', '\x2', 
		'\x1B', ' ', '\x3', '\x2', '\x2', '\x2', '\x1C', '\x1D', '\t', '\x3', 
		'\x2', '\x2', '\x1D', ' ', '\x5', '\b', '\x5', '\x2', '\x1E', ' ', '\x5', 
		'\b', '\x5', '\x2', '\x1F', '\x17', '\x3', '\x2', '\x2', '\x2', '\x1F', 
		'\x1C', '\x3', '\x2', '\x2', '\x2', '\x1F', '\x1E', '\x3', '\x2', '\x2', 
		'\x2', ' ', ',', '\x3', '\x2', '\x2', '\x2', '!', '\"', '\f', '\a', '\x2', 
		'\x2', '\"', '#', '\a', '\a', '\x2', '\x2', '#', '+', '\x5', '\x6', '\x4', 
		'\b', '$', '%', '\f', '\x6', '\x2', '\x2', '%', '&', '\t', '\x4', '\x2', 
		'\x2', '&', '+', '\x5', '\x6', '\x4', '\a', '\'', '(', '\f', '\x5', '\x2', 
		'\x2', '(', ')', '\t', '\x3', '\x2', '\x2', ')', '+', '\x5', '\x6', '\x4', 
		'\x6', '*', '!', '\x3', '\x2', '\x2', '\x2', '*', '$', '\x3', '\x2', '\x2', 
		'\x2', '*', '\'', '\x3', '\x2', '\x2', '\x2', '+', '.', '\x3', '\x2', 
		'\x2', '\x2', ',', '*', '\x3', '\x2', '\x2', '\x2', ',', '-', '\x3', '\x2', 
		'\x2', '\x2', '-', '\a', '\x3', '\x2', '\x2', '\x2', '.', ',', '\x3', 
		'\x2', '\x2', '\x2', '/', '\x30', '\t', '\x5', '\x2', '\x2', '\x30', '\t', 
		'\x3', '\x2', '\x2', '\x2', '\a', '\r', '\x13', '\x1F', '*', ',',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
