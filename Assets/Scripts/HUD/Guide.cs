using UnityEngine;

public class Guide : MonoBehaviour
{
    //Open Game guide
    public void OpenGuide()
    {
        //Check that no other guide is open
        if (SetParams.canClick == true)
        {
            SetParams.isClosed = false;
            SetParams.canClick = false; //prevent user from clicking on buttons below the opened guide
        }
    }

    //Close Game guide
    public void CloseGuide()
    {
        SetParams.isClosed = true;
        SetParams.canClick = true;
    }

    private void Update()
    {
        //Check if Guide is opened or not
        if(SetParams.isClosed == true)
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.SetActive(false);

            }
        }
        if (SetParams.isClosed == false)
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.SetActive(true);

            }
        }

    }
}
