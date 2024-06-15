using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
public class DetectGrab : MonoBehaviour
{
    public GameObject onGrabSelectHandGO;
    private XRGrabInteractable interactor = null;
    public bool IsGrabbing;


    // Start is called before the first frame update
    private void Awake()
    {
        if (interactor == null)
        {
            interactor = GetComponent<XRGrabInteractable>();
        }
        if (interactor != null)
        {
            interactor.firstSelectEntered.AddListener(StartGrab);
            interactor.lastSelectExited.AddListener(EndGrab);
        }
    }

    private void StartGrab(SelectEnterEventArgs arg0)
    {
        IXRSelectInteractor interactor = arg0.interactorObject;
        onGrabSelectHandGO = interactor.transform.parent.gameObject;
        IsGrabbing = true;
    }
    private void EndGrab(SelectExitEventArgs arg0)
    {
        IXRSelectInteractor interactor = arg0.interactorObject;
        onGrabSelectHandGO = interactor.transform.parent.gameObject;
        IsGrabbing = false;
    }
}


