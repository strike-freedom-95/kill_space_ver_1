using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System.IO;

public class Bullet : MonoBehaviour
{
    public float life = 1;
    public GameObject explosion;
    public AudioSource src;
    public AudioClip sfx1;
    int score = 0;

    void Awake()
    {
        Destroy(gameObject, life);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (File.Exists("temp.txt"))
        {
            score = System.Int32.Parse(File.ReadAllText("temp.txt"));
        }
        score += 10;
        File.WriteAllText("temp.txt", score.ToString());
        src.clip = sfx1;
        src.enabled = true;
        src.PlayOneShot(sfx1);
        Destroy(collision.gameObject);
        Destroy(gameObject);
        var kaboom = Instantiate(explosion, collision.transform.position, collision.transform.rotation);
        Destroy(kaboom, 0.4f);
    }

    void CreateScoreFile()
    {

    }
}
