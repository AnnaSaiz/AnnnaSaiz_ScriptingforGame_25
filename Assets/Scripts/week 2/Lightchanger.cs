using System.Runtime.CompilerServices;
using UnityEngine;

public class Lightchanger : MonoBehaviour
{
    public Light lightWeWantToChange;

    public Vector3 lightMoveDirection;

    public bool isItorIsntIt = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


        ChangeLightColor(Color.green);

        //ChangeLightColor(Color.blue); // 

        this.gameObject.SetActive(isItorIsntIt);
        //lightWeWantToChange.gameObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        AdjustLight();
        Debug.Log("light");

        if(Input.GetKeyDown(KeyCode.R))
        {
            ChangeLightColor(Color.red);
        }

        if(Input.GetKeyDown(KeyCode.G))
        {
            ChangeLightColor(Color.green);

        }
        if(Input.GetKeyDown(KeyCode.B))
        {
            ChangeLightColor(Color.blue);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            lightWeWantToChange.gameObject.SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            lightWeWantToChange.gameObject.SetActive(true);
        }
    }

       
    private void AdjustLight()
    {
        lightWeWantToChange.transform.position += lightMoveDirection * Time.deltaTime;
        lightWeWantToChange.intensity += 40f * Time.deltaTime;
        lightWeWantToChange.spotAngle += 10f * Time.deltaTime;
    }

    public void ChangeLightColor(Color santaclaus)
    {
        lightWeWantToChange.color = santaclaus;
    }





        private void OnEnable()
    {
        
    }
        private void OnDisable()
    {
        
    }
        private void Awake()
    {
        
    }

    private void OnDestroy()
    {
        
    }
}
