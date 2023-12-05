using UnityEngine;

public class Controls : MonoBehaviour
{
    //Open Controls guide
    public void OpenGuide()
    {
        //Check that no other guide is open
        if(SetParams.canClick == true)
        {
            SetParams.isClosed2 = false;
            SetParams.canClick = false; //prevent user from clicking on buttons below the opened guide
        }
    }

    //Close Controls guide
    public void CloseGuide()
    {
        SetParams.isClosed2 = true;
        SetParams.canClick = true;
    }

    private void Update()
    {
        //Check if Controls guide is opened or not
        if (SetParams.isClosed2 == true)
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.SetActive(false);

            }
        }
        if (SetParams.isClosed2 == false)
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.SetActive(true);

            }
        }

    }
}
