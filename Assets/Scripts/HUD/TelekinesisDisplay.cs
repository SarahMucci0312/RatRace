using UnityEngine;

public class TelekinesisDisplay : MonoBehaviour
{
    void Update()
    {
        //Shows telekinesis icon
        if (SetParams.canFly == true)
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.SetActive(true);
            }

        }
        else
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.SetActive(false);
            }
        }
    }
}
