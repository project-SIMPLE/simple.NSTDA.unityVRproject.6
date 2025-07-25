using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRCallbackGrabbaleObject : UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable
{
    [SerializeField]
    private GameObject callbackObj;
    [SerializeField]
    private Transform instantiateTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    protected override void Awake()
    {
        base.Awake();
    }
    

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {

        instantiateTransform = args.interactorObject.transform;

        //GameObject newObj = Instantiate(instantiateObj, instantiateTransform.position, Quaternion.identity);
        callbackObj.transform.position = instantiateTransform.position;
        callbackObj.transform.rotation = instantiateTransform.rotation;


        UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable objInteracable = callbackObj.GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>();

        interactionManager.SelectEnter(args.interactorObject, objInteracable);
        base.OnSelectEntered(args);
    }
}
