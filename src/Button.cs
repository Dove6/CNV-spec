using _global;

namespace PIKLib;

public interface BUTTON : OBJECT {
    bool DRAGGABLE { init; }
    bool ENABLEඞ { init; }
    string GFXONCLICK { init; }
    string GFXONMOVE { init; }
    string GFXSTANDARD { init; }
    rect RECT { init; }
    string SNDONMOVE { init; }

    void DISABLE();
    void DISABLEBUTVISIBLE();
    void ENABLE();
    string GETSTD();
    void SETONCLICK(string object_name);
    void SETONMOVE(string object_name);
    void SETPRIORITY(int priority);
    void SETRECT(string object_name);
    void SETRECT(int left_x, int top_y, int right_x, int bottom_y);
    void SETSTD(string object_name);
    
    event SignalHandler ONACTION;
    event SignalHandler ONCLICKED;
    event SignalHandler ONDRAGGING;
    event SignalHandler ONENDDRAGGING;
    event SignalHandler ONFOCUSOFF;
    event SignalHandler ONFOCUSON;
    event SignalHandler ONINIT;
    event SignalHandler ONRELEASED;
    event SignalHandler ONSTARTDRAGGING;
}
