using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gm;
    public bool isLit = false;
    private void Awake()
    {
        if (gm == null) gm = this;
        else if (gm != null) Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void setLit()
    {
        if (!isLit)
        {
           isLit = true;
        }
        else
        {
            isLit = false;
        }

    }
}
