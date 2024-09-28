using abstractions;

namespace PIKLib;

public class STRING : OBJECT {
    public bool TOINI { private get; init; }
    public string VALUE { private get; init; }

    public string ADD(string suffix) { throw new NotImplementedException(); }
    public bool COPYFILE(string filename, string copied_filename) { throw new NotImplementedException(); }
    public void CUT(int index, int length) { throw new NotImplementedException(); }
    public int FIND(string needle, int start_index = 0) { throw new NotImplementedException(); }
    public string GET(int start_index) { throw new NotImplementedException(); }
    public string GET(int start_index, int length) { throw new NotImplementedException(); }
    public int LENGTH() { throw new NotImplementedException(); }
    public void REPLACE(string search, string replace) { throw new NotImplementedException(); }
    public void REPLACEAT(int index, string replace) { throw new NotImplementedException(); }
    public void RESETINI() { throw new NotImplementedException(); }
    public void SET(string value) { throw new NotImplementedException(); }
    public void SUB(int index, int length) { throw new NotImplementedException(); }
    public void UPPER() { throw new NotImplementedException(); }

    public event SignalHandler<stringified_value>? ONBRUTALCHANGED;
    public event SignalHandler<stringified_value>? ONCHANGED;
    public event SignalHandler? ONINIT;
}
