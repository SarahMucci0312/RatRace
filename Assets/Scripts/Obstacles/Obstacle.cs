using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public AudioSource obstacleSound;

    private void OnCollisionEnter(Collision other)
    {
        //Checks that player collides with obstacle
        if (other.gameObject.CompareTag("Player"))
        {
            obstacleSound.Play();

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
    }
}
