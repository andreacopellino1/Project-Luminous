using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public ProtagonistScript protagonist;
    public Text playerHPDisplayedText;

    public void updatePlayerHPText(float hp)
    {
        playerHPDisplayedText.text = hp.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
