using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip sound1, sound2, sound3, sound4;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        sound1 = Resources.Load<AudioClip>("s_1");
        sound2 = Resources.Load<AudioClip>("s_2");
        sound3 = Resources.Load<AudioClip>("s_3");
        sound4 = Resources.Load<AudioClip>("s_4");
        audioSrc = GetComponent<AudioSource>();
    }
    void Update()
    {

    }
    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "s_1":
                audioSrc.PlayOneShot(sound1);
                break;
            case "s_2":
                audioSrc.PlayOneShot(sound2);
                break;
            case "s_3":
                Debug.Log("3");
                audioSrc.PlayOneShot(sound3);
                break;
            case "s_4":
                audioSrc.PlayOneShot(sound4);
                break;
        }

    }
}

