using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Acceleration))]
public class BulletController : MonoBehaviour
{
    private Acceleration _bulletAcceleration;

    private void Start()
    {
        _bulletAcceleration = GetComponent<Acceleration>();

        _bulletAcceleration.AddForce();
    }
}
