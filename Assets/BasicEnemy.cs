using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : MonoBehaviour
{
    public float speed;
    public float fastSpeed;
    public float distance;
    private bool movingright = true;
    public Transform groundDetection;
    private Transform target;
    public GameObject player;
    public int health;
    void Start()
    {
    }
    void Update()
    {
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);
        if (GameManager.GM.willHunt == true)
        {
            target = player.transform;
            transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, 0), new Vector2(target.position.x, 0), fastSpeed * Time.deltaTime);
        }        
         else 
            {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
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
        if (health <= 0)
        {
            GameObject.Destroy(this.gameObject);
        }
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
    }
}
