using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void GoTo(string sceneName)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }
}
