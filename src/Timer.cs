using _global;

namespace PIKLib;

public interface TIMER : OBJECT {
    int ELAPSE { init; }
    bool ENABLED { init; }
    int TICKS { init; }

    void DISABLE();
    void ENABLE();
    int GETTICKS();
    void RESET();
    void SET(int _);
    void SETELAPSE(int _);

    event SignalHandler ONINIT;
    event ParametrizedSignalHandler ONTICK;
}
