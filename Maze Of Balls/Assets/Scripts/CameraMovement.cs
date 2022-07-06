using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private List<Transform> _targets;
    [SerializeField] private float _smooth;
    [SerializeField] private Vector3 _offset;
    [SerializeField] private EndHole _endHole;

    private void FixedUpdate()
    {
        if(_targets.Count > 0)
        {
            transform.position = Vector3.Lerp(transform.position, _targets[0].transform.position + _offset, Time.deltaTime * _smooth);
            foreach (var target in _targets)
            {
                if (target.gameObject.activeSelf == false)
                {
                    _targets.Remove(target);
                    break;
                }
            }
        }
        else
        {
            _endHole.DoEndGame();
        }
    }

    public void AddTargets(Transform ball)
    {
        _targets.Add(ball);
    }
}
