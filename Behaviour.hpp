#include "object.hpp"

class BEHAVIOUR : OBJECT {
public:
    const string CODE;
    const string CONDITION;

    opt_variable RUN(variable_list arguments);
    opt_variable RUNC(variable_list arguments);
    void RUNLOOPED(integer start, integer range_size, integer step = 1);
};
