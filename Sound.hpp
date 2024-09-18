#include "object.hpp"

class SOUND : OBJECT {
public:
    bool ISPLAYING();
    void LOAD(string filename);
    void PAUSE();
    void PLAY();
    void RESUME();
    void SETVOLUME(integer volume);
    void STOP();
};
