using UnityEngine;

public class ShrinkSerum : MonoBehaviour
{
    public AudioSource serumSound; //Sound variable
    
    //Checks for collisions and sets appropriate variable for power-up
    private void OnCollisionEnter(Collision other)
    {
        serumSound.Play();
        SetParams.isSmall = true;
        gameObject.SetActive(false);
    }
}
