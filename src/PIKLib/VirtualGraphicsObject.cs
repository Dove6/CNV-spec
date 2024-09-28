using abstractions;

namespace PIKLib;

public class VIRTUALGRAPHICSOBJECT : OBJECT {
    public bool ASBUTTON { private get; init; }
    public string MASK { private get; init; }
    public bool MONITORCOLLISION { private get; init; }
    public bool MONITORCOLLISIONALPHA { private get; init; }
    public int PRIORITY { private get; init; }
    public string SOURCE { private get; init; }
    public bool TOCANVAS { private get; init; }
    public bool VISIBLE { private get; init; }

    public int GETHEIGHT() { throw new NotImplementedException(); }
    public int GETPOSITIONX() { throw new NotImplementedException(); }
    public int GETPOSITIONY() { throw new NotImplementedException(); }
    public int GETWIDTH() { throw new NotImplementedException(); }
    public void MOVE(int x_offset, int y_offset) { throw new NotImplementedException(); }
    public void SETMASK(string graphics_name) { throw new NotImplementedException(); }
    public void SETPOSITION(int x, int y) { throw new NotImplementedException(); }
    public void SETPRIORITY(int priority) { throw new NotImplementedException(); }
    public void SETSOURCE(string graphics_name) { throw new NotImplementedException(); }
}
