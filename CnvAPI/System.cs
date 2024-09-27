namespace CnvAPI;

public interface SYSTEM : OBJECT {
    string GETDATE();
    int GETMHZ();
    int GETMINUTES();
    int GETSECONDS();
    int GETSYSTEMTIME();
}
