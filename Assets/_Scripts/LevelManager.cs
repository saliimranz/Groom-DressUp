using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public float autoLoadNextLevelAfter;

    public void Start()
    {
        if (autoLoadNextLevelAfter <= 0)
        {
            Debug.Log("Auto Load Disabled.");
        }
        else
        {
            Invoke("LoadNextLevel", autoLoadNextLevelAfter);
        }
    }
    public void LoadLevel(string name)
    {
        Debug.Log("Load level is called for: " + name);
        SceneManager.LoadScene(name);
    }

    public void QuitRequest()
    {
          #if UNITY_EDITOR
        UnityEditor.EditorApplication.ExitPlaymode();
          #endif
        Application.Quit(); 
    }
    public void LoadNextLevel()
    {
        int LoadedScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(LoadedScene + 1);
    }

    public void LoadPrevLevel()
    {
        int LoadedScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(LoadedScene - 1);
    }

}
