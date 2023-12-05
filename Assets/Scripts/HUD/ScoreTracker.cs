using TMPro;
using UnityEngine;

public class ScoreTracker : MonoBehaviour
{
    //Text Objects
    public TMP_Text scoreText; //HUD score text
    public TMP_Text scoreText2; //Game Over score text
    public TMP_Text highScoreText; //Game Over high score text
    private int distancePoints = 0;

    void Update()
    {
        //Increase score by 10 points every meter travelled
        if (SetParams.distance > 1)
        {
            distancePoints += 10; 
            SetParams.distance = 0;
        }
        SetParams.totalScore = SetParams.points + distancePoints;

        //If score surpasses previous high score, make the new score the high score
        if(SetParams.totalScore > SetParams.highScore)
        {
            SetParams.highScore = SetParams.totalScore;
        }

        //Update all text displays
        scoreText.text = "Score: " + SetParams.totalScore;
        scoreText2.text = "Score: " + SetParams.totalScore;
        highScoreText.text = "High Score: " + SetParams.highScore;
    }
}
