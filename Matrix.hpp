#include "object.hpp"

//! 2D Boulder Dash-like simulation.
/*!
    Implemented by \c Matrix.dll
*/
class MATRIX : OBJECT {
public:
    const "INT, INT",BASEPOS
    const INT,CELLHEIGHT
    const INT,CELLWIDTH
    const "INT, INT",SIZE,n/d,liczba kolu

    integer CALCENEMYMOVEDEST(integer, integer);
    integer CALCENEMYMOVEDIR(integer, integer);
    bool CANHEROGOTO(integer);
    integer GET(integer);
    integer GETCELLOFFSET(integer, integer);
    integer GETCELLPOSX(integer);
    integer GETCELLPOSY(integer);
    integer GETCELLSNO(integer);
    integer GETFIELDPOSX(integer);
    integer GETFIELDPOSY(integer);
    integer GETOFFSET(integer, integer);
    bool ISGATEEMPTY();
    bool ISINGATE(integer);
    void MOVE(integer, integer);
    integer NEXT();
    void SET(integer, integer);
    void SETGATE(integer, integer, integer, integer);
    void SETROW(integer);
    void SETROW(integer, integer);
    void SETROW(integer, integer, integer);
    void TICK();
};
