using UnityEngine;

public class DeadEventTrigger : MonoBehaviour
{
    public GameObject RedBall;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(RedBall);
        print("Red Ball Destroyed!");
    }
}
