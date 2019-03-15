using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float Speed;
    public bool isLit;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isLit = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") < 0f)
        {
            rb.velocity = new Vector3(-Speed, rb.velocity.y, 0f);
           // transform.localScale = new Vector3(-1, transform.localScale.y, 1);
        }
        else if (Input.GetAxisRaw("Horizontal") > 0f)
        {
            rb.velocity = new Vector3(Speed, rb.velocity.y, 0f);
           // transform.localScale = new Vector3(1, transform.localScale.y, 1);
        }
        else
        {
            rb.velocity = new Vector3(0f, rb.velocity.y, 0f);
        }
    }
   
    
   
}
