using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Acceleration : MonoBehaviour
{
    [SerializeField] private float _accelerationPower;
    [SerializeField] private ForceMode2D _forceMode;

    private Rigidbody2D _rigidbody2D;

    void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void AddForce() 
    {
        _rigidbody2D.AddForce(transform.up * _accelerationPower, _forceMode);
    }
}
