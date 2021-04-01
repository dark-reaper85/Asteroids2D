using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfScreenDestroy : MonoBehaviour
{
    private Vector2 _screenDimensions;

    void Start()
    {
        _screenDimensions = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
    }

    void Update()
    {
        if (transform.position.x > _screenDimensions.x)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x < -_screenDimensions.x)
        {
            Destroy(gameObject);
        }
        else if (transform.position.y > _screenDimensions.y)
        {
            Destroy(gameObject);
        }
        else if (transform.position.y < -_screenDimensions.y)
        {
            Destroy(gameObject);
        }
    }
}
