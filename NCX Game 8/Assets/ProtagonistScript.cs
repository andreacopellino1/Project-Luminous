using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProtagonistScript : MonoBehaviour
{
    public LogicScript logic;
    private float playerHP = 100;

    // Start is called before the first frame update
    void Start()
    {
        playerHP = 100;
        logic.updatePlayerHPText(playerHP);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("EnemyBullet"))
        {
            Destroy(collision.gameObject);
            playerHP -= 10;
            logic.updatePlayerHPText(playerHP);

            if(playerHP < 1)
            {
                playerHP = 0;
                logic.restartGame();
            }
            Debug.Log(playerHP);
            Debug.Log("You got hit!");

        }
    }
}
