using System.Collections;
using UnityEngine;

public class ObstaclesParent : MonoBehaviour
{
    private void Update()
    {
        StartCoroutine(Timer());
    }

    //Respawn Obstacles that were destroyed by Bomb power-up
    private IEnumerator Timer()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            if (SetParams.destroy == i)
            {
                transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        yield return new WaitForSeconds(5);
        SetParams.destroy = -1;
        StopAllCoroutines();
    }
}
