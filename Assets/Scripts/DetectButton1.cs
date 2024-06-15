using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
public class DetectButton1 : MonoBehaviour
{
    [SerializeField]
    private InputActionReference trigger;

    // Update is called once per frame
    void Update()
    {
        PossibilityToActivate();
    }

    private void PossibilityToActivate()
    {
        if (trigger.action.inProgress )
        {
            Debug.Log("you have used the trigger button on the right manette using DetectButton1");
        }
    }

}


