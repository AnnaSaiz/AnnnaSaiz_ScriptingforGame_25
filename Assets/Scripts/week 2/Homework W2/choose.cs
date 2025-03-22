using UnityEngine;
using UnityEngine.UI;

public class choose : MonoBehaviour
{

    public Button buttonOne;
    public Button buttonTwo;

    public bool buttonOneHasBeenPressed;
    public bool buttonTwoHasBeenPressed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        buttonOneHasBeenPressed = false;
        buttonTwoHasBeenPressed = false;
    }

    // Update is called once per frame
    void Update()
    {
       //if(buttonOne.OnClick == true)
        {
            // buttonHasBeenPressed = true;
        }

    }

    public void ChooseAHamster()
    {

    }
}
