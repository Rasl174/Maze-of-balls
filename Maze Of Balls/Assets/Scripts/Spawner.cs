using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Ball[] _balls;

    private Vector3 _spawnPosition;

    private void Update()
    {
        _spawnPosition = transform.position;
        _spawnPosition.y += 0.3f;
    }

    public void Spawn()
    {
        Instantiate(_balls[Random.Range(0, _balls.Length)], _spawnPosition, Quaternion.identity);
    }
}
