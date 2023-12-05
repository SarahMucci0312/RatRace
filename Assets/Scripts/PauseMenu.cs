using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Pause game
            if(SetParams.isMoving == true && SetParams.isPaused == false)
            {
                SetParams.isMoving = false;
                SetParams.isPaused = true;
                for (int i = 0; i < transform.childCount; i++)
                {
                    transform.GetChild(i).gameObject.SetActive(true);
                }
            }
            //Unpause game
            else
            {
                SetParams.isMoving = true;
                SetParams.isPaused = false;
                for (int i = 0; i < transform.childCount; i++)
                {
                    transform.GetChild(i).gameObject.SetActive(false);

                }
            }
        }
    }

    //Unpause game
    public void Resume()
    {
        SetParams.isMoving = true;
        SetParams.isPaused = false;
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);

        }
    }
}
