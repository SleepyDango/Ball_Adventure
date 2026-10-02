using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject GameOverPanel;

    public void gameOver()
    {
        GameOverPanel.SetActive(true);
    }
}
