using _global;

namespace PIKLib;

public interface RAND : OBJECT {
    int GET(int max_exclusive);
    int GET(int summand, int max_exclusive);
    void GETPLENTY(string arr_name, int _, int _2, int _3 , bool _4);
}
