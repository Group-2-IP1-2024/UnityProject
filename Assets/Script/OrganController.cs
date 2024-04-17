using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OrganController : MonoBehaviour
{
    public GameObject transfusionPrefab;
    public GameObject xrayPrefab;
    public GameObject vainPrefab;
    public GameObject stitchPrefab;

    public GameObject SlaveOrgans;
    
    public GameObject SceneManager;
    public GameObject toolcontroller;

    
    
    public bool minigameComplete = false;

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
    public void OrganClicked(Organ o, GameObject oGO)
    {
        if (SceneManager.GetComponent<CharacterScrip>().state == CharacterScrip.State.Opened)
        {
            switch (o)
            {
                case Organ.Ribcage:
                    if (toolcontroller.GetComponent<ToolControllerv2>()._tool == ToolControllerv2.tool.Scalpel)
                    {
                        oGO.SetActive(false);
                        SceneManager.GetComponent<OrganSync>().organs[4].state =
                            false;
                    }

                    break;
                case Organ.Heart:
                    if (toolcontroller.GetComponent<ToolControllerv2>()._tool == ToolControllerv2.tool.Scalpel)
                    {
                        oGO.SetActive(false);
                        SceneManager.GetComponent<OrganSync>().organs[1].state =
                            false;
                        Cursor.SetCursor(toolCursor, new Vector2(toolCursor.width * 0.5f, toolCursor.height * 0.5f),
                            CursorMode.Auto);
                        toolcontroller.GetComponent<ToolControllerv2>()._tool = ToolControllerv2.tool.Default;
                        Instantiate(transfusionPrefab, new Vector3(15.15f, 0, 0), Quaternion.Euler(0, 0, 0));
                    }

                    break;
                case Organ.Kidney:
                    if (toolcontroller.GetComponent<ToolControllerv2>()._tool == ToolControllerv2.tool.Scalpel)
                    {
                        oGO.SetActive(false);
                        SceneManager.GetComponent<OrganSync>().organs[0].state =
                            false;
                    }

                    break;
                case Organ.Liver:
                    if (toolcontroller.GetComponent<ToolControllerv2>()._tool == ToolControllerv2.tool.MagnifyingGlass)
                    {
                        oGO.SetActive(false);
                        SceneManager.GetComponent<OrganSync>().organs[2].state =
                            false;
                        Cursor.SetCursor(toolCursor, new Vector2(toolCursor.width * 0.5f, toolCursor.height * 0.5f), CursorMode.Auto);
                        toolcontroller.GetComponent<ToolControllerv2>()._tool = ToolControllerv2.tool.Default;
                        Instantiate(xrayPrefab, new Vector3(15.15f, 0, 0), Quaternion.Euler(0, 0, 0));
                    }

                    break;
                case Organ.Lung:
                    if (toolcontroller.GetComponent<ToolControllerv2>()._tool == ToolControllerv2.tool.Scalpel)
                    {
                        oGO.SetActive(false);
                        SceneManager.GetComponent<OrganSync>().organs[3].state =
                            false;
                        Cursor.SetCursor(toolCursor, new Vector2(toolCursor.width * 0.5f, toolCursor.height * 0.5f), CursorMode.Auto);
                        toolcontroller.GetComponent<ToolControllerv2>()._tool = ToolControllerv2.tool.Default;
                        Instantiate(vainPrefab, new Vector3(15.15f, 99, 0), Quaternion.Euler(0, 0, 0));
                    }

                    break;
                case Organ.Skin:
                    if (toolcontroller.GetComponent<ToolControllerv2>()._tool == ToolControllerv2.tool.Needle && minigameComplete == true)
                    {
                        SceneManager.GetComponent<CharacterScrip>().state = CharacterScrip.State.Closed;
                        oGO.SetActive(false);
                        SceneManager.GetComponent<OrganSync>().organs[5].state =
                            false;
                    }
                    break;

            }
        }
        else if(o == Organ.Skin && SceneManager.GetComponent<CharacterScrip>().state == CharacterScrip.State.Closed && toolcontroller.GetComponent<ToolControllerv2>()._tool == ToolControllerv2.tool.Scissors)
        {
            SceneManager.GetComponent<CharacterScrip>().state = CharacterScrip.State.Opened;
            oGO.SetActive(false);
            SceneManager.GetComponent<OrganSync>().organs[5].state = false;
        }
    }
}
