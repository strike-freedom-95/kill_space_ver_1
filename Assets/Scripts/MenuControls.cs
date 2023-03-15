using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControls : MonoBehaviour
{
    public void ActivateStart()
    {
        SceneManager.LoadScene("Level1");
    }
    public void ActivateControls()
    {
        SceneManager.LoadScene("Controls");
    }

    public void ActivateQuit()
    {
        Application.Quit();
    }

    public void ActivateBackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
