using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationMovement : MonoBehaviour
{
    public MasterJoystick joystick;

    private void FixedUpdate()
    {
        transform.Rotate(0, 0, -joystick.Horizontal, Space.World);
    }
}