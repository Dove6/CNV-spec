#include "object.hpp"

class DATABASE : OBJECT {
public:
    const string MODEL;

    void ADD(string);
    integer FIND(string, variable value, integer start_index);
    integer GETCURSORPOS();
    integer GETROWSNO();
    void LOAD(string);
    void NEXT();
    void REMOVEALL();
    void SAVE(string);
    void SELECT(integer row_index);
};
