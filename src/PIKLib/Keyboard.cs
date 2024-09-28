using abstractions;
using char_name = System.String;

namespace PIKLib;

public class KEYBOARD : OBJECT {
    public void DISABLE() { throw new NotImplementedException(); }
    public void ENABLE() { throw new NotImplementedException(); }
    public void GETLATESTKEY() { throw new NotImplementedException(); }
    public bool ISENABLED() { throw new NotImplementedException(); }
    public bool ISKEYDOWN() { throw new NotImplementedException(); }
    public void SETAUTOREPEAT() { throw new NotImplementedException(); }

    public event SignalHandler<char_name>? ONCHAR;
    public event SignalHandler? ONKEYDOWN;
    public event SignalHandler? ONKEYUP;
}
