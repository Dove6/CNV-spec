namespace abstractions;

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
/// A plain non-parametrized signal handler. It can receive an arbitrary number of arguments.
/// </summary>
/// <param name="arguments">Arguments passed to the handler.</param>
public delegate void SignalHandler(params variable[] arguments);

/// <summary>
/// A specialized signal handler identified by its parametr. It can receive an arbitrary number of arguments.
/// </summary>
/// <typeparam name="P">Type of the parameter (for documentation purposes).</typeparam>
/// <param name="parameter">The parameter identifying the handler.</param>
/// <param name="arguments">Arguments passed to the handler.</param>
public delegate void SignalHandler<P>(P parameter, params variable[] arguments);