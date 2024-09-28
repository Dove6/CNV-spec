using abstractions;

namespace PIKLib;

public class TEXT : OBJECT {
    public string FONT { private get; init; }
    public bool HJUSTIFY { private get; init; }
    public bool HYPERTEXT { private get; init; }
    public bool MONITORCOLLISION { private get; init; }
    public bool MONITORCOLLISIONALPHA { private get; init; }
    public rect RECT { private get; init; }
    public string TEXTඞ { private get; init; }
    public bool TOCANVAS { private get; init; }
    public bool VISIBLE { private get; init; }
    public bool VJUSTIFY { private get; init; }

    public void HIDE() { throw new NotImplementedException(); }
    public void SETCOLOR() { throw new NotImplementedException(); }
    public void SETJUSTIFY() { throw new NotImplementedException(); }
    public void SETPOSITION() { throw new NotImplementedException(); }
    public void SETTEXT(string text) { throw new NotImplementedException(); }
    public void SHOW() { throw new NotImplementedException(); }

    public event SignalHandler? ONINIT;
}
