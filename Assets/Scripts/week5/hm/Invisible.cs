using UnityEngine;

public class Invisible : MonoBehaviour
{
    public float timer = 30f;
    public SpawnIn numberr;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        numberr = FindAnyObjectByType<SpawnIn>();

        timernumerotwo();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

      if (numberr.isMoving == true)
       {
            if (timer <= 5f)
            {
                invisibleGo();
                timernumerotwo();

            }

       }
        
    }

    void invisibleGo()
    {
        if(this.gameObject.GetComponent<MeshRenderer>().enabled == true)
        {
        this.gameObject.GetComponent<MeshRenderer>().enabled = false;
        }
        else
        {
                  this.gameObject.GetComponent<MeshRenderer>().enabled = true;
        }
        
           
    }
    void timernumerotwo()
    {
        timer = Random.Range (0f, 20f);
    }
}
