using UnityEngine;
public class MovingPlatform : MonoBehaviour
{
    private float useSpeed;
    public float directionSpeed = 9.0f;
    float origY;
    public float distance = 10.0f;

    // Use this for initialization
    void Start()
    {
        origY = transform.position.y;
        useSpeed = -directionSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (origY - transform.position.y > distance)
        {
            useSpeed = directionSpeed; //flip direction
        }
        else if (origY - transform.position.y < -distance)
        {
            useSpeed = -directionSpeed; //flip direction
        }
        transform.Translate(0, useSpeed*Time.deltaTime, 0);
    }
}

//public class MovingPlatform : MonoBehaviour
//{
//    private void OnCollisionEnter2D(Collision2D collision)
//    {
//        if (collision.gameObject.CompareTag("Player"))
//        {
//            var playerTransform = collision.gameObject.transform;
//            playerTransform.SetParent(transform);
//        }
//    }

//    private void OnCollisionExit2D(Collision2D collision)
//    {
//        var player = collision.gameObject;
//        if (player.activeInHierarchy && player.CompareTag("Player"))
//        {
//            var playerTransform = collision.gameObject.transform;
//            playerTransform.SetParent(null);
//        }
//    }
//}
