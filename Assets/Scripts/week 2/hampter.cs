using UnityEngine;

public class hampter : MonoBehaviour
{
    public GameObject hamster;
    public float scaleIncrease = 3f;
    public GameObject youdiedscreen;
  
    public GameObject sadHamster;

    public Buttons press;

   


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        youdiedscreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        
        sadHamster.transform.Rotate(0, 90 * Time.deltaTime, 0);

        
        
           hamster.transform.localScale += Vector3.one * scaleIncrease * Time.deltaTime;
        
        
        
        
        if(hamster.transform.localScale.x > 15)
        {
            youdiedscreen.SetActive(true);
        }
       
        

    }
    
   
  
}
