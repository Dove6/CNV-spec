#include "object.hpp"

//! Boolean value.
class BOOL : OBJECT {
public:
    const bool TOINI;
    const bool VALUE;

    /*! \brief Sets the value of the object to \a value.

        \param value New value for the object.
    */
    void SET(bool value);

    /*! \brief Switches the value of the object between TRUE and FALSE.

        \param _unused1 Unused.
        \param _unused2 Unused.
    */
    void SWITCH(bool _unused1, bool _unused2);
};
