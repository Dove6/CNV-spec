using _abstractions;

namespace PIKLib;

public interface SCENE : OBJECT {
    string AUTHOR { init; }
    string BACKGROUND { init; }
    string CREATIONTIME { init; }
    string[] DLLS { init; }
    string LASTMODIFYTIME { init; }
    string MUSIC { init; }
    string PATH { init; }
    string VERSION { init; }

    void GETMAXHSPRIORITY();
    void GETMINHSPRIORITY();
    void GETPLAYINGANIMO();
    void GETPLAYINGSEQ();
    void PAUSE();
    void REMOVECLONES();
    void RESUME();
    variable? RUN(string object_name, string method_name, params variable[] arguments);
    void RUNCLONES();
    void SETMAXHSPRIORITY();
    void SETMINHSPRIORITY();
    void SETMUSICVOLUME(int volume);
    void STARTMUSIC();
    void STOPMUSIC();
}
