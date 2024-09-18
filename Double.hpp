#include "object.hpp"

class DOUBLE : OBJECT {
public:
    const bool TOINI;
    const double VALUE;

    double ADD(double);
    double ARCTAN(double);
    double ARCTANEX(double, double);
    double ARCTANEX(double, double, integer);
    double CLAMP(double, double);
    double COSINUS(double);
    void DIV(double);
    double LENGTH(double, double);
    double MAXA(double);
    double MAXA(double, double);
    double MAXA(double, double, double);
    double MINA(double);
    double MINA(double, double);
    double MINA(double, double, double);
    void MUL(double);
    void SET(double);
    double SINUS(double);
    double SQRT();
    double SUB(double);
};
