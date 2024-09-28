using _abstractions;

namespace PIKLib;

/// <summary>
/// A set of "global" methods callable in isolation from any object using the @ syntax.
/// </summary>
public static class AAඞAA {
    /// <summary>
    /// Creates an object of type <see cref="PIKLib.BOOL"/>.
    /// </summary>
    /// <param name="name">The name of created object.</param>
    /// <param name="value">The initial value of created object.</param>
    public static void BOOL(string name, bool value) { throw new NotImplementedException(); }

    public static void BREAK() { throw new NotImplementedException(); }

    /// <summary>
    /// Creates an object of type <see cref="PIKLib.DOUBLE"/>.
    /// </summary>
    /// <param name="name">The name of created object.</param>
    /// <param name="value">The initial value of created object.</param>
    public static void DOUBLE(string name, double value) { throw new NotImplementedException(); }

    public static void IF(string condition, string code_if_true, string code_if_false) { throw new NotImplementedException(); }

    public static void IF(string left, string operand, string right, string code_if_true, string code_if_false) { throw new NotImplementedException(); }

    /// <summary>
    /// Creates an object of type <see cref="PIKLib.INTEGER"/>.
    /// </summary>
    /// <param name="name">The name of created object.</param>
    /// <param name="value">The initial value of created object.</param>
    public static void INT(string name, int value) { throw new NotImplementedException(); }

    public static void LOOP(string behaviour, int init, int len, int step) { throw new NotImplementedException(); }

    public static void MSGBOX(string message) { throw new NotImplementedException(); }

    public static variable RETURN(variable value) { throw new NotImplementedException(); }

    /// <summary>
    /// Creates an object of type <see cref="PIKLib.STRING"/>.
    /// </summary>
    /// <param name="name">The name of created object.</param>
    /// <param name="value">The initial value of created object.</param>
    public static string STRING(string name, string value) { throw new NotImplementedException(); }

    public static void WHILE(string left, string condition, string right, string code) { throw new NotImplementedException(); }
}
