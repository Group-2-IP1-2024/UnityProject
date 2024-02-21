using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

namespace Script
{
    public class CameraHandler : MonoBehaviour
    {
        public GameObject sideCamera;
        public GameObject topCamera;


        public void Awake()
        {
            sideCamera = GameObject.Find("SideCamera");
            topCamera = GameObject.Find("TopCamera");
        }

        public bool topView;

        public void Update()
        {
            UpdateCamera();
        }

        public void UpdateCamera()
        {
            if(topView)
            {
                sideCamera.GetComponent<Cinemachine.CinemachineVirtualCamera>().Priority = -1;
                topCamera.GetComponent<Cinemachine.CinemachineVirtualCamera>().Priority = 1;
            }
            else
            {
                sideCamera.GetComponent<Cinemachine.CinemachineVirtualCamera>().Priority = 1;
                topCamera.GetComponent<Cinemachine.CinemachineVirtualCamera>().Priority = -1;
            }
        }
        
    }
}