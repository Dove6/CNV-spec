using abstractions;
using stringified_tick_number = System.String;

namespace PIKLib;

public class TIMER : OBJECT {
    public int ELAPSE { private get; init; }
    public bool ENABLED { private get; init; }
    public int TICKS { private get; init; }

    public void DISABLE() { throw new NotImplementedException(); }
    public void ENABLE() { throw new NotImplementedException(); }
    public int GETTICKS() { throw new NotImplementedException(); }
    public void RESET() { throw new NotImplementedException(); }
    public void SET(int _) { throw new NotImplementedException(); }
    public void SETELAPSE(int _) { throw new NotImplementedException(); }

    public event SignalHandler? ONINIT;
    public event SignalHandler<stringified_tick_number>? ONTICK;
}
