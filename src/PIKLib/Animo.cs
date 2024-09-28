using abstractions;

namespace PIKLib;

/// <summary>
/// 2D sprite animation.
/// </summary>
public class ANIMO : OBJECT {
    /// <summary>
    /// A path to a file where the animation data is stored.
    /// </summary>
    /// <remarks>
    /// The file must be in the ANN format.
    /// </remarks>
    /// <seealso cref="LOAD"/>
    public string FILENAME { private get; init; }

    /// <summary>
    /// Target animation speed (in frames per second).
    /// </summary>
    /// <remarks>
    /// The property overrides settings from a file.
    /// </remarks>
    /// <seealso cref="SETFPS"/>
    public int? FPS { private get; init; } = null;

    /// <summary>
    /// Should 2D collisions be detected for the object?
    /// </summary>
    /// <remarks>
    /// Setting the property to TRUE means <see cref="ONCOLLISION"/> callback is called.
    ///
    /// By default, AABB collision algorithm is used.
    /// </remarks>
    /// <seealso cref="MONITORCOLLISIONALPHA"/>
    /// <seealso cref="MONITORCOLLISION"/>
    /// <seealso cref="REMOVEMONITORCOLLISION"/>
    public bool MONITORCOLLISIONඞ { private get; init; } = false;

    /// <summary>
    /// Should the pixel-perfect collision algorithm be used instead of the default AABB one?
    /// </summary>
    /// <remarks>
    /// The property is ignored if <see cref="MONITORCOLLISIONඞ"/> is set to FALSE.
    /// </remarks>
    /// <seealso cref="MONITORCOLLISIONඞ"/>
    /// <seealso cref="MONITORCOLLISION"/>
    /// <seealso cref="REMOVEMONITORCOLLISION"/>
    public bool MONITORCOLLISIONALPHA { private get; init; } = false;

    /// <summary>
    /// Should the file specified in <see cref="FILENAME"/> be loaded instantly?
    /// </summary>
    // TODO: instead of when?
    public bool PRELOAD { private get; init; }

    /// <summary>
    /// The position of the object on the Z axis (directed out of the screen).
    /// Objects with greater priority are displayed over those with smaller priority.
    /// </summary>
    /// <remarks>
    /// For the same priority value, objects declared later are displayed over those declared before.
    /// </remarks>
    /// <seealso cref="GETPRIORITY"/>
    /// <seealso cref="SETPRIORITY"/>
    public int PRIORITY { private get; init; }

    /// <summary>
    /// Should the file handle be released after loading the file specified in <see cref="FILENAME"/>?
    /// </summary>
    // TODO: verify this
    public bool RELEASE { private get; init; }

    /// <remarks>
    /// Without setting the property to TRUE, the object remains invisible.
    /// </remarks>
    public bool TOCANVAS { private get; init; } = false;

    /// <summary>
    /// Should the object be visible by default?
    /// </summary>
    /// <seealso cref="TOCANVAS"/>
    /// <seealso cref="HIDE"/>
    /// <seealso cref="ISVISIBLE"/>
    /// <seealso cref="SHOW"/>
    public bool VISIBLE { private get; init; } = false;


    /// <summary>
    /// Retrieves the horizontal position of the center of the object (in pixels).
    /// </summary>
    /// <returns>The horizontal position of the object's center (in pixels).</returns>
    // TODO: check what "position" means in this context
    public int GETCENTERX() { throw new NotImplementedException(); }

    /// <summary>
    /// Retrieves the vertical position of the center of the object (in pixels).
    /// </summary>
    /// <returns>The vertical position of the object's center (in pixels).</returns>
    // TODO: check what "position" means in this context
    public int GETCENTERY() { throw new NotImplementedException(); }

    /// <summary>
    /// Retrieves the 0-based index of the current frame within its parent public event (a sequence of frames).
    /// </summary>
    /// <returns>The index of the current frame within the current event.</returns>
    /// <seealso cref="GETFRAME"/>
    public int GETCFRAMEINEVENT() { throw new NotImplementedException(); }

