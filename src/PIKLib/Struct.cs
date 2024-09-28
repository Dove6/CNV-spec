using abstractions;

namespace PIKLib;

public class STRUCT : OBJECT {
    public (string, string)[] FIELDS { private get; init; }

    public variable GETFIELD(string field_name) { throw new NotImplementedException(); }
    public void SET(string struct_name) { throw new NotImplementedException(); }
    public void SETFIELD(string field_name, variable value) { throw new NotImplementedException(); }
}
