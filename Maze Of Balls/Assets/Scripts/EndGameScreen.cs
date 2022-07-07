using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndGameScreen : MonoBehaviour
{
    [SerializeField] private Tablet _tablet;
    [SerializeField] private TMP_Text _endBallsCount;

    private int _ballsCount = 45;

    public void GameOver()
    {
        _endBallsCount.text = _ballsCount.ToString();
        gameObject.SetActive(true);
    }
}