    /// <summary>
    /// Retrieves the horizontal position of the current animation frame (in pixels).
    /// </summary>
    /// <returns>The horizontal position of the current animation frame (in pixels).</returns>
    // TODO: is this ANIMO:POSITION + image position + frame position or something less?
    public int GETCURRFRAMEPOSX() { throw new NotImplementedException(); }

    /// <summary>
    /// Retrieves the vertical position of the current animation frame (in pixels).
    /// </summary>
    /// <returns>The vertical position of the current animation frame (in pixels).</returns>
    // TODO: is this ANIMO:POSITION + image position + frame position or something less?
    public int GETCURRFRAMEPOSY() { throw new NotImplementedException(); }

    /// <summary>
    /// Retrieves the horizontal position of the right edge of the object (in pixels).
    /// </summary>
    /// <returns>The horizontal position of the object's right edge (in pixels).</returns>
    // TODO: check what "position" means in this context
    public int GETENDX() { throw new NotImplementedException(); }

    /// <summary>
    /// Retrieves the vertical position of the bottom edge of the object (in pixels).
    /// </summary>
    /// <returns>The vertical position of the object's bottom edge (in pixels).</returns>
    // TODO: check what "position" means in this context
    public int GETENDY() { throw new NotImplementedException(); }

    /// <summary>
    /// Retrieves the name of the current public event (a sequence of frames).
    /// </summary>
    /// <returns>The name of the current event.</returns>
    public string GETEVENTNAME() { throw new NotImplementedException(); }

    /// <summary>
    /// Retrieves the 0-based index of the compound image pointed to by the current animation frame.
    /// </summary>
    /// <returns>The index of currently displayed animation image (not the index of a frame).</returns>
    /// <seealso cref="SETFRAME(int)"/>
    /// <seealso cref="GETCFRAMEINEVENT"/>
    public int GETFRAME() { throw new NotImplementedException(); }

    /// <summary>
    /// Retrieves the name of the current frame.
    /// </summary>
    /// <returns>The name of the current frame.</returns>
    /// <seealso cref="SETFRAMENAME"/>
    public string GETFRAMENAME() { throw new NotImplementedException(); }

    /// <summary>
    /// Retrieves the height of the current animation frame (in pixels).
    /// </summary>
    /// <returns>The height of the current animation frame (in pixels).</returns>
    public int GETHEIGHT() { throw new NotImplementedException(); }

    /// <summary>
    /// Checks the height of all compound images and returns the maximum (in pixels).
    /// </summary>
    /// <returns>The maximal possible height of the displayed image (in pixels).</returns>
    // TODO: verify this
    public int GETMAXWIDTH() { throw new NotImplementedException(); }

    /// <summary>
    /// Retrieves the total number of animation events (sequences of frames).
    /// </summary>
    /// <returns>The total number of animation events.</returns>
    public int GETNOE() { throw new NotImplementedException(); }

    /// <summary>
    /// Retrieves the total number of animation frames within the current public event (a sequence of frames).
    /// </summary>
    /// <returns>The total number of animation frames within the current event.</returns>
    // TODO: verify this
    public int GETNOF() { throw new NotImplementedException(); }

    /// <summary>
    /// Retrieves the total number of animation frames within the public event (a sequence of frames) identified by the given name.
    /// </summary>
    /// <param name="event_name">The name of the public event to check.</param>
    /// <returns>The total number of animation frames within the specified event.</returns>
    // TODO: verify this
    public int GETNOFINEVENT(string event_name) { throw new NotImplementedException(); }

    /// <summary>
    /// Retrieves the general opacity of the animation.
    /// </summary>
    /// <returns>The general opacity of the animation.</returns>
    /// <seealso cref="SETOPACITY"/>
    // TODO: verify this (this could be the frame opacity as well)
    public int GETOPACITY() { throw new NotImplementedException(); }

