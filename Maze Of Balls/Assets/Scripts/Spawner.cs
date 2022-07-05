using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Ball[] _balls;
    [SerializeField] private int _spawnCount;
    [SerializeField] private TMP_Text _countBallsText;
    [SerializeField] private CameraMovement _cameraMovement;

    private Vector3 _spawnPosition;
    private int _ballIndex;

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
            _ballIndex = Random.Range(0, _balls.Length);
            Instantiate(_balls[_ballIndex], _spawnPosition, Quaternion.identity);
            _spawnCount--;
            //_cameraMovement.AddTargets(_balls[_ballIndex].gameObject.transform);
        }
    }
}
