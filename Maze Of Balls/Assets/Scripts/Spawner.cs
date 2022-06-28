using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Ball[] _balls;
    [SerializeField] private int _spawnCount;
    [SerializeField] private TMP_Text _countBallsText;

    private Vector3 _spawnPosition;

    private void Start()
    {
        _countBallsText.text = _spawnCount.ToString();
    }

    private void Update()
    {
        _spawnPosition = transform.position;
        _spawnPosition.y += 0.3f;
    }

    public void TrySpawn()
    {
        _countBallsText.text = _spawnCount.ToString();

        if (_spawnCount <= 0)
        {
            gameObject.SetActive(false);
        }
        else
        {
            Instantiate(_balls[Random.Range(0, _balls.Length)], _spawnPosition, Quaternion.identity);
            _spawnCount--;
        }
    }
}
