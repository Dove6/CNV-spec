namespace CnvAPI;

public interface EXPRESSION : OBJECT {
    string OPERAND1 { init; }
    string OPERAND2 { init; }
    expression_operator OPERATOR { init; }
}
