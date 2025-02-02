using UnityEngine;

public class Homework2 : MonoBehaviour
{
  float total;
   public float peanut;
   public float tiger;
   public float sleepy;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     total = (peanut * tiger) + sleepy;
     
     Debug.Log(total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
