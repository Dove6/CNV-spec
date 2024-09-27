namespace CnvAPI;

public interface DATABASE : OBJECT {
    string MODEL { init; }

    void ADD(string object_name);
    int FIND(string column_name, variable value, int start_row_index);
    int GETCURSORPOS();
    int GETROWSNO();
    void LOAD(string filename);
    void NEXT();
    void REMOVEALL();
    void SAVE(string filename);
    void SELECT(int row_index);
}
