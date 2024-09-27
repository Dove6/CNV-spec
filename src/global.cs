namespace CnvAPI;

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
/// /// Run for parametrized signals.
/// </summary>
public delegate void ParametrizedSignalHandler(string parameter, params variable[] arguments);

public interface global {
    /// <summary>
    /// Creates an object of type <see cref="CnvAPI.BOOL"/>.
    /// </summary>
    /// <param name="name">The name of created object.</param>
    /// <param name="value">The initial value of created object.</param>
    void BOOL(string name, bool value);

    void BREAK();

    /// <summary>
    /// Creates an object of type <see cref="CnvAPI.DOUBLE"/>.
    /// </summary>
    /// <param name="name">The name of created object.</param>
    /// <param name="value">The initial value of created object.</param>
    void DOUBLE(string name, double value);

    void IF(string condition, string code_if_true, string code_if_false);

    void IF(string left, string operand, string right, string code_if_true, string code_if_false);

    /// <summary>
    /// Creates an object of type <see cref="CnvAPI.INTEGER"/>.
    /// </summary>
    /// <param name="name">The name of created object.</param>
    /// <param name="value">The initial value of created object.</param>
    void INT(string name, int value);

    void LOOP(string behaviour, int init, int len, int step);

    void MSGBOX(string message);

    variable RETURN(variable value);

    /// <summary>
    /// Creates an object of type <see cref="CnvAPI.STRING"/>.
    /// </summary>
    /// <param name="name">The name of created object.</param>
    /// <param name="value">The initial value of created object.</param>
    string STRING(string name, string value);

    void WHILE(string left, string condition, string right, string code);
}
