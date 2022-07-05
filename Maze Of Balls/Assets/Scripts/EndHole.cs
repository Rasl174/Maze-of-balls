using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndHole : MonoBehaviour
{
    [SerializeField] private Tablet _tablet;
    [SerializeField] private ParticleSystem _stream;

    private int _ballsCount;

    public void EnumeratorBalls()
    {
        _ballsCount++;
        _tablet.AddBalls(_ballsCount);
        _tablet.StartAnimation();
        _stream.Play();
    }
}
