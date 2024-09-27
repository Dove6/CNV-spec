using _global;

namespace PIKLib;

public interface STRUCT : OBJECT {
    (string, string)[] FIELDS { init; }

    variable GETFIELD(string field_name);
    void SET(string struct_name);
    void SETFIELD(string field_name, variable value);
}
