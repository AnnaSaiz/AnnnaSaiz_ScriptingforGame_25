using UnityEngine;
using TMPro;
public class keepCount : MonoBehaviour
{
    public float startCount = 0;
   
    public TextMeshProUGUI Count;

    private float currentCount;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentCount = startCount;
        UpdateCountDisplay();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            currentCount += 1;
            UpdateCountDisplay();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            currentCount -=1;
            UpdateCountDisplay();
        }
    }

    void UpdateCountDisplay()
    {
        Count.text = currentCount.ToString();
    }
}
