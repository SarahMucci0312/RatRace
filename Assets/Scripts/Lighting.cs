using UnityEngine;

public class Lighting : MonoBehaviour
{
    //Variables to count seconds and change light color
    private float secondsCount;
    private int count = 0;

    // Update is called once per frame
    void Update()
    {
        if(SetParams.flashingLights == true)
        {
            //Count seconds
            secondsCount += Time.deltaTime;
            
            //Change Light color every second to simulate flashing red light
            if (secondsCount > 1)
            {
                count++;
                ChangeColor(count);
                secondsCount = 0;
            }
        }
        
    }

    //Method to change color and intensity of light
    private void ChangeColor(int count)
    {
        if(count % 2 == 0)
        {
            gameObject.GetComponent<Light>().color = Color.white;
            gameObject.GetComponent<Light>().intensity = 1f;
        }
        if(count % 2 == 1)
        {
            gameObject.GetComponent<Light>().color = Color.red;
            gameObject.GetComponent<Light>().intensity = 2f;
        }
    }
}
