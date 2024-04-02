using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    private bool isPressed = false;
    private float pressedTimer = 0f;
    public float TimeForLongPress = 4f;

    GameObject timer1;
    GameObject timer2;
    GameObject timer3;
    GameObject timer4;
    GameObject TimerDone;

    // Start is called before the first frame update
    void Start()
    {
        timer1 = GameObject.Find("Timer1");
        timer1.SetActive(false);
        timer2 = GameObject.Find("Timer2");
        timer2.SetActive(false);
        timer3 = GameObject.Find("Timer3");
        timer3.SetActive(false);
        timer4 = GameObject.Find("Timer4");
        timer4.SetActive(false);
        TimerDone = GameObject.Find("TimerDone");
        TimerDone.GetComponent<MeshRenderer>().material.color = Color.gray;
    }

    // Update is called once per frame
    void Update()
    {
        if (isPressed)
        {
            if(pressedTimer >= 0.01f)
            {
                timer1.SetActive(true);
            }
            else
            {
                timer1.SetActive(false);
            }
            if(pressedTimer >= 1f)
            {
                timer2.SetActive(true);
            }
            else
            {
                timer2.SetActive(false);
            }
            if(pressedTimer >= 2f)
            {
                timer3.SetActive(true);
            }
            else
            {
                timer3.SetActive(false);
            }
            if(pressedTimer >= 3f)
            {
                timer4.SetActive(true);
            }
            else
            {
                timer4.SetActive(false);
            }
            if(pressedTimer >= 4f)
            {
                TimerDone.GetComponent<MeshRenderer>().material.color = new Color(0.1414f, 0.2392f, 0.1754f, 1f);
            }
            else
            {
                TimerDone.GetComponent<MeshRenderer>().material.color = Color.gray;
            }
            if(pressedTimer >= 5)
            {
                TimerDone.GetComponent<MeshRenderer>().material.color = Color.red;
            }
            if(pressedTimer >= 6)
            {
                GameObject.Find("Lose1").GetComponent<ParticleSystem>().Play();
                GameObject.Find("Lose2").GetComponent<ParticleSystem>().Play();
            }
            pressedTimer += Time.deltaTime;
        }
    }

    private void OnMouseDown()
    {
        isPressed = true;
        Debug.Log("Mouse button pressed!");
    }

    private void OnMouseUpAsButton()
    {
        if(pressedTimer >= TimeForLongPress)
        {
            Debug.Log("Win confition met!");
            GameObject.Find("TransfusedParticles").GetComponent<ParticleSystem>().Play();
            resetall();
        }
        else
        {
            Debug.Log("Mouse button released early!");
            resetall();
        }
    }

    private void resetall()
    {
        isPressed = false;
        pressedTimer = 0f;
        timer1.SetActive(false);
        timer2.SetActive(false);
        timer3.SetActive(false);
        timer4.SetActive(false);
        TimerDone.GetComponent<MeshRenderer>().material.color = Color.gray;
    }
}
