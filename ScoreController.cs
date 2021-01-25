using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{
    public Text endScreen;
    public Text Lives;
    public static int lives = 3;
    // Start is called before the first frame update
    void Start()
    {
        Lives.text = "Lives: " + lives.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Lives.text = "Lives: " + lives.ToString();
        if (lives == 0)
        {
            endScreen.text = "YOU LOSE";
            GameManager.playgame = false;
        }
    }
}
