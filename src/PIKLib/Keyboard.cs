using abstractions;

namespace PIKLib;

public class KEYBOARD : OBJECT {
    public void DISABLE() { throw new NotImplementedException(); }
    public void ENABLE() { throw new NotImplementedException(); }
    public void GETLATESTKEY() { throw new NotImplementedException(); }
    public bool ISENABLED() { throw new NotImplementedException(); }
    public bool ISKEYDOWN() { throw new NotImplementedException(); }
    public void SETAUTOREPEAT() { throw new NotImplementedException(); }

    event ParametrizedSignalHandler ONCHAR;
    event SignalHandler ONKEYDOWN;
    event SignalHandler ONKEYUP;
}
