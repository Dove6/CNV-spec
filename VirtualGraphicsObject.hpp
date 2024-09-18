#include "object.hpp"

class VIRTUALGRAPHICSOBJECT : OBJECT {
public:
    integer GETHEIGHT();
    integer GETPOSITIONX();
    integer GETPOSITIONY();
    integer GETWIDTH();
    void MOVE(integer x_offset, integer y_offset);
    void SETMASK(string);
    void SETPOSITION(integer x, integer y);
    void SETPRIORITY(integer priority);
    void SETSOURCE(string);
};
