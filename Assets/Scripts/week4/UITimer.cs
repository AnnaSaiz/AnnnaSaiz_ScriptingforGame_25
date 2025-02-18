using UnityEngine;

public class UITimer : MonoBehaviour
{
    public float timerCountingDown = 30f;
    public float defaultTime = 30;

    
  
   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timerCountingDown = defaultTime;
    }

    // Update is called once per frame
    void Update()
    {
        timerCountingDown -= Time.deltaTime;
        

        if(timerCountingDown)
        
        if(timerCountingDown <= 0)
        {
            Debug.Log("Timer hit 0");
            timerCountingDown = defaultTime;

        }

        
        
    }
}
