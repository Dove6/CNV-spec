using _global;

namespace Inertia;

/// <summary>
/// 2D physics simulation.
/// </summary>
/// Implemented by <c>Inertia.dll</c>
public interface INERTIA : OBJECT {
    void ADDFORCE(int id, double x, double y);
    int CREATESPHERE(double _1, double _2, double _3, double _4);
    void DELETEBODY(int id);
    double GETPOSITIONX(int id);
    double GETPOSITIONY(int id);
    double GETSPEED(int id);
    void LINK(int id, string object_name, bool _1, bool _2);
    void LOAD(string filename);
    void RESETTIMER();
    void SETGRAVITY(double x, double y);
    void SETLINEARDAMPING(double x, double y);
    void SETMATERIAL(int id, string material_name);
    void SETPOSITION(int id, double x, double y);
    void SETVELOCITY(int id, double x, double y);
    void TICK();
    void UNLINK(int id);
}
