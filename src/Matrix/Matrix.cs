using _abstractions;

namespace Matrix;

/// <summary>
/// 2D Boulder Dash-like simulation.
/// </summary>
/// Implemented by <c>Matrix.dll</c>
public interface MATRIX : OBJECT {
    (int, int) BASEPOS { init; }
    int CELLHEIGHT { init; }
    int CELLWIDTH { init; }
    (int, int) SIZE { init; }

    int CALCENEMYMOVEDEST(int current_cell, int current_direction);
    int CALCENEMYMOVEDIR(int current_cell, int current_direction);
    bool CANHEROGOTO(int cell_index);
    int GET(int cell_index);
    int GETCELLOFFSET(int x, int y);
    int GETCELLPOSX(int cell_index);
    int GETCELLPOSY(int cell_index);
    int GETCELLSNO(int cell_type);
    int GETFIELDPOSX(int cell_index);
    int GETFIELDPOSY(int cell_index);
    int GETOFFSET(int x, int y);
    bool ISGATEEMPTY();
    bool ISINGATE(int _);
    void MOVE(int _, int _2);
    int NEXT();
    void SET(int cell_index, int cell_type);
    void SETGATE(int _, int _2, int _3, int _4);
    void SETROW(int row_index, params int[] cell_types);
    void TICK();

    event SignalHandler ONLATEST;
    event SignalHandler ONNEXT;
}
