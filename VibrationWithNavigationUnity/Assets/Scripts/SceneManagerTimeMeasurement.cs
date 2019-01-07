using UnityEngine;

public class SceneManagerTimeMeasurement : MonoBehaviour
{
    public string timerText;
    private float secondsCount;
    private int minuteCount;
    private int hourCount;

    void Update()
    {
        UpdateTimerUI();
    }

    public void UpdateTimerUI()
    {
        //set timer UI
        secondsCount += Time.deltaTime;
        timerText = hourCount.ToString("00") + "h:" + minuteCount.ToString("00") + "m:" + ((int)secondsCount).ToString("00") + "s";
        if (secondsCount >= 60)
        {
            minuteCount++;
            secondsCount = 0;
        }
        else if (minuteCount >= 60)
        {
            hourCount++;
            minuteCount = 0;
        }
    }

    public string GetTimerText()
    {
        return timerText;
    }

    public void ResetTimerText()
    {
        secondsCount = 0;
    }
}
