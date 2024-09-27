namespace CnvAPI;

public interface VIRTUALGRAPHICSOBJECT : OBJECT {
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
