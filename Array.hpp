#include "object.hpp"

class ARRAY : OBJECT {
public:
    void ADD();
    void ADDAT(integer index, variable summand);
    void CHANGEAT(integer index, variable value);
    void CLAMPAT(integer index, variable min, variable max);
    void CONTAINS(variable value);
    void COPYTO();
    void FIND();
    void GET(integer);
    void GETSIZE();
    void GETSUMVALUE();
    void INSERTAT(integer index, variable value);
    void LOAD();
    void LOADINI();
    void MODAT();
    void MULAT();
    void REMOVE();
    void REMOVEALL();
    void REMOVEAT();
    void REVERSEFIND();
    void SAVE();
    void SAVEINI();
    void SUB();
    void SUBAT();
    void SUM();
};
