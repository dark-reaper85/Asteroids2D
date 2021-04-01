using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Acceleration), typeof(RotateController), typeof(ShootController))]
public class ShipController : MonoBehaviour
{
    private Acceleration _acceleration;
    private RotateController _rotateController;
    private ShootController _shootController;

    void Start()
    {
        _acceleration = GetComponent<Acceleration>();
        _rotateController = GetComponent<RotateController>();
        _shootController = GetComponent<ShootController>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _shootController.Shoot();
        }
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _acceleration.AddForce();
        }

        if (Input.GetKey(KeyCode.D))
        {
            _rotateController.RotateRight();
        }

        if (Input.GetKey(KeyCode.A))
        {
            _rotateController.RotateLeft();
        }
    }
}
