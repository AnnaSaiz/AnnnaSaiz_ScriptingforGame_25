using UnityEngine;

public class Datatypepractice : MonoBehaviour
{
    int SantaClaus;

    float total;

    public float mario;

    public float yoshi = 4.8F;

    char bee = 'B';

    string intro = "Hello World";
    string outro = "see you later";

    public string chestName; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SantaClaus = 56;

        SantaClaus = (SantaClaus + 5) * 2 / (3 - 7);

        Debug.Log(SantaClaus);

        Debug.Log(yoshi);

        //Subtrcts 2 from the current value of yoshi
        yoshi = yoshi - 2;

        //subtracts 2 from current value of yoshi (diffent)
        yoshi -= 2;

        Debug.Log("yoshi's value is " + yoshi);

        Debug.Log(bee + intro);

        total = mario + yoshi;

        Debug.Log(total);

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
