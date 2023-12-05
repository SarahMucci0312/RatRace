using System.Collections;
using UnityEngine;

public class Cherries : MonoBehaviour
{
    public AudioSource cherriesSound; //Sound variable
    public float time = 5f;

    private void Update()
    {
        if(SetParams.isInvincible == true)
        {
            StartCoroutine(Timer());
        }
    }

    //Checks for collisions and sets appropriate variable for power-up
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            cherriesSound.Play();
            SetParams.isInvincible = true;
            gameObject.SetActive(false);
        }
    }

    //Tracks how long the power-up lasts
    private IEnumerator Timer()
    {
        yield return new WaitForSeconds(time);
        SetParams.isInvincible = false;
        StopAllCoroutines();
    }
}
