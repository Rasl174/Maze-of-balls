using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private List<Transform> _targets;
    [SerializeField] private float _smooth;
    [SerializeField] private Vector3 _offset;
    [SerializeField] private EndHole _endHole;
    [SerializeField] private int _endTimer;

    private float _timer = 0;

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
            _timer += Time.deltaTime;
            if(_timer >= _endTimer)
            {
                _endHole.DoEndGame();
            }
        }
    }

    public void AddTargets(Transform ball)
    {
        _targets.Add(ball);
    }

    public void AddAlternativeTarget(Transform tablet)
    {
        _targets.Add(tablet);
    }
}
