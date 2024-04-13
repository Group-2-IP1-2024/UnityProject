using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class clicklogicscrip : MonoBehaviour
{
    public yummyscrip bam;
    public GameObject blam;
    public Sprite yes;
    public Sprite no;
    public AudioSource audioSFX;


    //please ignore how i did this im lazy
    public void on_click_pink()
    {
        audioSFX.Play();
        int slap = bam.rando;
        if (slap == 0)
        {
            print("win");
            blam.GetComponent<Image>().sprite = yes;
        }
        else
        {
            print("lose");
            blam.GetComponent<Image>().sprite = no;
        }
        blam.SetActive(true);

    }

    public void on_click_red()
    {
        audioSFX.Play();
        int slap = bam.rando;
        if (slap == 1)
        {
            print("win");
            blam.GetComponent<Image>().sprite = yes;
        }
        else
        {
            print("lose");
            blam.GetComponent<Image>().sprite = no;
        }
        blam.SetActive(true);
    }
    public void on_click_purple()
    {
        audioSFX.Play();
        int slap = bam.rando;
        if (slap == 2)
        {
            print("win");
            blam.GetComponent<Image>().sprite = yes;
        }
        else
        {
            print("lose");
            blam.GetComponent<Image>().sprite = no;
        }
        blam.SetActive(true);
    }

    public void on_click_orange()
    {
        audioSFX.Play();
        int slap = bam.rando;
        if (slap == 3)
        {
            print("win");
            blam.GetComponent<Image>().sprite = yes;
        }
        else
        {
            print("lose");
            blam.GetComponent<Image>().sprite = no;
        }
        blam.SetActive(true);
    }
    public void on_click_yellow()
    {
        audioSFX.Play();
        int slap = bam.rando;
        if (slap == 4)
        {
            print("win");
            blam.GetComponent<Image>().sprite = yes;
        }
        else
        {
            print("lose");
            blam.GetComponent<Image>().sprite = no;
        }
        blam.SetActive(true);
    }
    public void on_click_green()
    {
        audioSFX.Play();
        int slap = bam.rando;
        if (slap == 5)
        {
            print("win");
            blam.GetComponent<Image>().sprite = yes;
        }
        else
        {
            print("lose");
            blam.GetComponent<Image>().sprite = no;
        }
        blam.SetActive(true);
    }
}
