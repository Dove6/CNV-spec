using _abstractions;

namespace PIKLib;

public interface COMPLEXCONDITION : OBJECT {
    string CONDITION1 { init; }
    string CONDITION2 { init; }
    complex_operator OPERATOR { init; }

    void BREAK(bool _);
    bool CHECK(bool _);
    void ONE_BREAK(bool _);

    event SignalHandler ONRUNTIMEFAILED;
    event SignalHandler ONRUNTIMESUCCESS;
}
