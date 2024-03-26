using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialScript : MonoBehaviour
{
    Animator animtut;

    public void Start()
    {
        animtut = GetComponent<Animator>();
        Time.timeScale = 0f;
    }

    void changeAnimation()
    {
        animtut.SetInteger("Change", animtut.GetInteger("Change") + 1);
    }

    public void Endtut()
    {
        Time.timeScale = 1f;
    }

    private void Update()
    {
        if (Input.anyKeyDown)
        {
            changeAnimation();
        }
    }
}
