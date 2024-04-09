using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolControllerv2 : MonoBehaviour
{
    public GameObject cam;
    public tool _tool;
    public enum tool
    {
        Scalpel,
        Scissors,
        Needle,
        Default
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        foreach (Transform child in transform)
        {
            child.LookAt(cam.transform.position);
        }
    }
}
