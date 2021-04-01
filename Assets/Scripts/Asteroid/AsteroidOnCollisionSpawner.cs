using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidOnCollisionSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _smallAsteroidPrefab;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out BulletController bullet))
        {
            for (int i = 0; i < Random.Range(1, 4); i++)
            {
                var smallAsteroid = Instantiate(_smallAsteroidPrefab, transform.position, Quaternion.identity);
                smallAsteroid.transform.Rotate(0, 0, Vector3.Angle(transform.position * Random.Range(-1f, 1f), Vector3.up));
            }
        }
    }
}
