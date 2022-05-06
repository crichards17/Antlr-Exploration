grammar Math;

/*
* Parser rules
 */


equation: line* EOF;

line: expression+;

expression: INTEGER OPERATOR INTEGER;

INTEGER: [0-9]+ ;

OPERATOR: '*' | '/' | '+' | '-';

WS : [ \t\r\n]+ -> skip;