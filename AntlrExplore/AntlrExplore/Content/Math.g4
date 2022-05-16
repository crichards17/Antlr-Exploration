grammar Math;

/*
* Parser rules
 */


file
    : line*
    ;

line
    : expression+ (NEWLINE | EOF)
    ;

// PEMDAS
expression
    : LPAREN expression RPAREN # parenExpr
    | left=expression op=POW right=expression # opExpr
    | left=expression op=(MUL | DIV) right=expression # opExpr
    | left=expression op=(SUM | SUB) right=expression # opExpr
    | val=INTEGER # valExpr //change to value when adding doubles support
    ;

value
    : INTEGER
    | DOUBLE
    ;

// Fragments
INTEGER
    : [0-9]+ 
    ;

DOUBLE
    : [0-9]+ '.' [0-9]+ 
    ;

LPAREN
    : '('
    ;

RPAREN 
    : ')'
    ;

POW
    : '^'
    ;

MUL
    : '*'
    ;

DIV
    : '/'
    ;

SUM
    : '+'
    ;

SUB
    : '-'
    ;

NEWLINE
    : '\r\n'
    | '\n'
    | '\r'
    ;

WS : [ \t]+ -> skip;