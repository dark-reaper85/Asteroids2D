using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    [SerializeField] private float _startSpawnTime = 1;
    [SerializeField] private float _spawnRepeatTime = 2;
    [SerializeField] private GameObject _asteroidPrefab;
    [SerializeField] private float _spawnRadius = 5;

    private void Start()
    {
        InvokeRepeating("SpawnAsteroid", _startSpawnTime, _spawnRepeatTime);
    }

    private void SpawnAsteroid() 
    {
        var randomPosition = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized * _spawnRadius;

        var randomAsteroid = Instantiate(_asteroidPrefab, randomPosition, Quaternion.identity);

        randomAsteroid.transform.Rotate(0, 0, Random.Range(-1f, 1f) * Vector3.Angle(randomPosition, Vector3.up));
    }
}
