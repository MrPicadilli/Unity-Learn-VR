using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
public class DetectButton2 : MonoBehaviour
{
    [SerializeField]
    private InputActionReference trigger;


    private void OnEnable() {
        trigger.action.performed += DoSomething;
    }

    private void DoSomething(InputAction.CallbackContext context)
    {
        Debug.Log("you have used the trigger button on the right manette using DetectButton2");
    }

    private void OnDisable() {
        trigger.action.performed -= DoSomething;
    }


}


