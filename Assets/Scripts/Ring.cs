using UnityEngine;

public class Ring : MonoBehaviour
{
    public GameObject R_ring;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(R_ring);
        print("Obtain a Rare Ring !!!");
    }

}
