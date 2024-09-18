#include "object.hpp"

class SEQUENCE : OBJECT {
public:
    string GETEVENTNAME();
    void HIDE();
    bool ISPLAYING();
    void PAUSE();
    void PLAY(string parameter);
    void RESUME();
    void STOP(bool emit_on_finished = true);
};
