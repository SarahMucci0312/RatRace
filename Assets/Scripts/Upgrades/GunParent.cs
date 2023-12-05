using UnityEngine;

public class GunParent : MonoBehaviour
{
    void Update()
    {
        //Unlock guns 
        if(SetParams.points >= SetParams.ug3)
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.SetActive(true);

            }
        }
    }
}
