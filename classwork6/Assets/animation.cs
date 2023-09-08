using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour
{
    Animator anim;
    bool canjump;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(canjump == true && Input.GetKeyDown(KeyCode.Space))
        {
            canjump = false;
            anim.SetBool("jump", true);
            anim.SetBool("run", false);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "floor" && Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A)) 
        {
            canjump = true;
            anim.SetBool("jump", false);
            anim.SetBool("run", true);
        }
        else if(collision.gameObject.tag == "floor" && Input.anyKey == false) 
        {
            canjump= true;
            anim.SetBool("jump", false);
            anim.SetBool("run", false);
        }
    }
}
