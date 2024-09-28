using _abstractions;

namespace PIKLib;

public interface STRING : OBJECT {
    bool TOINI { init; }
    string VALUE { init; }

    string ADD(string suffix);
    bool COPYFILE(string filename, string copied_filename);
    void CUT(int index, int length);
    int FIND(string needle, int start_index = 0);
    string GET(int start_index);
    string GET(int start_index, int length);
    int LENGTH();
    void REPLACE(string search, string replace);
    void REPLACEAT(int index, string replace);
    void RESETINI();
    void SET(string value);
    void SUB(int index, int length);
    void UPPER();

    event ParametrizedSignalHandler ONBRUTALCHANGED;
    event ParametrizedSignalHandler ONCHANGED;
    event SignalHandler ONINIT;
}
