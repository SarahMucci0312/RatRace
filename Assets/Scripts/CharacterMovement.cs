using TMPro;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    //Movement input variables
    private float horizontalInput;
    private float verticalInput;
    private float turnSpeed = 30.0f;

    //Variable to check if player is on the ground
    private bool isGrounded = true;

    //Distance variables
    private Vector3 lastPosition; //tracks last position
    private float distance = 0f; //tracks total distance
    public TMP_Text distanceText; //displays distance travelled

    //Timers
    private float secondsCount;
    private float smallTimer; //variable for ShrinkSerum power-up
    private float flyTimer; //Variable for Cheese power-up

    private void Start()
    {
        lastPosition = transform.position; //get initial player position
    }

    void Update()
    {
        //Count seconds
        secondsCount += Time.deltaTime;

        //Increase player speed every 25 seconds for increased challenge
        if (secondsCount > 25)
        {
            SetParams.IncreaseSpeed();
            secondsCount = 0;
        }

        //Check if player can move (e.g.: Not in Pause Menu or Game Over)
        if (SetParams.isMoving == true)
        {
            Vector3 distanceVector = transform.position - lastPosition; //get distance vector
            float distanceThisFrame = distanceVector.magnitude; //get magnitude of distance vector
            distance += distanceThisFrame; //add recent distance vector magnitude to total distance
            distance = Mathf.Round(distance * 100.0f) * 0.01f; //round distance for nicer look in HUD
            SetParams.distance += distanceThisFrame;
            distanceText.text = "Distance Travelled: " + distance + "m"; //display distance travelled on Game Over screen
            lastPosition = transform.position; //re-initialize last position with current position

            //If ShrinkSerum power-up is activated,make player small
            if (SetParams.isSmall == true)
            {
                smallTimer += Time.deltaTime;
                transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
                
                //After 4 seconds, make player big again
                if (smallTimer >= 4)
                {
                    SetParams.isSmall = false;
                    smallTimer = 0;
                }
            }
            else
            {
                transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
            }

            //Move
            horizontalInput = Input.GetAxis("Horizontal");
            verticalInput = Input.GetAxis("Vertical");

            transform.Translate(Vector3.forward * Time.deltaTime * verticalInput * SetParams.speed); //forward & backward
            transform.Rotate(Vector3.up * Time.deltaTime * horizontalInput * SetParams.speed * turnSpeed); //rotate left and right

            //Jump
            if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
            {
                gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 2000, ForceMode.Impulse);
                isGrounded = false;
            }

            //Fly (Cheese power-up activated)
            if (SetParams.canFly == true)
            {
                flyTimer += Time.deltaTime;

                //After 4 seconds, make player stop flying
                if (flyTimer >= 4)
                {
                    SetParams.canFly = false;
                    flyTimer = 0;
                }

                //Hold Shift to fly
                if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
                {
                    gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 40f, ForceMode.Impulse);
                }
                
            }
            
        }
        else
        {
            gameObject.isStatic = true; //keep player static if game is paused
        }

    }

    // Check if player is on the ground
    private void OnCollisionStay(Collision collision)
    {
        isGrounded = true;
    }
}

