namespace CnvAPI;

public interface STRUCT : OBJECT {
    variable GETFIELD(string field_name);
    void SET(string struct_name);
    void SETFIELD(string field_name, variable value);
}
