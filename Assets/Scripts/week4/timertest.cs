using UnityEngine;

public class timertest : MonoBehaviour
{
    public float timerCountingUp = 0;
    public float timerMaxDuration = 3f;

    public bool hasFinishedtimer = false;
    public GameObject Cube;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    
    void Update()
    {
       
        
      timerCountingUp += Time.deltaTime;
            //Debug.Log(timerCountingUp);

       if (timerCountingUp >= timerMaxDuration)
        {
        
            Debug.Log("Reached end of Timer");
            Cube.transform.position += Vector3.right;
            timerCountingUp = 0f;
        }
      
       

    }
}
