using abstractions;

namespace PIKLib;

public class BEHAVIOUR : OBJECT {
    public string CODE { private get; init; }
    public string CONDITION { private get; init; }

    public variable? RUN(params variable[] arguments) { throw new NotImplementedException(); }
    public variable? RUNC(params variable[] arguments) { throw new NotImplementedException(); }
    public void RUNLOOPED(int start, int range_size, int step = 1) { throw new NotImplementedException(); }
}
