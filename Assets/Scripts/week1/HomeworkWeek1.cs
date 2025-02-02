using UnityEngine;

public class DatatypePractice : MonoBehaviour
{
    // 3 int variables - hard coded- & 1 int variable called total
    int total; 
    int pickle = 20;
    int lemon = -5;
    int blueberry = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    //+, -, *, or / 3 hardcoded varibles together and assign to total 
    // use 1 variable mutiply time and then display the total iun debug.log 
    int total = ( blueberry + lemon) + pickle - blueberry;

    Debug.Log(total);

    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
