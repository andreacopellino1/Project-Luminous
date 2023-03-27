using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class WeaponRodScript : MonoBehaviour
{
    private StarterAssetsInputs _input;

    [SerializeField]
    private GameObject bulletPrefab;

    [SerializeField]
    private GameObject bulletStartingPoint;

    [SerializeField]
    private float bulletSpeed = 600;

    // Start is called before the first frame update
    void Start()
    {
        _input = transform.root.GetComponent<StarterAssetsInputs>();
    }

    // Update is called once per frame
    void Update()
    {
        if(_input.attackLight)
        {
            Shoot();
            _input.attackLight = false;
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletStartingPoint.transform.position, bulletStartingPoint.transform.rotation);
        bullet.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed);
        Debug.Log("Shoot!");
        Destroy(bullet, 1); // this destroyes the bullet after 1 second, that's the purpose of the second argument
    }
}
