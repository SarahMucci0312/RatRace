using UnityEngine;

public class InvincibilityDisplay : MonoBehaviour
{
    void Update()
    {
        //Display invincibility icon
        if (SetParams.isInvincible == true)
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
