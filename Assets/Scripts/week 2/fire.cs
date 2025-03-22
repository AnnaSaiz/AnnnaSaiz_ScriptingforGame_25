using UnityEngine;

public class fire : MonoBehaviour
{
    public hampter didYaPress;
    public GameObject Fire;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Fire.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (didYaPress != null && didYaPress.buttonOneHasBeenPressed())
        {
            Fire.SetActive(true);
        }
    }
}
