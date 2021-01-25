using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderAI : MonoBehaviour
{
    public float speed;
    public float range;

    Vector2 wayPoint;

    void Start()
    {
        SetNewDestination();
    }


    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, wayPoint, speed * Time.deltaTime);
        if (GameManager.playgame==true)
        {
            if (Vector2.Distance(transform.position, wayPoint) < range)
            {
                SetNewDestination();
            }
        }
    }

    void SetNewDestination()
    {
        wayPoint = new Vector2(Random.Range(-4.3f, 4.8f), Random.Range(-4.6f, 3.4f));

    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (GameManager.playgame==true)
        {
            SetNewDestination();
        }
    }
}
