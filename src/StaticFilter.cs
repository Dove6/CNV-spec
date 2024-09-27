namespace CnvAPI;

public interface STATICFILTER : OBJECT {
    void LINK(string graphics_name);
    void SETPROPERTY(string key, variable value);
    void UNLINK(string graphics_name);
}
