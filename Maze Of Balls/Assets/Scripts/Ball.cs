using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private void Start()
    {
        float size = Random.Range(-0.4f, -0.2f);
        transform.localScale = new Vector3(size, size, size);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Spawner>(out Spawner spawnPlatform))
        {
            spawnPlatform.Spawn();
        }
        else if(other.TryGetComponent<Blocker>(out Blocker blocker))
        {
            blocker.EnumeratorBalls();
            Destroy(gameObject);
        }
    }
}
