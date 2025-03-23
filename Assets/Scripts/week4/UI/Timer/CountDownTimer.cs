using UnityEngine;
using TMPro;

public class CountDownTimer : MonoBehaviour
{
    public float startTime = 30f;

    private float timeRemaining;

    public TextMeshProUGUI countdownText;

    public bool timerHasFinished;

    public keepCount stopCountScript;
 
    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
       timeRemaining = startTime;
       UpdateTimerUI();
    }

    // Update is called once per frame
    void Update()
    {
        if(timerHasFinished == false)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                UpdateTimerUI();
            }
            else
            {
                timerHasFinished = true;
               
               
                timeRemaining = 0;
                UpdateTimerUI();

                stopCountScript.stopCount();

            }
        }
       
    }

    void UpdateTimerUI()
    {
        if(countdownText != null)
        {
            countdownText.text = Mathf.CeilToInt(timeRemaining).ToString("f0");
        }
    }
}
