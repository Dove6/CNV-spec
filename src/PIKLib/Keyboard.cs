using _abstractions;

namespace PIKLib;

public interface KEYBOARD : OBJECT {
    void DISABLE();
    void ENABLE();
    void GETLATESTKEY();
    bool ISENABLED();
    bool ISKEYDOWN();
    void SETAUTOREPEAT();

    event ParametrizedSignalHandler ONCHAR;
    event SignalHandler ONKEYDOWN;
    event SignalHandler ONKEYUP;
}
