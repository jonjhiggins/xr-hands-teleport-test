using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpGemTrackHands : MonoBehaviour
{
    public Transform handTransform;
    public Vector3 offset;
    private bool trackHand = true;
    private Quaternion startRotation;

    void Start()
    {
        startRotation = transform.rotation;
    }
    // Update is called once per frame
    void Update()
    {
        if (trackHand)
        {
            SetToHandPosition();
        }
    }

    void SetToHandPosition()
    {
        transform.position = handTransform.position + offset;
    }

    public void SetHandTrackingActive() {
        trackHand = true;
        transform.rotation = startRotation;
    }

    public void SetHandTrackingInactive() {
        trackHand = false;
    }
}
