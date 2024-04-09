using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OrganController : MonoBehaviour
{
    public GameObject transfusionPrefab;
    public GameObject SceneManager;
    public GameObject toolcontroller;

    public Texture2D toolCursor;
    public enum Organ
    {
        Heart,
        Kidney,
        Liver,
        Lung,
        Ribcage,
        Skin
    }

    void Awake()
    {
        
    }

    void Update()
    {
    }

    public void OrganClicked(Organ o, GameObject oGO)
    {
        if (SceneManager.GetComponent<CharacterScrip>().state == CharacterScrip.State.Opened)
        {
            switch (o)
            {
                case Organ.Ribcage:
                    if (toolcontroller.GetComponent<ToolControllerv2>()._tool == ToolControllerv2.tool.Scissors)
                        oGO.SetActive(false);
                    break;
                case Organ.Heart:
                    if (toolcontroller.GetComponent<ToolControllerv2>()._tool == ToolControllerv2.tool.Scalpel)
                        oGO.SetActive(false);
                    Cursor.SetCursor(toolCursor, new Vector2(toolCursor.width * 0.5f, toolCursor.height * 0.5f), CursorMode.Auto);
                    toolcontroller.GetComponent<ToolControllerv2>()._tool = ToolControllerv2.tool.Default;
                    Instantiate(transfusionPrefab, new Vector3(15.15f, 0, 0), Quaternion.Euler(0, 0, 0));

                    break;
                case Organ.Kidney:
                    if (toolcontroller.GetComponent<ToolControllerv2>()._tool == ToolControllerv2.tool.Scalpel)
                        oGO.SetActive(false);
                    break;
                case Organ.Liver:
                    if (toolcontroller.GetComponent<ToolControllerv2>()._tool == ToolControllerv2.tool.Scalpel)
                        oGO.SetActive(false);
                    break;
                case Organ.Lung:
                    if (toolcontroller.GetComponent<ToolControllerv2>()._tool == ToolControllerv2.tool.Scalpel)
                        oGO.SetActive(false);
                    break;

            }
        }
        else if(o == Organ.Skin && SceneManager.GetComponent<CharacterScrip>().state == CharacterScrip.State.Closed && toolcontroller.GetComponent<ToolControllerv2>()._tool == ToolControllerv2.tool.Scissors)
        {
            SceneManager.GetComponent<CharacterScrip>().state = CharacterScrip.State.Opened;
            oGO.SetActive(false);
        }
    }
}