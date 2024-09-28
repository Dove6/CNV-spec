using _abstractions;

namespace PIKLib;

/// <summary>
/// Boolean value.
/// </summary>
public interface BOOL : OBJECT {
    bool TOINI { init; }
    bool VALUE { init; }

    /// <summary>
    /// Sets the value of the object to <c>value</c>.
    /// </summary>
    /// <param name="value">New value for the object.</param>
    void SET(bool value);

    /// <summary>
    /// Switches the value of the object between <c>TRUE</c> and <c>FALSE</c>.
    /// </summary>
    /// <param name="_unused1">Unused.</param>
    /// <param name="_unused2">Unused.</param>
    void SWITCH(bool _unused1, bool _unused2);
    
    event ParametrizedSignalHandler ONBRUTALCHANGED;
    event ParametrizedSignalHandler ONCHANGED;
}