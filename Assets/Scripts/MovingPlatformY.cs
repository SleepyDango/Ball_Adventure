using UnityEngine;
public class MovingPlatformY : MonoBehaviour
{
    private float useSpeed;
    public float directionSpeed = 9.0f;
    float origY;
    public float distance = 10.0f;

    void Start()
    {
        origY = transform.position.y;
        useSpeed = -directionSpeed;
    }

    void Update()
    {
        if (origY - transform.position.y > distance)
        {
            useSpeed = directionSpeed;
        }
        else if (origY - transform.position.y < -distance)
        {
            useSpeed = -directionSpeed;
        }
        transform.Translate(0, useSpeed*Time.deltaTime, 0);
    }
}
