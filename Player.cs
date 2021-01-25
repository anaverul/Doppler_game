using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject player;
    Vector2 friendloc;
    // Start is called before the first frame update
    void Start()
    {
        friendloc = GameObject.FindWithTag("Friend").transform.position;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        friendloc = GameObject.FindWithTag("Friend").transform.position;
        Debug.Log(Vector2.Distance(transform.position, friendloc));
        if (GameManager.playgame==true)
        {
            movement();
            if (Vector2.Distance(transform.position, friendloc) > 4)
            {
                SoundManager.PlaySound("s_1");
            }
            else if (3 < (Vector2.Distance(transform.position, friendloc)) && (Vector2.Distance(transform.position, friendloc)) < 4)
            {
                SoundManager.PlaySound("s_2");
            }
            else if (2 < (Vector2.Distance(transform.position, friendloc)) && (Vector2.Distance(transform.position, friendloc)) < 3)
            {
                SoundManager.PlaySound("s_3");
            }
            else if (Vector2.Distance(transform.position, friendloc) < 1)
            {
                SoundManager.PlaySound("s_4");
            }

        }
    }

    void movement()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector2(5 * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector2(-5 * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector2(0, 5 * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector2(0, -5 * Time.deltaTime));
        }
    }

}