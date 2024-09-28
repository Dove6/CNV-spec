using abstractions;

namespace PIKLib;

public class INTEGER : OBJECT {
    public bool TOINI { private get; init; }
    public int VALUE { private get; init; }
    public string VARTYPE { private get; init; }

    /// <summary>
    /// Sets the modulus of <c>value</c> as the value of the object.
    /// </summary>
    /// <param name="value">The value of which modulus is to be set as the value of the object.</param>
    /// <returns></returns>
    public int ABS(int value) { throw new NotImplementedException(); }

    public int ADD(int summand) { throw new NotImplementedException(); }
    
    public int AND(int operand) { throw new NotImplementedException(); }

    public int CLAMP(int min, int max) { throw new NotImplementedException(); }

    public void DEC() { throw new NotImplementedException(); }

    public void DIV(int divisor) { throw new NotImplementedException(); }

    public void INC() { throw new NotImplementedException(); }

    public int LENGTH(int horizontal_distance, int vertical_distance) { throw new NotImplementedException(); }

    public void MOD(int divisor) { throw new NotImplementedException(); }

    public void MUL(int multiplier) { throw new NotImplementedException(); }

    public int OR(int operand) { throw new NotImplementedException(); }

    public int RANDOM(int max_exclusive) { throw new NotImplementedException(); }

    public int RANDOM(int summand, int max_exclusive) { throw new NotImplementedException(); }

    public void RESETINI() { throw new NotImplementedException(); }

    public void SET(int value) { throw new NotImplementedException(); }

    public int SUB(int subtrahend) { throw new NotImplementedException(); }

    public void SWITCH(int value1, int value2) { throw new NotImplementedException(); }

    event ParametrizedSignalHandler ONBRUTALCHANGED;
    event ParametrizedSignalHandler ONCHANGED;
    event SignalHandler ONINIT;
    event ParametrizedSignalHandler ONSIGNAL;
}
