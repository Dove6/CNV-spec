#ifndef OBJECT_HPP
#define OBJECT_HPP

#include "types.hpp"

class OBJECT {
public:
    const string DESCRIPTION;
    const string TYPE;

    void ADDBEHAVIOUR(string signal_name, string code);
    void CLONE(integer count = 1);
    integer GETCLONEINDEX();
    string GETNAME();
    void MSGBOX(string message);
    void REMOVEBEHAVIOUR(string signal_name);
    void RESETCLONES();
};

#endif
