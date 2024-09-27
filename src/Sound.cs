namespace CnvAPI;

public interface SOUND : OBJECT {
    bool ISPLAYING();
    void LOAD(string filename);
    void PAUSE();
    void PLAY();
    void RESUME();
    void SETVOLUME(int volume);
    void STOP();
}
