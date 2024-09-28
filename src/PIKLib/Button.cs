using _abstractions;

namespace PIKLib;

public class BUTTON : OBJECT {
    public bool DRAGGABLE { private get; init; }
    public bool ENABLEඞ { private get; init; }
    public string GFXONCLICK { private get; init; }
    public string GFXONMOVE { private get; init; }

    /// <summary>
    /// A graphics
    /// </summary>
    public string GFXSTANDARD { private get; init; }
    public rect RECT { private get; init; }
    public string SNDONMOVE { private get; init; }

    public void DISABLE() { throw new NotImplementedException(); }
    public void DISABLEBUTVISIBLE() { throw new NotImplementedException(); }
    public void ENABLE() { throw new NotImplementedException(); }
    public string GETSTD() { throw new NotImplementedException(); }
    public void SETONCLICK(string object_name) { throw new NotImplementedException(); }
    public void SETONMOVE(string object_name) { throw new NotImplementedException(); }
    public void SETPRIORITY(int priority) { throw new NotImplementedException(); }
    public void SETRECT(rect rect) { throw new NotImplementedException(); }
    public void SETSTD(string object_name) { throw new NotImplementedException(); }
    
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
