using _abstractions;

namespace PIKLib;

public interface SEQUENCE : OBJECT {
    string FILENAME { init; }

    string GETEVENTNAME();
    void HIDE();
    bool ISPLAYING();
    void PAUSE();
    void PLAY(string parameter);
    void RESUME();
    void STOP(bool emit_on_finished = true);

    event ParametrizedSignalHandler ONFINISHED;
    event SignalHandler ONINIT;
    event ParametrizedSignalHandler ONSTARTED;
}
