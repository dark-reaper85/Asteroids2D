using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class ShootController : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPrefab;

    private AudioSource _shootSound;

    private void Start()
    {
        _shootSound = GetComponent<AudioSource>();
    }

    public void Shoot() 
    {
        _shootSound.Play();
        Instantiate(_bulletPrefab, transform.localPosition, transform.localRotation);
    }
}
