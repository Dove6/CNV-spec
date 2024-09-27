namespace CnvAPI;

public interface VECTOR : OBJECT {
    void ADD(string summand_name);
    void ASSIGN(params double[] values);
    double GET(int index);
    double LEN();
    void MUL(double multiplier);
    void NORMALIZE();
    void REFLECT(string normal_name, string result_name);
}
