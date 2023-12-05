using UnityEngine;

public class Scale: MonoBehaviour
{
    //Scale variables
    public float scaleEasy;
    public float scaleMedium;
    public float scaleHard;

    //Scale objects according to game difficulty 
    void Start()
    {
       if(SetParams.mode == 1) //Easy
        {
            transform.localScale = new Vector3 (scaleEasy, scaleEasy, scaleEasy);
        } 
       else if(SetParams.mode == 2) //Medium
        {
            transform.localScale = new Vector3(scaleMedium, scaleMedium, scaleMedium);
        }
        else //Hard
        {
            transform.localScale = new Vector3 (scaleHard, scaleHard, scaleHard);
        }
    }

}
