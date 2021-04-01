using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class OutOfScreenTeleport : MonoBehaviour
{
    private Vector2 _screenDimensions;
    private SpriteRenderer _spriteRenderer;

    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _screenDimensions = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
    }

    void Update()
    {
        if (transform.position.x - _spriteRenderer.bounds.size.x / 2 > _screenDimensions.x)
        {
            transform.position = new Vector2(-_screenDimensions.x, -transform.position.y);
        }
        else if (transform.position.x + _spriteRenderer.bounds.size.x / 2 < -_screenDimensions.x)
        {
            transform.position = new Vector2(_screenDimensions.x, transform.position.y);
        }
        else if (transform.position.y + _spriteRenderer.bounds.size.y / 2 < -_screenDimensions.y)
        {
            transform.position = new Vector2( transform.position.x, _screenDimensions.y);
        }
        else if (transform.position.y - _spriteRenderer.bounds.size.y / 2 > _screenDimensions.y)
        {
            transform.position = new Vector2(-transform.position.x, -_screenDimensions.y);
        }
    }
}
