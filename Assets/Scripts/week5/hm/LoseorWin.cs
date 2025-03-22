using UnityEngine;

public class LoseorWin : MonoBehaviour
{

    //check if timer has ended
    //check player count
    //check west count
    //compare
    //win or lose

    public CountDownTimer timerDone;
    public keepCount stillCount;
    public SpawnIn numberofWests;
    public keepCount whatIsCount;
    

    public GameObject youWinScreen;
    public GameObject youBigLoser;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
        
    }

    // Update is called once per frame
    void Update()
    {
        if (numberofWests == null)
            Debug.LogError("numberofWests is NULL!");
        if (whatIsCount == null)
            Debug.LogError("whatIsCount is NULL!");

        if (timerDone.timerHasFinished == true)
        {
           
            //check player count
            if (stillCount.allowCounting == false)
            {
                //get component of timer amount
                if (numberofWests.CountingAllThemWests() == whatIsCount.currentCount)
                {
                    //display win screen
                    youWinScreen.SetActive(true);
                }
                else
                {
                    //display lose screen
                    youBigLoser.SetActive(true);
                }
            }
        }



    }


}
