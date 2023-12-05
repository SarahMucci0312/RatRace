using System.Collections;
using UnityEngine;

public class Parent : MonoBehaviour
{
    //Respawn Time
    public float time = 5f;

    void Update()
    {
        StartCoroutine(Respawn());
    }

    private IEnumerator Respawn()
    {
        yield return new WaitForSeconds(time);
        RespawnChildren();
        StopAllCoroutines();
    }

    //Respawn Obstacles & Power-Ups
    private void RespawnChildren()
    {
        for (int i = 0; i < transform.childCount; i++)
         {
            transform.GetChild(i).gameObject.SetActive(true);
         }
        
    }
}
