namespace CnvAPI;

public interface GROUP : OBJECT {
    void ADD(string object_name);
    void ADDCLONES();
    void GETSIZE();
    void NEXT();
    void PREV();
    void REMOVE(string object_name);
    void REMOVEALL();
    void RESETMARKER();
    void SETMARKERPOS(int index);
}
