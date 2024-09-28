using abstractions;

namespace PIKLib;

public class APPLICATION : OBJECT {
    public string AUTHOR { private get; init; }
    public string BLOOMOO_VERSION { private get; init; }
    public string CREATIONTIME { private get; init; }
    public string EPISODES { private get; init; }
    public string LASTMODIFYTIME { private get; init; }
    public string PATH { private get; init; }
    public string STARTWITH { private get; init; }
    public string VERSION { private get; init; }

    public void EXIT() { throw new NotImplementedException(); }
    public string GETLANGUAGE() { throw new NotImplementedException(); }
    public variable? RUN(string object_name, string method_name, params variable[] arguments) { throw new NotImplementedException(); }
    public variable? RUNENV(string scene_name, string beh_name) { throw new NotImplementedException(); }
    public void SETLANGUAGE(string lang_id) { throw new NotImplementedException(); }
}
