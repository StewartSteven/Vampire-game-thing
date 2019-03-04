using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineOfSight : MonoBehaviour
{
    GameObject player = GameObject.Find("Player");
    // Start is called before the first frame update
    void Start()
    {
      //  player;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && PlayerMovement. )
        {
            Debug.Log("I see you");
        }
    }

}
