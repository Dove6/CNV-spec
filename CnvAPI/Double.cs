namespace CnvAPI;

public interface DOUBLE : OBJECT {
    bool TOINI { init; }
    double VALUE { init; }

    double ADD(double summand);
    double ARCTAN(double degrees);
    double ARCTANEX(double y, double x, int summand = 0);
    double CLAMP(double min, double max);
    double COSINUS(double degrees);
    void DIV(double divisor);
    double LENGTH(double horizontal_distance, double vertical_distance);
    double MAXA(params double[] values);
    double MINA(params double[] values);
    void MUL(double multiplier);
    void SET(double value);
    double SINUS(double degrees);
    double SQRT();
    double SUB(double subtrahend);
}
