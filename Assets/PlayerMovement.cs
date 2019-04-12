using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float Speed;
    public float jumpHeight;
    private bool isJumping = false;
    GameObject Kill;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Kill = GameObject.Find("Kill");
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
        if (Input.GetKeyDown(KeyCode.Space) && isJumping == false)
        {
            rb.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
            isJumping = true;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(1);
        }
        /*if (Input.GetKeyDown(KeyCode.F))
        {
            GameObject KillBox = GameObject.Instantiate();
            Destroy(KillBox);
        }
        */
        if (isJumping == true)
        {
            this.gameObject.transform.parent = null;
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Platform") && isJumping)
        {
            isJumping = false;
            this.gameObject.transform.parent = col.gameObject.transform;
             if(isJumping == true)
            {
                this.gameObject.transform.parent = null;
            }
        }
        if (col.gameObject.CompareTag("Falling") && isJumping)
        {
            isJumping = false;
            
        }
        if (col.gameObject.CompareTag("ground") && isJumping)
        {
            isJumping = false;
            Debug.Log("Check");
            this.gameObject.transform.parent = null;
            if (isJumping == true)
            {
                this.gameObject.transform.parent = null;
            }
        }
        if (col.gameObject.CompareTag("Water"))
        {
            SceneManager.LoadScene(1);
        }

    }
}
