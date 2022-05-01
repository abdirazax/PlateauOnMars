using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class TaskOutput : MonoBehaviour
{

    [SerializeField]
    TextMeshPro outputTMPro;
    [SerializeField]
    TextMeshPro outputTMProSmallScreen;

    public void DisplayText(string text)
    {
        outputTMPro.text = text;
    }

    public void DisplayMovers( List<Mover> movers )
    {
        string outputText = "";
        foreach (Mover mover in movers)
        {
            outputText += mover.Pos.x
                                + " "
                                + mover.Pos.y
                                + " "
                                + mover.OrientationManager.CurrentOrientationString
                                + "\n";
        }
        outputTMPro.text = outputText;
    }

    internal void DisplayTextOnSmallScreen(string text)
    {
        outputTMProSmallScreen.text = text;
    }
}
