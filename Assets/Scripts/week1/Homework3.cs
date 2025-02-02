using UnityEngine;

public class Homework3 : MonoBehaviour
{
    string fullsentence;
    public string Firstname;
    public string middlename;
    public string lastname;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { fullsentence = (  Firstname   +   middlename   +   lastname  );
        
    Debug.Log(fullsentence);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
