namespace CnvAPI;

public interface OBJECT {
    string DESCRIPTION { init; }
    string TYPE { init; }

    void ADDBEHAVIOUR(string signal_name, string code);
    void CLONE(int count = 1);
    int GETCLONEINDEX();
    string GETNAME();
    void MSGBOX(string message);
    void REMOVEBEHAVIOUR(string signal_name);
    void RESETCLONES();
}
