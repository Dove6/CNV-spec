#include "object.hpp"

class CONDITION : OBJECT {
public:
    const string OPERAND1;
    const string OPERAND2;
    const string OPERATOR;

    void BREAK(bool);
    bool CHECK(bool);
    void ONE_BREAK(bool);
};
