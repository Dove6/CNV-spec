using abstractions;

namespace Inertia;

/// <summary>
/// 2D physics simulation.
/// </summary>
/// Implemented by <c>Inertia.dll</c>
public class INERTIA : OBJECT {
    public void ADDFORCE(int id, double x, double y) { throw new NotImplementedException(); }
    public int CREATESPHERE(double _1, double _2, double _3, double _4) { throw new NotImplementedException(); }
    public void DELETEBODY(int id) { throw new NotImplementedException(); }
    public double GETPOSITIONX(int id) { throw new NotImplementedException(); }
    public double GETPOSITIONY(int id) { throw new NotImplementedException(); }
    public double GETSPEED(int id) { throw new NotImplementedException(); }
    public void LINK(int id, string object_name, bool _1, bool _2) { throw new NotImplementedException(); }
    public void LOAD(string filename) { throw new NotImplementedException(); }
    public void RESETTIMER() { throw new NotImplementedException(); }
    public void SETGRAVITY(double x, double y) { throw new NotImplementedException(); }
    public void SETLINEARDAMPING(double x, double y) { throw new NotImplementedException(); }
    public void SETMATERIAL(int id, string material_name) { throw new NotImplementedException(); }
    public void SETPOSITION(int id, double x, double y) { throw new NotImplementedException(); }
    public void SETVELOCITY(int id, double x, double y) { throw new NotImplementedException(); }
    public void TICK() { throw new NotImplementedException(); }
    public void UNLINK(int id) { throw new NotImplementedException(); }
}
