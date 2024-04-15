using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tool : MonoBehaviour
{
    public Texture2D toolCursor;
    public AudioSource audioSFX;

    private void OnMouseUpAsButton()
    {
        Debug.Log($"Button Clicked {name}");
        audioSFX.Play();
        Cursor.SetCursor(toolCursor, new Vector2(toolCursor.width * 0.5f, toolCursor.height * 0.5f), CursorMode.ForceSoftware);
        switch (name)
        {
            case "Scalpel":
                this.GetComponentInParent<ToolControllerv2>()._tool = ToolControllerv2.tool.Scalpel;
                break;
            case "Scissors":
                this.GetComponentInParent<ToolControllerv2>()._tool = ToolControllerv2.tool.Scissors;
                break;
            case "Needle":
                this.GetComponentInParent<ToolControllerv2>()._tool = ToolControllerv2.tool.Needle;
                break;
            case "MagnifyingGlass":
                this.GetComponentInParent<ToolControllerv2>()._tool = ToolControllerv2.tool.MagnifyingGlass;
                break;
        }
    }
}
