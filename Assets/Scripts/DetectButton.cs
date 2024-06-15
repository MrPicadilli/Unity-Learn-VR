using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class DetectButton : MonoBehaviour
{
    private XRNode xrNodeRight = XRNode.RightHand;
    private XRNode xrNodeLeft = XRNode.LeftHand;
    private XRGrabInteractable interactor = null;
    private List<UnityEngine.XR.InputDevice> devices = new List<UnityEngine.XR.InputDevice>();
    private UnityEngine.XR.InputDevice deviceRight;
    private UnityEngine.XR.InputDevice deviceLeft;


    private void Awake()
    {
        if (interactor == null)
        {
            interactor = GetComponent<XRGrabInteractable>();
        }
    }


    void GetDevice()
    {
        InputDevices.GetDevicesAtXRNode(xrNodeRight, devices);
        deviceRight = devices.FirstOrDefault();
        InputDevices.GetDevicesAtXRNode(xrNodeLeft, devices);
        deviceLeft = devices.FirstOrDefault();
    }
    void OnEnable()
    {
        if (!deviceRight.isValid)
        {
            GetDevice();
        }
        if (!deviceLeft.isValid)
        {
            GetDevice();
        }
    }

    // Update is called once per frame
    void Update()
    {
        PossibilityToActivate();
    }

    private void PossibilityToActivate()
    {
        if (!deviceRight.isValid)
        {
            GetDevice();
        }
        if (!deviceLeft.isValid)
        {
            GetDevice();
        }
        
        bool triggerValueR;

        if (deviceRight.TryGetFeatureValue(UnityEngine.XR.CommonUsages.triggerButton, out triggerValueR) && triggerValueR)
        {
            Debug.Log("you have used the trigger button on the right manette using DetectButton");
        }
    }


}


