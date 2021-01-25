using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static bool playgame = true;
    public Text endSc;
    void OnTriggerEnter2D(Collider2D target)
    {

        if (target.tag == "Enemy")
        {
            Debug.Log("ouch! that's an enemy!");
            if (ScoreController.lives>0)
            {
                ScoreController.lives -= 1;
            }
        }
        else if (target.tag == "Friend")
        {
            Debug.Log("Yay! found them");
            endSc.text = "YOU WIN";
            playgame = false;
        }
    }
}
