using UnityEngine;

public class RespawnEventTrigger : MonoBehaviour
{
    public GameObject RespawnPoint;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(RespawnPoint);
    }
}
