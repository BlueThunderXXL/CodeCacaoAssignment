using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Play game button
    public void PlayGame()
    {
        //loading next scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //Quit game button
    public void QuitGame()
    {
        //Just to make sure it works inside Unity
        Debug.Log("Quit button works");
        Application.Quit();
    }
}
