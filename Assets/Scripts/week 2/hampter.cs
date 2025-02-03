using UnityEngine;

public class hampter : MonoBehaviour
{
    public GameObject hamster;
    public float scaleIncrease = .5f;
    public GameObject youdiedscreen;
    public Vector3 rotationAmount;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hamster.transform.localScale += Vector3.one * scaleIncrease * Time.deltaTime;

        if(hamster.transform.localScale.x > 15)
        {
            youdiedscreen.SetActive(true);
        }

    }
    public void Resethamster()
    {
        hamster.transform.localScale = Vector3.one;
        scaleIncrease += .5f;

    }
    public void Rotatehamster()
    {
        hamster.transform.Rotate(new Vector3(0f, 0f, -90f));

        hamster.transform.Rotate(rotationAmount);
    }
    public void TeleportHamster()
    {

    }

}
