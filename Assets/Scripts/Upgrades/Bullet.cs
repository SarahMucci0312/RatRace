using UnityEngine;

public class Bullet : MonoBehaviour
{
    //Destroys bullet on collision with anything other than player
    private void OnCollisionEnter(Collision other)
    {
        if (!other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
