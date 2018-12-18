using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserDataScript : MonoBehaviour
{
    public int correctTurns;
    public int wrongTurns;

    public void addCorrectTurn()
    {
        correctTurns++;
    }

    public void addWrongTurn()
    {
        wrongTurns++;
    }
}
