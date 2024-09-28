using abstractions;

namespace PIKLib;

public class EXPRESSION : OBJECT {
    public string OPERAND1 { private get; init; }
    public string OPERAND2 { private get; init; }
    public expression_operator OPERATOR { private get; init; }
}
