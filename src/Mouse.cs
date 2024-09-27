namespace CnvAPI;

public interface MOUSE : OBJECT {
    void DISABLE();
    void DISABLESIGNAL();
    void ENABLE();
    void ENABLESIGNAL();
    int GETPOSX();
    int GETPOSY();
    void HIDE();
    bool ISLBUTTONDOWN();
    void SET();
    void SETCLIPRECT();
    void SETPOSITION(int x, int y);
    void SHOW();
}
