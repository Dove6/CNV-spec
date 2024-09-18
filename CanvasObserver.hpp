#include "object.hpp"

class CANVAS_OBSERVER : OBJECT {
public:
    void ADD();
    void ENABLENOTIFY();
    opt_string GETGRAPHICSAT(integer, integer, bool, integer, integer, bool);
    void MOVEBKG(integer x_offset, integer y_offset);
    void PASTE();
    void REDRAW();
    void REFRESH();
    void REMOVE();
    void SAVE(string filename);
    void SETBACKGROUND(string object_name_or_filename);
    void SETBKGPOS(integer x, integer y);
};
