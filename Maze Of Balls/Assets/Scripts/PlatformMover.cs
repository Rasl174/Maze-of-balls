using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMover : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;

    private float _maxAngle = 0.1f;
    private Quaternion _platformRotation;

    private void Start()
    {
        _platformRotation = gameObject.transform.rotation;
    }

    public void RotateForward()
    {
        _platformRotation.x = Mathf.MoveTowards(_platformRotation.x, _maxAngle, _rotationSpeed * Time.deltaTime);
        gameObject.transform.rotation = _platformRotation;
    }

    public void RotateBack()
    {
        _platformRotation.x = Mathf.MoveTowards(_platformRotation.x, -_maxAngle, _rotationSpeed * Time.deltaTime);
        gameObject.transform.rotation = _platformRotation;
    }

    public void RotateLeft()
    {
        _platformRotation.z = Mathf.MoveTowards(_platformRotation.z, _maxAngle, _rotationSpeed * Time.deltaTime);
        gameObject.transform.rotation = _platformRotation;
    }

    public void RotateRight()
    {
        _platformRotation.z = Mathf.MoveTowards(_platformRotation.z, -_maxAngle, _rotationSpeed * Time.deltaTime);
        gameObject.transform.rotation = _platformRotation;
    }
}
