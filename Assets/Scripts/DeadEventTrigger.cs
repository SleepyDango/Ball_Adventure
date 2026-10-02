using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;

public class DeadEventTrigger : MonoBehaviour
{
    public GameObject RedBall;
    public GameObject GameOverPanel;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(RedBall);
        gameOver();
    }
    public void gameOver()
    {
        GameOverPanel.SetActive(true);
        OnRestartButtonClicked();
    }

    public void OnRestartButtonClicked()
    {
        SceneManager.LoadScene("Level1");
    }
}
