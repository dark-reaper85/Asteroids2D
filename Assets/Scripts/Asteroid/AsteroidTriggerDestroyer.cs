using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AsteroidTriggerDestroyer : MonoBehaviour
{
    private AudioSource _collisionSound;

    private void Start()
    {
        _collisionSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other == null) return;

        _collisionSound.Play();

        if (other.TryGetComponent(out BulletController bullet))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        else if(other.TryGetComponent(out LifeChecker ship))
        {
            ship.CurrentLives--;

            if (ship.CurrentLives > 0)
            {
                Destroy(gameObject);
            }
            else
            {
                Debug.Log("Game Over");

                Destroy(other.gameObject);
            }
        }
    }
}
