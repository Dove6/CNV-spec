using _abstractions;

namespace PIKLib;

public class PATTERN : OBJECT {
    public int GRIDX { private get; init; }
    public int GRIDY { private get; init; }
    public int HEIGHT { private get; init; }
    public int LAYERS { private get; init; }
    public int PRIORITY { private get; init; }
    public bool TOCANVAS { private get; init; }
    public bool VISIBLE { private get; init; }
    public int WIDTH { private get; init; }

    public void ADD(string _, int x, int y, string object_name, int _2) { throw new NotImplementedException(); }
    public string GETGRAPHICSAT(int x, int y, bool _, bool _2, int _3) { throw new NotImplementedException(); }
    public void MOVE(int x, int y) { throw new NotImplementedException(); }
}
