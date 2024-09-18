#include "object.hpp"

class BUTTON : OBJECT {
public:
    const bool DRAGGABLE;
    const bool ENABLE;
    const string GFXONCLICK;
    const string GFXONMOVE;
    const string GFXSTANDARD;
    const rect RECT;
    const string SNDONMOVE;

    void DISABLE();
    void DISABLEBUTVISIBLE();
    void ENABLE();
    string GETSTD();
    void SETONCLICK(string object_name);
    void SETONMOVE(string object_name);
    void SETPRIORITY(integer priority);
    void SETRECT(string object_name);
    void SETRECT(integer left_x, integer top_y, integer right_x, integer bottom_y);
    void SETSTD(string object_name);
};
