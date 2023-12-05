using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    //Variables for time and time display
    public TMP_Text timerText;
    private float secondsCount;
    private int minuteCount;

    void Update()
    {
        //Checks if user is in Pause Menu
        if(SetParams.isPaused == false)
        {
            UpdateTimer();
        }
    }

    public void UpdateTimer()
    {
        //Count seconds
        secondsCount += Time.deltaTime;
        
        // Display time in UI properly
        if(secondsCount < 10)
        {
            timerText.text = "Time: " + minuteCount + ":0" + (int)secondsCount; //displays time as 0:00
        }
        else
        {
            timerText.text = "Time: " + minuteCount + ":" + (int)secondsCount;
        }

        // Convert every 60 seconds to 1 minute
        if (secondsCount >= 60)
        {
            minuteCount++;
            secondsCount = 0;
        }

    }
}
