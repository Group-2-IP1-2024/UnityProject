using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolController : MonoBehaviour
{
    public GameObject cam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach(Transform child in transform)
        {
            child.LookAt(cam.transform.position);
        }
    }
}