    /// <summary>
    /// Retrieves the horizontal position of the object (in pixels).
    /// </summary>
    /// <returns>The horizontal position of the object (in pixels).</returns>
    /// <seealso cref="GETPOSITIONY"/>
    /// <seealso cref="SETPOSITION"/>
    /// <seealso cref="MOVE"/>
    // TODO: check what "position" means in this context (and if this takes anchor into consideration)
    public int GETPOSITIONX() { throw new NotImplementedException(); }

    /// <summary>
    /// Retrieves the base vertical position of the object (in pixels).
    /// </summary>
    /// <returns>The base vertical position of the object (in pixels).</returns>
    /// <seealso cref="GETPOSITIONX"/>
    /// <seealso cref="SETPOSITION"/>
    /// <seealso cref="MOVE"/>
    // TODO: check what "position" means in this context (and if this takes anchor into consideration)
    public int GETPOSITIONY() { throw new NotImplementedException(); }

    /// <summary>
    /// Retrieves the priority of the object.
    /// </summary>
    /// <returns>The priority of the object.</returns>
    /// <seealso cref="PRIORITY"/>
    /// <seealso cref="SETPRIORITY"/>
    public int GETPRIORITY() { throw new NotImplementedException(); }

    /// <summary>
    /// Retrieves the width of the current animation frame (in pixels).
    /// </summary>
    /// <returns>The width of the current animation frame (in pixels).</returns>
    public int GETWIDTH() { throw new NotImplementedException(); }

    /// <summary>
    /// Makes the object invisible.
    /// </summary>
    /// <seealso cref="VISIBLE"/>
    /// <seealso cref="ISVISIBLE"/>
    /// <seealso cref="SHOW"/>
    public void HIDE() { throw new NotImplementedException(); }

    public void INVALIDATE() { throw new NotImplementedException(); }

    public bool ISAT(int x, int y, bool _) { throw new NotImplementedException(); }

    /// <summary>
    /// Checks if the object is near the <c>other</c> one.
    /// </summary>
    /// Nearness is decided based on the Intersection over Union metric between the two objects.
    /// If it is greater or equal to \a iou_threshold, the objects are considered as being near each other.
    /// <param name="other">Another graphics object for which nearness with the current object is checked.</param>
    /// <param name="iou_threshold">Minimum IoU value to treat two objects as being near each other.</param>
    /// <returns>A boolean value indicating if objects are near each other.</returns>
    public bool ISNEAR(string other, string iou_threshold) { throw new NotImplementedException(); }

    /// <summary>
    /// Checks if any animation public event (a sequence of frames) is currently being played.
    /// </summary>
    /// <returns>Boolean value indicating if any animation public event is currently being played.</returns>
    /// <seealso cref="PLAY(string)"/>
    /// <seealso cref="PLAY(int)"/>
    /// <seealso cref="STOP"/>
    /// <seealso cref="PAUSE"/>
    /// <seealso cref="RESUME"/>
    public bool ISPLAYING() { throw new NotImplementedException(); }

    /// <summary>
    /// Checks if the object is visible.
    /// </summary>
    /// <returns>A boolean value indicating if the object is visible.</returns>
    /// <seealso cref="VISIBLE"/>
    /// <seealso cref="HIDE"/>
    /// <seealso cref="SHOW"/>
    public bool ISVISIBLE() { throw new NotImplementedException(); }

    /// <summary>
    /// Loads animation data from the file located at the given path.
    /// </summary>
    /// <param name="filename">The path where the file is located.</param>
    public void LOAD(string filename) { throw new NotImplementedException(); }

    public void MERGEALPHA() { throw new NotImplementedException(); }

