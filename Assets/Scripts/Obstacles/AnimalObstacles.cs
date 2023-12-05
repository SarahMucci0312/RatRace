using UnityEngine;

public class AnimalObstacles : MonoBehaviour
{
    public AudioSource animalSound; //Sound variable

    private void OnCollisionEnter(Collision other)
    {
        //Checks that player or bullet collides with obstacle
        if (other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("Animal"))
        {
            animalSound.Play();

            //Check if first upgrade (ball srength) has been unlocked
            if (SetParams.points >= SetParams.ug1 && SetParams.isInvincible == false)
            {
                SetParams.DecreaseHealthLess();
            }
            else if (SetParams.points < SetParams.ug1 && SetParams.isInvincible == false)
            {
                SetParams.DecreaseHealth();
            }
        }
        gameObject.SetActive(false);
    }
}
