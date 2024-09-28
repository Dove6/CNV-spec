using _abstractions;

namespace PIKLib;

public interface MUSIC : OBJECT {
    string FILENAME { init; }

    void PLAY();
}
