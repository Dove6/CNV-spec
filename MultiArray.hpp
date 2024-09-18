#include "object.hpp"

class MULTIARRAY : OBJECT {
public:
    opt_variable GET(integer_list indices);
    void SET(integer_list indices, variable value);
};
