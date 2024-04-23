using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVHandler : MonoBehaviour
{
    private int organ;

    public OrganController.Organ _organ;

    public GameObject Heart;
    public GameObject Kidney;
    public GameObject Liver;
    public GameObject Lungs;

    // Start is called before the first frame update
    void Awake()
    {
        var rnd = new System.Random();
        organ = rnd.Next(0, 3);
        switch (organ)
        {
            case 0:
                Heart.SetActive(true);
                Kidney.SetActive(false);
                Liver.SetActive(false);
                Lungs.SetActive(false);
                _organ = OrganController.Organ.Heart;
                break;
            case 1:
                Heart.SetActive(false);
                Kidney.SetActive(false);
                Liver.SetActive(true);
                Lungs.SetActive(false);
                _organ = OrganController.Organ.Liver;
                break;
            case 2:
                Heart.SetActive(false);
                Kidney.SetActive(true);
                Liver.SetActive(false);
                Lungs.SetActive(false);
                _organ = OrganController.Organ.Kidney;
                break;
            case 3:
                Heart.SetActive(false);
                Kidney.SetActive(false);
                Liver.SetActive(false);
                Lungs.SetActive(true);
                _organ = OrganController.Organ.Lung;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
