#include "object.hpp"

class KEYBOARD : OBJECT {
public:
    void DISABLE();
    void ENABLE();
    void GETLATESTKEY();
    bool ISENABLED();
    bool ISKEYDOWN();
    void SETAUTOREPEAT();
};
