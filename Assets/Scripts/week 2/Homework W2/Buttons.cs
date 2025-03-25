using System.Collections;
using UnityEngine;

public class Buttons : MonoBehaviour
{

    public hampter buttonOne;
    public GameObject exploded;

    public bool isExploding;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
       
       exploded.SetActive(false);
        isExploding = false;
       
       
        
    }
    

    // Update is called once per frame
    void Update()
    {
        

       



    }
    public void ButtonOnePressedNow()
    {
        Debug.Log("pressed");
       
        if (buttonOne.buttonPressed == true)
        {
            if(isExploding == false)
            {
                buttonOne.sadHamster.SetActive(false);
                buttonOne.hamster.transform.localScale = new Vector3(1, 1, 1);
              
                StartCoroutine(ExplostionHappening());
            }
          
            
        }
    }

    IEnumerator ExplostionHappening()
    {

        Debug.Log("happening");
          isExploding = true;
        
          exploded.SetActive(true);

          yield return new WaitForSeconds(1f);

          exploded.SetActive(false);
          isExploding = false;
        
       


    }




}

