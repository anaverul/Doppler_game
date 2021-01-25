using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stayinside : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -4.3f, 4.8f), Mathf.Clamp(transform.position.y,-4.6f,3.4f), transform.position.z);
    }
}
