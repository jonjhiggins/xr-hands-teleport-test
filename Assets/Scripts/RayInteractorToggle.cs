using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayInteractorToggle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SetInactive();
    }

    // Update is called once per frame
    public void SetActive()
    {
        gameObject.SetActive(true);
    }

    public void SetInactive()
    {
        gameObject.SetActive(false);
    }
}
