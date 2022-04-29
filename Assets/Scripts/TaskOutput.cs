using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TaskOutput : MonoBehaviour
{

    List<Rover> _rovers;
    [SerializeField]
    TaskInput input;
    [SerializeField]
    TextMeshPro outputTMPro;
    public void ExecuteAndDisplay()
    {
        string outputText = "";
        _rovers = input.GetRoversAfterCommandsExecuted();
        foreach(Rover r in _rovers)
        {
            outputText += r.Pos.x
                                + " "
                                + r.Pos.y
                                + " "
                                + r.OrientationManager.CurrentOrientationString
                                + "\n";
            
        }
        outputTMPro.text = outputText;
    }

    //debugging
    private void Start()
    {
        ExecuteAndDisplay();
    }
}
