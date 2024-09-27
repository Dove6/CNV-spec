namespace CnvAPI;

public interface IMAGE : OBJECT {
    string FILENAME { init; }
    bool MONITORCOLLISION { init; }
    bool MONITORCOLLISIONALPHA { init; }
    bool PRELOAD { init; }
    int PRIORITY { init; }
    bool RELEASE { init; }
    bool TOCANVAS { init; }
    bool VISIBLE { init; }

    void GETALPHA();
    void GETHEIGHT();
    void GETPIXEL();
    void GETPOSITIONX();
    void GETPOSITIONY();
    void GETWIDTH();
    void HIDE();
    void INVALIDATE();
    void ISVISIBLE();
    void LOAD();
    void MERGEALPHA(int x_offset, int y_offset, string object_name);
    void MOVE(int x_offset, int y_offset);
    void SETASBUTTON();
    void SETCLIPPING(int left_x, int top_y, int _width, int _height);
    void SETOPACITY();
    void SETPOSITION(int x, int y);
    void SETPRIORITY();
    void SHOW();
}
