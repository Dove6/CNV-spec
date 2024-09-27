namespace CnvAPI;

public interface INTEGER : OBJECT {
    bool TOINI { init; }
    int VALUE { init; }
    string VARTYPE { init; }

    /// <summary>
    /// Sets the modulus of <c>value</c> as the value of the object.
    /// </summary>
    /// <param name="value">The value of which modulus is to be set as the value of the object.</param>
    /// <returns></returns>
    int ABS(int value);

    int ADD(int summand);
    
    int AND(int operand);

    int CLAMP(int min, int max);

    void DEC();

    void DIV(int divisor);

    void INC();

    int LENGTH(int horizontal_distance, int vertical_distance);

    void MOD(int divisor);

    void MUL(int multiplier);

    int OR(int operand);

    int RANDOM(int max_exclusive);

    int RANDOM(int summand, int max_exclusive);

    void RESETINI();

    void SET(int value);

    int SUB(int subtrahend);

    void SWITCH(int value1, int value2);
}
