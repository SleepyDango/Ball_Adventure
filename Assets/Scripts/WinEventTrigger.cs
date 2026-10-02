using UnityEngine;
using UnityEngine.SceneManagement;

public class WinEventTrigger : MonoBehaviour
{
    public GameObject FinishPoint;
    public GameObject VictoryPanel;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(FinishPoint);
        Victory();
    }
    public void Victory()
    {
        VictoryPanel.SetActive(true);
        OnNextStageButtonClicked();
    }
    public void OnNextStageButtonClicked()
    {
        SceneManager.LoadScene("Level2");
    }
}
