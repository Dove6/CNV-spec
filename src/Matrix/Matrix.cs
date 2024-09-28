using abstractions;

namespace Matrix;

/// <summary>
/// 2D Boulder Dash-like simulation.
/// </summary>
/// Implemented by <c>Matrix.dll</c>
public class MATRIX : OBJECT {
    public (int, int) BASEPOS { private get; init; }
    public int CELLHEIGHT { private get; init; }
    public int CELLWIDTH { private get; init; }
    public (int, int) SIZE { private get; init; }

    public int CALCENEMYMOVEDEST(int current_cell, int current_direction) { throw new NotImplementedException(); }
    public int CALCENEMYMOVEDIR(int current_cell, int current_direction) { throw new NotImplementedException(); }
    public bool CANHEROGOTO(int cell_index) { throw new NotImplementedException(); }
    public int GET(int cell_index) { throw new NotImplementedException(); }
    public int GETCELLOFFSET(int x, int y) { throw new NotImplementedException(); }
    public int GETCELLPOSX(int cell_index) { throw new NotImplementedException(); }
    public int GETCELLPOSY(int cell_index) { throw new NotImplementedException(); }
    public int GETCELLSNO(int cell_type) { throw new NotImplementedException(); }
    public int GETFIELDPOSX(int cell_index) { throw new NotImplementedException(); }
    public int GETFIELDPOSY(int cell_index) { throw new NotImplementedException(); }
    public int GETOFFSET(int x, int y) { throw new NotImplementedException(); }
    public bool ISGATEEMPTY() { throw new NotImplementedException(); }
    public bool ISINGATE(int _) { throw new NotImplementedException(); }
    public void MOVE(int _, int _2) { throw new NotImplementedException(); }
    public int NEXT() { throw new NotImplementedException(); }
    public void SET(int cell_index, int cell_type) { throw new NotImplementedException(); }
    public void SETGATE(int _, int _2, int _3, int _4) { throw new NotImplementedException(); }
    public void SETROW(int row_index, params int[] cell_types) { throw new NotImplementedException(); }
    public void TICK() { throw new NotImplementedException(); }

    event SignalHandler ONLATEST;
    event SignalHandler ONNEXT;
}
