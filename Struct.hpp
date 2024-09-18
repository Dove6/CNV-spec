#include "object.hpp"

class STRUCT : OBJECT {
public:
    variable GETFIELD(string);
    void SET(string);
    void SETFIELD(string, variable);
};
