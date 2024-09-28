using abstractions;

namespace PIKLib;

public class SOUND : OBJECT {
    public string FILENAME { private get; init; }
    public bool FLUSHAFTERPLAYED { private get; init; }
    public bool PRELOAD { private get; init; }
    public bool RELEASE { private get; init; }

    public bool ISPLAYING() { throw new NotImplementedException(); }
    public void LOAD(string filename) { throw new NotImplementedException(); }
    public void PAUSE() { throw new NotImplementedException(); }
    public void PLAY() { throw new NotImplementedException(); }
    public void RESUME() { throw new NotImplementedException(); }
    public void SETVOLUME(int volume) { throw new NotImplementedException(); }
    public void STOP() { throw new NotImplementedException(); }

    public event SignalHandler? ONFINISHED;
    public event SignalHandler? ONINIT;
    public event SignalHandler? ONSTARTED;
}
