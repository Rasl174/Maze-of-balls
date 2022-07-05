using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float _minSize;
    [SerializeField] private float _maxSize;
    [SerializeField] private ParticleSystem _splash;

    private MeshRenderer _mesh;
    private Rigidbody _body;

    private void Start()
    {
        _body = gameObject.GetComponent<Rigidbody>();
        _mesh = gameObject.GetComponent<MeshRenderer>();
        float size = Random.Range(_minSize, _maxSize);
        transform.localScale = new Vector3(size, size, size);
        _body.velocity = new Vector3(0, -2, 0);
    }

    private void Update()
    {
        if (_body.IsSleeping())
        {
            _body.WakeUp();
        }
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
            SetColor();
            Instantiate(_splash, gameObject.transform.position, Quaternion.identity);
            gameObject.SetActive(false);
        }
        else if(other.TryGetComponent<EndHole>(out EndHole endHole))
        {
            endHole.EnumeratorBalls();
            SetColor();
            Instantiate(_splash, gameObject.transform.position, Quaternion.identity);
            gameObject.SetActive(false);
        }
    }

    private void SetColor()
    {
        _splash.startColor = _mesh.material.color;
    }
}
