using abstractions;

namespace PIKLib;

public class IMAGE : OBJECT {
    public string FILENAME { private get; init; }
    public bool MONITORCOLLISION { private get; init; }
    public bool MONITORCOLLISIONALPHA { private get; init; }
    public bool PRELOAD { private get; init; }
    public int PRIORITY { private get; init; }
    public bool RELEASE { private get; init; }
    public bool TOCANVAS { private get; init; }
    public bool VISIBLE { private get; init; }

    public void GETALPHA() { throw new NotImplementedException(); }
    public void GETHEIGHT() { throw new NotImplementedException(); }
    public void GETPIXEL() { throw new NotImplementedException(); }
    public void GETPOSITIONX() { throw new NotImplementedException(); }
    public void GETPOSITIONY() { throw new NotImplementedException(); }
    public void GETWIDTH() { throw new NotImplementedException(); }
    public void HIDE() { throw new NotImplementedException(); }
    public void INVALIDATE() { throw new NotImplementedException(); }
    public void ISVISIBLE() { throw new NotImplementedException(); }
    public void LOAD() { throw new NotImplementedException(); }
    public void MERGEALPHA(int x_offset, int y_offset, string object_name) { throw new NotImplementedException(); }
    public void MOVE(int x_offset, int y_offset) { throw new NotImplementedException(); }
    public void SETASBUTTON() { throw new NotImplementedException(); }
    public void SETCLIPPING(int left_x, int top_y, int _width, int _height) { throw new NotImplementedException(); }
    public void SETOPACITY() { throw new NotImplementedException(); }
    public void SETPOSITION(int x, int y) { throw new NotImplementedException(); }
    public void SETPRIORITY() { throw new NotImplementedException(); }
    public void SHOW() { throw new NotImplementedException(); }

    public event SignalHandler? ONCLICK;
    public event SignalHandler? ONFOCUSOFF;
    public event SignalHandler? ONFOCUSON;
    public event SignalHandler? ONINIT;
}
