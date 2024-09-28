namespace abstractions;

public abstract class OBJECT {
    public string DESCRIPTION  { private get; init; }
    public string TYPE  { private get; init; }

    public void ADDBEHAVIOUR(string signal_name, string code) { throw new NotImplementedException(); }
    public void CLONE(int count = 1) { throw new NotImplementedException(); }
    public int GETCLONEINDEX() { throw new NotImplementedException(); }
    public string GETNAME() { throw new NotImplementedException(); }
    public void MSGBOX(string message) { throw new NotImplementedException(); }
    public void REMOVEBEHAVIOUR(string signal_name) { throw new NotImplementedException(); }
    public void RESETCLONES() { throw new NotImplementedException(); }
}
