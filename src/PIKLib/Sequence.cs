using abstractions;

namespace PIKLib;

public class SEQUENCE : OBJECT {
    public string FILENAME { private get; init; }

    public string GETEVENTNAME() { throw new NotImplementedException(); }
    public void HIDE() { throw new NotImplementedException(); }
    public bool ISPLAYING() { throw new NotImplementedException(); }
    public void PAUSE() { throw new NotImplementedException(); }
    public void PLAY(string parameter) { throw new NotImplementedException(); }
    public void RESUME() { throw new NotImplementedException(); }
    public void STOP(bool emit_on_finished = true) { throw new NotImplementedException(); }

    event ParametrizedSignalHandler ONFINISHED;
    event SignalHandler ONINIT;
    event ParametrizedSignalHandler ONSTARTED;
}
