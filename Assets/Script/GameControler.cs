using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private static int numberOfConditionsMet = 0;
    private const int totalConditions = 3;

    public void Awake()
    {
        Debug.Log($"{this.gameObject.name}");
    }

    public static void ConditionMet(GameObject g)
    {
        numberOfConditionsMet++;

        if (numberOfConditionsMet >= totalConditions)
        {
            Debug.Log("Win");
            Destroy(g);
            //SceneManager.LoadScene("Win");
        }
        
    }

    public static void ResetConditions()
    {
        numberOfConditionsMet = 0;
    }
}