    /// <summary>
    /// Enables the 2D collision detection for the object.
    /// </summary>
    /// <param name="pixel_perfect">Should the pixel-perfect collision algorithm be used instead of the default AABB one?</param>
    /// <seealso cref="MONITORCOLLISIONඞ"/>
    /// <seealso cref="MONITORCOLLISIONALPHA"/>
    /// <seealso cref="REMOVEMONITORCOLLISION"/>
    public void MONITORCOLLISION(bool pixel_perfect) { throw new NotImplementedException(); }

    /// <summary>
    /// Moves the animation object by the given offset (in pixels).
    /// </summary>
    /// <param name="x_offset">A horizontal offset to be added to the current base object position.</param>
    /// <param name="y_offset">A vertical offset to be added to the current base object position.</param>
    /// <seealso cref="GETPOSITIONX"/>
    /// <seealso cref="GETPOSITIONY"/>
    /// <seealso cref="SETPOSITION"/>
    public void MOVE(int x_offset, int y_offset) { throw new NotImplementedException(); }

    public void NEXT() { throw new NotImplementedException(); }

    public void NEXTFRAME() { throw new NotImplementedException(); }

    public void NPLAY() { throw new NotImplementedException(); }

    /// <summary>
    /// Pauses the current animation public event (a sequence of frames).
    /// </summary>
    /// <seealso cref="RESUME"/>
    /// <seealso cref="ISPLAYING"/>
    /// <seealso cref="PLAY(string)"/>
    /// <seealso cref="PLAY(int)"/>
    /// <seealso cref="STOP"/>
    // TODO: what if animation isn't currently playing?
    public void PAUSE() { throw new NotImplementedException(); }

    /// <summary>
    /// Plays animation public event identified by name <paramref name="event_name"/>.
    /// </summary>
    /// <remarks>
    /// Makes the object visible.
    ///
    /// Animation can loop depending on its definition (see ANN format specification).
    /// </remarks>
    /// <param name="event_name">The name of the animation public event to be played.</param>
    /// <seealso cref="PLAY(int)"/>
    /// <seealso cref="ISPLAYING"/>
    /// <seealso cref="STOP"/>
    /// <seealso cref="PAUSE"/>
    /// <seealso cref="RESUME"/>
    // TODO: what if animation is currently playing?
    public void PLAY(string event_name) { throw new NotImplementedException(); }

    /// <summary>
    /// Plays animation public event identified by index <paramref name="event_index"/>.
    /// </summary>
    /// <remarks>
    /// Makes the object visible.
    ///
    /// Animation can loop depending on its definition (see ANN format specification).
    /// </remarks>
    /// <param name="event_index">The 0-based index of the animation public event to be played.</param>
    /// <seealso cref="PLAY(string)"/>
    /// <seealso cref="ISPLAYING"/>
    /// <seealso cref="STOP"/>
    /// <seealso cref="PAUSE"/>
    /// <seealso cref="RESUME"/>
    // TODO: what if animation is currently playing?
    public void PLAY(int event_index) { throw new NotImplementedException(); }

    public void PREVFRAME() { throw new NotImplementedException(); }

    /// <summary>
    /// Disables the 2D collision detection for the object.
    /// </summary>
    /// <seealso cref="MONITORCOLLISIONඞ"/>
    /// <seealso cref="MONITORCOLLISIONALPHA"/>
    /// <seealso cref="MONITORCOLLISION"/>
    public void REMOVEMONITORCOLLISION() { throw new NotImplementedException(); }

    /// <summary>
    /// Unpauses the current animation public event (a sequence of frames).
    /// </summary>
    /// <seealso cref="PAUSE"/>
    /// <seealso cref="ISPLAYING"/>
    /// <seealso cref="PLAY(string)"/>
    /// <seealso cref="PLAY(int)"/>
    /// <seealso cref="STOP"/>
    // TODO: what if animation isn't currently playing?
    // TODO: what if animation isn't currently paused?
    public void RESUME() { throw new NotImplementedException(); }

    public void SETANCHOR(anchor anchor) { throw new NotImplementedException(); }

