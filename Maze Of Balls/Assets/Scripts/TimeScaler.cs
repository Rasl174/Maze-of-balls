using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeScaler : MonoBehaviour
{
    [SerializeField] private float _time;

    private void Awake()
    {
        Time.timeScale = _time;
    }
}
