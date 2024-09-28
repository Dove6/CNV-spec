using abstractions;

namespace PIKLib;

/// <summary>
/// An interactable area which reacts to mouse cursor being hovered over it and clicking it.
/// </summary>
public class BUTTON : OBJECT {
    /// <summary>
    /// A value specifying if the object should support dragging.
    /// </summary>
    // TODO: what does it mean?
    public bool DRAGGABLE { private get; init; }

    /// <summary>
    /// A value specifying if the object should be activated by default.
    /// </summary>
    /// <remarks>
    /// A disabled button hides associated objects supplied using the <see cref="GFXSTANDARD"/>, <see cref="GFXONMOVE"/> and <see cref="GFXONCLICK"/> properties.
    /// </remarks>
    // TODO: what if the SHOW method of referenced objects is called?
    public bool ENABLEඞ { private get; init; }

    /// <summary>
    /// The name of an <see cref="ANIMO"/> or <see cref="IMAGE"/> object to be shown when the mouse button is being pressed over the button.
    /// </summary>
    /// <remarks>
    /// This property is overridden by the <see cref="RECT"/> property.
    /// </remarks>
    public string? GFXONCLICK { private get; init; }

    /// <summary>
    /// The name of an <see cref="ANIMO"/> or <see cref="IMAGE"/> object to be shown when the mouse cursor is being hovered over the button.
    /// </summary>
    /// <remarks>
    /// This property is overridden by the <see cref="RECT"/> property.
    /// </remarks>
    public string? GFXONMOVE { private get; init; }

    /// <summary>
    /// The name of an <see cref="ANIMO"/> or <see cref="IMAGE"/> object to be shown when the button is neither pressed nor hovered upon.
    /// </summary>
    /// <remarks>
    /// This property is overridden by the <see cref="RECT"/> property.
    /// </remarks>
    // TODO: is it required?
    // TODO: interactive area behavior
    public string GFXSTANDARD { private get; init; }

    /// <summary>
    /// A literal rect described by four coordinates or a reference being the name of a graphical object to base the rect on, capturing its current state.
    /// </summary>
    /// <remarks>
    /// This property overrides the <see cref="GFXSTANDARD"/>, <see cref="GFXONMOVE"/> and <see cref="GFXONCLICK"/> properties.
    ///
    /// If a reference is used, the rect only reflects the state of the referenced object at the time of the method call.
    /// For example changing the referenced animation frame does not result in the interactive area of the button being resized/moved.
    /// </remarks>
    // TODO: is it required?
    public rect RECT { private get; init; }

    /// <summary>
    /// The name of a <see cref="SOUND"/> object to be played when mouse cursor hovers over the button.
    /// </summary>
    public string? SNDONMOVE { private get; init; }

    public void DISABLE() { throw new NotImplementedException(); }
    public void DISABLEBUTVISIBLE() { throw new NotImplementedException(); }
    public void ENABLE() { throw new NotImplementedException(); }
    public string GETSTD() { throw new NotImplementedException(); }
    public void SETONCLICK(string object_name) { throw new NotImplementedException(); }
    public void SETONMOVE(string object_name) { throw new NotImplementedException(); }
    public void SETPRIORITY(int priority) { throw new NotImplementedException(); }

    /// <summary>
    /// Sets the interactive area of the button to the given <paramref name="rect"/>.
    /// </summary>
    /// <remarks>
    /// Calling this method does not make the button visible or enabled.
    ///
    /// Setting a rect makes the <see cref="GFXSTANDARD"/>, <see cref="GFXONMOVE"/> and <see cref="GFXONCLICK"/> properties as well as any further calls to the <see cref="SETSTD"/>, <see cref="SETONMOVE"/> and <see cref="SETONCLICK"/> methods to be ignored.
    ///
    /// If a reference is used, the rect only reflects the state of the referenced object at the time of the method call.
    /// For example changing the referenced animation frame does not result in the interactive area of the button being resized/moved.
    /// </remarks>
    /// <param name="rect">A literal rect described by four coordinates or a reference being the name of a graphical object to base the rect on, capturing its current state.</param>
    public void SETRECT(rect rect) { throw new NotImplementedException(); }
    public void SETSTD(string object_name) { throw new NotImplementedException(); }

    public event SignalHandler? ONACTION;
    public event SignalHandler? ONCLICKED;
    public event SignalHandler? ONDRAGGING;
    public event SignalHandler? ONENDDRAGGING;
    public event SignalHandler? ONFOCUSOFF;
    public event SignalHandler? ONFOCUSON;
    public event SignalHandler? ONINIT;
    public event SignalHandler? ONRELEASED;
    public event SignalHandler? ONSTARTDRAGGING;
}