    /// <summary>
    /// Enables or disables the object being interactable.
    /// </summary>
    /// <remarks>
    /// Interactibility means reacting to mouse cursor being hovered and mouse button being clicked over the displayed object.
    /// In reaction to these events, the following signals are fires: <see cref="ONFOCUSON"/>, <see cref="ONFOCUSOFF"/>, <see cref="ONCLICK"/>, <see cref="ONRELEASE"/>.
    ///
    /// The interactable area is the AABB representing the frame at the time of calling the method.
    /// </remarks>
    /// <param name="as_button">Should interactibility be enabled?</param>
    /// <param name="with_cursor_pointer">Should the mouse cursor icon be changed to pointer when it hovers over the interactable area? The argument is ignored if <paramref name="as_button"/> is FALSE.</param>
    // TODO: verify this
    public void SETASBUTTON(bool as_button, bool with_cursor_pointer) { throw new NotImplementedException(); }

    public void SETBACKWARD() { throw new NotImplementedException(); }

    public void SETCLIPPING() { throw new NotImplementedException(); }

    public void SETFORWARD() { throw new NotImplementedException(); }

    /// <summary>
    /// Sets the animation speed (in frames per second).
    /// </summary>
    /// <remarks>
    /// The property overrides settings from a file.
    /// </remarks>
    /// <seealso cref="FPS"/>
    public void SETFPS(int fps) { throw new NotImplementedException(); }

    /// <summary>
    /// Changes the currently displayed frame to the image identified by the given index.
    /// </summary>
    /// <remarks>
    /// If any animation public event (a sequence of frames) is currently played, the image set by this method gets overwritten by the next update.
    /// </remarks>
    /// <param name="image_index"></param>
    /// <seealso cref="GETFRAME"/>
    /// <seealso cref="SETFRAME(string, int)"/>
    public void SETFRAME(int image_index) { throw new NotImplementedException(); }

    /// <summary>
    /// Changes the currently displayed frame to the one identified by the given index within the public event of name <paramref name="event_name"/>.
    /// </summary>
    /// <param name="event_name"></param>
    /// <param name="frame_index"></param>
    /// <seealso cref="GETFRAME"/>
    /// <seealso cref="SETFRAME(int)"/>
    // TODO: what if an public event is being played? (two case: changing only frame and changing the public event too)
    public void SETFRAME(string event_name, int frame_index) { throw new NotImplementedException(); }

    /// <summary>
    /// Changes the name of the current frame.
    /// </summary>
    /// <param name="frame_name">The name to be set.</param>
    /// <seealso cref="GETFRAMENAME"/>
    public void SETFRAMENAME(string frame_name) { throw new NotImplementedException(); }

    /// <summary>
    /// Sets the general opacity of the animation.
    /// </summary>
    /// <param name="opacity">The opacity to be set.</param>
    /// <seealso cref="GETOPACITY"/>
    // TODO: verify this (this could be the frame opacity as well)
    public void SETOPACITY(int opacity) { throw new NotImplementedException(); }

    /// <summary>
    /// Sets the base position of the animation.
    /// </summary>
    /// <param name="x">The horizontal position to be set (in pixels).</param>
    /// <param name="y">The vertical position to be set (in pixels).</param>
    /// <seealso cref="GETPOSITIONX"/>
    /// <seealso cref="GETPOSITIONY"/>
    /// <seealso cref="MOVE"/>
    public void SETPOSITION(int x, int y) { throw new NotImplementedException(); }

    /// <summary>
    /// Sets the priority of the object.
    /// </summary>
    /// <param name="priority">The priority to be set.</param>
    /// <seealso cref="PRIORITY"/>
    /// <seealso cref="GETPRIORITY"/>
    public void SETPRIORITY(int priority) { throw new NotImplementedException(); }

