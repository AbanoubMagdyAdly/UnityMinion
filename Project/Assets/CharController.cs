using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{
    private Animator anim;
    public float speed = 10f;
    Rigidbody2D rigidbody2d;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (null != anim)
            {
                rigidbody2d.velocity = new Vector3(0, speed * 1,0);
                // play Bounce but start at a quarter of the way though
                anim.Play("Walk", 0, 0.25f);
            }
        }
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody2d.velocity = new Vector2(speed * -1, 0f);
            anim.SetBool("Idle", false);
            anim.SetBool("Walk", true);
        }



        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody2d.velocity = new Vector2(speed, 0f);
            anim.SetBool("Walk", true);
            anim.SetBool("Idle", false);

        }

        else
        {
           
            anim.SetBool("Idle", true);
            anim.SetBool("Walk", false);

        }

    }
}
