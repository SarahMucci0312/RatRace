using UnityEngine;

public class Bomb : MonoBehaviour
{
    public AudioSource bombSound; //Sound variable

    //Checks for collisions and sets appropriate variable for power-up
    private void OnCollisionEnter(Collision other)
    {
        bombSound.Play();
        if (other.gameObject.CompareTag("Player"))
        {
            int rand = Random.Range(0, 5);
            SetParams.destroy = rand;
            Debug.Log("destroy="+ SetParams.destroy); //destroys random type of obstacle
        }
        gameObject.SetActive(false);
    }


}