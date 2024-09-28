using abstractions;

namespace PIKLib;

public class GROUP : OBJECT {
    public void ADD(string object_name) { throw new NotImplementedException(); }
    public void ADDCLONES() { throw new NotImplementedException(); }
    public void GETSIZE() { throw new NotImplementedException(); }
    public void NEXT() { throw new NotImplementedException(); }
    public void PREV() { throw new NotImplementedException(); }
    public void REMOVE(string object_name) { throw new NotImplementedException(); }
    public void REMOVEALL() { throw new NotImplementedException(); }
    public void RESETMARKER() { throw new NotImplementedException(); }
    public void SETMARKERPOS(int index) { throw new NotImplementedException(); }

    event SignalHandler ONINIT;
}
