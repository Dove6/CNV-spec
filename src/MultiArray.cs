namespace CnvAPI;

public interface MULTIARRAY : OBJECT {
    int DIMENSIONS { init; }

    variable? GET(params int[] indices);
    void SET(variable value, params int[] indices); // TODO: swap the order (value after indices)
}
