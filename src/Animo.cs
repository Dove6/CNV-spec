/// <summary>
/// 2D sprite animation.
/// </summary>
namespace CnvAPI;

public interface ANIMO : OBJECT {
    string FILENAME { init; }
    int FPS { init; }
    bool MONITORCOLLISION_ { init; } // TODO: remove underscore
    bool MONITORCOLLISIONALPHA { init; }
    bool PRELOAD { init; }
    int PRIORITY { init; }
    bool RELEASE { init; }
    bool TOCANVAS { init; }
    bool VISIBLE { init; }

    /// <summary>
    /// Retrieves the horizontal position of the center of the object.
    /// </summary>
    /// <returns>Horizontal position of the object's center.</returns>
    int GETCENTERX();

    int GETCENTERY();
    int GETCFRAMEINEVENT();
    int GETCURRFRAMEPOSX();
    int GETCURRFRAMEPOSY();
    int GETENDX();
    int GETENDY();
    string GETEVENTNAME();
    int GETFRAME();
    string GETFRAMENAME();
    int GETHEIGHT();
    int GETMAXWIDTH();
    int GETNOE();
    int GETNOF();
    int GETNOFINEVENT(string event_name);
    int GETOPACITY();
    int GETPOSITIONX();
    int GETPOSITIONY();
    int GETPRIORITY();
    int GETWIDTH();

    /// <summary>
    /// Hides the object.
    /// </summary>
    void HIDE();
    void INVALIDATE();
    bool ISAT();
    
    /// <summary>
    /// Checks if the object is near the <c>other</c> one.
    /// </summary>
    /// Nearness is decided based on the Intersection over Union metric between the two objects.
    /// If it is greater or equal to \a iou_threshold, the objects are considered as being near each other.
    /// <param name="other">Another graphics object for which nearness with the current object is checked.</param>
    /// <param name="iou_threshold">Minimum IoU value to treat two objects as being near each other.</param>
    /// <returns>Boolean value indicating if objects are near each other.</returns>
    bool ISNEAR(string other, string iou_threshold);
    bool ISPLAYING();
    bool ISVISIBLE();
    void LOAD(string filename);
    void MERGEALPHA();
    void MONITORCOLLISION(bool pixel_perfect);
    void MOVE(int x_offset, int y_offset);
    void NEXT();
    void NEXTFRAME();
    void NPLAY();
    void PAUSE();
    
    /// <summary>
    /// Plays animation event identified by name <c>event_name</c>.
    /// </summary>
    /// Makes the object visible.
    /// Animation can loop depending on its definition (see ANN format specification)
    /// <param name="event_name">The name of the animation event to play.</param>
    void PLAY(string event_name);
    void PLAY(int event_index);
    void PREVFRAME();
    void REMOVEMONITORCOLLISION();
    void RESUME();
    void SETANCHOR(anchor anchor);
    void SETASBUTTON(bool as_button, bool with_cursor_pointer);
    void SETBACKWARD();
    void SETCLIPPING();
    void SETFORWARD();
    void SETFPS(int fps);
    void SETFRAME(int image_index);
    void SETFRAME(string event_name, int frame_index);
    void SETFRAMENAME(string frame_name);
    void SETOPACITY(int opacity);
    void SETPOSITION(int x, int y);
    void SETPRIORITY(int priority);
    void SHOW();
    void STOP(bool emit_on_finished = true);

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
