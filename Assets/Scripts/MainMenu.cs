using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void GoToScene(string sceneName) {
        
        SceneManager.LoadScene(sceneName);
        SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Click);
    }



    public void QuitApp()
    {
        Application.Quit();
        Debug.Log("Application has quit.");
    }
}
