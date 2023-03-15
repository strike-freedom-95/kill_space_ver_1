using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetect : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Game over");
        //var Scene = SceneManager.GetSceneByName("GameOver");
        SceneManager.LoadScene("GameOver");
    }
}
