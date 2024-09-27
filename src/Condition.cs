using _global;

namespace PIKLib;

public interface CONDITION : OBJECT {
    string OPERAND1 { init; }
    string OPERAND2 { init; }
    condition_operator OPERATOR { init; }

    void BREAK(bool _);
    bool CHECK(bool _);
    void ONE_BREAK(bool _);

    event SignalHandler ONRUNTIMEFAILED;
    event SignalHandler ONRUNTIMESUCCESS;
}
