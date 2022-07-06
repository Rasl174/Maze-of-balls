using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndGameScreen : MonoBehaviour
{
    [SerializeField] private Tablet _tablet;
    [SerializeField] private TMP_Text _endBallsCount;

    public void GameOver()
    {
        _endBallsCount.text = _tablet.BallsCount.text;
        gameObject.SetActive(true);
    }
}
