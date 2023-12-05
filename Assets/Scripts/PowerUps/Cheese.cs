using UnityEngine;

public class Cheese : MonoBehaviour
{
    public AudioSource cheeseSound; //Sound variable

    //Checks for collisions and sets appropriate variable for power-up
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            cheeseSound.Play();
            SetParams.canFly = true;
            gameObject.SetActive(false);
        }
    }
}
