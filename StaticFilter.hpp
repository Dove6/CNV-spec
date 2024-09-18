#include "object.hpp"

class STATICFILTER : OBJECT {
public:
    void LINK(string);
    void SETPROPERTY(string key, variable value);
    void UNLINK(string);
};
