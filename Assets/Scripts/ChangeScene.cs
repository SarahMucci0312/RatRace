using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    //Game difficulty setters
    public void Easy()
    {
        if(SetParams.canClick == true)
        {
            SetParams.mode = 1;
            SetParams.multiplier = 1f;
            SetParams.speed = 3f;
            SceneManager.LoadScene(1);
        }
    }

    public void Medium()
    {
        if (SetParams.canClick == true)
        {
            SetParams.mode = 2;
            SetParams.multiplier = 1.5f;
            SetParams.speed = 3.5f;
            SceneManager.LoadScene(1);
        }
    }

    public void Hard()
    {
        if (SetParams.canClick == true)
        {
            SetParams.mode = 3;
            SetParams.multiplier = 2f;
            SetParams.speed = 4f;
            SceneManager.LoadScene(1);
        }
    }

    //Return to menu method
    public void GoToMenu()
    {
        //Reset all game values to default
        SetParams.SetDefaults();
        SceneManager.LoadScene(0);
    }
}
