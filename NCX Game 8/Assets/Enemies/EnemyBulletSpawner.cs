using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class EnemyBulletSpawner : MonoBehaviour
{

    [SerializeField]
    private GameObject bulletPrefab;

    [SerializeField]
    private float bulletSpeed = 600;

    private float timer = 0;

    [SerializeField]
    private float spawnRate = 2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            EnemyShoot();
        }
    }

    void EnemyShoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        bullet.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed);
        Debug.Log("Enemy Shoot!");
        timer = 0;
        Destroy(bullet, 1); // this destroyes the bullet after 1 second, that's the purpose of the second argument
    }
}
