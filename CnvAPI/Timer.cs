namespace CnvAPI;

public interface TIMER : OBJECT {
    void DISABLE();
    void ENABLE();
    int GETTICKS();
    void RESET();
    void SET(int _);
    void SETELAPSE(int _);
}
