using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Acceleration))]
public class AsteroidController : MonoBehaviour
{
    private Acceleration _asteroidAcceleration;

    private void Start()
    {
        _asteroidAcceleration = GetComponent<Acceleration>();
        _asteroidAcceleration.AddForce();
    }
}
