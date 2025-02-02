using UnityEngine;

public class Homework4 : MonoBehaviour
{
    public Vector3 startingposition;
    public Vector3 movedirection;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.transform.position += startingposition;
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += movedirection * Time.deltaTime;
        Debug.Log("wheeeeee");
    }

}
