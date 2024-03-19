using UnityEngine;

public class GameController : MonoBehaviour
{
    private static int numberOfConditionsMet = 0;
    private const int totalConditions = 3;

    public static void ConditionMet()
    {
        numberOfConditionsMet++;

        if (numberOfConditionsMet >= totalConditions)
        {
            Debug.Log("End game");
        }
    }

    public static void ResetConditions()
    {
        numberOfConditionsMet = 0;
    }
}

