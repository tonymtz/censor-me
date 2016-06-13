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
}
