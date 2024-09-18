#include "object.hpp"

class VECTOR : OBJECT {
public:
    void ADD(string);
    void ASSIGN(double);
    void ASSIGN(double, double);
    void ASSIGN(double, double, double);
    double GET(integer index);
    double LEN();
    void MUL(double);
    void NORMALIZE();
    void REFLECT(string, string);
};
