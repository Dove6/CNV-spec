namespace CnvAPI;

public interface VIRTUALGRAPHICSOBJECT : OBJECT {
    bool ASBUTTON { init; }
    string MASK { init; }
    bool MONITORCOLLISION { init; }
    bool MONITORCOLLISIONALPHA { init; }
    int PRIORITY { init; }
    string SOURCE { init; }
    bool TOCANVAS { init; }
    bool VISIBLE { init; }

    int GETHEIGHT();
    int GETPOSITIONX();
    int GETPOSITIONY();
    int GETWIDTH();
    void MOVE(int x_offset, int y_offset);
    void SETMASK(string graphics_name);
    void SETPOSITION(int x, int y);
    void SETPRIORITY(int priority);
    void SETSOURCE(string graphics_name);
}
