using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : MonoBehaviour
{
    public float speed;
    public float distance;
    private bool movingright = true;
    public Transform groundDetection;
    private Transform target;
    public GameObject player;
    public float StoppingDistance;
     void Start()
    {
        target = player.transform;
    }
    void Update()
    {

        transform.Translate(Vector2.right * speed * Time.deltaTime);
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);
        if (GameManager.GM.willHunt)
        {
            

        }
        if (groundInfo.collider == false)
        {
            if (movingright == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingright = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingright = true;
            }
        }
    }
}
