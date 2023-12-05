using UnityEditor;
using UnityEngine;

public class SetParams : MonoBehaviour
{
    // Main Menu
    public static bool isClosed = true;
    public static bool isClosed2 = true;
    public static bool isClosed3 = true;
    public static int mode = 1;
    public static bool flashingLights = true;
    public static bool canClick = true;

    //Pause Menu & Game Over Menu
    public static bool isMoving = true;
    public static bool isPaused = false;

    //General
    public static float ug1 = 12000;
    public static float ug2 = 24000;
    public static float ug3 = 40000;

    //Health
    public static float health = 10f;
    public static float maxHealth = 10f;

    //Score
    public static float totalScore = 0f;
    public static float highScore = 0f;

    //Distance
    public static float distance = 0f;

    //Points
    public static float points = 0f;
    public static float multiplier = 1f;

    //Speed
    public static float speed = 3f;

    //Variables related to power-ups
    public static int destroy = -1;
    public static bool canFly = false;
    public static bool isDouble = false;
    public static bool isInvincible = false;
    public static bool isSmall = false ;

    //Methods to decrease health on obstacle contact
    public static void DecreaseHealth()
    {
        health--;
    }

    public static void DecreaseHealthLess()
    {
        health -= 0.5f;
    }

    //Methods to increase points on coin contact
    public static void IncreasePoints()
    {
        points += (100 * multiplier);
    }

    public static void DoublePoints()
    {
        points += (200 * multiplier);
    }

    //Method to increase player speed
    public static void IncreaseSpeed()
    {
        speed += 0.1f;
    }

    //Set default values
    public static void SetDefaults()
    {
        //Reset Menu Settings
        isMoving = true;
        isPaused = false ;

        //Reset default health, score, distance travelled, points
        health = 10f;
        maxHealth = 10f;
        totalScore = 0f;
        distance = 0f;
        points = 0f;

        //Reset Power-Up Variables
        destroy = -1;
        canFly = false;
        isDouble = false;
        isInvincible = false;
        isSmall = false;

    }

}
