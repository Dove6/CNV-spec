#include "object.hpp"

//! 2D physics simulation.
/*!
    Implemented by \c Inertia.dll
*/
class INERTIA : OBJECT {
public:
    void ADDFORCE(integer, double, double);
    integer CREATESPHERE(double, double, double, double);
    void DELETEBODY(integer);
    double GETPOSITIONX(integer);
    double GETPOSITIONY(integer);
    double GETSPEED(integer);
    void LINK(integer, string, bool, bool);
    void LOAD(string);
    void RESETTIMER();
    void SETGRAVITY(double, double);
    void SETLINEARDAMPING(double, double);
    void SETMATERIAL(integer, string);
    void SETPOSITION(integer, double, double);
    void SETVELOCITY(integer, double, double);
    void TICK();
    void UNLINK(integer);
};
