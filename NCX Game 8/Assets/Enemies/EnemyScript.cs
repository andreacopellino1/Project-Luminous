using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [SerializeField]
    private float enemyHP = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(enemyHP < 1)
        {
            Destroy(gameObject);
            Debug.Log("Enemy Destroyed!");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag.Equals("Bullet"))
        {
            Destroy(collision.gameObject);
            enemyHP -= 10;
            Debug.Log(enemyHP);
            Debug.Log("Enemy lost 10hp!");
            
        }
    }
}
