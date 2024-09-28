using _abstractions;

namespace PIKLib;

public class SCENE : OBJECT {
    public string AUTHOR { private get; init; }
    public string BACKGROUND { private get; init; }
    public string CREATIONTIME { private get; init; }
    public string[] DLLS { private get; init; }
    public string LASTMODIFYTIME { private get; init; }
    public string MUSIC { private get; init; }
    public string PATH { private get; init; }
    public string VERSION { private get; init; }

    public void GETMAXHSPRIORITY() { throw new NotImplementedException(); }
    public void GETMINHSPRIORITY() { throw new NotImplementedException(); }
    public void GETPLAYINGANIMO() { throw new NotImplementedException(); }
    public void GETPLAYINGSEQ() { throw new NotImplementedException(); }
    public void PAUSE() { throw new NotImplementedException(); }
    public void REMOVECLONES() { throw new NotImplementedException(); }
    public void RESUME() { throw new NotImplementedException(); }
    public variable? RUN(string object_name, string method_name, params variable[] arguments) { throw new NotImplementedException(); }
    public void RUNCLONES() { throw new NotImplementedException(); }
    public void SETMAXHSPRIORITY() { throw new NotImplementedException(); }
    public void SETMINHSPRIORITY() { throw new NotImplementedException(); }
    public void SETMUSICVOLUME(int volume) { throw new NotImplementedException(); }
    public void STARTMUSIC() { throw new NotImplementedException(); }
    public void STOPMUSIC() { throw new NotImplementedException(); }
}
