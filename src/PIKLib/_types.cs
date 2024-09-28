namespace _abstractions;

public enum anchor
{
    CENTER,
    LEFTUPPER,
    RIGHTUPPER,
    LEFTLOWER,
    RIGHTLOWER,
    LEFT,
    RIGHT,
    TOP,
    BOTTOM
}

public enum condition_operator
{
    EQUAL,
    NOTEQUAL,
    LESS,
    GREATER,
    LESSEQUAL,
    GREATEREQUAL
}

public enum complex_operator
{
    AND,
    OR
}

public enum expression_operator
{
    ADD,
    SUB,
    MUL,
    DIV,
    MOD
}

public abstract record variable;

public record StringVariable(string value) : variable;

public record IntVariable(int value) : variable;

public record DoubleVariable(double value) : variable;

public record BoolVariable(bool value) : variable;

public abstract record rect;

public record ReferenceRect(string object_name) : rect;

public record LiteralRect(int left_x, int top_y, int right_x, int bottom_y) : rect;

/// <summary>
/// Run for signals.
/// </summary>
public delegate void SignalHandler(params variable[] arguments);

/// <summary>
/// Run for parametrized signals.
/// </summary>
public delegate void ParametrizedSignalHandler(string parameter, params variable[] arguments);