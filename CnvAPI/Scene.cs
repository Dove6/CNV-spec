namespace CnvAPI;

public interface SCENE : OBJECT {
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
