using UnityEngine;
using TMPro;

public class CountDownTimer : MonoBehaviour
{
    public float startTime = 30f;

    private float timeRemaining;

    public TextMeshProUGUI countdownText;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       timeRemaining = startTime;
       UpdateTimerUI();
    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            UpdateTimerUI();
        }
        else
        {
            timeRemaining = 0;
            UpdateTimerUI();
        }
    }

    void UpdateTimerUI()
    {
        if(countdownText != null)
        {
            countdownText.text = Mathf.CeilToInt(timeRemaining).ToString();
        }
    }
}
