using System.Collections;
using UnityEngine;

public class Hourglass : MonoBehaviour
{
    public AudioSource hourglassSound; //Sound variable
    private float time = 6f;

    private void Update()
    {
        if (SetParams.isDouble == true)
        {
            StartCoroutine(Timer());
        }
    }

    //Checks for collisions and sets appropriate variable for power-up
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            hourglassSound.Play();
            SetParams.isDouble = true;
            gameObject.SetActive(false);
        }
    }

    //Tracks how long the power-up lasts
    private IEnumerator Timer()
    {
        yield return new WaitForSeconds(time);
        SetParams.isDouble = false;
        StopAllCoroutines();
    }

}
