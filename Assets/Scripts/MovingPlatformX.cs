using UnityEngine;
public class MovingPlatformX : MonoBehaviour
{
    private float useSpeed;
    public float directionSpeed = 9.0f;
    float origX;
    public float distance = 10.0f;

    void Start()
    {
        origX = transform.position.x;
        useSpeed = -directionSpeed;
    }

    void Update()
    {
        if (origX - transform.position.x > distance)
        {
            useSpeed = directionSpeed;
        }
        else if (origX - transform.position.x < -distance)
        {
            useSpeed = -directionSpeed;
        }
        transform.Translate(0, useSpeed*Time.deltaTime, 0);
    }
}