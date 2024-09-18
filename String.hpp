#include "object.hpp"

class STRING : OBJECT {
public:
    string ADD(string);
    bool COPYFILE(string, string);
    void CUT(integer, integer);
    integer FIND(string);
    integer FIND(string, integer);
    string GET(integer);
    string GET(integer, integer);
    integer LENGTH();
    void REPLACE(string, string);
    void REPLACEAT(integer, string);
    void RESETINI();
    void SET(string);
    void SUB(integer, integer);
    void UPPER();
};
