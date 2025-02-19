using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private WeaponVisualController visualController;

    private void Start()
    {
        visualController = GetComponentInParent<WeaponVisualController>();
    }

    public void ReloadIsOver()
    {
        visualController.MaximizeRigWeight();
        
        //refill bullet
    }

    public void ReturnRig()
    {
        visualController.MaximizeRigWeight();
        visualController.MaximizeLeftHandWeight();
    }

    public void WeaponGrabIsOver()
    {
        
        visualController.SetBusyGrabbingWeaponTo(false);
    }
}
