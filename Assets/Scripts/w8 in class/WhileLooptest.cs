using System.Collections;
using UnityEngine;

public class WhileLooptest : MonoBehaviour
{
    public float speed = 3f;
    Coroutine co;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //not for this class
        /* while(this.transform.position.x < 7f)
         {
             this.transform.position += Vector3.right * speed * Time.deltaTime;
         }*/

        co = StartCoroutine(MoveRightAndChangeColor()); //start coroutine(Important)
    }

    // Update is called once per frame
    void Update()
    {
       /* while(this.transform.position.y < 10)
        {
            this.transform.position += Vector3.right * speed * Time.deltaTime;
        }*/
       if(Input.GetKeyDown(KeyCode.Space))
        {
            StopCoroutine(co); //ref to a specific coroutine
        }
       if(Input.GetKeyDown(KeyCode.D))
        {
            StopAllCoroutines();// ref to all coroutines
        }
    }

    IEnumerator MoveRightAndChangeColor()
    {
        /*
        Debug.Log("frame 1 Runs");
        yield return null;
        Debug.Log("Frame 2 Runs");
        yield return new WaitForSeconds(2f); //helpful for timer stuff
        Debug.Log("waited 2 second");
        */
        while (this.transform.position.x < 7f)
        {

            this.transform.position += Vector3.right * speed * Time.deltaTime;
            yield return null;  // stop at end of frame then do it again at start of next (if still true)
        }
        yield return new WaitForSeconds(2f);

        this.GetComponent<MeshRenderer>().material.color = Color.blue;

        yield return new WaitForSeconds(2f);
        
        
        while (this.transform.position.x > -8f)
        {

            this.transform.position += Vector3.left * speed * Time.deltaTime;
            yield return null;  // stop at end of frame then do it again at start of next (if still true)
        }
       
        yield return new WaitForSeconds(2f);

        this.GetComponent<MeshRenderer>().material.color = Color.red; // goes right then left while changing from blue to red 

        // dont run same coroutine in same script more than once

        //sequence things in a very nice way




    }
}
