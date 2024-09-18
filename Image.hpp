#include "object.hpp"

class IMAGE : OBJECT {
public:
    const string FILENAME;
    const bool MONITORCOLLISION;
    const bool MONITORCOLLISIONALPHA;
    const bool PRELOAD;
    const integer PRIORITY;
    const bool RELEASE;
    const bool TOCANVAS;
    const bool VISIBLE;

    void GETALPHA();
    void GETHEIGHT();
    void GETPIXEL();
    void GETPOSITIONX();
    void GETPOSITIONY();
    void GETWIDTH();
    void HIDE();
    void INVALIDATE();
    void ISVISIBLE();
    void LOAD();
    void MERGEALPHA(integer, integer, string);
    void MOVE(integer, integer);
    void SETASBUTTON();
    void SETCLIPPING(integer, integer, integer, integer);
    void SETOPACITY();
    void SETPOSITION(integer, integer);
    void SETPRIORITY();
    void SHOW();
};
