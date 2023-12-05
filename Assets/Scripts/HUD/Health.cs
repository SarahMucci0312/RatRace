using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private HealthBar healthBar;
    
    void Start()
    {
        //Easy mode health parameters
        if (SetParams.mode == 1)
        {
            SetParams.health = 10f;
            SetParams.maxHealth = 10f;
        }
        //Medium mode health parameters
        else if (SetParams.mode == 2)
        {
            SetParams.health = 8f;
            SetParams.maxHealth = 8f;
        }
        //Hard mode health parameters
        else
        {
            SetParams.health = 5f;
            SetParams.maxHealth = 5f;
        }

        healthBar.SetMaxHealth(SetParams.maxHealth); //Set parameters in HUD
    }

    void Update()
    {
        healthBar.setHealth(SetParams.health); //Update parameters in HUD
    }
}
