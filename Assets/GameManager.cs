using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager GM;
    public bool isVisible = false;
    public bool willHunt = false;
    private void Awake()
    {
        if (GM == null) GM = this;
        else if (GM != null) Destroy(gameObject);
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
    public void setVisible()
    {
        isVisible = !isVisible;

    }
    public void setHunt()
    {
        willHunt = !willHunt;
    }
   public IEnumerable visibilityCheck()
    {
        yield return new WaitUntil(() => isVisible == true);
    }
}
