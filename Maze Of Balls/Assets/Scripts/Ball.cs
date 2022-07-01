using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float _minSize;
    [SerializeField] private float _maxSize;

    private void Start()
    {
        float size = Random.Range(_minSize, _maxSize);
        transform.localScale = new Vector3(size, size, size);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Spawner>(out Spawner spawnPlatform))
        {
            spawnPlatform.TrySpawn();
        }
        else if(other.TryGetComponent<Blocker>(out Blocker blocker))
        {
            blocker.EnumeratorBalls();
            gameObject.SetActive(false);
        }
        else if(other.TryGetComponent<EndHole>(out EndHole endHole))
        {
            endHole.EnumeratorBalls();
        }
    }
}
