using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Ball[] _balls;
    [SerializeField] private int _spawnCount;
    [SerializeField] private TMP_Text _countBallsText;
    [SerializeField] private float _spawnTimer;
    [SerializeField] private Animator _animator;

    private Vector3 _spawnPosition;
    private int _ballIndex;

    private void Start()
    {
        _countBallsText.text = _spawnCount.ToString();
    }

    private void Update()
    {
        _spawnPosition = transform.position;
        _spawnPosition.y += 0.4f;
    }

    private IEnumerator Spawn()
    {
        while(_spawnCount > 0)
        {
            _ballIndex = Random.Range(0, _balls.Length);
            Instantiate(_balls[_ballIndex], _spawnPosition, Quaternion.identity);
            _spawnCount--;
            yield return new WaitForSeconds(_spawnTimer);
        }
    }

    public void TrySpawn()
    {
        _countBallsText.text = _spawnCount.ToString();

        if (_spawnCount <= 0)
        {
            StopCoroutine(Spawn());
            gameObject.SetActive(false);
        }
        else
        {
            StartCoroutine(Spawn());
        }
    }

    public void StartAnimation()
    {
        _animator.Play("Text");
    }
}
