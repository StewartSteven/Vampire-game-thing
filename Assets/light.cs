using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        //StartCoroutine("WaitforVisibility");
        if (other.gameObject.CompareTag("Player") && GameManager.GM.isVisible == true)
        {
            Debug.Log("I see you");
            GameManager.GM.setHunt();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("I dont see you");
            GameManager.GM.setHunt();
        }
    }
    IEnumerator WaitforVisibility()
    {
        yield return new WaitUntil(() => GameManager.GM.isVisible);
    }
}
