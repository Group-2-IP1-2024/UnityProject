using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Wires : MonoBehaviour
{
    private bool conditionMet = false;
    public AudioSource audioSFX;

    private LineRenderer line;
    [SerializeField] private string destinationTag;

    Vector3 offset;

    private void Awake()
    {
        conditionMet = false;
        GameController.ResetConditions();
    }
    private void Start()
    {
        line = GetComponent<LineRenderer>();
    }

    private void OnMouseDown()
    {
        offset = transform.position - MouseWorldPosition();
    }

    private void OnMouseDrag()
    {
      line.SetPosition(0, MouseWorldPosition() + offset);
        line.SetPosition(1, transform.position);
    }

    private void OnMouseUp()
    {
        Vector3 rayOrigin = Camera.main.transform.position;
        Vector3 rayDir = MouseWorldPosition() - Camera.main.transform.position;
        RaycastHit hitInfo;

        if(Physics.Raycast(rayOrigin, rayDir, out hitInfo))
        {
            if (hitInfo.transform.tag == destinationTag)
            {
                audioSFX.Play();
                line.SetPosition(0, hitInfo.transform.position);
                transform.gameObject.GetComponent<Collider>().enabled = false;

                // Set the condition to true when the action is done
                conditionMet = true;

                // Call the method in GameController to inform that a condition is met
                GameController.ConditionMet(this.gameObject.transform.parent.transform.parent.gameObject  );

            }
            else
            {
                line.SetPosition(0, transform.position);
            }
        }
    }

    private Vector3 MouseWorldPosition()
    {
        Vector3 mouseScreenPos = Input.mousePosition;
        mouseScreenPos.z = Camera.main.WorldToScreenPoint(transform.position).z;
        return Camera.main.ScreenToWorldPoint(mouseScreenPos);
    }
}

