using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class OrganSync : MonoBehaviour
{
    public class SyncOrgan
    {
        public OrganController.Organ organ { get; set; }
        public bool state { get; set; }
    }
    
    public SyncOrgan[] organs = new SyncOrgan[6];
    
    public GameObject TopCanvas;
    public GameObject SideCanvas;
    
    [Header("Organs")] 
    public GameObject Kidney;

    public GameObject Heart;

    public GameObject Liver;

    public GameObject Lung;

    public GameObject Ribcage;

    public GameObject Skin;
    
    [Header("SlaveOrgans")]
    public GameObject _Kidney;

    public GameObject _Heart;

    public GameObject _Liver;

    public GameObject _Lung;

    public GameObject _Ribcage;

    public GameObject _Skin;

    void Awake()
    {
        organs[0] = new SyncOrgan()
        {
            organ = OrganController.Organ.Kidney,
            state = Kidney.activeSelf
        };
        
        organs[1] = new SyncOrgan()
        {
            organ = OrganController.Organ.Heart,
            state = Heart.activeSelf
        };
        
        organs[2] = new SyncOrgan()
        {
            organ = OrganController.Organ.Liver,
            state = Liver.activeSelf
        };
        
        organs[3] = new SyncOrgan()
        {
            organ = OrganController.Organ.Lung,
            state = Lung.activeSelf
        };
        
        organs[4] = new SyncOrgan()
        {
            organ = OrganController.Organ.Ribcage,
            state = Ribcage.activeSelf
        };
        
        organs[5] = new SyncOrgan()
        {
            organ = OrganController.Organ.Skin,
            state = Skin.activeSelf
        };
    }

    void Update()
    {
        if (TopCanvas.activeSelf)
        {
            Kidney.SetActive(organs[0].state);
            Heart.SetActive(organs[1].state);
            Liver.SetActive(organs[2].state);
            Lung.SetActive(organs[3].state);
            Ribcage.SetActive(organs[4].state);
            Skin.SetActive(organs[5].state);
        }

        if (SideCanvas.activeSelf)
        {
            _Kidney.SetActive(organs[0].state);
            _Heart.SetActive(organs[1].state);
            _Liver.SetActive(organs[2].state);
            _Lung.SetActive(organs[3].state);
            _Ribcage.SetActive(organs[4].state);
            _Skin.SetActive(organs[5].state);
        }
    }
}
