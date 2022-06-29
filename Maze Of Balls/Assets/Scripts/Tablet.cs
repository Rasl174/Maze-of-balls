using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tablet : MonoBehaviour
{
    [SerializeField] private int _endBalls;
    [SerializeField] private TMP_Text _ballsForEnd;
    [SerializeField] private TMP_Text _currentBallsCount;

    [SerializeField] private Animator _animator;

    private void Start()
    {
        _ballsForEnd.text = _endBalls.ToString();
    }

    public void AddBalls(int count)
    {
        _currentBallsCount.text = count.ToString();
    }

    public void StartAnimation()
    {
        _animator.Play("Tablet");
    }
}
