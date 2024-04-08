using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StitchScript : MonoBehaviour
{
    public Camera m_camera;
    public GameObject brushPink;
    LineRenderer lineRen;

    Vector3 lastPos;
    void Update()
    {
        Drawing();
    }

    void AddAPoint(Vector3 pointPos)
    {
        lineRen.positionCount++;
        int positionIndex = lineRen.positionCount - 1;
        lineRen.SetPosition(positionIndex, pointPos);
    }

    void PointToMousePos()
    {
        Vector3 mousePos = MouseWorldPosition();
        if (lastPos != mousePos)
        {
            AddAPoint(mousePos);
            lastPos = mousePos;
        }
    }
    void Drawing()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            CreateBrushPink();
        }
        else if (Input.GetKey(KeyCode.Mouse0))
        {
            PointToMousePos();
        }
        else
        {
            lineRen = null;
        }
    }

    void CreateBrushPink()
    {
        GameObject brushInstance = Instantiate(brushPink);
        lineRen = brushInstance.GetComponent<LineRenderer>();
        Vector3 mousePos = MouseWorldPosition();
        lineRen.SetPosition(0, mousePos);
        lineRen.SetPosition(1, mousePos);
    }
    private Vector3 MouseWorldPosition()
    {
        Vector3 mouseScreenPos = Input.mousePosition;
        mouseScreenPos.z = Camera.main.WorldToScreenPoint(transform.position).z;
        return Camera.main.ScreenToWorldPoint(mouseScreenPos);
    }
}
