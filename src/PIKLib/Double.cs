using _abstractions;

namespace PIKLib;

public class DOUBLE : OBJECT {
    public bool TOINI { private get; init; }
    public double VALUE { private get; init; }

    public double ADD(double summand) { throw new NotImplementedException(); }
    public double ARCTAN(double degrees) { throw new NotImplementedException(); }
    public double ARCTANEX(double y, double x, int summand = 0) { throw new NotImplementedException(); }
    public double CLAMP(double min, double max) { throw new NotImplementedException(); }
    public double COSINUS(double degrees) { throw new NotImplementedException(); }
    public void DIV(double divisor) { throw new NotImplementedException(); }
    public double LENGTH(double horizontal_distance, double vertical_distance) { throw new NotImplementedException(); }
    public double MAXA(params double[] values) { throw new NotImplementedException(); }
    public double MINA(params double[] values) { throw new NotImplementedException(); }
    public void MUL(double multiplier) { throw new NotImplementedException(); }
    public void SET(double value) { throw new NotImplementedException(); }
    public double SINUS(double degrees) { throw new NotImplementedException(); }
    public double SQRT() { throw new NotImplementedException(); }
    public double SUB(double subtrahend) { throw new NotImplementedException(); }
}
