using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimatedHandInput : MonoBehaviour
{
    public InputActionProperty PinchAnimationAction;
    public InputActionProperty GripAnimationAction;
    public Animator HandAnimator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PinchAnimation();
        GripAnimation();
    }

    public void PinchAnimation()
    {
        float triggerValue = PinchAnimationAction.action.ReadValue<float>();
        HandAnimator.SetFloat("Trigger", triggerValue);
    }

    public void GripAnimation() 
    {
        float GripValue = GripAnimationAction.action.ReadValue<float>();
        HandAnimator.SetFloat("Grip", GripValue);
    }
}
