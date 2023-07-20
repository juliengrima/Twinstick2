using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    [SerializeField] int _life;
    Vector2 _direction;

    private void Reset()
    {
        _life = 40;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Component
        PlayerTag tag = collision.gameObject.GetComponent<PlayerTag>();
        if (tag != null)
        {
            if (collision.TryGetComponent(out Health health))
            {
                health.GiveLife(_life);
                Destroy(gameObject);
            }
        }
    }
}
