using _abstractions;

namespace PIKLib;

public class COMPLEXCONDITION : OBJECT {
    public string CONDITION1 { private get; init; }
    public string CONDITION2 { private get; init; }
    public complex_operator OPERATOR { private get; init; }

    public void BREAK(bool _) { throw new NotImplementedException(); }
    public bool CHECK(bool _) { throw new NotImplementedException(); }
    public void ONE_BREAK(bool _) { throw new NotImplementedException(); }

    event SignalHandler ONRUNTIMEFAILED;
    event SignalHandler ONRUNTIMESUCCESS;
}
