using UnityEngine;

public class hm1 : MonoBehaviour
{
    public GameObject go;
    public GameObject go2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ColorGameObjectByName();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ColorGameObjectByName()
    {
        Debug.Log("go is named" + go.name);
        Debug.Log("go2 is named" + go2.name);

        if(go.name == "CUBE")
        {

            //Change color to magenta
        }
         else if(go.name == "Sphere")
        {
            //Change the color to cyan
        }
        else if (go.name == "cylinder")
        {
            //change color to black
        }
        else
        {
            //change color to orange
        }
    }

}
