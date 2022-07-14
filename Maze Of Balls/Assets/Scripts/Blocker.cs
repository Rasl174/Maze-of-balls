using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Blocker : MonoBehaviour
{
    [SerializeField] private int _countBallsForDestroy;
    [SerializeField] private TMP_Text _ballsForDestroy;
    [SerializeField] private Animator _animator;

    private void Start()
    {
        _ballsForDestroy.text = _countBallsForDestroy.ToString();
    }
    private void TryDestroyBlocker()
    {
        if(_countBallsForDestroy <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void EnumeratorBalls()
    {
        _countBallsForDestroy--;
        _ballsForDestroy.text = _countBallsForDestroy.ToString();
        TryDestroyBlocker();
    }

    public void StartAnimation()
    {
        _animator.Play("BlockerText");
    }
}
