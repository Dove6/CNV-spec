using abstractions;

namespace PIKLib;

public class MOUSE : OBJECT {
    public int? RAW { private get; init;  }

    public void DISABLE() { throw new NotImplementedException(); }
    public void DISABLESIGNAL() { throw new NotImplementedException(); }
    public void ENABLE() { throw new NotImplementedException(); }
    public void ENABLESIGNAL() { throw new NotImplementedException(); }
    public int GETPOSX() { throw new NotImplementedException(); }
    public int GETPOSY() { throw new NotImplementedException(); }
    public void HIDE() { throw new NotImplementedException(); }
    public bool ISLBUTTONDOWN() { throw new NotImplementedException(); }
    public void SET() { throw new NotImplementedException(); }
    public void SETCLIPRECT() { throw new NotImplementedException(); }
    public void SETPOSITION(int x, int y) { throw new NotImplementedException(); }
    public void SHOW() { throw new NotImplementedException(); }

    event ParametrizedSignalHandler ONCLICK;
    event SignalHandler ONDBLCLICK;
    event SignalHandler ONINIT;
    event SignalHandler ONMOVE;
    event SignalHandler ONRELEASE;
}