    /// <summary>
    /// Makes the object visible.
    /// </summary>
    /// <seealso cref="VISIBLE"/>
    /// <seealso cref="HIDE"/>
    /// <seealso cref="ISVISIBLE"/>
    public void SHOW() { throw new NotImplementedException(); }

    /// <summary>
    /// Stops the animation public event (a sequence of frames) being currently played.
    /// </summary>
    /// <param name="emit_on_finished">Should the <see cref="ONFINISHED"/> signal be emitted?</param>
    // TODO: is the frame index rewound to 0?
    public void STOP(bool emit_on_finished = true) { throw new NotImplementedException(); }


    /// <summary>
    /// A handler for the signal emitted when the object is in interactive mode and a mouse button is pressed over it.
    /// </summary>
    /// <seealso cref="SETASBUTTON"/>
    // TODO: LMB, RMB, MMD?
    public event SignalHandler? ONCLICK;

    /// <summary>
    /// A handler for the signal emitted when the object is in collision with another object.
    /// </summary>
    /// <remarks>
    /// Can be specialized using the <see cref="other_name"/> parameter which is the name of the object with which the current object collides.
    /// </remarks>
    /// <seealso cref="MONITORCOLLISIONඞ"/>
    /// <seealso cref="MONITORCOLLISIONALPHA"/>
    /// <seealso cref="MONITORCOLLISION"/>
    /// <seealso cref="REMOVEMONITORCOLLISION"/>
    // TODO: is it emitted every frame?
    public event SignalHandler<other_name>? ONCOLLISION;

    /// <summary>
    /// A handler for the signal emitted when an animation public event has finished playing.
    /// </summary>
    /// <remarks>
    /// Can be specialized using the <see cref="event_name"/> parameter which is the name of the finished event.
    /// </remarks>
    /// <seealso cref="STOP"/>
    /// <seealso cref="PLAY"/>
    public event SignalHandler<event_name>? ONFINISHED;

    /// <summary>
    /// A handler for the signal emitted when the object is in interactive mode and the mouse cursors is moved onto it.
    /// </summary>
    /// <seealso cref="SETASBUTTON"/>
    public event SignalHandler? ONFOCUSON;

    /// <summary>
    /// A handler for the signal emitted when the object is in interactive mode and the mouse cursors is moved outside its area.
    /// </summary>
    /// <seealso cref="SETASBUTTON"/>
    public event SignalHandler? ONFOCUSOFF;

    /// <summary>
    /// A handler for the signal emitted when the displayed frame changes as a result of an animation public event being played.
    /// </summary>
    /// <remarks>
    /// Can be specialized using the <see cref="event_name"/> parameter which is the name of the public event currently being played.
    /// </remarks>
    /// <seealso cref="PLAY"/>
    public event SignalHandler? ONFRAMECHANGED;

    /// <summary>
    /// A handler for the signal emitted when the object is initialized.
    /// </summary>
    public event SignalHandler? ONINIT;

    /// <summary>
    /// A handler for the signal emitted when the object is in interactive mode and a mouse button is released over it.
    /// </summary>
    /// <seealso cref="SETASBUTTON"/>
    // TODO: LMB, RMB, MMD?
    public event SignalHandler? ONRELEASE;

    /// <summary>
    /// A handler for the signal emitted when a custom message is sent.
    /// </summary>
    /// <remarks>
    /// Can be specialized using the <see cref="event_name"/> parameter which is the name of the public event currently being played.
    /// </remarks>
    // TODO: OBJECT^SEND is not a part of official documentation sadly - is there any game employing it?
    public event SignalHandler<signal_name>? ONSIGNAL;

    /// <summary>
    /// A handler for the signal emitted when an animation public event has started playing.
    /// </summary>
    /// <remarks>
    /// Can be specialized using the <see cref="event_name"/> parameter which is the name of the started event.
    /// </remarks>
    /// <seealso cref="PLAY"/>
    public event SignalHandler<event_name>? ONSTARTED;
}
