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
            var xrRayInteractor = teleportationArea.interactorsHovering[0].transform.GetComponent<XRRayInteractor>();
            bool rayhitExists = xrRayInteractor.TryGetCurrent3DRaycastHit(out RaycastHit raycastHit);
            if (rayhitExists)
            {
               
            Teleport(raycastHit);
            }
        }
    }

    void Teleport(RaycastHit raycastHit)
    {


        TeleportRequest teleportRequest = new TeleportRequest
        {
            destinationPosition = raycastHit.point,
            destinationRotation = transform.rotation,
        };

        teleportationArea.teleportationProvider.QueueTeleportRequest(teleportRequest);
    }
}
