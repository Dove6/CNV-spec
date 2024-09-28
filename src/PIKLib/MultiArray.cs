using abstractions;

namespace PIKLib;

public class MULTIARRAY : OBJECT {
    public int DIMENSIONS { private get; init; }

    public variable? GET(params int[] indices) { throw new NotImplementedException(); }
    public void SET(variable value, params int[] indices) { throw new NotImplementedException(); } // TODO: swap the order (value after indices)
}
