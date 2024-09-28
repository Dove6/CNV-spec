using _abstractions;

namespace PIKLib;

public class EPISODE : OBJECT {
    public string AUTHOR { private get; init; }
    public string CREATIONTIME { private get; init; }
    public string LASTMODIFYTIME { private get; init; }
    public string PATH { private get; init; }
    public string[] SCENES { private get; init; }
    public string STARTWITH { private get; init; }
    public string VERSION { private get; init; }

    public void BACK() { throw new NotImplementedException(); }
    public string GETCURRENTSCENE() { throw new NotImplementedException(); }
    public string GETLATESTSCENE() { throw new NotImplementedException(); }
    public void GOTO(string scene_name) { throw new NotImplementedException(); }
}
