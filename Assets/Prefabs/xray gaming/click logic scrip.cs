using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

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
            if(GameObject.Find("TV").GetComponent<TVHandler>()._organ == OrganController.Organ.Liver){
                print("win");
                blam.GetComponent<Image>().sprite = yes;
                SceneManager.LoadScene("Win");
                Destroy(this.gameObject);
            }
            else
            {
                print("lose");
                blam.GetComponent<Image>().sprite = no;
                SceneManager.LoadScene("Lose");
            }
        }
        else
        {
            print("lose");
            blam.GetComponent<Image>().sprite = no;
            SceneManager.LoadScene("Lose");
        }
        blam.SetActive(true);

    }

    public void on_click_red()
    {
        audioSFX.Play();
        int slap = bam.rando;
        if (slap == 1)
        {
            if(GameObject.Find("TV").GetComponent<TVHandler>()._organ == OrganController.Organ.Liver){
                print("win");
                blam.GetComponent<Image>().sprite = yes;
                SceneManager.LoadScene("Win");
                Destroy(this.gameObject);
            }
            else
            {
                print("lose");
                blam.GetComponent<Image>().sprite = no;
                SceneManager.LoadScene("Lose");
            }
        }
        else
        {
            print("lose");
            blam.GetComponent<Image>().sprite = no;
            SceneManager.LoadScene("Lose");
        }
        blam.SetActive(true);
    }
    public void on_click_purple()
    {
        audioSFX.Play();
        int slap = bam.rando;
        if (slap == 2)
        {
            if(GameObject.Find("TV").GetComponent<TVHandler>()._organ == OrganController.Organ.Liver){
                print("win");
                blam.GetComponent<Image>().sprite = yes;
                SceneManager.LoadScene("Win");
                Destroy(this.gameObject);
            }
            else
            {
                print("lose");
                blam.GetComponent<Image>().sprite = no;
                SceneManager.LoadScene("Lose");
            }
        }
        else
        {
            print("lose");
            blam.GetComponent<Image>().sprite = no;
            SceneManager.LoadScene("Lose");
        }
        blam.SetActive(true);
    }

    public void on_click_orange()
    {
        audioSFX.Play();
        int slap = bam.rando;
        if (slap == 3)
        {
            if(GameObject.Find("TV").GetComponent<TVHandler>()._organ == OrganController.Organ.Liver){
                print("win");
                blam.GetComponent<Image>().sprite = yes;
                SceneManager.LoadScene("Win");
                Destroy(this.gameObject);
            }
            else
            {
                print("lose");
                blam.GetComponent<Image>().sprite = no;
                SceneManager.LoadScene("Lose");
            }
        }
        else
        {
            print("lose");
            blam.GetComponent<Image>().sprite = no;
            SceneManager.LoadScene("Lose");
        }
        blam.SetActive(true);
    }
    public void on_click_yellow()
    {
        audioSFX.Play();
        int slap = bam.rando;
        if (slap == 4)
        {
            if(GameObject.Find("TV").GetComponent<TVHandler>()._organ == OrganController.Organ.Liver){
            print("win");
            blam.GetComponent<Image>().sprite = yes;
            SceneManager.LoadScene("Win");
            Destroy(this.gameObject);
            }
            else
            {
                print("lose");
                blam.GetComponent<Image>().sprite = no;
                SceneManager.LoadScene("Lose");
            }
        }
        else
        {
            print("lose");
            blam.GetComponent<Image>().sprite = no;
            SceneManager.LoadScene("Lose");
        }
        blam.SetActive(true);
    }
    public void on_click_green()
    {
        audioSFX.Play();
        int slap = bam.rando;
        if (slap == 5)
        {
            if(GameObject.Find("TV").GetComponent<TVHandler>()._organ == OrganController.Organ.Liver){
                print("win");
                blam.GetComponent<Image>().sprite = yes;
                SceneManager.LoadScene("Win");
                Destroy(this.gameObject);
            }
            else
            {
                print("lose");
                blam.GetComponent<Image>().sprite = no;
                SceneManager.LoadScene("Lose");
            }
        }
        else
        {
            print("lose");
            blam.GetComponent<Image>().sprite = no;
            SceneManager.LoadScene("Lose");
        }
        blam.SetActive(true);
    }
}
