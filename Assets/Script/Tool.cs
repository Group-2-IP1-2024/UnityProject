using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tool : MonoBehaviour
{
    public Texture2D toolCursor;

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
        Debug.Log($"Button Clicked {name}");
        Cursor.SetCursor(toolCursor, Vector2.zero, CursorMode.Auto);
    }
}