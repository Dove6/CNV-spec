#include "types.hpp"


class global {
public:
    /*! \brief Creates an object of type #BOOL.

        \param name The name of created object.
        \param value The initial value of created object.
    */
    void BOOL(string name, bool value);

    void BREAK();

    /*! \brief Creates an object of type #DOUBLE.

        \param name The name of created object.
        \param value The initial value of created object.
    */
    void DOUBLE(string name, double value);

    void IF(string condition, string code_if_true, string code_if_false);

    void IF(string left, string operand, string right, string code_if_true, string code_if_false);

    /*! \brief Creates an object of type #INTEGER.

        \param name The name of created object.
        \param value The initial value of created object.
    */
    void INT(string name, integer value);

    void LOOP(string behaviour, integer init, integer len, integer step);

    void MSGBOX(string message);

    variable RETURN(variable value);

    /*! \brief Creates an object of type #STRING.

        \param name The name of created object.
        \param value The initial value of created object.
    */
    string STRING(string name, string value);

    void WHILE(string left, string condition, string right, string code);
};
