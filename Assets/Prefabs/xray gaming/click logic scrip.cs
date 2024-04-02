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


    //please ignore how i did this im lazy
    public void on_click_pink()
    {
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
