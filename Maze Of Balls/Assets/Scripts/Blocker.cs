using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Blocker : MonoBehaviour
{
    [SerializeField] private int _countBallsForDestroy;
    [SerializeField] private TMP_Text _ballsForDestroy;

    private void Start()
    {
        _ballsForDestroy.text = _countBallsForDestroy.ToString();
    }

    public void EnumeratorBalls()
    {
        _countBallsForDestroy--;
        _ballsForDestroy.text = _countBallsForDestroy.ToString();
        TryDestroyBlocker();
    }

    private void TryDestroyBlocker()
    {
        if(_countBallsForDestroy <= 0)
        {
            Destroy(gameObject);
        }
    }
}
