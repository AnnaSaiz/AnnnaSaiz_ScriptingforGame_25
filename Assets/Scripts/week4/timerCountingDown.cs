using UnityEngine;

public class timerCountingDown : MonoBehaviour
{
    public float timerCountingdown = 0f;
    public float timerMaxDuration = -3f;

    public GameObject Cube;
    public bool hasFinishedTimer = false;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timerMaxDuration = Random.Range(1f, 4f);

        Invoke("moveCubeRight", timerMaxDuration);
    }

    // Update is called once per frame


    /*void Update()
     {
         timerCountingdown -= Time.deltaTime;
         if(timerCountingdown <= timerMaxDuration)
         {
             Cube.transform.position += Vector3.right;
             timerCountingdown = 0f;

         }
      }
    */
    void moveCubeRight()

    {
        Cube.transform.position += Vector3.right;
        if (Cube.transform.position.x < 10)
        {
            Invoke("moveCubeRight", timerMaxDuration);


        }
        
        
    }


}

