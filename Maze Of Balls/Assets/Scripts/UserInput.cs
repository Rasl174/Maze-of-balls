using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    [SerializeField] private PlatformMover _platform;

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _platform.RotateForward();
        }
        else if (Input.GetKey(KeyCode.S))
        {
            _platform.RotateBack();
        }
        else if (Input.GetKey(KeyCode.A))
        {
            _platform.RotateLeft();
        }
        else if (Input.GetKey(KeyCode.D))
        {
            _platform.RotateRight();
        }
    }
}
