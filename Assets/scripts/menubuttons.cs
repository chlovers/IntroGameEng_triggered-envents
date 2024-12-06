using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menubuttons : MonoBehaviour
{
    // Start is called before the first frame update
    public void Replay()
    {
        SceneManager.LoadScene("Hospital_Level");
    }


    public void Quit()
    {
        Application.Quit();
    }
}
