using UnityEngine;

public class MainMenu : MonoBehaviour {
    private AudioManager audioManager;

    void Start() {
        audioManager = AudioManager.Instance;
        audioManager.PlayMenuMusic();
    }

    public void MenuClickSFX() {
        audioManager.PlayMenuSFX();
        audioManager.ToggleMute();
    }

    public void GoTo(string sceneName) {
        audioManager.PlayMenuSFX();
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }

    public void GoToPlay() {
        audioManager.PlayMenuSFX();
        string nextWorld = "play_basic";

        switch(UserProfile.LoadData().WorldSelected) {
            case World.BIRDS:
                nextWorld = "play_birds";
                break;
            case World.MONSTERS:
                nextWorld = "play_monsters";
                break;
            case World.ZOMBIES:
                nextWorld = "play_zombies";
                break;
        }

        Debug.Log(UserProfile.LoadData().WorldSelected);

        UnityEngine.SceneManagement.SceneManager.LoadScene(nextWorld);
    }
}
