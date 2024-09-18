#include "object.hpp"

class SCENE : OBJECT {
public:
    void GETMAXHSPRIORITY();
    void GETMINHSPRIORITY();
    void GETPLAYINGANIMO();
    void GETPLAYINGSEQ();
    void PAUSE();
    void REMOVECLONES();
    void RESUME();
    opt_variable RUN(string object_name, string method_name, variable_list arguments);
    void RUNCLONES();
    void SETMAXHSPRIORITY();
    void SETMINHSPRIORITY();
    void SETMUSICVOLUME(integer volume);
    void STARTMUSIC();
    void STOPMUSIC();
};
