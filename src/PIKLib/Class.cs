using _abstractions;

namespace PIKLib;

public interface CLASS : OBJECT {
    string BASE { init; }
    string DEF { init; }

    void NEW(string object_name, params variable[] arguments);
}
