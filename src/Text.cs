using _global;

namespace PIKLib;

public interface TEXT : OBJECT {
    string FONT { init; }
    bool HJUSTIFY { init; }
    bool HYPERTEXT { init; }
    bool MONITORCOLLISION { init; }
    bool MONITORCOLLISIONALPHA { init; }
    rect RECT { init; }
    string TEXT { init; }
    bool TOCANVAS { init; }
    bool VISIBLE { init; }
    bool VJUSTIFY { init; }

    void HIDE();
    void SETCOLOR();
    void SETJUSTIFY();
    void SETPOSITION();
    void SETTEXT(string text);
    void SHOW();

    event SignalHandler ONINIT;
}
