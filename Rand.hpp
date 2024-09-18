#include "object.hpp"

class RAND : OBJECT {
public:
    integer GET(integer max_exclusive);
    integer GET(integer summand, integer max_exclusive);
    void GETPLENTY(string arr_name, integer, integer, integer, bool);
};
