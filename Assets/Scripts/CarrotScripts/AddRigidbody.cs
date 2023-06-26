using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class AddRigidbody : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<Rigidbody>();
        gameObject.GetComponent<Rigidbody>().drag = 1;
        gameObject.AddComponent<XRGrabInteractable>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
