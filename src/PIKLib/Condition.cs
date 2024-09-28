using _abstractions;

namespace PIKLib;

public class CONDITION : OBJECT {
    public string OPERAND1 { private get; init; }
    public string OPERAND2 { private get; init; }
    public condition_operator OPERATOR { private get; init; }

    public void BREAK(bool _) { throw new NotImplementedException(); }
    public bool CHECK(bool _) { throw new NotImplementedException(); }
    public void ONE_BREAK(bool _) { throw new NotImplementedException(); }

    event SignalHandler ONRUNTIMEFAILED;
    event SignalHandler ONRUNTIMESUCCESS;
}
