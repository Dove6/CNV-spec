#include "object.hpp"

class SYSTEM : OBJECT {
public:
    string GETDATE();
    integer GETMHZ();
    integer GETMINUTES();
    integer GETSECONDS();
    integer GETSYSTEMTIME();
};
