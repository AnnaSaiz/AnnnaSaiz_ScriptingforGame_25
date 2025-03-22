using UnityEngine;

public class hampter : MonoBehaviour
{
    public GameObject hamster;
    public float scaleIncrease = 3f;
    public GameObject youdiedscreen;
    public Vector3 rotationAmount;
    public GameObject sadHamster;

    public bool buttonPressed = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        youdiedscreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject.FindGameObjectWithTag("button");
        
        sadHamster.transform.Rotate(0, 90 * Time.deltaTime, 0);
        hamster.transform.localScale += Vector3.one * scaleIncrease * Time.deltaTime;
        
        
        if(hamster.transform.localScale.x > 15)
        {
            youdiedscreen.SetActive(true);
        }
       
        

    }
    public bool buttonOneHasBeenPressed()
    {
        sadHamster.SetActive(false);
        return buttonPressed;
        


    }
    public void buttonTwoHasBeenPressed()
    {
        
    }
    public void TeleportHamster()
    {

    }

}
