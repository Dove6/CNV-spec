using abstractions;

namespace PIKLib;

/// <summary>
/// Boolean value.
/// </summary>
public class BOOL : OBJECT {
    public bool TOINI { private get; init; }
    public bool VALUE { private get; init; }

    /// <summary>
    /// Sets the value of the object to <c>value</c>.
    /// </summary>
    /// <param name="value">New value for the object.</param>
    public void SET(bool value) { throw new NotImplementedException(); }

    /// <summary>
    /// Switches the value of the object between <c>TRUE</c> and <c>FALSE</c>.
    /// </summary>
    /// <param name="_unused1">Unused.</param>
    /// <param name="_unused2">Unused.</param>
    public void SWITCH(bool _unused1, bool _unused2) { throw new NotImplementedException(); }

    public event SignalHandler<stringified_value>? ONBRUTALCHANGED;
    public event SignalHandler<stringified_value>? ONCHANGED;
}