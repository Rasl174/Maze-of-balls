using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndHole : MonoBehaviour
{
    [SerializeField] private Tablet _tablet;
    [SerializeField] private ParticleSystem _stream;
    [SerializeField] private List<ParticleSystem> _confetties;
    [SerializeField] private EndGameScreen _endGameScreen;

    private int _ballsCount;
    private int _playingCount = 0;

    private void Awake()
    {
        foreach (var confetti in _confetties)
        {
            confetti.Stop();
        }
    }

    public void EnumeratorBalls()
    {
        _ballsCount++;
        _tablet.AddBalls(_ballsCount);
        _tablet.StartAnimation();
        _stream.Play();
    }

    public void DoEndGame()
    {
        if(_playingCount < _confetties.Count)
        {
            foreach (var confetti in _confetties)
            {
                _playingCount++;
                confetti.Play();
            }
            _endGameScreen.GameOver();
        }
    }
}
