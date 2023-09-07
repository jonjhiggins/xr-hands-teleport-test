using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

public class TeleportFloor : MonoBehaviour
{
    private TeleportationArea teleportationArea;

    private void Start()
    {
        teleportationArea = GetComponent<TeleportationArea>();
    }
    // Start is called before the first frame update
    public void CheckIfShouldTeleport()
    {
        if (teleportationArea.interactorsHovering.Count > 0)
        {
            Transform interactorTransform = teleportationArea.interactorsHovering[0].transform;
            Teleport(interactorTransform);
        }
    }

    void Teleport(Transform interactorTransform)
    {
        TeleportRequest teleportRequest = new TeleportRequest
        {
            destinationPosition = interactorTransform.position,
            destinationRotation = interactorTransform.rotation,
        };

        teleportationArea.teleportationProvider.QueueTeleportRequest(teleportRequest);
    }
}
