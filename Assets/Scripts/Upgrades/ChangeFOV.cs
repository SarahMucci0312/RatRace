using Cinemachine;
using UnityEngine;

public class ChangeFOV : MonoBehaviour
{
    //Camera variable
    public CinemachineVirtualCamera virtualCamera;

    void Update()
    {
        //Unlock increased FOV
        if(SetParams.points >= SetParams.ug2)
        {
            virtualCamera.m_Lens.FieldOfView = 50;
        }
        
    }
}
