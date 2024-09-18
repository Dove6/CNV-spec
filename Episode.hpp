#include "object.hpp"

class EPISODE : OBJECT {
public:
    const string AUTHOR;
    const string CREATIONTIME;
    const string DESCRIPTION;
    const string LASTMODIFYTIME;
    const string PATH;
    const string_list SCENES;
    const string STARTWITH;
    const string VERSION;

    void BACK();
    string GETCURRENTSCENE();
    string GETLATESTSCENE();
    void GOTO(string scene_name);
};
