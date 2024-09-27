namespace CnvAPI;

public interface KEYBOARD : OBJECT {
    void DISABLE();
    void ENABLE();
    void GETLATESTKEY();
    bool ISENABLED();
    bool ISKEYDOWN();
    void SETAUTOREPEAT();
}
