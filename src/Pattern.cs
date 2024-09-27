using _global;

namespace PIKLib;

public interface PATTERN : OBJECT {
    int GRIDX { init; }
    int GRIDY { init; }
    int HEIGHT { init; }
    int LAYERS { init; }
    int PRIORITY { init; }
    bool TOCANVAS { init; }
    bool VISIBLE { init; }
    int WIDTH { init; }

    void ADD(string _, int x, int y, string object_name, int _2);
    string GETGRAPHICSAT(int x, int y, bool _, bool _2, int _3);
    void MOVE(int x, int y);
}
