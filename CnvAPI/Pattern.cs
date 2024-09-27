namespace CnvAPI;

public interface PATTERN : OBJECT {
    void ADD(string _, int x, int y, string object_name, int _2);
    string GETGRAPHICSAT(int x, int y, bool _, bool _2, int _3);
    void MOVE(int x, int y);
}
