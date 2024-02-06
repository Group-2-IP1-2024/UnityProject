using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using MEC;
using Assets.Script;
using Script;
using System.Linq;

public class DocumentGeneration : MonoBehaviour
{

    public Enums.PatientData createPatientdata()
    {
        Enums.PatientData PatientData = new Enums.PatientData();
        string[] names = FileHandling.PatientNames[UnityEngine.Random.Range(0, FileHandling.PatientNames.Count)].Split(" ");
        PatientData.FirstName = names[0];
        PatientData.LastName = names[1];
        PatientData.DOB = DateTime.Now.AddYears(-UnityEngine.Random.Range(18, 100));
        PatientData.Weight = UnityEngine.Random.Range(50, 150);
        PatientData.Height = UnityEngine.Random.Range(150, 200);
        PatientData.Illness = FileHandling.Illnesses[UnityEngine.Random.Range(0, FileHandling.Illnesses.Count)];
        return PatientData;
    }

    private IEnumerator<float> CreateDataExample()
    {
        //Example for how to wait within an MEC coroutine
        yield return Timing.WaitForSeconds(1);

        //Create the patient data
        Enums.PatientData examplePatient = createPatientdata();

        //Example for getting treatment (all illness data is stored in examplePatient.Illness)
        Debug.Log(examplePatient.Illness.Treatment[0]);
        //Example for getting first name
        Debug.Log(examplePatient.FirstName);
    }
}
