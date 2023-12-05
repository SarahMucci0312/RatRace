using UnityEngine;

public class Gun : MonoBehaviour
{
    //Variables for guns
    public Rigidbody bullet; //bullet to be shot
    public AudioSource bulletSound; //sound of bullet being shot
    public float speed = 10f; //speed of bullet

    // Update is called once per frame
    void Update()
    {
        //Instantiates and shoots bullet
        if (Input.GetKeyDown(KeyCode.Z))
        {
            bulletSound.Play();
            Rigidbody instantiatedBullet = Instantiate(bullet,
                                                        transform.position,
                                                        transform.rotation) as Rigidbody;
            instantiatedBullet.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
        }
    }

}
