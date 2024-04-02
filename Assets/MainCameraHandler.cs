using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MainCameraHandler : MonoBehaviour
{
    public GameObject cameraBrain;
    public GameObject sideCamera;
    public GameObject topCamera;

    public GameObject sideCanvas;
    public GameObject topCanvas;

    public int camerap1;
    public int camerap2;
    public void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            topCamera.GetComponent<Cinemachine.CinemachineVirtualCamera>().Priority = 100;
            sideCamera.GetComponent<Cinemachine.CinemachineVirtualCamera>().Priority = 0;
            sideCanvas.SetActive(false);
            topCanvas.SetActive(true);
        }
        if (Input.GetKey(KeyCode.S))
        {
            topCamera.GetComponent<Cinemachine.CinemachineVirtualCamera>().Priority = 0;
            sideCamera.GetComponent<Cinemachine.CinemachineVirtualCamera>().Priority = 100;
            sideCanvas.SetActive(true);
            topCanvas.SetActive(false);
        }
    }
}
