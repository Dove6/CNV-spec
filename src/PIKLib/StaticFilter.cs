using _abstractions;

namespace PIKLib;

public interface STATICFILTER : OBJECT {
    string ACTION { init; }

    void LINK(string graphics_name);
    void SETPROPERTY(string key, variable value);
    void UNLINK(string graphics_name);
}
