#include "object.hpp"

class INTEGER : OBJECT {
public:
    const bool TOINI;
    const integer VALUE;
    const string VARTYPE;

    integer ABS(integer);
    integer ADD(integer);
    integer AND(integer);
    integer CLAMP(integer, integer);
    void DEC();
    void DIV(integer);
    void INC();
    integer LENGTH(integer, integer);
    void MOD(integer);
    void MUL(integer);
    integer OR(integer);
    integer RANDOM(integer);
    integer RANDOM(integer, integer);
    void RESETINI();
    void SET(integer);
    integer SUB(integer);
    void SWITCH(integer, integer);
};
