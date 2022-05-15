
using UnityEngine;
using Cinemachine;

public class CinemachineSwitcher : MonoBehaviour
{
    [SerializeField]
    private CinemachineVirtualCamera vcam1; // direita
    [SerializeField]
    private CinemachineVirtualCamera vcam2; // esquerda

    void Update()
    {
        SwitchState();
    }

    private void SwitchState()
    {
        if(Input.GetAxis("Horizontal") < 0)
        {
            vcam1.Priority = 0;
            vcam2.Priority = 1;
        }
        else if(Input.GetAxis("Horizontal") > 0)
        {
            vcam1.Priority = 1;
            vcam2.Priority = 0;
        }
    }
   
}
