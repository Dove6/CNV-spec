using _abstractions;

namespace PIKLib;

public class DATABASE : OBJECT {
    public string MODEL { private get; init; }

    public void ADD(string object_name) { throw new NotImplementedException(); }
    public int FIND(string column_name, variable value, int start_row_index) { throw new NotImplementedException(); }
    public int GETCURSORPOS() { throw new NotImplementedException(); }
    public int GETROWSNO() { throw new NotImplementedException(); }
    public void LOAD(string filename) { throw new NotImplementedException(); }
    public void NEXT() { throw new NotImplementedException(); }
    public void REMOVEALL() { throw new NotImplementedException(); }
    public void SAVE(string filename) { throw new NotImplementedException(); }
    public void SELECT(int row_index) { throw new NotImplementedException(); }
}
