using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public float moveSpeed = 0.1f;
    //public Transform bulletSpawnPoint;
    public Transform bulletSpawnPoint1;
    public Transform bulletSpawnPoint2;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;

    public Transform enemySpawnPoint;
    public GameObject enemyPrefab;
    public AudioClip laserBlast;
    public int score = 0;
    public int enemyCount = 6;
    public TMPro.TextMeshProUGUI textMeshPro;
    int count = 0;
    
    void Update()
    {
        float shipPos = transform.position.x;

        if ((Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) && shipPos > -5f)
        {
            transform.Translate(-moveSpeed * Time.deltaTime, 0f, 0f);
        }
        if ((Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) && shipPos < 5f)
        {
            transform.Translate(moveSpeed * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            InitBullet();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (File.Exists("temp.txt"))
            {
                File.Delete("temp.txt");
            }
            SceneManager.LoadScene("Menu");
        }
        if (Input.GetMouseButtonDown(0))
        {
            InitBullet();
        }
    }

    void InitBullet()
    {
        var bullet1 = Instantiate(bulletPrefab, bulletSpawnPoint1.position, bulletSpawnPoint1.rotation);
        bullet1.GetComponent<Rigidbody2D>().velocity = bulletSpawnPoint1.up * bulletSpeed;
        //var bullet2 = Instantiate(bulletPrefab, bulletSpawnPoint2.position, bulletSpawnPoint2.rotation);
        //bullet2.GetComponent<Rigidbody2D>().velocity = bulletSpawnPoint2.up * bulletSpeed;
        laserBlast.LoadAudioData();
    }

    void InitEnemy()
    {
        float enemySpeed = Random.Range(1,5);
        float posOffset = Random.Range(-4, 4);
        var enemy = Instantiate(enemyPrefab, enemySpawnPoint.position + new Vector3(posOffset, 0, 0), enemySpawnPoint.rotation);
        enemy.GetComponent<Rigidbody2D>().velocity = enemySpawnPoint.up * enemySpeed * -1;
    }

    void FixedUpdate()
    {
        count++;
        if(count == 150)
        {
            InitEnemy();
            count = 0;
        }
        if (File.Exists("temp.txt"))
        {
            score = System.Int32.Parse(File.ReadAllText("temp.txt"));
        }
        textMeshPro.text = score.ToString();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene("GameOver");
    }
}

class ScoreBoard
{
    int score;
    int getScore()
    {
        return this.score;
    }

    void setScore(int score)
    {
        this.score = score;
    }
}
