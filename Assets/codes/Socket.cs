using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Socket : MonoBehaviour
{
    [SerializeField] private XRSocketInteractor socket;
    [SerializeField] private TeleportationArea area;
    bool isSocketed;
    public void on()
    {
        //isSocketed = false;
        //Debug.Log("Socketed: " + isSocketed);
        area.interactionLayers = InteractionLayerMask.GetMask("Nothing");

    }

    public void off()
    {
        //isSocketed = true;
        //Debug.Log("Socketed: " + isSocketed);
        area.interactionLayers = InteractionLayerMask.GetMask("Teleport");
    }

    //public void TeleportOn()   //끼우면 발동식.으로교체
    //{
    //    area.interactionLayers = InteractionLayerMask.GetMask("Teleport");
        
    //}
    //public void LateUpdate()
    //{
    //    if(isSocketed)
    //    {
    //        TeleportOn();
    //    }
    //    else
    //    {
    //        area.interactionLayers = InteractionLayerMask.GetMask("Nothing");
    //    }
    //}

}
