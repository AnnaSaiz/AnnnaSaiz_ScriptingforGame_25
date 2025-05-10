using System.Collections;
using UnityEngine;


public class Buttons : MonoBehaviour
{

    public hampter buttonOne;
    public GameObject exploded;
    public GameObject bigExploded;
    public hampter buttonTwo;

    public bool isExploding;
    public AudioSource booom;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
       
       exploded.SetActive(false);
        bigExploded.SetActive(false);
        isExploding = false;
       


    }
    

    // Update is called once per frame
    void Update()
    {
        

       



    }
    public void ButtonOnePressedNow()
    {
        Debug.Log("pressed");
       
        

        isExploding = true;
        Debug.Log("button obe pressed");
           
          
        buttonOne.sadHamster.SetActive(false);
        buttonOne.hamster.transform.localScale = new Vector3(1, 1, 1);
              
         StartCoroutine(ExplostionHappening());
            
          
            
        
    }
    public void ButtonTwoPressedNow()
    {
        Debug.Log("button 2 press");
        buttonOne.scaleIncrease = 0f;
        StartCoroutine(BigExplostionHappening());
    }

    IEnumerator ExplostionHappening()
    {

        Debug.Log("happening");
         
        
          exploded.SetActive(true);
        booom.Play();

          yield return new WaitForSeconds(1f);

          exploded.SetActive(false);
          isExploding = false;
        booom.Stop();
        
    }

    IEnumerator BigExplostionHappening()
    {

        Debug.Log("happening");


        bigExploded.SetActive(true);
        booom.Play();

        yield return new WaitForSeconds(1f);

        bigExploded.SetActive(false);
        isExploding = false;
        booom.Stop();  
        buttonOne.youdiedscreen.SetActive(true);

    }



}

