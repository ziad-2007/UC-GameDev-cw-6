using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterflip : MonoBehaviour
{
    SpriteRenderer sr;
    bool flipright = false;
    bool flipX = false;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        flip();
    }
    void flip() 
    {
        if (Input.GetKeyDown(KeyCode.D)) 
        {
            sr.flipX = false;
            flipright = false;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            sr.flipX = true;
            flipright = true;
        }
    }
}
