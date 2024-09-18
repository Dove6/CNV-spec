#include "object.hpp"

class TIMER : OBJECT {
public:
    void DISABLE();
    void ENABLE();
    integer GETTICKS();
    void RESET();
    void SET(integer);
    void SETELAPSE(integer);
};
