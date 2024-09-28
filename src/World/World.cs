using _abstractions;

namespace World;

/// <summary>
/// 3D physics simulation.
/// </summary>
/// Implemented by <c>World.dll</c>
public interface WORLD : OBJECT {
    string FILENAME { init; }

    void ADDBODY();
    void ADDFORCE();
    void ADDGRAVITYEX();
    void FINDPATH();
    void FOLLOWPATH();
    void GETANGLE();
    void GETBKGPOSX();
    void GETBKGPOSY();
    void GETMOVEDISTANCE();
    void GETPOSITIONX();
    void GETPOSITIONY();
    void GETPOSITIONZ();
    void GETROTATIONZ();
    void GETSPEED();
    void JOIN();
    void LINK();
    void LOAD();
    void MOVEOBJECTS();
    void REMOVEOBJECT();
    void SETACTIVE();
    void SETBKGSIZE();
    void SETBODYDYNAMICS();
    void SETG();
    void SETGRAVITY();
    void SETGRAVITYCENTER();
    void SETLIMIT();
    void SETMAXSPEED();
    void SETMOVEFLAGS();
    void SETPOSITION();
    void SETREFOBJECT();
    void SETVELOCITY();
    void START();
    void STOP();
    void UNLINK();
}
