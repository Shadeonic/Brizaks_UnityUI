using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeScript : MonoBehaviour
{//pāriet uz galveno ainu
    public void ToUIScene()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
    //pāriet uz menu
    public void ToMainMenue()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
    //iziet no spēles
    public void Quit()
    {
        Application.Quit();
    }
    
}
