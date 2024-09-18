#include "object.hpp"

class MOUSE : OBJECT {
public:
    void DISABLE();
    void DISABLESIGNAL();
    void ENABLE();
    void ENABLESIGNAL();
    integer GETPOSX();
    integer GETPOSY();
    void HIDE();
    bool ISLBUTTONDOWN();
    void SET();
    void SETCLIPRECT();
    void SETPOSITION(integer x, integer y);
    void SHOW();
};
