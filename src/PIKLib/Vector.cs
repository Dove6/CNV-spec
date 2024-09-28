using abstractions;

namespace PIKLib;

public class VECTOR : OBJECT {
    public int SIZE { private get; init; }
    public double[] VALUE { private get; init; }

    public void ADD(string summand_name) { throw new NotImplementedException(); }
    public void ASSIGN(params double[] values) { throw new NotImplementedException(); }
    public double GET(int index) { throw new NotImplementedException(); }
    public double LEN() { throw new NotImplementedException(); }
    public void MUL(double multiplier) { throw new NotImplementedException(); }
    public void NORMALIZE() { throw new NotImplementedException(); }
    public void REFLECT(string normal_name, string result_name) { throw new NotImplementedException(); }
}
