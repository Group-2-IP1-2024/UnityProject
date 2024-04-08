using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
public class CharacterScrip : MonoBehaviour
{
    public GameObject character;

    public bool isChicken = true;

    public bool isPaper = false;

    public bool isRobot = false;
    
    public State state = State.Closed;
    
    public Sprite chickenClosed;
    public Sprite chickenOpen;
    public Sprite chickenOrgans;
    public Sprite paperClosed;
    public Sprite paperOpen;
    public Sprite paperOrgans;
    public Sprite robotClosed;
    public Sprite robotOpen;
    public Sprite robotOrgans;
    public enum State
    {
        Closed,
        Opened,
        Organs
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (isChicken)
        {
            switch (state)
            {
                case State.Closed:
                    character.GetComponent<UnityEngine.UI.Image>().sprite = chickenClosed;
                    break;
                case State.Opened:
                    character.GetComponent<UnityEngine.UI.Image>().sprite = chickenOpen;
                    break;
                case State.Organs:
                    character.GetComponent<UnityEngine.UI.Image>().sprite = chickenOrgans;
                    break;
            }
            //character.GetComponent<UnityEngine.UI.Image>().sprite
        }

        if (isPaper)
        {
            switch (state)
            {
                case State.Closed:
                    //character.GetComponent<UnityEngine.UI.Image>().sprite = 
                    break;
            }
        }
    }
}
