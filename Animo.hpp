#include "object.hpp"

//! 2D sprite animation.
class ANIMO : OBJECT {
public:
    const string FILENAME;
    const integer FPS;
    const bool MONITORCOLLISION;
    const bool MONITORCOLLISIONALPHA;
    const bool PRELOAD;
    const integer PRIORITY;
    const bool RELEASE;
    const bool TOCANVAS;
    const bool VISIBLE;

    /*! \brief Retrieves the horizontal position of the center of the object.

        \return Horizontal position of the object's center.
    */
    integer GETCENTERX();

    integer GETCENTERY();
    integer GETCFRAMEINEVENT();
    integer GETCURRFRAMEPOSX();
    integer GETCURRFRAMEPOSY();
    integer GETENDX();
    integer GETENDY();
    string GETEVENTNAME();
    integer GETFRAME();
    string GETFRAMENAME();
    integer GETHEIGHT();
    integer GETMAXWIDTH();
    integer GETNOE();
    integer GETNOF();
    integer GETNOFINEVENT(string event_name);
    integer GETOPACITY();
    integer GETPOSITIONX();
    integer GETPOSITIONY();
    integer GETPRIORITY();
    integer GETWIDTH();

    /*! \brief Hides the object.
    */
    void HIDE();
    void INVALIDATE();
    bool ISAT();
    
    /*! \brief Checks if the object is near the \a other one.

        Nearness is decided based on the Intersection over Union metric between the two objects.
        If it is greater or equal to \a iou_threshold, the objects are considered as being near each other.

        \param other Another graphics object for which nearness with the current object is checked.
        \param iou_threshold Minimum IoU value to treat two objects as being near each other.

        \return Boolean value indicating if objects are near each other.
    */
    bool ISNEAR(string other, string iou_threshold);
    bool ISPLAYING();
    bool ISVISIBLE();
    void LOAD(string filename);
    void MERGEALPHA();
    void MONITORCOLLISION(bool pixel_perfect);
    void MOVE(integer x_offset, integer y_offset);
    void NEXT();
    void NEXTFRAME();
    void NPLAY();
    void PAUSE();
    
    /*! \brief Plays animation event identified by name \a event_name.
    
        Makes the object visible.
        Animation can loop depending on its definition (see ANN format specification)

        \param event_name The name of the animation event to play.
    */
    void PLAY(string event_name);
    void PLAY(integer event_index);
    void PREVFRAME();
    void REMOVEMONITORCOLLISION();
    void RESUME();
    void SETANCHOR(anchor anchor);
    void SETASBUTTON(bool as_button, bool with_cursor_pointer);
    void SETBACKWARD();
    void SETCLIPPING();
    void SETFORWARD();
    void SETFPS(integer fps);
    void SETFRAME(integer image_index);
    void SETFRAME(string event_name, integer frame_index);
    void SETFRAMENAME(string frame_name);
    void SETOPACITY(integer opacity);
    void SETPOSITION(integer x, integer y);
    void SETPRIORITY(integer priority);
    void SHOW();
    void STOP(bool emit_on_finished = true);
};
