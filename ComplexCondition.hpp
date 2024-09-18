#include "object.hpp"

class COMPLEXCONDITION : OBJECT {
public:
    const string CONDITION1;
    const string CONDITION2;
    const string OPERATOR;

    void BREAK();
    bool CHECK(bool);
    void ONE_BREAK();
};
