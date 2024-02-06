using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusRotate : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.rotation = transform.rotation * Quaternion.Euler(1, Random.Range(-1, 2), -1);
    }
}
