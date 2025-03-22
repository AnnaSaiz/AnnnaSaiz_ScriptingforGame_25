using UnityEngine;
using TMPro;
using UnityEngine.InputSystem.Android;
public class keepCount : MonoBehaviour
{
    public int startCount = 0;
   
    public TextMeshProUGUI Count;

    public float currentCount;

    public bool allowCounting = true;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentCount = startCount;
        UpdateCountDisplay();
    }

    // Update is called once per frame
    void Update()
    {
        if (allowCounting == true)
        {
            if(Input.GetKeyDown(KeyCode.UpArrow))
           {
                currentCount += 1;
                UpdateCountDisplay();
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {

                currentCount -= 1;
                UpdateCountDisplay();
            }
        }
       
    }

    void UpdateCountDisplay()
    {
        Count.text = currentCount.ToString();
    }
   public void stopCount()
    {
        allowCounting = false;
    }
}
