using _abstractions;

namespace PIKLib;

/// <summary>
/// 2D sprite animation.
/// </summary>
public class ANIMO : OBJECT {
    public string FILENAME { private get; init; }
    public int FPS { private get; init; }
    public bool MONITORCOLLISIONඞ { private get; init; }
    public bool MONITORCOLLISIONALPHA { private get; init; }
    public bool PRELOAD { private get; init; }
    public int PRIORITY { private get; init; }
    public bool RELEASE { private get; init; }
    public bool TOCANVAS { private get; init; }
    public bool VISIBLE { private get; init; }

    /// <summary>
    /// Retrieves the horizontal position of the center of the object.
    /// </summary>
    /// <returns>Horizontal position of the object's center.</returns>
    public int GETCENTERX() { throw new NotImplementedException(); }

    public int GETCENTERY() { throw new NotImplementedException(); }
    public int GETCFRAMEINEVENT() { throw new NotImplementedException(); }
    public int GETCURRFRAMEPOSX() { throw new NotImplementedException(); }
    public int GETCURRFRAMEPOSY() { throw new NotImplementedException(); }
    public int GETENDX() { throw new NotImplementedException(); }
    public int GETENDY() { throw new NotImplementedException(); }
    public string GETEVENTNAME() { throw new NotImplementedException(); }
    public int GETFRAME() { throw new NotImplementedException(); }
    public string GETFRAMENAME() { throw new NotImplementedException(); }
    public int GETHEIGHT() { throw new NotImplementedException(); }
    public int GETMAXWIDTH() { throw new NotImplementedException(); }
    public int GETNOE() { throw new NotImplementedException(); }
    public int GETNOF() { throw new NotImplementedException(); }
    public int GETNOFINEVENT(string event_name) { throw new NotImplementedException(); }
    public int GETOPACITY() { throw new NotImplementedException(); }
    public int GETPOSITIONX() { throw new NotImplementedException(); }
    public int GETPOSITIONY() { throw new NotImplementedException(); }
    public int GETPRIORITY() { throw new NotImplementedException(); }
    public int GETWIDTH() { throw new NotImplementedException(); }

    /// <summary>
    /// Hides the object.
    /// </summary>
    public void HIDE() { throw new NotImplementedException(); }
    public void INVALIDATE() { throw new NotImplementedException(); }
    public bool ISAT() { throw new NotImplementedException(); }
    
    /// <summary>
    /// Checks if the object is near the <c>other</c> one.
    /// </summary>
    /// Nearness is decided based on the Intersection over Union metric between the two objects.
    /// If it is greater or equal to \a iou_threshold, the objects are considered as being near each other.
    /// <param name="other">Another graphics object for which nearness with the current object is checked.</param>
    /// <param name="iou_threshold">Minimum IoU value to treat two objects as being near each other.</param>
    /// <returns>Boolean value indicating if objects are near each other.</returns>
    public bool ISNEAR(string other, string iou_threshold) { throw new NotImplementedException(); }
    public bool ISPLAYING() { throw new NotImplementedException(); }
    public bool ISVISIBLE() { throw new NotImplementedException(); }
    public void LOAD(string filename) { throw new NotImplementedException(); }
    public void MERGEALPHA() { throw new NotImplementedException(); }
    public void MONITORCOLLISION(bool pixel_perfect) { throw new NotImplementedException(); }
    public void MOVE(int x_offset, int y_offset) { throw new NotImplementedException(); }
    public void NEXT() { throw new NotImplementedException(); }
    public void NEXTFRAME() { throw new NotImplementedException(); }
    public void NPLAY() { throw new NotImplementedException(); }
    public void PAUSE() { throw new NotImplementedException(); }
    
    /// <summary>
    /// Plays animation event identified by name <c>event_name</c>.
    /// </summary>
    /// Makes the object visible.
    /// Animation can loop depending on its definition (see ANN format specification)
    /// <param name="event_name">The name of the animation event to play.</param>
    public void PLAY(string event_name) { throw new NotImplementedException(); }
    public void PLAY(int event_index) { throw new NotImplementedException(); }
    public void PREVFRAME() { throw new NotImplementedException(); }
    public void REMOVEMONITORCOLLISION() { throw new NotImplementedException(); }
    public void RESUME() { throw new NotImplementedException(); }
    public void SETANCHOR(anchor anchor) { throw new NotImplementedException(); }
    public void SETASBUTTON(bool as_button, bool with_cursor_pointer) { throw new NotImplementedException(); }
    public void SETBACKWARD() { throw new NotImplementedException(); }
    public void SETCLIPPING() { throw new NotImplementedException(); }
    public void SETFORWARD() { throw new NotImplementedException(); }
    public void SETFPS(int fps) { throw new NotImplementedException(); }
    public void SETFRAME(int image_index) { throw new NotImplementedException(); }
    public void SETFRAME(string event_name, int frame_index) { throw new NotImplementedException(); }
    public void SETFRAMENAME(string frame_name) { throw new NotImplementedException(); }
    public void SETOPACITY(int opacity) { throw new NotImplementedException(); }
    public void SETPOSITION(int x, int y) { throw new NotImplementedException(); }
    public void SETPRIORITY(int priority) { throw new NotImplementedException(); }
    public void SHOW() { throw new NotImplementedException(); }
    public void STOP(bool emit_on_finished = true) { throw new NotImplementedException(); }

    event SignalHandler ONCLICK;
    event ParametrizedSignalHandler ONCOLLISION;

    /// <summary>
    /// Signal emitted when an animation event has finished playing.
    /// </summary>
    event ParametrizedSignalHandler ONFINISHED;
    event SignalHandler ONFOCUSOFF;
    event SignalHandler ONFOCUSON;
    event ParametrizedSignalHandler ONFRAMECHANGED;
    event SignalHandler ONINIT;
    event SignalHandler ONRELEASE;
    event ParametrizedSignalHandler ONSIGNAL;
    event ParametrizedSignalHandler ONSTARTED;
}
