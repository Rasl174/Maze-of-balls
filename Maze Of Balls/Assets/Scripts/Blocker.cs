using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Blocker : MonoBehaviour
{
    [SerializeField] private int _countBallsForDestroy;
    [SerializeField] private TMP_Text _currentBalls;
    [SerializeField] private TMP_Text _ballsForDestroy;

    private int _ballsCount = 0;

    private void Start()
    {
        _ballsForDestroy.text = _countBallsForDestroy.ToString();
    }

    public void EnumeratorBalls()
    {
        _ballsCount++;
        _currentBalls.text = _ballsCount.ToString();
        TryDestroyBlocker();
    }

    private void TryDestroyBlocker()
    {
        if(_countBallsForDestroy == _ballsCount)
        {
            Destroy(gameObject);
        }
    }
}
