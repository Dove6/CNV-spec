using _global;

namespace PIKLib;

public interface VECTOR : OBJECT {
    int SIZE { init; }
    double[] VALUE { init; }

    void ADD(string summand_name);
    void ASSIGN(params double[] values);
    double GET(int index);
    double LEN();
    void MUL(double multiplier);
    void NORMALIZE();
    void REFLECT(string normal_name, string result_name);
}
