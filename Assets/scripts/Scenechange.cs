using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;

public class Scenechange : MonoBehaviour
{
    public PlayableDirector director; 
    public string sceneToLoad = "EndScreen";

    
    public void OnSceneChangeSignal()
    {
        // Load the desired scene
        SceneManager.LoadScene("EndScreen");
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
