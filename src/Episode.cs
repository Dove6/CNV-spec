namespace CnvAPI;

public interface EPISODE : OBJECT {
    string AUTHOR { init; }
    string CREATIONTIME { init; }
    string DESCRIPTION { init; }
    string LASTMODIFYTIME { init; }
    string PATH { init; }
    string[] SCENES { init; }
    string STARTWITH { init; }
    string VERSION { init; }

    void BACK();
    string GETCURRENTSCENE();
    string GETLATESTSCENE();
    void GOTO(string scene_name);
}
