using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerControls controls {get; private set;};
    public PlayerAim aim {get; private set;} // get; private set means : read-only

    private void Awake()
    {
        controls = new PlayerControls();
        aim = GetComponent<PLayerAim>();
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }
}
