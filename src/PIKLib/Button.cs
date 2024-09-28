using abstractions;

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

    /// <summary>
    /// Sets the interactive area of the button to the given rect.
    /// </summary>
    /// Calling this method does not make the button visible or enabled.
    /// If a reference is used, the rect only reflects the state of the referenced object at the time of the method call.
    /// For example changing the referenced animation frame does not result in the interactive area of the button being resized/moved.
    /// <param name="rect">A literal rect described by four coordinates or a reference being the name of a graphical object to base the rect on, capturing its current state.</param>
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
