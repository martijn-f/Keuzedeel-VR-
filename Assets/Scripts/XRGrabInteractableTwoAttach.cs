using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRGrabInteractableTwoAttach : XRGrabInteractable
{
    public Transform leftAttachTransform;
    public Transform rightAttachTransform;


    protected override void OnSelectEntering(SelectEnterEventArgs args)
    {
        if(args.interactableObject.transform.CompareTag("Left Hand"))
        {
            attachTransform = leftAttachTransform;
        }
        else if(args.interactorObject.transform.CompareTag("Right Hand"))
        {
            attachTransform = rightAttachTransform;
        }




        base.OnSelectEntering(args);
    }
}
