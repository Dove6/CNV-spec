using _abstractions;

namespace PIKLib;

public interface ARRAY : OBJECT {
    void ADD();
    void ADDAT(int index, variable summand);
    void CHANGEAT(int index, variable value);
    void CLAMPAT(int index, variable min, variable max);
    void CONTAINS(variable value);
    void COPYTO();
    void FIND();
    void GET(int index);
    void GETSIZE();
    void GETSUMVALUE();
    void INSERTAT(int index, variable value);
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
}
