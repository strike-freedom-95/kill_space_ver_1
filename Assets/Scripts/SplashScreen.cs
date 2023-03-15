using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour
{
    float delay = 3f;
    GameObject g;
    public GameObject loadingBar;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        loadingBar.transform.Translate(6 * Time.deltaTime, 0, 0);
        delay -= Time.deltaTime;
        if (delay <= 0)
        {
            SceneManager.LoadScene("Menu");
        }
            // LoadLevel("NextLevelToLoad");
    }
}
