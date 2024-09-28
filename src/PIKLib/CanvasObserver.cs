using abstractions;

namespace PIKLib;

public class CANVAS_OBSERVER : OBJECT {
    public void ADD() { throw new NotImplementedException(); }
    public void ENABLENOTIFY() { throw new NotImplementedException(); }
    public string? GETGRAPHICSAT(int x_position, int y_position) { throw new NotImplementedException(); }
    public string? GETGRAPHICSAT(int x_position, int y_position, bool _unknown, int min_priority, int max_priority, bool pixel_perfect) { throw new NotImplementedException(); }
    public void MOVEBKG(int x_offset, int y_offset) { throw new NotImplementedException(); }
    public void PASTE() { throw new NotImplementedException(); }
    public void REDRAW() { throw new NotImplementedException(); }
    public void REFRESH() { throw new NotImplementedException(); }
    public void REMOVE() { throw new NotImplementedException(); }
    public void SAVE(string filename) { throw new NotImplementedException(); }
    public void SETBACKGROUND(string object_name_or_filename) { throw new NotImplementedException(); }
    public void SETBKGPOS(int x, int y) { throw new NotImplementedException(); }

    event ParametrizedSignalHandler ONWINDOWFOCUSOFF;
    event ParametrizedSignalHandler ONWINDOWFOCUSON;
}
