using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public string tutorialSceneName, mainMenuSceneName, playSceneName;
    
    public void Exit()
    {
        Application.Quit();
    }

    public void Tutorial()
    {
        SceneManager.LoadScene(tutorialSceneName);
    }

    public void Back()
    {
        SceneManager.LoadScene(mainMenuSceneName);
    }

    public void Play()
    {
        SceneManager.LoadScene(playSceneName);
    }

}
