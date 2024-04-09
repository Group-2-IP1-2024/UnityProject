using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Organ : MonoBehaviour
{
    public OrganController.Organ OrganType;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnMouseUpAsButton()
    {
        this.transform.parent.GetComponentInParent<OrganController>().OrganClicked(OrganType, this.gameObject);
    }
}
