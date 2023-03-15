using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovements : MonoBehaviour
{
    private float moveSpeed = 0.5f;

    public float bulletSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, moveSpeed * Time.deltaTime, 0f);
        //var bullet1 = Instantiate(bulletPrefab, bulletSpawnPoint1.position, bulletSpawnPoint1.rotation);
        //bullet1.GetComponent<Rigidbody2D>().velocity = bulletSpawnPoint1.up * bulletSpeed * -1;
        //var bullet2 = Instantiate(bulletPrefab, bulletSpawnPoint2.position, bulletSpawnPoint2.rotation);
        //bullet1.GetComponent<Rigidbody2D>().velocity = bulletSpawnPoint2.up * bulletSpeed * -1;
    }
}
