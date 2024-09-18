#include "object.hpp"

class APPLICATION : OBJECT {
public:
    string AUTHOR;
    string BLOOMOO_VERSION;
    string CREATIONTIME;
    string EPISODES;
    string LASTMODIFYTIME;
    string PATH;
    string STARTWITH;
    string VERSION;

    void EXIT();
    string GETLANGUAGE();
    opt_variable RUN(string object_name, string method_name, variable_list arguments);
    opt_variable RUNENV(string scene_name, string beh_name);
    void SETLANGUAGE(string lang_id);
};
