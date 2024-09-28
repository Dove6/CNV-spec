using _abstractions;

namespace PIKLib;

public interface SOUND : OBJECT {
    string FILENAME { init; }
    bool FLUSHAFTERPLAYED { init; }
    bool PRELOAD { init; }
    bool RELEASE { init; }

    bool ISPLAYING();
    void LOAD(string filename);
    void PAUSE();
    void PLAY();
    void RESUME();
    void SETVOLUME(int volume);
    void STOP();

    event SignalHandler ONFINISHED;
    event SignalHandler ONINIT;
    event SignalHandler ONSTARTED;
}
