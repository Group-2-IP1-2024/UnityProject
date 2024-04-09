using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
public class CharacterScrip : MonoBehaviour
{
    //public GameObject character;

    public GameObject sideCharacter;
    public GameObject topCharacter;

    public GameObject organs;
    public GameObject topOrgans;

    public character _character = character.Chicken;
    public State state = State.Closed;
    
    public Sprite chickenClosed;
    public Sprite topChickenClosed;
    public Sprite chickenOpen;
    public Sprite topChickenOpen;
    public Sprite paperClosed;
    public Sprite topPaperClosed;
    public Sprite paperOpen;
    public Sprite topPaperOpen;
    public Sprite robotClosed;
    public Sprite topRobotClosed;
    public Sprite robotOpen;
    public Sprite topRobotOpen;

    public enum State
    {
        Closed,
        Opened
    }
    public enum character
    {
        Chicken,
        Paper,
        Robot
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        switch(_character)
        {
            case character.Chicken:
                switch(state)
                {
                    case State.Closed:
                        sideCharacter.GetComponent<Image>().sprite = chickenClosed;
                        topCharacter.GetComponent<Image>().sprite = topChickenClosed;
                        organs.SetActive(false);
                        topOrgans.SetActive(false);
                        break;
                    case State.Opened:
                        sideCharacter.GetComponent<Image>().sprite = chickenOpen;
                        topCharacter.GetComponent<Image>().sprite = topChickenOpen;
                        organs.SetActive(true);
                        topOrgans.SetActive(true);
                        break;
                }
                break;
            case character.Paper:
                switch (state)
                {
                    case State.Closed:
                        sideCharacter.GetComponent<Image>().sprite = paperClosed;
                        topCharacter.GetComponent<Image>().sprite = topPaperClosed;
                        organs.SetActive(false);
                        topOrgans.SetActive(false);
                        break;
                    case State.Opened:
                        sideCharacter.GetComponent<Image>().sprite = paperOpen;
                        topCharacter.GetComponent<Image>().sprite = topPaperOpen;
                        organs.SetActive(true);
                        topOrgans.SetActive(true);
                        break;
                }
                break;
            case character.Robot:
                switch (state)
                {
                    case State.Closed:
                        sideCharacter.GetComponent<Image>().sprite = robotClosed;
                        topCharacter.GetComponent<Image>().sprite = topRobotClosed;
                        organs.SetActive(false);
                        topOrgans.SetActive(false);
                        break;
                    case State.Opened:
                        sideCharacter.GetComponent<Image>().sprite = robotOpen;
                        topCharacter.GetComponent<Image>().sprite = topRobotOpen;
                        organs.SetActive(true);
                        topOrgans.SetActive(true);
                        break;
                }
                break;
        }
    }
}
