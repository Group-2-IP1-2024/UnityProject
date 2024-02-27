using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class yummyscrip : MonoBehaviour
{
    public Sprite[] bleem;
    public int rando;
    // Start is called before the first frame update
    void Start()
    {
        rando = Random.Range(0, bleem.Length);
        gameObject.GetComponent<Image>().sprite = bleem[rando];

    }

    // Update is called once per frame
    void Update()
    {   
    }
}
