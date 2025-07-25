using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRInstantiateGrabbaleObject : UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable
{
    [SerializeField]
    private GameObject instantiateObj;
    [SerializeField]
    private Transform instantiateTransform;

    protected override void Awake()
    {
        base.Awake();
    }

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        
        instantiateTransform = args.interactorObject.transform;

        GameObject newObj = Instantiate(instantiateObj, instantiateTransform.position, Quaternion.identity);

        UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable objInteracable = newObj.GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>();

        interactionManager.SelectEnter(args.interactorObject, objInteracable);
        base.OnSelectEntered(args);
    }
}
