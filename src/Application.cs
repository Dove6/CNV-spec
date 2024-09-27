using _global;

namespace PIKLib;

public interface APPLICATION : OBJECT {
    string AUTHOR { init; }
    string BLOOMOO_VERSION { init; }
    string CREATIONTIME { init; }
    string EPISODES { init; }
    string LASTMODIFYTIME { init; }
    string PATH { init; }
    string STARTWITH { init; }
    string VERSION { init; }

    void EXIT();
    string GETLANGUAGE();
    variable? RUN(string object_name, string method_name, params variable[] arguments);
    variable? RUNENV(string scene_name, string beh_name);
    void SETLANGUAGE(string lang_id);
}
