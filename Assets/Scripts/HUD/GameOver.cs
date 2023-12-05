using UnityEngine;

public class GameOver : MonoBehaviour
{
    public AudioSource bgMusic;
    public AudioSource deathSound;
    void Update()
    {
        //When player dies, show Game Over screen
        if (SetParams.health == 0)
        {
            deathSound.Play();
            bgMusic.Stop();
            SetParams.isMoving = false;
            SetParams.isPaused = true;
            SetParams.distance = 0f;
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.SetActive(true);
            }
        }
    }
}
