using UnityEngine;

public class WinEventTrigger : MonoBehaviour
{
    public GameObject FinishPoint;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(FinishPoint);
        print("You WIN !!!");
    }
}
