using _global;

namespace PIKLib;

public interface MUSIC : OBJECT {
    string FILENAME { init; }

    void PLAY();
}
