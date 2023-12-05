using UnityEngine;
using UnityEngine.UI;

public class Options : MonoBehaviour
{
    public GameObject btn; //Get enable/disable flashing lights button

    //Open Options guide
    public void OpenGuide()
    {
        if (SetParams.canClick == true)
        {
            SetParams.isClosed3 = false;
            SetParams.canClick = false; //prevent user from clicking on buttons below the opened guide
        }
    }

    //Close Options guide
    public void CloseGuide()
    {
        SetParams.isClosed3 = true;
        SetParams.canClick = true;
    }

    private void Update()
    {
        //Check if Options is opened or not
        if (SetParams.isClosed3 == true)
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.SetActive(false);

            }
        }
        if (SetParams.isClosed3 == false)
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.SetActive(true);

            }
        }

    }

    //Enable/Disable flashing lights
    public void FlashingLights()
    {
        if(SetParams.flashingLights == true)
        {
            SetParams.flashingLights = false;
            btn.GetComponent<Image>().color = Color.white;
        }
        else
        {
            SetParams.flashingLights = true;
            btn.GetComponent<Image>().color = Color.black;
        }
    }
}

