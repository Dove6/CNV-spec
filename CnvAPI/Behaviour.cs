namespace CnvAPI;

public interface BEHAVIOUR : OBJECT {
    string CODE { init; }
    string CONDITION { init; }

    variable? RUN(params variable[] arguments);
    variable? RUNC(params variable[] arguments);
    void RUNLOOPED(int start, int range_size, int step = 1);
}
