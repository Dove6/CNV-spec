using _abstractions;

namespace PIKLib;

public interface MOUSE : OBJECT {
    int? RAW { init;  }

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

    event ParametrizedSignalHandler ONCLICK;
    event SignalHandler ONDBLCLICK;
    event SignalHandler ONINIT;
    event SignalHandler ONMOVE;
    event SignalHandler ONRELEASE;
}
