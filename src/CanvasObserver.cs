namespace CnvAPI;

public interface CANVAS_OBSERVER : OBJECT {
    void ADD();
    void ENABLENOTIFY();
    string? GETGRAPHICSAT(int x_position, int y_position);
    string? GETGRAPHICSAT(int x_position, int y_position, bool _unknown, int min_priority, int max_priority, bool pixel_perfect);
    void MOVEBKG(int x_offset, int y_offset);
    void PASTE();
    void REDRAW();
    void REFRESH();
    void REMOVE();
    void SAVE(string filename);
    void SETBACKGROUND(string object_name_or_filename);
    void SETBKGPOS(int x, int y);

    event ParametrizedSignalHandler ONWINDOWFOCUSOFF;
    event ParametrizedSignalHandler ONWINDOWFOCUSON;
}
