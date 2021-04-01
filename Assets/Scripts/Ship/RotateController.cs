using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateController : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed;

    public void RotateLeft() 
    {
        transform.Rotate(0, 0, _rotateSpeed);
    }

    public void RotateRight() 
    {
        transform.Rotate(0, 0, -_rotateSpeed);
    }
}
